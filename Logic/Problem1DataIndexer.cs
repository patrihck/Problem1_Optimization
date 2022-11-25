using Problem1_Optimization.Model;

namespace Problem1_Optimization.Logic
{
    internal class Problem1DataIndexer
    {
        public Problem1DataModel GetIndexesOfRowsWhereCellValueExistsInOtherColumn(string[][] rows, int column1Index, int column2Index)
        {
            List<string[]> indexesWithValues = new List<string[]>();
            var higherIndex = Math.Max(column1Index, column2Index);
            //TODO add validation method - if higherIndex is equal or higher than columns.Length, then operatio is not allowed

            for (int i = 0; i < rows.Length; i++)
            {
                if (CheckIfValueExistsInOtherColumn(rows, column2Index, rows[i][column1Index]))
                {
                    indexesWithValues.Add(new string[2] { rows[i][column2Index], (i + 1).ToString() });
                }
                else
                {
                    rows[i][column1Index] = String.Empty;
                    rows[i][column2Index] = String.Empty;
                }
            }

            return new Problem1DataModel { Rows = indexesWithValues.ToArray() };
        }

        private bool CheckIfValueExistsInOtherColumn(string[][] rows, int column1Index, string value)
        {
            return rows.Any(row => row[column1Index] == value);
        }
    }
}
