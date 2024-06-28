using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using CondSecurityRFID.Store.Dto;
using CondSecurityRFID.Store.Login.Dto;
using Refit;

namespace CondSecurityRFID.Store.Login
{
    public interface ILoginAppService
    {
        [Post("/User/loginApp")]
        Task<GetLoginTokenInputDto> LoginApi([Body] GetLoginOutputDto body);

    }
}
