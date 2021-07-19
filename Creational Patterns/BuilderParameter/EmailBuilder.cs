using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderParameter
{
    public class EmailBuilder
    {
        private readonly Email email;
        public EmailBuilder(Email email) => this.email = email;

        public EmailBuilder From(string from)
        {
            email.From = from;
            return this;
        }
        public EmailBuilder To(string to)
        {
            email.To = to;
            return this;
        }
        public EmailBuilder Body(string body)
        {
            email.Body = body;
            return this;
        }
        // other fluent members here
    }

    /*Now, to coerce the client to use only the builder for sending emails, you can implement a MailService as follows:
     */
    public class MailService
    {
        private void SendEmailInternal(Email email) { }

        public void SendEmail(Action<EmailBuilder> builder)
        {
            var email = new Email();
            builder(new EmailBuilder(email));
            SendEmailInternal(email);
        }
    }
}