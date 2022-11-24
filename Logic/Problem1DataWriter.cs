using Problem1_Optimization.Model;

namespace Problem1_Optimization.Logic
{
    internal class Problem1DataWriter
    {
        public void WriteData(string path, Problem1DataModel model)
        {
            using (StreamWriter writer = File.CreateText(path))
            {
                for (int i = 0; i < model.Rows.Length; i++)
                {
                    writer.WriteLine(string.Join("\t", model.Rows[i]));
                }
            }
        }
    }
}
