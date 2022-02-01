﻿using System.Threading.Tasks;
using Bit.Core.Entities;

namespace Bit.Core.OrganizationFeatures.OrganizationSponsorships.FamiliesForEnterprise.Interfaces
{
    public interface IRevokeSponsorshipCommand
    {
        Task RevokeSponsorshipAsync(Organization sponsoredOrg, OrganizationSponsorship sponsorship);
    }
}
