using Spreadsheet_Simulator.Exeption;
using Spreadsheet_Simulator.Sheet;
using System.Collections.Generic;
using System.Linq;

namespace Spreadsheet_Simulator.Calculator
{
    public class SimpleCalculator : ICalculator
    {
        Dictionary<string, OperationDelegat> operatioinList;

        public SimpleCalculator()
        {
            operatioinList = new Dictionary<string, OperationDelegat>();
        }

        public void AddOperation(string key, OperationDelegat op)
        {
            if (operatioinList.ContainsKey(key)) return;
            operatioinList.Add(key, op);
        }

        public IResult PerformOperation(string key, params IResult[] args)
        {
            foreach (IResult arg in args)
            {
                if (arg is TextResult)
                {
                    throw new InvalidArgumentException(arg.GetValue());
                }
            }

            return operatioinList[key](args);
        }

        public string[] GetOperation()
        {
            return operatioinList.Keys.ToArray<string>();
        }
    }
}
