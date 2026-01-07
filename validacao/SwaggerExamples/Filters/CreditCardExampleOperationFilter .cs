using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace validacao.SwaggerExamples.Filters
{
    public class CreditCardExampleOperationFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            if (!context.ApiDescription.RelativePath.Contains("creditcard/validate"))
                return;

            operation.Responses["200"].Content["application/json"].Example =
                OpenApiAnyFactory.CreateFromJson(
                    System.Text.Json.JsonSerializer.Serialize(
                        new CreditCardValidExample().GetExamples()));

            operation.Responses["400"].Content["application/json"].Example =
                OpenApiAnyFactory.CreateFromJson(
                    System.Text.Json.JsonSerializer.Serialize(
                        new CreditCardInvalidExample().GetExamples()));
        }
    }
}
