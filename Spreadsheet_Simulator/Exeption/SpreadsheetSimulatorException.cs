using System;

namespace Spreadsheet_Simulator.Exeption
{
    public class SpreadsheetSimulatorException : ApplicationException
    {
        protected string MessageError = String.Empty;

        public SpreadsheetSimulatorException() {}

        public override string Message
        {
            get
            {
                return String.Format("#{0}", MessageError);
            }
        }
    }
}
