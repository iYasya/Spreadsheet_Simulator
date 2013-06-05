namespace Spreadsheet_Simulator.Exeption
{
    public class InvalidFormatException : SpreadsheetSimulatorException
    {
        public InvalidFormatException(string Data)
            : base()
        {
            MessageError = string.Format("InvalidFormat: \"{0}\"", Data);
        }
    }
}
