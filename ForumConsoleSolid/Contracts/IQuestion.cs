using System.Collections.Generic;

namespace ForumConsoleSolid.Contracts
{
    public interface IQuestion : IPost
    {
        string Title { get; set; }
        IList<IAnswer> Answers { get; }
    }
}