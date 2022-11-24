using Problem1_Optimization.Model;

namespace Problem1_Optimization.Logic
{
    internal class Problem1DataSorter
    {
        public void SortByColumn(Problem1DataModel model, int columnIndex)
        {
            if (model.Rows.Length > 0 && model.Rows.First().Length > columnIndex)
            {
                model.Rows = model.Rows.OrderBy((string[] columns) => columns[columnIndex]).ToArray();
            }
        }
    }
}
