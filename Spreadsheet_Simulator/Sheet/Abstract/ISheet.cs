using Spreadsheet_Simulator.Calculator;
using Spreadsheet_Simulator.Interpret;

namespace Spreadsheet_Simulator.Sheet
{
    public interface ISheet
    {
        int width { get; set; }
        int height { get; set; }

        IInterpret interpret { get; set; }

        Fields[,] Fields { get; set; }

        void Read();
        void Write();
        void Interpret();
    }
}
