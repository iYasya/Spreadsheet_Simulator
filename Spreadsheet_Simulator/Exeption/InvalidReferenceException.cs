namespace Spreadsheet_Simulator.Exeption
{
    public class InvalidReferenceException : SpreadsheetSimulatorException
    {
        public InvalidReferenceException(string reference)
            : base()
        {
            MessageError = string.Format("Not find reference: \"{0}\"", reference);
        }
    }
}
