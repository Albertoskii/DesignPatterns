using Newtonsoft.Json.Linq;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace BuilderPersons
{
    class Program
    {
        static void Main(string[] args)
        {
            var pb = new PersonBuilder();
            Person person = pb
              .Lives
                .At("123 London Road")
                .In("London")
                .WithPostcode("SW12BC")
              .Works
                .At("Fabrikam")
                .AsA("Engineer")
                .Earning(123000);
            Console.WriteLine(JObject.FromObject(person));
            string jsonString = JsonSerializer.Serialize(person);
            Console.WriteLine(jsonString);


        }
    }
}
