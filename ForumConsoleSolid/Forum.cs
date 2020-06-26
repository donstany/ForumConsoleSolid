using System;
using System.Collections.Generic;
using System.Text;
using ForumConsoleSolid.Contracts;

namespace ForumConsoleSolid
{
    public class Forum : IForum
    {
        private const string DefaultAdminUser = "admin";
        private const string DefaultAdminPassword = "admin";
        private const string DefaultAdminEmail = "admin@example.com";

        public Forum()
        {
            this.Users = new List<IUser>();
            this.Questions = new List<IQuestion>();
            this.Answers = new List<IAnswer>();
            this.HasStarted = true;
            this.Output = new StringBuilder();
        }

        public bool HasStarted { get; set; }
        public bool IsLogged
        {
            get
            {
                return this.CurrentUser != null;
            }
        }
        public IList<IUser> Users { get; private set; }
        public IList<IQuestion> Questions { get; private set; }
        public IList<IAnswer> Answers { get; private set; }
        public IQuestion CurrentQuestion { get; set; }
        public IUser CurrentUser { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public StringBuilder Output { get; private set; }
        public void Run()
        {
            this.Output.Clear();
            var inputCommand = Console.ReadLine();
        }
    }
}