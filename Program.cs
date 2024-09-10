namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program t = new Program();
            t.GetData("meccs.txt");
            t.Feladat2();
        }
        public List<foci> meccsek = new();
        public void GetData(string fileName)
        {
            foreach(var line in File.ReadAllLines(fileName).Skip(1))
            {
                int f = int.Parse(line.Split(" ")[0]);
                int hg = int.Parse(line.Split(" ")[1]);
                int vg = int.Parse(line.Split(" ")[2]);
                int hf = int.Parse(line.Split(" ")[3]);
                int vf = int.Parse(line.Split(" ")[4]);
                string h = line.Split(" ")[5];
                string v = line.Split(" ")[6];

                meccsek.Add(new foci(f, hg, vg, hf, vf, h, v));
            }
            
        }
        public void Feladat2()
        {
            Console.Write("Írja be a forduló számát:");
            int fordulo = Convert.ToInt32(Console.ReadLine());
            foreach (var f in meccsek)
            {
                if (fordulo == f.fordulo)
                {
                    Console.WriteLine($"{f.fordulo}.forduló: {f.hazai}-{f.vendeg}: {f.hazaigol}-{f.vendeggol} ({f.hfelido}-{f.vfelido})");
                }
            }
        }
    }
}
