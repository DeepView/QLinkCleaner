using System.Text;

namespace QLinkCleaner
{
    public class Statistic
    {
        public int Count { get; set; }

        public DateTime Last { get; set; }

        public Statistic() => Reset();

        public Statistic(int count, DateTime last)
        {
            Count = count;
            Last = last;
        }

        public Statistic(Statistic other)
        {
            Count = other.Count;
            Last = other.Last;
        }

        public static Statistic FromFile(string file)
        {
            if (!File.Exists(file))
            {
                File.Create(file).Close();
                return new Statistic(0, DateTime.MinValue);
            }
            else
            {
                Statistic statistic = new();
                Dictionary<string, long> dict = [];
                using StreamReader streamReader = new(file, Encoding.UTF8);
                string? line;
                while ((line = streamReader.ReadLine()) != null) // Ensure line is not null
                {
                    string[] parts = line.Split('=');
                    if (parts.Length == 2 && long.TryParse(parts[1], out long val))
                    {
                        dict[parts[0]] = val;
                    }
                }
                statistic.Count = dict.TryGetValue("Count", out long count) ? (int)count : 0;
                statistic.Last = dict.TryGetValue("Last", out long last) ? new DateTime(last) : DateTime.Now;
                return statistic;
            }
        }

        public void Save(string file)
        {
            if (!File.Exists(file))
                File.Create(file).Close(); // Ensure the file exists before writing
            using StreamWriter streamWriter = new(file, false, Encoding.UTF8);
            streamWriter.WriteLine($"Count={Count}");
            streamWriter.WriteLine($"Last={Last.Ticks}");
        }

        public void Reset()
        {
            Count = 0;
            Last = DateTime.Now;
        }

        public void UpdateRecord()
        {
            Count++;
            Last = DateTime.Now;
        }

        public override string ToString() => $"Intercept count: {Count}\nLast interception time: {Last:yyyy-MM-dd HH:mm:ss}";
    }
}
