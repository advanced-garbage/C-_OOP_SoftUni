using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CommandPattern.Core.Invoker
{
    internal class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] inputInfo = args.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string commandName = inputInfo[0] + "Command";
            string[] parameters = inputInfo.Skip(1).ToArray();

            ICommand command = null;
            string result = string.Empty;

            Type type = Assembly.GetCallingAssembly().GetTypes().Where(t => t.Name == commandName).FirstOrDefault();

            command = (ICommand)Activator.CreateInstance(type);

            result = command.Execute(parameters);

            return result;
        }
    }
}
