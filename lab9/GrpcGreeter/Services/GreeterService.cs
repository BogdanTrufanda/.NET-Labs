using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace GrpcGreeter
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }
        
        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply
            {
                Message = "Hello " + request.Name
            });
        }
       
        public override Task<AddCommentResponse> AddCommentFunction(AddCommentRequest request, ServerCallContext context)
        {
            return base.AddCommentFunction(request, context);
        }

        public override Task<AddPostResponse> AddPostFunction(AddPostRequest request, ServerCallContext context)
        {
            return base.AddPostFunction(request, context);
        }

        public override Task<DeletePostResponse> DeletePostFunction(DeletePostRequest request, ServerCallContext context)
        {
            return base.DeletePostFunction(request, context);
        }

        public override Task<GetCommentByIdResponse> GetCommentByIdFunction(GetCommentByIdRequest request, ServerCallContext context)
        {
            return base.GetCommentByIdFunction(request, context);
        }

        public override Task<GetPostByIdResponse> GetPostByIdFunction(GetPostByIdRequest request, ServerCallContext context)
        {
            return base.GetPostByIdFunction(request, context);
        }

        public override Task<GetPostsResponse> GetPostsFunction(GetPostsRequest request, ServerCallContext context)
        {
            return base.GetPostsFunction(request, context);
        }

        public override Task<UpdateCommentResponse> UpdateCommentFunction(UpdateCommentRequest request, ServerCallContext context)
        {
            return base.UpdateCommentFunction(request, context);
        }

        public override Task<UpdatePostResponse> UpdatePostFunction(UpdatePostRequest request, ServerCallContext context)
        {
            return base.UpdatePostFunction(request, context);
        }
           
    }

}
