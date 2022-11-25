using Problem1_Optimization.Model;
using System.Diagnostics;

namespace Problem1_Optimization.Logic
{
    internal class Problem1DataIndexer
    {
        public Problem1DataModel GetIndexesOfRowsWhereCellValueExistsInOtherColumn(string[] column1, string[] column2)
        {
            string[] doubledValues = new string[column1.Length];

            Parallel.For(0, column1.Length , i =>
            {
                var valueFromSecondColumn = column2.SingleOrDefault(value => value == column1[i]);

                if (valueFromSecondColumn != null)
                {
                    doubledValues[i] = column2[i];
                }
                else
                {
                    column2[i] = null;
                }
            });

            return new Problem1DataModel { Rows = doubledValues.Where(row => row != null)
                .Select(row => new string[2] { row, (Array.IndexOf(doubledValues, row) + 1).ToString() }).ToArray() };
        }
    }
}
