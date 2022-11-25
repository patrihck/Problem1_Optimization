using Problem1_Optimization.Model;

namespace Problem1_Optimization.Logic
{
    internal class Problem1DataWriter
    {
        public void WriteData(string path, string[][] rows)
        {
            using (StreamWriter writer = File.CreateText(path))
            {
                for (int i = 0; i < rows.Length; i++)
                {
                    writer.WriteLine(string.Join("\t", rows[i]));
                }
            }
        }
    }
}
