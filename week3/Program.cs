using System;
using System.Runtime.InteropServices;

namespace week3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayChallenge(new int[] {1,2,3,4});
        }
        public static void ArrayChallenge(int[] arr)
        {
            int[] newlist = new int[arr.Length];
            if (arr[0] == 1) 
            {
                

                int cep = arr[0];
                int sayaç = 1;

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    newlist[i] = arr[sayaç];
                    sayaç++;
                    if (i == arr.Length - 2) newlist[arr.Length - 1] = cep;
                }
                foreach (var item in newlist)
                {
                    Console.Write(item);
                }
            }
            int[] newlist2 = new int[arr.Length];
            if (arr[0]==2)
            {
                int cep = arr[0];
                int sayaç = 1;

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    newlist[i] = arr[sayaç];
                    sayaç++;
                    if (i == arr.Length - 2) newlist[arr.Length - 1] = cep;
                }

                int cep2 = newlist[0];
                int sayaç2 = 1;

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    newlist2[i] = newlist[sayaç2];
                    sayaç2++;
                    if (i == newlist.Length - 2) newlist2[arr.Length - 1] = cep2;
                }
                foreach (var item in newlist2)
                {
                    Console.Write(item);
                }

            }
            int[] newlist3 = new int[arr.Length];
            if (arr[0] == 3)
            {
                
                    int cep = arr[0];
                    int sayaç = 1;

                    for (int i = 0; i < arr.Length - 1; i++)
                    {
                        newlist[i] = arr[sayaç];
                        sayaç++;
                        if (i == arr.Length - 2) newlist[arr.Length - 1] = cep;
                    }

                    int cep2 = newlist[0];
                    int sayaç2 = 1;

                    for (int i = 0; i < arr.Length - 1; i++)
                    {
                        newlist2[i] = newlist[sayaç2];
                        sayaç2++;
                        if (i == newlist.Length - 2) newlist2[arr.Length - 1] = cep2;
                    }

                    int cep3 = newlist2[0];
                    int sayaç3 = 1;

                    for (int i = 0; i < arr.Length - 1; i++)
                    {
                        newlist3[i] = newlist2[sayaç2];
                        sayaç3++;
                        if (i == newlist2.Length - 2) newlist3[arr.Length - 1] = cep3;
                    }

                    foreach (var item in newlist3)
                    {
                        Console.Write(item);
                    }
                
            }

            int[] newlist4 = new int[arr.Length];
            if (arr[0] == 4)
            {
                int cep = arr[0];
                int sayaç = 1;

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    newlist[i] = arr[sayaç];
                    sayaç++;
                    if (i == arr.Length - 2) newlist[arr.Length - 1] = cep;
                }

                int cep2 = newlist[0];
                int sayaç2 = 1;

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    newlist2[i] = newlist[sayaç2];
                    sayaç2++;
                    if (i == newlist.Length - 2) newlist2[arr.Length - 1] = cep2;
                }

                int cep3 = newlist2[0];
                int sayaç3 = 1;

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    newlist3[i] = newlist2[sayaç3];
                    sayaç3++;
                    if (i == newlist2.Length - 2) newlist3[arr.Length - 1] = cep3;
                }
                int cep4 = newlist3[0];
                int sayaç4 = 1;

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    newlist4[i] = newlist3[sayaç4];
                    sayaç4++;
                    if (i == newlist3.Length - 2) newlist4[arr.Length - 1] = cep4;
                }

                foreach (var item in newlist4)
                {
                    Console.Write(item);
                }
            }

            int[] newlist5 = new int[arr.Length];
            if (arr[0] == 5) 
            {
                int cep = arr[0];
                int sayaç = 1;

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    newlist[i] = arr[sayaç];
                    sayaç++;
                    if (i == arr.Length - 2) newlist[arr.Length - 1] = cep;
                }

                int cep2 = newlist[0];
                int sayaç2 = 1;

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    newlist2[i] = newlist[sayaç2];
                    sayaç2++;
                    if (i == newlist.Length - 2) newlist2[arr.Length - 1] = cep2;
                }

                int cep3 = newlist2[0];
                int sayaç3 = 1;

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    newlist3[i] = newlist2[sayaç3];
                    sayaç3++;
                    if (i == newlist2.Length - 2) newlist3[arr.Length - 1] = cep3;
                }
                int cep4 = newlist3[0];
                int sayaç4 = 1;

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    newlist4[i] = newlist3[sayaç4];
                    sayaç4++;
                    if (i == newlist3.Length - 2) newlist4[arr.Length - 1] = cep4;
                }
                int cep5 = newlist4[0];
                int sayaç5 = 1;

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    newlist5[i] = newlist4[sayaç5];
                    sayaç5++;
                    if (i == newlist4.Length - 2) newlist5[arr.Length - 1] = cep5;
                }

                foreach (var item in newlist5)
                {
                    Console.Write(item);
                }
            }







        }
        public static int MathChallenge(int num1, int num2)
        {
            int a = 1;
            for (int i = 2; i < num1+1; i++)
            {
                if (num1 % i == 0 && num2 % i == 0)
                {
                    a = i;
                }
                
            }
            
            return a;

        }
        public static bool StringChallenge(string str)
        {
            string[] bol = str.Split(' ');
            bool a = false;


            if (bol.Length == 1)
            {
                char[] harfler = bol[0].ToCharArray();

                int count1 = 0;
                int ustuste = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    for (int b = 1; b < 10; b++)
                    {

                        if (harfler[i] == Convert.ToChar(b))
                        {
                            count1++;
                        }
                    }
                    for (int d = 0; d < harfler.Length; d++)
                    {
                        for (int c = 1; c < harfler.Length; c++)
                        {

                            if (harfler[d] == harfler[c])
                            {
                                ustuste++;
                            }
                        }
                    }


                }
                if (count1 == 3 || ustuste > 1) a = false;
                else a = true;

            }
            if (bol.Length == 2)
            {
                char[] harfler1 = bol[0].ToCharArray();

                char[] harfler2 = bol[1].ToCharArray();

                int count1 = 0;
                int ustuste1 = 0;

                int count2 = 0;
                int ustuste2 = 0;
                for (int i = 0; i < harfler1.Length; i++)
                {
                    for (int b = 1; b < 10; b++)
                    {

                        if (harfler1[i] == Convert.ToChar(b))
                        {
                            count1++;
                        }
                    }


                }
                for (int d = 0; d < harfler1.Length; d++)
                {
                    for (int c = 1; c < harfler1.Length; c++)
                    {

                        if (harfler1[d] == harfler1[c])
                        {
                            ustuste1++;
                        }
                    }
                }


                for (int i = 0; i < harfler2.Length; i++)
                {
                    for (int b = 1; b < 10; b++)
                    {

                        if (harfler2[i] == Convert.ToChar(b))
                        {
                            count2++;
                        }
                    }


                }
                for (int d = 0; d < harfler2.Length; d++)
                {
                    for (int c = 1; c < harfler2.Length; c++)
                    {

                        if (harfler2[d] == harfler2[c])
                        {
                            ustuste2++;
                        }
                    }
                }
                if (count1 == 3 || ustuste1 > 1 || count2 == 3 || ustuste2 > 1) a = false;
                else a = true;
            }
            if (bol.Length == 3) a = true;


            return a;


        }
    }
}
