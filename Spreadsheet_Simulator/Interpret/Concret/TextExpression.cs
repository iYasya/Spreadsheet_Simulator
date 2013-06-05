using Spreadsheet_Simulator.Sheet;

namespace Spreadsheet_Simulator.Interpret
{
    public class TextExpression : IExpression
    {
        public override void Interpret(Fields context)
        { 
            if (Check(context))
            {
                context.Value = new TextResult(context.Data.Substring(1));
            }
        }

        public override bool Check(Fields context)
        { return context.Data[0] == '\''; }
    }
}
