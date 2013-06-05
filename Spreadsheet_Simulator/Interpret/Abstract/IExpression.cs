using Spreadsheet_Simulator.Sheet;

namespace Spreadsheet_Simulator.Interpret
{
    public abstract class IExpression
    {
        public abstract void Interpret(Fields context);

        public abstract bool Check(Fields context);
    }
}
