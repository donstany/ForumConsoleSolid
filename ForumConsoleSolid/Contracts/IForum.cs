using System.Collections.Generic;
using System.Text;

namespace ForumConsoleSolid.Contracts
{
    public interface IForum
    {
        bool HasStarted { get; set; }
        bool IsLogged { get; }
        IList<IUser> Users { get; }
        IList<IQuestion> Questions { get; }
        IList<IAnswer> Answers { get; }
        IQuestion CurrentQuestion { get; set; }
        IUser CurrentUser { get; set; }
        StringBuilder Output { get; }
        void Run();

    }
}
