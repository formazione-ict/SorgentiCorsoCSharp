using System;
namespace Corso_12
{
    public class Request
    {
        public Request()
        {
        }

        public Request(Request request)
        {
            this.Message = request.Message;
            this.RequestDateTime = request.RequestDateTime;
            this.User = request.User;
        }

        public Request(string user, string message)
        {
            RequestDateTime = DateTime.Now;
            this.User = user;
            this.Message = message;
        }

        public string Message { get; set; }

        public DateTime RequestDateTime { get; set; }

        public string User { get; set; }
    }
}
