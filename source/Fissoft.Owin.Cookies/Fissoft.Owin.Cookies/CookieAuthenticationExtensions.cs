using System;
using Microsoft.Owin.Extensions;
using Owin;

namespace Fissoft.Owin.Cookies
{
    public static class CookieAuthenticationExtensions
    {
     
        public static IAppBuilder UseFissoftCookieAuthentication(this IAppBuilder app, CookieAuthenticationOptions options)
        {
            return app.UseFissoftCookieAuthentication(options, PipelineStage.Authenticate);
        }

        public static IAppBuilder UseFissoftCookieAuthentication(this IAppBuilder app, CookieAuthenticationOptions options, PipelineStage stage)
        {
            if (app == null)
            {
                throw new ArgumentNullException("app");
            }

            app.Use(typeof(CookieAuthenticationMiddleware), app, options);
            app.UseStageMarker(stage);
            return app;
        }
    }
}
