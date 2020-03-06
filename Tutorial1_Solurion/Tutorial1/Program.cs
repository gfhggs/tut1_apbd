using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tutorial1
{
    public class Program
    {
        
       public static async Task Main(string[] args) {
           
            var websioteUrl = args[0];
            var httpClient = new HttpClient();
            var response = await  httpClient.GetAsync(websioteUrl);



            //check response 
            if (response.IsSuccessStatusCode)
            {
                var htmlContent = await response.Content.ReadAsStringAsync();
                var regex = new Regex("[a-z]+[a-z0-9]*@[a-z0-9]\\.[a-z0-9]]+", RegexOptions.IgnoreCase);
                var emailAdresses = regex.Matches(htmlContent);

                foreach(var match in emailAdresses)
                {
                    Console.WriteLine(match.ToString());
                }
                  
            }

            Console.WriteLine("Hello World! gjf");

        }
    }
            //asynchornised programming tasks will be exceuted in parallel thred simultaniously  so in  total it will  take 3 sec. something 
            //synchronised programming 3 indepemndent tasks. t1 is done it moves to t2 in total i twilll taske 9 sec 

}
