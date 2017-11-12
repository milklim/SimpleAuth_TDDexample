using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAuth
{
    public class Request : IRequest
    {
        public Task<EAuthResponse> Authorize(string login, string pass)
        {
            if (login == "user@ort.com" && pass == "ort")
            {
                return Task.FromResult(EAuthResponse.Success);
            }

            return Task.FromResult(EAuthResponse.OtherError);
        }
    }
}
