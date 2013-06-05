using Spreadsheet_Simulator.Exeption;
using Spreadsheet_Simulator.Sheet;
using System.Collections.Generic;

namespace Spreadsheet_Simulator.Interpret
{
    public class SimpleInterpret : IInterpret
    {
        List<IExpression> ListExpression;

        public SimpleInterpret()
        {
            ListExpression = new List<IExpression>();
        }

        public void Interpret(Fields context)
        {
            if (context.Data == null)
            {
                throw new NotSetValueException();
            }

            if (context.Data == "")
            {
                context.Value = new TextResult("");
                return;
            }

            foreach (IExpression expression in ListExpression)
            {
                expression.Interpret(context);
            }

            if (context.Value == null)
            {
                throw new InvalidFormatException(context.Data);
            }
        }

        public void AddExpression(IExpression Expression)
        {
            ListExpression.Add(Expression);
        }
    }
}
