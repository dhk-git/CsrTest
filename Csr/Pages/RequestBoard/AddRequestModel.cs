using Csr.Models;

namespace Csr.Pages.RequestBoard
{
    public class AddRequestModel
    {
        public RequestType RequestType { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string CreateUserID { get; set; }
        public string ProjectID { get; set; }
        public string CustomerID { get; set; }
    }
}
