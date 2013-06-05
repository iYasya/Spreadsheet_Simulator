namespace Spreadsheet_Simulator.Exeption
{
    public class InvalidArgumentException : SpreadsheetSimulatorException
    {
        public InvalidArgumentException(string argument)
            : base()
        {
            MessageError = string.Format("InvalidArgument: \"{0}\"", argument);
        }
    }
}
