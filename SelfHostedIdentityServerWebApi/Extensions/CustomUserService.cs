﻿using IdentityServer3.Core.Models;
using IdentityServer3.Core.Services;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SelfHostedIdentityServerWebApi.Extensions
{
    class CustomUserService : IUserService
    {
        public Task<AuthenticateResult> AuthenticateLocalAsync(string username, string password, SignInMessage message = null)
        {
            if (message != null)
            {
                var tenant = message.Tenant;

                if (username == password)
                {
                    var claims = new List<Claim>
                    {
                        new Claim("account_store", tenant)
                    };

                    var result = new AuthenticateResult("123", username, 
                        claims: claims,
                        authenticationMethod: "custom");

                    return Task.FromResult(new AuthenticateResult("123", username, claims));
                }
            }

            // default account store
            throw new NotImplementedException();
        }

        public Task<AuthenticateResult> AuthenticateExternalAsync(ExternalIdentity externalUser, SignInMessage message)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Claim>> GetProfileDataAsync(ClaimsPrincipal subject, IEnumerable<string> requestedClaimTypes = null)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsActiveAsync(ClaimsPrincipal subject)
        {
            throw new NotImplementedException();
        }

        public Task<AuthenticateResult> PreAuthenticateAsync(SignInMessage message)
        {
            throw new NotImplementedException();
        }

        public Task SignOutAsync(ClaimsPrincipal subject, IDictionary<string, object> env)
        {
            throw new NotImplementedException();
        }

        public Task SignOutAsync(ClaimsPrincipal subject)
        {
            throw new NotImplementedException();
        }
    }
}