using Problem1_Optimization.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1_Optimization.Logic
{
    internal class Problem1DataConverter
    {
        public Problem1DataModel ConvertToValuesAndIndexesOfDoubledColumns(Problem1DataModel model, int[] rowWithDoubledColumnsIndexes)
        {
            var dataRows = new string[rowWithDoubledColumnsIndexes.Length][];
            for (int i = 0; i < rowWithDoubledColumnsIndexes.Length; i++)
            {
                var duplicates = model.Rows[rowWithDoubledColumnsIndexes[i]]
                    .GroupBy(i => i)
                    .Where(g => g.Count() > 1)
                    .Select(g => g.Key);

                dataRows[i] = new string[model.Rows[rowWithDoubledColumnsIndexes[i]].Length];
                dataRows[i][0] = duplicates.First();
                dataRows[i][1] = rowWithDoubledColumnsIndexes[i].ToString();
            }

            return new Problem1DataModel { Rows = dataRows };
        }
    }
}
