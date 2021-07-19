/*There are situations, however, when you want to explicitly force the user to interact with
 * the builder from the outset, possibly concealing even the object they're actually building.
 * 
 * Long story short, the Builder Parameter approach forces the consumer of your API to use a builder, 
 * whether they like it or not. This Action trick that we employ ensures that the client has a way of receiving an already-initialized builder object.
 */

namespace BuilderParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            var ms = new MailService();
            ms.SendEmail(email => email.From("foo@bar.com")
                                       .To("bar@baz.com")
                                       .Body("Hello, how are you?"));
        }
    }
}
