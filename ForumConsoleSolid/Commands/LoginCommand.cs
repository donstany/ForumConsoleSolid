﻿using System.Linq;
using ForumConsoleSolid.Commands.Exceptions;
using ForumConsoleSolid.Contracts;
using ForumConsoleSolid.Utility;

namespace ForumConsoleSolid.Commands
{
    public class LoginCommand : AbstractCommand
    {
        public LoginCommand(IForum forum)
                  : base(forum)
        {
        }

        public override void Execute()
        {
            if (this.Forum.IsLogged)
            {
                throw new CommandException(Messages.AlreadyLoggedIn);
            }

            string username = this.CommandToken[1];
            string password = PasswordUtility.Hash(this.CommandToken[2]);

            IUser user = this.Forum.Users
                .FirstOrDefault(u => u.Username == username);

            if (user == null || user.Password != password)
            {
                throw new CommandException(Messages.InvalidLoginDetails);
            }

            this.Forum.CurrentUser = user;

            this.Forum.Output.AppendLine(
                string.Format(Messages.LoginSuccess, username));
        }

    }
}
