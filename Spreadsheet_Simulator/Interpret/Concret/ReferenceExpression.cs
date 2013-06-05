using Spreadsheet_Simulator.Exeption;
using Spreadsheet_Simulator.Sheet;

namespace Spreadsheet_Simulator.Interpret
{
    public class ReferenceExpression : IExpression
    {
        ISheet sheet;
        IInterpret interpret;

        public ReferenceExpression(ISheet sheet, IInterpret interpret)
        {
            this.interpret = interpret;
            this.sheet = sheet;
        }

        public override void Interpret(Fields context)
        {
            if (Check(context))
            {
                int i = int.Parse(context.Data[1].ToString()) - 1;
                int j = LetterToNumber(context.Data[0]);
                if ((sheet.width <= j) || (sheet.height <= i))
                {
                    throw new InvalidReferenceException(context.Data);
                }
                Fields temp = sheet.Fields[i, j];
                interpret.Interpret(temp);
                context.Value = new NumberResult(int.Parse(temp.Value.GetValue()));
            }
        }

        public int LetterToNumber(char letter)
        {
            return (int)char.ToUpper(letter) - (int)'A';
        }

        public override bool Check(Fields context)
        { return char.IsLetter(context.Data, 0); }
    }
}
