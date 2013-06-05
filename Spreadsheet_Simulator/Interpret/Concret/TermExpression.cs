using Spreadsheet_Simulator.Calculator;
using Spreadsheet_Simulator.Sheet;
using System.Collections.Generic;

namespace Spreadsheet_Simulator.Interpret
{
    public class TermExpression : IExpression
    {
        IInterpret interpret;
        ICalculator calc;

        public TermExpression(IInterpret interpret, ICalculator calc)
        {
            this.interpret = interpret;
            this.calc = calc;
        }

        public override void Interpret(Fields context)
        {
            if (Check(context))
            {
                string[] splitOperation = calc.GetOperation();
                string datastring = context.Data.Substring(1);

                Fields field = new Fields("");
                string operation = "";
                while (datastring.Length != 0)
                {
                    int index = FindOperation(datastring, splitOperation);
                    Fields new_field = new Fields(datastring.Substring(0, (index == -1) ? datastring.Length : index));
                    interpret.Interpret(new_field);

                    if (field.Value == null)
                    {
                        field = new_field;
                    }
                    else
                    {
                        field.Value = calc.PerformOperation(operation, field.Value, new_field.Value);
                    }

                    if (index == -1)
                    { break; }
                    operation = datastring.Substring(index, 1);
                    datastring = datastring.Remove(0, index + 1);
                }

                context.Value = new NumberResult(int.Parse(field.Value.GetValue()));
            }
        }

        public int FindOperation(string expression, string[] splits)
        {
            int minindex = expression.Length;
            foreach (string split in splits)
            {
                if ((expression.IndexOf(split) >= 0) && (minindex > expression.IndexOf(split)))
                { minindex = expression.IndexOf(split); }
            }
            return (minindex != expression.Length) ? minindex : -1;
        }

        public override bool Check(Fields context)
        { return context.Data[0] == '='; }
    }
}
