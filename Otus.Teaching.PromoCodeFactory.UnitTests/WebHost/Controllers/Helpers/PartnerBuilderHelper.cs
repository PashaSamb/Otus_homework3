using Otus.Teaching.PromoCodeFactory.Core.Domain.PromoCodeManagement;
using System;
using System.Collections.Generic;

namespace Otus.Teaching.PromoCodeFactory.UnitTests.WebHost.Controllers.Helpers
{
    public class PartnerBuilderHelper
    {
        private Guid partnerId { get; set; }
        private string name { get; set; }
        private bool isActive { get; set; } = false;
        private int numberIssuedPromoCodes { get; set; }
        private ICollection<PartnerPromoCodeLimit> partnerLimits { get; set; }

        public PartnerBuilderHelper() { }

        public PartnerBuilderHelper AddPartnerName(string name)
        {
            this.name = name;
            return this;
        }


        public PartnerBuilderHelper AddPartnerId(Guid id)
        {
            partnerId = id;
            return this;
        }

        public PartnerBuilderHelper AddActiveState(bool isActive)
        {
            this.isActive = isActive;
            return this;
        }

        public PartnerBuilderHelper AddNumberIssuredPromos(int numberIssuedPromoCodes)
        {
            this.numberIssuedPromoCodes = numberIssuedPromoCodes;
            return this;
        }


        public PartnerBuilderHelper AddParthnerLimits(List<PartnerPromoCodeLimit> parthnerLimits)
        {
            partnerLimits = parthnerLimits;
            return this;
        }

        public Partner Build()
        {
            return new Partner()
            {
                Id = partnerId,
                IsActive = isActive,
                Name = name,
                NumberIssuedPromoCodes = numberIssuedPromoCodes,
                PartnerLimits = partnerLimits
            };
        }
    }
}
