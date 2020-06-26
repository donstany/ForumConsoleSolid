using System;
using ForumConsoleSolid.Contracts;

namespace ForumConsoleSolid
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            IForum forum = new Forum();
            forum.Run();
        }
    }
}
