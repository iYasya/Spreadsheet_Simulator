using Spreadsheet_Simulator.Sheet;
using Spreadsheet_Simulator.Interpret;
using Spreadsheet_Simulator.Calculator;
using System;

namespace Spreadsheet_Simulator
{
    class Program
    {
        static ICalculator calc;
        static IInterpret interpret;
        static ISheet sheet;

        static void Main(string[] args)
        {
            int height, width;
            string[] size = Console.ReadLine().Split('\t');
            height = int.Parse(size[0]);
            width = int.Parse(size[1]);

            InitSheet(width, height);
            InitCalculator();
            InitInterpret();

            sheet.interpret = interpret;

            sheet.Read();
            sheet.Interpret();
            sheet.Write();
        }

        static void InitCalculator()
        {
            calc = new SimpleCalculator();
            calc.AddOperation("+", OperationFuntions.Add);
            calc.AddOperation("-", OperationFuntions.Minus);
            calc.AddOperation("/", OperationFuntions.Divide);
            calc.AddOperation("*", OperationFuntions.Multiply);
        }

        static void InitInterpret()
        {
            interpret = new SimpleInterpret();
            interpret.AddExpression(new TextExpression());
            interpret.AddExpression(new NumberExpression());
            interpret.AddExpression(new TermExpression(interpret, calc));
            interpret.AddExpression(new ReferenceExpression(sheet, interpret));
        }

        static void InitSheet(int width, int height)
        {
            sheet = new SimpleSheet(width, height);
        }
    }
}
