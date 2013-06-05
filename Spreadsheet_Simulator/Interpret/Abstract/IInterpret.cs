using Spreadsheet_Simulator.Sheet;

namespace Spreadsheet_Simulator.Interpret
{
    public interface IInterpret
    {
        void Interpret(Fields context);

        void AddExpression(IExpression Expression);
    }
}
