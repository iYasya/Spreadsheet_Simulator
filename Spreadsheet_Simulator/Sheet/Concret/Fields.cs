namespace Spreadsheet_Simulator.Sheet
{
    public class Fields
    {
        public string Data { get; set; }
        public IResult Value { get; set; }

        public Fields(string context)
        {
            Data = context;
        }

        private void FindValue()
        { }
    }
}
