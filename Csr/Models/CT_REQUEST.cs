namespace Csr.Models
{
    public class CT_REQUEST : ModelBase
    {
        public int REQUEST_ID { get; set; }
        public RequestType REQUEST_TYPE { get; set; }   //
        public DateTime CREATE_DT { get; set; }
        public string PROJECT_ID { get; set; }
        public string CUSTOMER_USER_ID { get; set; }
        public string REQUEST_TITLE { get; set; }
        public string REQUEST_DETAIL { get; set; }
    }

    public enum RequestType
    {
        단순문의,
        프로그램오류,
        데이터수정
    }
}
