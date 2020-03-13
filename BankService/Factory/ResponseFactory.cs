using System;
using System.Collections.Generic;
using System.Text;

namespace BankService.Factory
{
    public class ResponseFactory : IResponseFactory
    {
        //Simulate always a success response from the bank
        public ResponseModel create() =>
            new ResponseModel
            {
                ResponseStatus = ResponseType.Success,
                Guid = Guid.NewGuid()
            };
    }
}
