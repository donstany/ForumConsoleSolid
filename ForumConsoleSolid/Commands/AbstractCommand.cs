using System.Collections.Generic;
using ForumConsoleSolid.Contracts;

namespace ForumConsoleSolid.Commands
{
    public abstract class AbstractCommand : ICommand
    {
        public readonly List<string> CommandToken = new List<string>();
        protected AbstractCommand(IForum forum)
        {
            this.Forum = forum;
        }

        public IForum Forum { get; private set; }

        public abstract void Execute();
    }
}
