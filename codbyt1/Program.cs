using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace codbyt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(ArrayChallenge(new string[] { "000", "100" }));
            //Console.WriteLine(MathChallenge(4));
            Console.WriteLine(StringChallenge("DDLL"));
        }

        public static int StringChallenge(string str)
        {

            Hashtable h1 = new Hashtable();
            h1.Add("I", 1);
            h1.Add("V", 5);
            h1.Add("X", 10);
            h1.Add("L", 50);
            h1.Add("C", 100);
            h1.Add("D", 500);
            h1.Add("M", 1000);
            str.ToCharArray();
            int a = 0;
            foreach (char item in str)
            {
                if (h1.ContainsKey(item)) a += (int)h1[item];
            }
            return a;

        }
        public static bool MathChallenge(int num)
        {
            int a=0;
            for (int i = 2; i <= num; i++)
            {
                if (num % i == 0) a++;
            }
            if (a >= 2) return false;
           
            else if(num==2) return true;
            else if(num==3) return true;
            else return true;

        }
        public static string ArrayChallenge(string[] strArr)
        {
            String str1= strArr[0];
            String str2= strArr[1];
            string[] list4 = new string[str2.Length];
            //str1.ToCharArray();
            //str2.ToCharArray();
            for (int i = 0; i < str1.Length; i++)
            {
                //string a = str1.Substring(i,i+1);
                //string b = str2.Substring(i, i+1);
                int a,b;
                a = str1.IndexOf('1', i);
                b = str2.IndexOf('1', i);
                if (a==b && a>=0 &&b>=0)
                {
                    list4[i] = "1";
                }
                else list4[i] = "0";
            }
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in list4)
            {
                stringBuilder.Append(item);
            }
            return stringBuilder.ToString();

            //int[] list1 = new int[str1.Length];
            //int[] list2 = new int[str2.Length];
            //int[] list3 = new int[str2.Length];



            //for (int i = 0; i < str1.Length; i++)
            //{
            //    list1[i]=(str1[i]);
            //}
            //for (int i = 0; i < str2.Length; i++)
            //{
            //    list2[i]=(str2[i]);
            //}
            //for (int i = 0; i < list1.Length; i++)
            //{
            //    if ((list1[i] == 1) && list2[i] == 1)
            //    {
            //        list3[i] = 1;
            //    }
            //    else list3[i] = 0;
            //}
            //string[] sonuc=new string[str1.Length];
            
            //for (int i = 0; i < str1.Length; i++)
            //{
            //    sonuc[i] = list3[i].ToString();
                
            //}
            ////string sonuc = Array.ConvertAll(list3, i => i.ToString);
            ////sonuc.ToString();

            //StringBuilder builder = new StringBuilder();
            //foreach (string item in sonuc)
            //{
            //    builder.Append(item);
            //}
            //return builder.ToString();
           
            
        }
    }
    
}
