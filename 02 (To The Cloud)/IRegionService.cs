namespace RefactorThis.ToTheCloud
{
    public interface IRegionService
    {
        Region GetRegionByAvailabilityZoneId(int id);
        Region GetRegionByInstanceId(int id);
        void Save(Region region);
    }
}
