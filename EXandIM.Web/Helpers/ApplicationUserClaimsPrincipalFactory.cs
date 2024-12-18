﻿using EXandIM.Web.Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Security.Claims;

namespace EXandIM.Web.Helpers
{
	public class ApplicationUserClaimsPrincipalFactory : UserClaimsPrincipalFactory<ApplicationUser, IdentityRole>
	{
		public ApplicationUserClaimsPrincipalFactory
			(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IOptions<IdentityOptions> options) : base(userManager, roleManager, options)
		{
		}

        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(ApplicationUser user)
		{
			var identity = await base.GenerateClaimsAsync(user);
			identity.AddClaim(new Claim(ClaimTypes.GivenName, user.FullName));
			identity.AddClaim(new Claim(ClaimTypes.Actor, user.ImageUrl));

			return identity;
		}

    }
}