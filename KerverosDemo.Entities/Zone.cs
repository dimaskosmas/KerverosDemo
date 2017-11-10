namespace KerverosDemo.Entities
{
    public class Zone
    {
        public int Id { get; set; }
        public string CustomerCode { get; set; }
        public int ZoneCode { get; set; }
        public string Description { get; set; }

        public virtual Customer Customer { get; set; }

        public Zone(int id, string customerCode, int zoneCode, string description)
        {
            Id = id;
            CustomerCode = customerCode;
            ZoneCode = zoneCode;
            Description = description;
        }

        public Zone()
        {

        }
    }
}
