﻿using System.Collections.Generic;
using System.Security.Claims;
using SimpleSocia.Services.Models.Followers;
using SimpleSocial.Data.Models;

namespace SimpleSocial.Web.Areas.Administration.Services
{
    public interface IAdministrationServices
    {
        ICollection<SimpleUserViewModel> GetAdminUsers(ClaimsPrincipal currentUser, List<SimpleUserViewModel> users = null);

        ICollection<SimpleUserViewModel> GetNonAdminUsers(ClaimsPrincipal currentUser, List<SimpleUserViewModel> users = null);

        void PromoteUser(string id);

        void DemoteUser(string id);

        string GetRandomQuote();

        IEnumerable<PostReport> GetAllReports();
    }
}
