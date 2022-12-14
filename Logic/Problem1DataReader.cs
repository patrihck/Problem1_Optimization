using Problem1_Optimization.Model;

namespace Problem1_Optimization.Logic
{
    internal class Problem1DataReader
    {
        public Problem1DataModel GetProblem1DataModelFromFile(string filePath)
        {
            var lines = File.ReadAllLines(filePath);
            var dataRows = new string[lines.Length][];

            for (int i = 0; i < lines.Length; i++)
            {
                var columnValues = lines[i].Split("\t");
                dataRows[i] = columnValues;
            }

            return new Problem1DataModel { Rows = dataRows };
        }
    }
}
