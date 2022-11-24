namespace Problem1_Optimization.Logic
{
    internal class Problem1DataIndexer
    {
        public int[] GetIndexesOfRowsWithDoubledColumns(string[][] rows, int column1Index, int column2Index)
        {
            List<int> indexes = new List<int>();
            var higherIndex = Math.Max(column1Index, column2Index);
            //TODO add validation method - if higherIndex is equal or higher than columns.Length, then operatio is not allowed

            for (int i = 0; i < rows.Length; i++)
            {
                if (rows[i][column1Index] == rows[i][column2Index])
                {
                    indexes.Add(i);
                }
            }

            return indexes.ToArray();
        }
    }
}
