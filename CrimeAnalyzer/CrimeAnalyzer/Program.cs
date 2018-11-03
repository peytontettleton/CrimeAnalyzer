using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            string csvFilePath = string.Empty;
            string reportFilePath = string.Empty;

            string startupPath = directory.getcurrentdirectory();
            
            if (args.Length != 2)
            {
                Console.WriteLine("Call Format: Crime Analyzer <Crime_CSV_File_path> <report_file_path>");
            }
        }
    }
}
