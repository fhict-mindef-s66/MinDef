namespace MinDef.Models.Messages
{
    public class DataType
    {
        public string Name { get; set; }
        public int CollectingTime { get; set; }

        public DataType(string name, int collectingTime)
        {
            Name = name;
            CollectingTime = collectingTime;
        }
    }
}