namespace RefactorThis.ToTheCloud
{
    public interface IInactivationService
    {
        bool CanInactivate(Instance instance);
    }
}
