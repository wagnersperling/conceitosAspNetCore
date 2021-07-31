using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreIdentity.Extensions
{
    public class PermissaoNecessaria : IAuthorizationRequirement
    {
        public string Permissao { get; set; }

        public PermissaoNecessaria(string permissao)
        {
            Permissao = permissao;
        }
    }

    public class PermissaoNecessariaHandler : AuthorizationHandler<PermissaoNecessaria>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, PermissaoNecessaria requisito)
        {
            if(context.User.HasClaim(c=> c.Type == "Permissao" && c.Value.Contains(requisito.Permissao)))
            {
                context.Succeed(requisito);
            }
            return Task.CompletedTask;
        }
    }
}

//insert into AspNetUserClaims values('707ebc77-4258-493c-be79-b82c0902821c', 'PodeExcluir','PodeExcluir')
//insert into AspNetUserClaims values('707ebc77-4258-493c-be79-b82c0902821c', 'Permissao','PodeLer, PodeEscrever')
