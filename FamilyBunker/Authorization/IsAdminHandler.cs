using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyBunker.Authorization
{

    public class IsAdminHandler : AuthorizationHandler<IsAdminRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, IsAdminRequirement requirement)
        {
            var IsAnAdmin = context.User.HasClaim(c => c.Type == Claims.IsAdmin);

            if (IsAnAdmin)
            {
                context.Fail();
            }

            return Task.CompletedTask;
        }
    }
}
