namespace Spreadsheet_Simulator.Sheet
{
    public class NumberResult : IResult
    {
        int Value;

        public NumberResult(int Value)
        {
            this.Value = Value;
        }

        public string GetValue()
        {
            return this.Value.ToString();
        }
    }
}
