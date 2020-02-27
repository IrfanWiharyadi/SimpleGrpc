using Grpc.Net.Client;
using GrpcService1;
using System;
using System.Threading.Tasks;
using SecureRX.Services.Identity.Protos;

namespace GrpcClient
{
    class Program
    {
        static async Task Main(string[] args)
        {

            //var channel = GrpcChannel.ForAddress("https://localhost:4001");
            //var client = new Greeter.GreeterClient(channel);

            //var reply = await client.SayHelloAsync(new HelloRequest() { Name = "Tim" });
            //Console.WriteLine(reply);
            Console.ReadKey();
            var channel2 = GrpcChannel.ForAddress("https://localhost:5101");
            var client2 = new ProtoUser.ProtoUserClient(channel2);

            try
            {
                var result = await client2.LoginAsync(new LoginRequestVM() { Application = "Web", IpAddress = "3", Username = "it@farmaku.com", Password = "P@ssw0rd", ForSpecificGroupId = 0 });
                Console.WriteLine(result.AccessToken);
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            
        }
    }
}
