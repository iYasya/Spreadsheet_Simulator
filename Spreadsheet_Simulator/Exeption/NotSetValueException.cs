namespace Spreadsheet_Simulator.Exeption
{
    public class NotSetValueException : SpreadsheetSimulatorException
    {
        public NotSetValueException()
            : base()
        {
            MessageError = "NotSetValue";
        }
    }
}
