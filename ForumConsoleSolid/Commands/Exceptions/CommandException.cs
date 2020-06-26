using System;
using System.Runtime.Serialization;

namespace ForumConsoleSolid.Commands.Exceptions
{
    public class CommandException : Exception, ISerializable
    {
        public CommandException(string message) : base(message)
        {
        }
    }
}
