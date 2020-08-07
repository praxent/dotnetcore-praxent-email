using System.Collections.Generic;

namespace Praxent.Email.Model
{
    public class MailMessage
    {
        public MailMessage()
        {
            ToEmailList = new List<string>();
        }

        public string FromEmail { get; set; }
        public string ReplyTo { get; set; }
        public IList<string> ToEmailList { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public IDictionary<string, string> MergeValues { get; set; }
    }
}