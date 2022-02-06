using System;

namespace SonarMULTI.Supreme_Classes
{
    public enum AddToCartCode
    {
        Fail,
        CardDeclined,
        InvalidCardDetails,
        Success,
        PostError,
        HttpError,
        InventoryIssue
    }
    public class AutoCheckoutResponse
    {
        public AddToCartCode Code;
        public string Response;
        public Object Data;
        public AutoCheckoutResponse(AddToCartCode code, string response = "", Object data = null)
        {
            Code = code;
            Response = response;
            Data = data;
        }
    }
}
