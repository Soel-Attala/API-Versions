using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

namespace APIVersionControl
{
    public class SwaggerConfig : IConfigureNamedOptions<SwaggerGenOptions>
    {

        private readonly IApiVersionDescriptionProvider _provider;

        public SwaggerConfig(IApiVersionDescriptionProvider provider)
        {
            _provider = provider;
        }


        public void Configure(string name, SwaggerGenOptions options)
        {
            throw new NotImplementedException();
        }

        public void Configure(SwaggerGenOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
