namespace RefactorThis.ToTheCloud
{
    public class Instance
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual AvailabilityZone AvailabilityZone { get; set; }
    }
}
