﻿using System.Linq;
using ForumConsoleSolid.Commands.Exceptions;
using ForumConsoleSolid.Contracts;
using ForumConsoleSolid.Entities;
using ForumConsoleSolid.Users.Entities;
using ForumConsoleSolid.Utility;

namespace ForumConsoleSolid.Commands
{
    public class RegisterCommand : AbstractCommand
    {
        public RegisterCommand(IForum forum) : base(forum)
        {
        }
        public override void Execute()
        {
            var users = this.Forum.Users;
            string username = this.CommandToken[1];
            string password = PasswordUtility.Hash(this.CommandToken[2]);
            string email = this.CommandToken[3];

            if (users.Any(u => u.Username == username || u.Email == email))
            {
                throw new CommandException(Messages.UserAlreadyRegistered);
            }

            User user;
            //register admin -> register gosho 123 gosh@a.bg administrator
            if (this.CommandToken.Count > 4)
            {
                var role = this.CommandToken[4];

                switch (role.ToLower())
                {
                    case "administrator":
                        if (users.Any())
                        {
                            throw new CommandException(Messages.RegAdminNotAllowed);
                        }

                        user = new Administrator(1, username, password, email);
                        break;
                    default:
                        user = new User(users.Count + 1, username, password, email);
                        break;
                }
            }
            else // register pesho 123 12@12.com
            {
                user = new User(users.Count + 1, username, password, email);
            }

            users.Add(user);

            this.Forum.Output.AppendLine(
                string.Format(Messages.RegisterSuccess, username, users.Last().Id));
        }
    }
}
