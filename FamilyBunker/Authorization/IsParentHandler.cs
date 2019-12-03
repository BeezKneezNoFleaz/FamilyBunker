using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyBunker.Authorization
{

    public class IsParentHandler : AuthorizationHandler<IsParentRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, IsParentRequirement requirement)
        {
            var IsAParent = context.User.HasClaim(c => c.Type == Claims.IsParent);

            if (IsAParent)
            {
                context.Fail();
            }

            return Task.CompletedTask;
        }
    }
}
