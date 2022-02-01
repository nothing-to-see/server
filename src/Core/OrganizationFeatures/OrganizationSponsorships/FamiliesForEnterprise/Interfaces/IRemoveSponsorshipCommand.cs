﻿using System.Threading.Tasks;
using Bit.Core.Entities;

namespace Bit.Core.OrganizationFeatures.OrganizationSponsorships.FamiliesForEnterprise.Interfaces
{
    public interface IRemoveSponsorshipCommand
    {
        Task RemoveSponsorshipAsync(Organization sponsoredOrg, OrganizationSponsorship sponsorship);
    }
}
