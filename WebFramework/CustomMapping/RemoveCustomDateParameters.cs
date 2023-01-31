using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Linq;

namespace WebFramework.Swagger
{
    public class RemoveCustomDateParameters : IOperationFilter
    {
        public void Apply(Operation operation)
        {
            // Remove CustomDate parameter from all Operations
            var CustomDateParameter = operation.Parameters.SingleOrDefault(p => p.Name == "CustomDate");
                operation.Parameters.Remove(CustomDateParameter);
        }
    }
}
