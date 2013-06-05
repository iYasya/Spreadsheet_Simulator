using Spreadsheet_Simulator.Sheet;

namespace Spreadsheet_Simulator.Calculator
{
    public delegate IResult OperationDelegat(params IResult[] args);

    public interface ICalculator
    {
        void AddOperation(string key, OperationDelegat op);

        IResult PerformOperation(string key, params IResult[] args);

        string[] GetOperation();
    }
}
