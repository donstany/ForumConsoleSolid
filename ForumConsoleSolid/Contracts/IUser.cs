using System.Collections.Generic;

namespace ForumConsoleSolid.Contracts
{
    public interface IUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        IList<IQuestion> Questions { get; }
    }
}