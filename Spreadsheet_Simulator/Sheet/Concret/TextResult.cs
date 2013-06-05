namespace Spreadsheet_Simulator.Sheet
{
    public class TextResult : IResult
    {
        string Value;

        public TextResult(string Value)
        {
            this.Value = Value;
        }

        public string GetValue()
        {
            return this.Value;
        }
    }
}
