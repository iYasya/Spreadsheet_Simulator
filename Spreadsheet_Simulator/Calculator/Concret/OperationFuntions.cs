using Spreadsheet_Simulator.Sheet;
using System;

namespace Spreadsheet_Simulator.Calculator
{
    public class OperationFuntions
    {
        public static IResult Add(params IResult[] args)
        {
            return new NumberResult(Int32.Parse(args[0].GetValue()) + Int32.Parse(args[1].GetValue()));
        }

        public static IResult Minus(params IResult[] args)
        {
            return new NumberResult(Int32.Parse(args[0].GetValue()) - Int32.Parse(args[1].GetValue()));
        }

        public static IResult Divide(params IResult[] args)
        {
            return new NumberResult(Int32.Parse(args[0].GetValue()) / Int32.Parse(args[1].GetValue()));
        }

        public static IResult Multiply(params IResult[] args)
        {
            return new NumberResult(Int32.Parse(args[0].GetValue()) * Int32.Parse(args[1].GetValue()));
        }
    }
}
