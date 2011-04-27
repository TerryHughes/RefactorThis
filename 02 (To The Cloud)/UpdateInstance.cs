namespace RefactorThis.ToTheCloud
{
    using System.Collections.Generic;

    public class UpdateInstance
    {
        public UpdateInstance()
        {
            this.ErrorMessages = new List<string>();
        }

        public int InstanceId { get; set; }
        public string AccountNumber { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int AvailabilityZoneId { get; set; }
        public ICollection<string> ErrorMessages { get; private set; }
    }
}
