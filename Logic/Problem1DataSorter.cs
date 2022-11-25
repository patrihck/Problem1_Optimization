using Problem1_Optimization.Model;

namespace Problem1_Optimization.Logic
{
    internal class Problem1DataSorter
    {
        public void SortByColumn(Problem1DataModel model, int columnIndex)
        {
            if (model.Rows.Length > 0 && model.Rows.First().Length > columnIndex)
            {
                var isNumericColumn = int.TryParse(model.Rows[0][columnIndex], out int number);

                model.Rows = isNumericColumn
                    ? model.Rows.OrderBy((string[] columns) => int.Parse(columns[columnIndex])).ToArray()
                    : model.Rows.OrderBy((string[] columns) => columns[columnIndex].ToString()).ToArray();
            }
        }
    }
}
