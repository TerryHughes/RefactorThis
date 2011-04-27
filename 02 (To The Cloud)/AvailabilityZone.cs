namespace RefactorThis.ToTheCloud
{
    using System.Collections.Generic;
    using System.Linq;

    public class AvailabilityZone
    {
        public AvailabilityZone()
        {
            this.Instances = new List<Instance>();
        }

        public virtual int Id { get; set; }
        public bool Available { get; set; }
        public virtual Region Region { get; set; }
        public virtual IList<Instance> Instances { get; set; }

        public bool IsThereAnotherInstanceWithTheName(string name)
        {
            return this.Instances.Count(i => i.Name == name) > 0;
        }

        public bool IsThereAnotherInstanceWithTheName(int id, string name)
        {
            return this.Instances.Count(i => i.Id != id && i.Name == name) > 0;
        }

        public void Add(Instance instance)
        {
            this.Instances.Add(instance);
        }
    }
}
