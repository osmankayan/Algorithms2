using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace week5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SearchingChallenge("10 2One Number*1*");
            ////StringChallengee("3.5");
            //StringChallenge("hello 45");
            
        }
        public static int StringChallenge(string str)
        {
            str.ToCharArray();
            int a = 0;
            int i = 0;
            foreach (var item in str)
            {
                if (str[i]=='A'|| str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U' || str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' ) a++;
                i++;
            }
           
            return a;
           

        }
        public static string StringChallengeee(string str)
        {
           char[] c1= str.ToCharArray();
            Dictionary<char, int> dc = new Dictionary<char, int>();
            int a = 0;
            for (char i = 'a' ; i <= 'z'; i++)
            {

                a++;
                dc.Add(i, a);
                
            }
            foreach (var item in c1)
            {
                if (dc.ContainsKey(item))
                {
                    Console.Write(dc[item]);
                }
                else Console.Write(item);
            }
            // code goes here  
            return str;

        }
        public static void StringChallengee(string str)
        {
            if (str.Contains('.')) 
            {
                string[] beforeaftercomma = str.Split('.');
                if (beforeaftercomma[1].Length == 1) beforeaftercomma[1] += "0";
                int aftercommaa = Convert.ToInt32(beforeaftercomma[1]);
                int beforecomma = Convert.ToInt32(beforeaftercomma[0]);
                string a = string.Empty;
                StringBuilder stringBuilder= new StringBuilder();
                for (int i = 1; i <= beforecomma; i++)
                {
                    stringBuilder.Append("full ");
                    a += "full ";
                   

                }
                if (aftercommaa > 25 && aftercommaa < 75)
                {
                    stringBuilder.Append("half ");
                    a += "half ";
                }

                stringBuilder.ToString().TrimEnd();
                a.TrimEnd();
                string[] stringdizisi = a.Split(' ');
                
                string[] dizi1= a.Split(' ');
                string[] dizi2 = new string[5];
                int c = dizi2.Length - (dizi1.Length-1);
                for (int i = 0; i < dizi1.Length-1; i++)
                {
                    dizi2[i] = dizi1[i];
                }
                if (c != 0) 
                {
                    for (int i = dizi2.Length-c; i <= dizi2.Length-1; i++)
                    {
                        dizi2[i] = "empty";
                    }
                }

                foreach (var item in dizi2)
                {
                    Console.Write(item+' ');
                    
                }
            }




            





        }
        public static int SearchingChallenge(string str)
        {
            Regex rgx = new Regex(@"[^a-zA-Z]");
            rgx.Replace(str, "");
           
            string sayilar = @"\D+";
            string[] sayidizisi = Regex.Split(str, sayilar);
            int toplamm = 0;
            for (int i = 0; i < sayidizisi.Length; i++)
            {
                int sayi;
                bool a = int.TryParse(sayidizisi[i], out sayi);
                if (a) 
                {
                    int c = int.Parse(sayidizisi[i]);
                    toplamm += c;
                }
                
            }

            

            Console.WriteLine(toplamm);
            return toplamm;
            

        }


    }
}
