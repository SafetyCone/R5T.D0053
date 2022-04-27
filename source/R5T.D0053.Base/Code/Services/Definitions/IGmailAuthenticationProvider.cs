using System;
using System.Threading.Tasks;

using R5T.Aalborg;

using R5T.T0064;


namespace R5T.D0053
{
    [ServiceDefinitionMarker]
    public interface IGmailAuthenticationProvider : IServiceDefinition
    {
        Task<IAuthentication> GetGmailAuthentication();
    }
}