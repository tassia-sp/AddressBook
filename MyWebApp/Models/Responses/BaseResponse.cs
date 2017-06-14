using System;

namespace MyWebApp.Models.Responses
{
    /// <summary>
    /// The Base class for all my Response models. 
    /// If it is going out the door from the Apis it must inherit form here. 
    /// Api Controllers do not need to implement this but this can be used.
    /// I will have examples in my api controller that utilize the response models and some that do not.
    /// </summary>
    public abstract class BaseResponse
    {
        public bool IsSuccessful { get; set; }

        public string TransactionId { get; set; }

        public BaseResponse()
        {
            //This TxId we are just faking to demo the purpose
            this.TransactionId = Guid.NewGuid().ToString();
        }
    }
}