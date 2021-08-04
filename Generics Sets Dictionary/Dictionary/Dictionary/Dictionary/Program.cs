using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();
            cookies["User"] = "Maria";
            cookies["Email"] = "Maria@gmail.com";
            cookies["Phone"] = "99283255";
            cookies["Phone"] = "91824724";


            Console.WriteLine(cookies["Phone"]) ;
            cookies.Remove("Phone");

            if (cookies.ContainsKey("Phone"))
            {
                Console.WriteLine(cookies["Phone"]);
            }
            else
            {
                Console.WriteLine("Can't find email value");
            }

            Console.WriteLine(cookies.Count) ;


            foreach(KeyValuePair<string,string> cookie in cookies)
            {
                Console.WriteLine(cookie.Key + " " + cookie.Value);
            }
        }
    }
}
