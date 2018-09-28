using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.API.Filter
{
    /// <summary>
    /// 头部请求参数
    /// </summary>
    public class GlobalHttpHeaderFilter : IOperationFilter
    {
        /// <summary>
        /// Apply
        /// </summary> 
        public void Apply(Operation operation, OperationFilterContext context)
        {
            operation.Parameters = operation.Parameters ?? new List<IParameter>();
            //MemberAuthorizeAttribute 自定义的身份验证特性标记
            //var isAuthor = operation != null && context != null && context.ApiDescription.ControllerAttributes().Any(e => e.GetType() == typeof(MemberAuthorizeAttribute)) || context.ApiDescription.ActionAttributes().Any(e => e.GetType() == typeof(MemberAuthorizeAttribute));
            if (true)
            {
                operation.Parameters.Add(new NonBodyParameter()
                {
                    Name = "token",
                    In = "header", //query formData ..
                    Description = "身份验证票据",
                    Required = false,
                    Type = "string"
                });
            }
        }
    }
}
