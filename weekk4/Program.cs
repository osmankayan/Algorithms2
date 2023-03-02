using System;
using System.Threading;

namespace weekk4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  ArrayChallenge(new string[] { "coder", "byte", "code" });
            StringChallenge("<div><div><b></b></div></p>");
            
        }
        public static string StringChallenge(string str)
        {

            
            string aranan = "<div><div>";
           int a=  str.IndexOf(aranan,0);

            string aranan2 = "<i>";
            string aranan3 = "/<i>";
            int b = str.IndexOf(aranan2);
            int c = str.LastIndexOf(aranan3);


            if (a != -1) return "div";



            else if (b == -1 || c == -1) return "i";

            else return "true";




           

        }
        public static string ArrayChallenge(string[] strArr)
        {
            string[] dizi1 = new string[strArr.Length];

            int b = 0;
            int a = 0;
            for (int i = 10; i > 0; i--)
            {
                a = 0;
                start:
               
                    while (a<strArr.Length)
                    {
                        if (strArr[a].Length == i)
                        {

                            while (b < strArr.Length)
                            {
                                dizi1[b] = strArr[a];
                                b++;
                                a++;
                                
                            if (dizi1[b - 1] != null) goto start;
                            }

                        }
                        else a++;





                }
            }
           
            return dizi1[2];
        }
    }
}
