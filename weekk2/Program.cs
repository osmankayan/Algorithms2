using System;
using System.Collections.Generic;
using System.Text;

namespace weekk2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static void ArrayChallenge(string[] strArr)
        {
            string mainword =strArr[0];
            for (int i = 1; i < strArr.Length; i++)
            {
                if (strArr[i] == mainword[0].ToString())
                {
                    //bool strArr[i+1] == mainword[1;
                }
            }

            

        }
        public static void StringChallengee(string str)
        {
            char[] chars = { ' ', ',', '.', ':', '-', '+', '*', '/', '#', '%', '&', '$', '!','?',')','(', '{', '}', '|', '^', '"','=','[', ']', };
            string[] bol = str.Split(chars);
            string a = null;
            string b = null;
            
            StringBuilder stringBuilder = new StringBuilder();
            

            a = bol[0].ToLower();
            b = bol[0][0].ToString().ToLower();
            stringBuilder.Append(b);
            stringBuilder.Append(a.Substring(1));
            for (int i = 1; i < bol.Length; i++)
            {
                a=bol[i].ToLower();
                b = bol[i][0].ToString().ToUpper();
                stringBuilder.Append(b);
                stringBuilder.Append(a.Substring(1));
               
               
                
            }
            Console.WriteLine(stringBuilder);
                
                
                
                

               

                







        }
            
            //char[] harfler=str.ToCharArray();
            //for (int i = 0; i < harfler.Length; i++)
            //{
                
            //    if (harfler[i].ToString() == "-") harfler[i].ToString().Replace("-", " ");
            //    if (harfler[i].ToString() == "*") harfler[i].ToString().Replace("*", " ");
            //    if (harfler[i].ToString() == "/") harfler[i].ToString().Replace("/", " ");
            //    if (harfler[i].ToString() == "+") harfler[i].ToString().Replace("+", " ");
            //    if (harfler[i].ToString() == "#") harfler[i].ToString().Replace("#", " ");
            //    if (harfler[i].ToString() == "%") harfler[i].ToString().Replace("%", " ");
            //    if (harfler[i].ToString() == "&") harfler[i].ToString().Replace("&", " ");
            //    if (harfler[i].ToString() == "$") harfler[i].ToString().Replace("$", " ");
            //    if (harfler[i].ToString() == "!") harfler[i].ToString().Replace("!", " ");

            //    if (harfler[i].ToString()==" ")
            //    {
            //        harfler[i + 1].ToString().ToUpper();
            //    }


            //}
            //foreach (var item in harfler)
            //{
            //    Console.WriteLine(item);
            //}
            //return "a";

        }
    }

