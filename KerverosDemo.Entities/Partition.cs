namespace KerverosDemo.Entities
{
    public class Partition
    {
        public int Id { get; set; }
        public string CustomerCode { get; set; }
        public int ZoneCode { get; set; }
        public int PartitionCode { get; set; }
        public string Description { get; set; }

        public virtual Customer Customer { get; set; }

        public Partition(int id, string customerCode, int zoneCode, int partitionCode, string description)
        {
            Id = id;
            CustomerCode = customerCode;
            ZoneCode = zoneCode;
            PartitionCode = partitionCode;
            Description = description;
        }

        public Partition()
        {

        }
    }
}
