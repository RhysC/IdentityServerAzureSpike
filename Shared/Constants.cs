﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin.Security.Cookies;

namespace IdentityServerAzureSpike.Shared
{
    public static class Constants
    {
        public const string IdentityServer = "IdentitySite";
        public const string IdentityServerUri = "https://identity.demo.local";
        public const string IdentityServerCoreUri = "https://identity.demo.local/core";
        public const string IdentityServerIdentityUri = "https://identity.demo.local/identity";


        public static class Sites
        {
            public static class A
            {
                public static readonly string Name = "SiteA_Hybrid";
                public static readonly string Uri = "http://sitea.demo.local:9556";
                public static readonly string RedirectUri = Uri + "/BouncedFromIdentityServer";
                public static readonly string PostbackUri = Uri + "/codeflow/callback/";
            }
            public static class B
            {
                public static readonly string Name = "SiteB_Hybrid";
                public static readonly string Uri = "http://SiteB.demo.local:9557";
                public static readonly string RedirectUri = Uri + "/BouncedFromIdentityServer";
                public static readonly string PostbackUri = Uri + "/codeflow/callback/";
            }
            public static class C
            {
                public static readonly string Name = "SiteC_ImplicitFlow";
                public static readonly string Uri = "http://sitec.demo.local:9558";
                public static readonly string RedirectUri = Uri + "/?WelcomeBack=you";
                public static readonly string PostbackUri = Uri + "/?LoggedOut=you";
            }
            public static class D
            {
                public static readonly string Name = "SiteD_CodeFlow";
                public static readonly string Uri = "http://SiteD.demo.local:9559";
                public static readonly string RedirectUri = Uri + "/BouncedFromIdentityServer";
                public static readonly string PostbackUri = "/callback/";
            }
            public static class E
            {
                public static readonly string Name = "SiteC_ImplicitFlow";
                public static readonly string Uri = "http://sitee.demo.local:9560";
                public static readonly string PostbackUri = Uri + "/implicitflow/callback/";
            }
        }

        public const string Secret = "secret";

        public const string AuthorizeEndpoint = IdentityServerCoreUri + "/connect/authorize";
        public const string LogoutEndpoint = IdentityServerCoreUri + "/connect/endsession";
        public const string TokenEndpoint = IdentityServerCoreUri + "/connect/token";
        public const string UserInfoEndpoint = IdentityServerCoreUri + "/connect/userinfo";
        public const string IdentityTokenValidationEndpoint = IdentityServerCoreUri + "/connect/identitytokenvalidation";
        public const string TokenRevocationEndpoint = IdentityServerCoreUri + "/connect/revocation";
        public const string PersmissionsEndpoint = IdentityServerCoreUri + "/permissions";

        public static class Scopes
        {
            public const string Full = "openid email profile read write offline_access";
            public const string CodeFlow = "openid profile read write";
            public const string Implicit = "openid email";
        }

        public static readonly List<string> RequiredScopes = Scopes.Full.Split().ToList();

        public static readonly List<string> RedirectSiteAUris = new List<string>()
        {
            Constants.Sites.A.Uri,
            Constants.Sites.A.RedirectUri,
             Constants.Sites.A.PostbackUri,
        };

        public static readonly List<string> RedirectSiteBUris = new List<string>()
        {
            Constants.Sites.B.Uri,
            Constants.Sites.B.RedirectUri,
            Constants.Sites.B.PostbackUri,
        };

        public static readonly List<string> RedirectSiteCUris = new List<string>()
        {
            Constants.Sites.C.Uri,
            Constants.Sites.C.RedirectUri,
            Constants.Sites.C.PostbackUri,
        };

        public static readonly List<string> RedirectSiteDUris = new List<string>()
        {
            Constants.Sites.D.Uri,
            Constants.Sites.D.RedirectUri,
            Constants.Sites.D.PostbackUri,
        };

        public static readonly List<string> RedirectSiteEUris = new List<string>()
        {
            Constants.Sites.E.Uri,
            Constants.Sites.E.PostbackUri,            
        };

        public static class Cookie
        {
            public const string Name = "identity";
            public const string Domain = "demo.local";
            public const string Path = "identity";
            public const string TempPassiveStateName = "TempPassiveState";

            public static CookieAuthenticationOptions Build()
            {
                return new CookieAuthenticationOptions
                {
                    CookieHttpOnly = false,
                    CookieSecure = CookieSecureOption.Never,
                    //ExpireTimeSpan = TimeSpan.FromHours(1),
                    CookieDomain = Domain,
                };
            }
        }


    }
}
