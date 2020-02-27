using Grpc.Core;
using Microsoft.Extensions.Logging;
using SecureRX.Services.Identity.Protos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace GrpcService1
{
    public class UserServices : ProtoUser.ProtoUserBase
    {
        private readonly ILogger<UserServices> _logger;
        public UserServices(ILogger<UserServices> logger)
        {
            _logger = logger;
        }

        public override Task<LoginResponseVM> Login(LoginRequestVM request, ServerCallContext context)
        {
            return Task.FromResult(new LoginResponseVM
            {
                AccessToken = "asd"
            });
        }
    }
}
