namespace KerverosDemo.Entities
{
    public class Partition
    {
        public int Id { get; set; }
        public string CustomerCode { get; set; }
        public int PartitionCode { get; set; }
        public string Description { get; set; }

        public virtual Customer Customer { get; set; }

        public Partition(int id, string customerCode, int partitionCode, string description)
        {
            Id = id;
            CustomerCode = customerCode;
            PartitionCode = partitionCode;
            Description = description;
        }

        public Partition()
        {

        }
    }
}
