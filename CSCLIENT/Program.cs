using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://localhost:7207/";
            var apiInstance = new ContactApi(config);

            List<Contact> result = apiInstance.ContactGet();
            for(int i=0; i<result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }
            var contact = new Contact
            {
                FirstName = "John",
                LastName = "Doe",
                Age = 50
            };
            var createdpost = apiInstance.ContactPost(contact);
            result.Add(createdpost);
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }


        }
    }
}