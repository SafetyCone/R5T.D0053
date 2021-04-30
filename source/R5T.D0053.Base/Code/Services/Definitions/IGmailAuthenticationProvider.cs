using System;
using System.Threading.Tasks;

using R5T.Aalborg;


namespace R5T.D0053
{
    public interface IGmailAuthenticationProvider
    {
        Task<IAuthentication> GetGmailAuthentication();
    }
}