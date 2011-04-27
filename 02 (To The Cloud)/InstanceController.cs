namespace RefactorThis.ToTheCloud
{
    using System;

    public class InstanceController
    {
        private readonly IRegionService regionService;

        private readonly IAccountService accountService;

        private readonly IInactivationService inactivationService;

        public InstanceController(IRegionService regionService, IAccountService accountService, IInactivationService inactivationService)
        {
            this.regionService = regionService;
            this.accountService = accountService;
            this.inactivationService = inactivationService;
        }

        public UpdateInstance Save(UpdateInstance model)
        {
            if (!String.IsNullOrWhiteSpace(model.AccountNumber) && !this.accountService.IsValidAccount(model.AccountNumber))
            {
                model.ErrorMessages.Add(String.Format("Could not find the account number {0}", model.AccountNumber));

                return model;
            }

            Region region;
            Instance instance;

            if (model.InstanceId != 0)
            {
                region = this.regionService.GetRegionByInstanceId(model.InstanceId);
                instance = region.GetInstanceBy(model.InstanceId);
                var zone = instance.AvailabilityZone;

                if (zone.IsThereAnotherInstanceWithTheName(instance.Id, model.Name))
                {
                    model.ErrorMessages.Add(String.Format("There is already an instance named '{0}'.", model.Name));

                    return model;
                }
            }
            else
            {
                region = this.regionService.GetRegionByAvailabilityZoneId(model.AvailabilityZoneId);
                var zone = region.GetAvailabilityZoneBy(model.AvailabilityZoneId);
                instance = new Instance { AvailabilityZone = zone, Name = model.Name };

                if (zone.IsThereAnotherInstanceWithTheName(model.Name))
                {
                    model.ErrorMessages.Add(String.Format("There is already an instance named '{0}'.", model.Name));

                    return model;
                }

                zone.Instances.Add(instance);
            }

            if (instance.IsActive && !model.IsActive && !this.inactivationService.CanInactivate(instance))
            {
                model.ErrorMessages.Add("Cannot inactivate this instance.");

                return model;
            }

            instance.Name = model.Name;
            instance.IsActive = model.IsActive;

            this.regionService.Save(region);

            model.InstanceId = instance.Id;

            return model;
        }
    }
}
