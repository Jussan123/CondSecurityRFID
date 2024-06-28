using CondSecurityRFID.Store.Dto;
using CondSecurityRFID.Store.Login.Dto;
using Newtonsoft.Json;
using Refit;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace CondSecurityRFID.Store.Login
{
    public static class LoginAppService 
    {
        public static async Task<GetLoginTokenInputDto> LoginApi(GetLoginOutputDto input)
        {
            var client = RestService.For<ILoginAppService>(HttpOptions.GetHttpClientNoBearer());
            return await client.LoginApi(input);
        }

        public static async Task<ResultOrMessageDto<GetLoginTokenInputDto>> Login(GetLoginOutputDto input)
        {
            var result = new ResultOrMessageDto<GetLoginTokenInputDto>();
            try
            {
                result.Result = await LoginApi(input);
                return result;
            }
            catch (ApiException e)
            {
                Console.WriteLine(e.Content);
                try
                {
                    result.Message = e.Content;
                    return result;
                }
                catch (Exception ex)
                {
                    throw new ArgumentException("Erro ao se comunicar com a API!\n Reinicie e aplicação conectado a internet\n" + ex.Message);
                }
            }
        }
    }
}
