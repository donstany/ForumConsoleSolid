using System;
using ForumConsoleSolid.Contracts;

namespace ForumConsoleSolid
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //IForum forum = new Forum();
            IForum forum = new ExtendedForum();
            forum.Run();
        }
    }
}
