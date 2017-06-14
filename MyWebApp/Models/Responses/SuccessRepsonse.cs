namespace MyWebApp.Models.Responses
{
    /// <summary>
    /// This class simply sets IsSuccesful to true by default.
    /// Many of the response classes will end up inheriting from here
    /// since they should be returning IsSuccessful = true
    /// </summary>
    public class SuccessRepsonse : BaseResponse
    {
        public bool SuccessResponse()
        {
            return this.IsSuccessful = true;
        }
    }
}