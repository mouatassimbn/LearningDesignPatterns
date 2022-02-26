using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class RemoteControl
    {
        private ICommand _commandTobePerformed;
        private ICommand _lastPerformedCommand;

        public void SetCommand(ICommand command)
        {
            this._commandTobePerformed = command;
        }

        public void ExecuteCommand()
        {
            this._commandTobePerformed.Execute();
            this._lastPerformedCommand = this._commandTobePerformed;
        }

        public void UndoCommand()
        {
            this._lastPerformedCommand.Undo();
        }
    }
}
