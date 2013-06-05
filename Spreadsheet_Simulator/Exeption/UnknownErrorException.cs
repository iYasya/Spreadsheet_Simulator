namespace Spreadsheet_Simulator.Exeption
{
    public class UnknownErrorException : SpreadsheetSimulatorException
    {
        public UnknownErrorException()
            : base()
        {
            MessageError = "UnknownError";
        }
    }
}
