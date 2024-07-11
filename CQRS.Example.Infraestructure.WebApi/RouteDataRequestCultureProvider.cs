using Microsoft.AspNetCore.Localization;

namespace CQRS.Example.Infraestructure.WebApi
{
    public class RouteDataRequestCultureProvider : RequestCultureProvider
    {
        public override Task<ProviderCultureResult> DetermineProviderCultureResult(HttpContext httpContext)
        {
            var pathSegments = httpContext.Request.Path.Value.Split('/');
            var culture = pathSegments.Length > 1 ? pathSegments[1] : null;

            if (string.IsNullOrEmpty(culture))
            {
                return Task.FromResult<ProviderCultureResult>(null);
            }

            var providerResultCulture = new ProviderCultureResult(culture);

            return Task.FromResult(providerResultCulture);
        }
    }
}