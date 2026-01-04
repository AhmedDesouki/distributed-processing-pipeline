using Grpc.Core;
using GrpcService;

namespace GrpcService.Services
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<Res> sumprocess(Nums request, ServerCallContext context)
        {
            
            return Task.FromResult(new Res
            {
                R= request.A + request.B
        });
        }

        
    }
}
