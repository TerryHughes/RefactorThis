namespace RefactorThis.ToTheCloud
{
    using System.Collections.Generic;
    using System.Linq;

    public class Region
    {
        public Region()
        {
            this.AvailabilityZones = new List<AvailabilityZone>();
        }

        public virtual int Id { get; set; }
        public virtual IList<AvailabilityZone> AvailabilityZones { get; set; }

        public AvailabilityZone GetAvailabilityZoneBy(int id)
        {
            return this.AvailabilityZones.First(a => a.Id == id);
        }

        public Instance GetInstanceBy(int id)
        {
            return this.AvailabilityZones.SelectMany(a => a.Instances).First(i => i.Id == id);
        }
    }
}
