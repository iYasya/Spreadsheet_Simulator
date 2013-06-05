using Spreadsheet_Simulator.Exeption;
using Spreadsheet_Simulator.Interpret;
using System;

namespace Spreadsheet_Simulator.Sheet
{
    public class SimpleSheet : ISheet
    {
        public int width { get; set; }
        public int height { get; set; }

        public IInterpret interpret { get; set; }

        public Fields[,] Fields { get; set; }

        public SimpleSheet(int width, int height)
        {
            this.width = width;
            this.height = height;

            Fields = new Fields[height, width];
        }

        public void Read()
        {
            for (int j = 0; j < height; j++)
            {
                string[] row = Console.ReadLine().Split('\t');
                for (int i = 0; i < width; i++)
                {
                    if (i >= row.Length)
                    {
                        Fields[j, i] = new Fields(null);
                    }
                    else
                    {
                        Fields[j, i] = new Fields(row[i]);
                    }
                }
            }
        }

        public void Write()
        {
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    Console.Write("{0}\t", Fields[j, i].Value.GetValue());
                }
                Console.WriteLine();
            }
        }

        public void Interpret()
        {
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    try
                    {
                        try
                        {
                            interpret.Interpret(Fields[j, i]);
                        }
                        catch (SpreadsheetSimulatorException e)
                        {
                            throw e;
                        }
                        catch (Exception e)
                        {
                            throw new UnknownErrorException();
                        }
                    }
                    catch (SpreadsheetSimulatorException e)
                    {
                        Fields[j, i].Value = new TextResult(e.Message);
                    }
                }
            }
        }
    }
}
