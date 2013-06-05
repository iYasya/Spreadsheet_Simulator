using Spreadsheet_Simulator.Sheet;

namespace Spreadsheet_Simulator.Interpret
{
    public class NumberExpression : IExpression
    {
        public override void Interpret(Fields context)
        {
            if (Check(context))
            {
                context.Value = new NumberResult(int.Parse(context.Data));
            }
        }

        public override bool Check(Fields context)
        { return char.IsDigit(context.Data[0]); }
    }
}
