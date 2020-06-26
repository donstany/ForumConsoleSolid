using System;
using System.Linq;
using System.Reflection;
using ForumConsoleSolid.Contracts;

namespace ForumConsoleSolid.Commands.Factories
{
    public static class CommandFactory
    {
        private const string CommandSuffix = "Command";

        public static IExecutable Create(string commandInput, IForum forum)
        {
            var data = commandInput.Split(null);
            string commandName = data[0].ToLower();

            var commandClass = Assembly.GetExecutingAssembly().GetTypes()
                               .Where(t => t.IsClass)
                               .Where(t => t.Name.EndsWith(CommandSuffix))
                                   .First(t => t.Name
                                          .Replace(CommandSuffix, string.Empty)
                                          .ToLower()
                                          .Equals(commandName));

            AbstractCommand command = Activator.CreateInstance(commandClass, forum) as AbstractCommand;

            foreach (var field in data)
            {
                command.Data.Add(field);
            }

            return (IExecutable)command;
        }
    }
}
