﻿using Owin;
using Microsoft.Owin;

[assembly: OwinStartup(typeof(SportsStore.IdentityConfig))]

namespace SportsStore
{
    public class IdentityConfig
    {
        public void Configuration(IAppBuilder app)
        {
            //app.CreatePerOwinContext(StoreIdentityDbContext.Create);
            //app.CreatePerOwinContext<StoreUserManager>(StoreUserManager.Create);
            //app.CreatePerOwinContext<StoreRoleManager>(StoreRoleManager.Create);

            //app.UseCookieAuthentication(new CookieAuthenticationOptions
            //{
            //    AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie
            //});
        }
    }
}