using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Praxent.Email.Model
{
    public class TransactionalEmail
    {
        public TransactionalEmail()
        {
            MergeValuesForTemplate = new Dictionary<string, string>();
        }

        // Check if email is valid
        // Ref: https://haacked.com/archive/2007/08/21/i-knew-how-to-validate-an-email-address-until-i.aspx/
        [RegularExpression(@"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                           + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                           + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$")]
        [Required]
        public string EmailAddress { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string TemplateName { get; set; }
        public IDictionary<string, string> MergeValuesForTemplate { get; set; }
    }
}