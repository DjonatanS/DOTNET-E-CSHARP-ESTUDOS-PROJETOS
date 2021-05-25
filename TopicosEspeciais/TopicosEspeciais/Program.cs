using System;

namespace TopicosEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Func para string
            /*
            string original = "abcde FGHIJ ABC abc DEFG ";
            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();
            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");
            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);
            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xy");
            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);
            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine("Substring(3): -" + s4 + "-");
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);
            */


            #endregion

            #region DateTime 
            /*
            DateTime date = DateTime.Now;
            Console.WriteLine(date);
            DateTime d2 = new DateTime(2018, 11, 10);
            Console.WriteLine(d2);
            DateTime d3 = DateTime.Today;
            Console.WriteLine(d3);
            DateTime d4 = DateTime.UtcNow;
            Console.WriteLine(d4);


            DateTime d5 = DateTime.Parse("2021-06-22");
            Console.WriteLine(d5);
            */
            #endregion


            #region TimeSpan


            TimeSpan t1 = new TimeSpan(0, 1, 30);
            Console.WriteLine(t1);

            TimeSpan t2 = TimeSpan.FromDays(1.5);
            Console.WriteLine(t2);

            TimeSpan t3 = TimeSpan.FromHours(1.5);
            Console.WriteLine(t3);
            #endregion

        }
    }
}
