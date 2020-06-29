using ForumConsoleSolid.Contracts;
using ForumConsoleSolid.Entities;

namespace ForumConsoleSolid.Users.Entities
{
    public class Administrator : User, IAdministrator
    {
        public Administrator(int id, string name, string password, string email)
                      : base(id, name, password, email)
        {
        }
    }
}
