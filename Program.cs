namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program t = new Program();
            t.GetData("meccs.txt");
        }
        public List<foci> meccsek = new();
        public void GetData(string fileName)
        {
            foreach(var line in File.ReadAllLines(fileName).Skip(1))
            {
                int f = int.Parse(line.Split(" ")[0]);
                int hg = int.Parse(line.Split(" ")[0]);
                int vg = int.Parse(line.Split(" ")[0]);
                int hf = int.Parse(line.Split(" ")[0]);
                int vf = int.Parse(line.Split(" ")[0]);
                string h = line.Split(" ")[5];
                string v = line.Split(" ")[6];

                meccsek.Add(new foci(f, hg, vg, hf, vf, h, v));
            }
            
        }
    }
}
