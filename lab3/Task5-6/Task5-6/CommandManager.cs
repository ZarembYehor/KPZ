using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_6
{
    public class CommandManager
    {
        private readonly Stack<ICommand> commandStack = new Stack<ICommand>();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            commandStack.Push(command);
        }

        public void UndoCommand()
        {
            if (commandStack.Count > 0)
            {
                var command = commandStack.Pop();
                command.Undo();
            }
            else
            {
                Console.WriteLine("No commands to undo.");
            }
        }
    }
}
