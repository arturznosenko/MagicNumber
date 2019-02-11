using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main()
        {

            int[] visiskaiciai = new int[900000];
            int number = 100000;

            for (int i = 0; i < visiskaiciai.Length; i++)
            {
                visiskaiciai[i] = number;
                number = number + 1;
            }
            Console.WriteLine(visiskaiciai[0] + " " + visiskaiciai[899999]);
            findMagicNumber(visiskaiciai);

            //Console.WriteLine(ArSkirtingi(136080));
            //Console.WriteLine(ArSkirtingiDuSkaicia(123456,154321));

            Console.ReadLine();
        }

        static bool ArSkirtingi(int skaicius = 0)
        
        {

            int[] number = new int[6];

         number[0] = skaicius % 1000000/100000;
         number[1] = skaicius % 100000/10000;
         number[2] = skaicius % 10000/1000;
         number[3] = skaicius % 1000/100;
         number[4] = skaicius % 100/10;
         number[5] = skaicius % 10;

         

            for (int i = 0; i<=5; i++)
            {
                for (int j = 1+i; j <= 5; j++)
                {
                    if (number[i] == number[j])
                    return false;
                }
            }
            return true;
        }

        static bool ArSkirtingiDuSkaicia(int skaicius1 = 0, int skaicius2 = 0)

        {

            int[] number1 = new int[6];
            int[] number2 = new int[6];

            number1[0] = skaicius1 % 1000000 / 100000;
            number1[1] = skaicius1 % 100000 / 10000;
            number1[2] = skaicius1 % 10000 / 1000;
            number1[3] = skaicius1 % 1000 / 100;
            number1[4] = skaicius1 % 100 / 10;
            number1[5] = skaicius1 % 10;

            number2[0] = skaicius2 % 1000000 / 100000;
            number2[1] = skaicius2 % 100000 / 10000;
            number2[2] = skaicius2 % 10000 / 1000;
            number2[3] = skaicius2 % 1000 / 100;
            number2[4] = skaicius2 % 100 / 10;
            number2[5] = skaicius2 % 10;

           
            int count = 0;

            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j <= 5; j++)
                {
                    if (number1[i] == number2[j])
                    {
                        count = count + 1;
                        break;
                    } 
                }
            }
         
            if (count == 6)
            { return true; }
            else
            { return false; }
        }

        private static void findMagicNumber(int [] magicnumbers)
        {
            
            bool yesno = false;
            bool duskaicia = false;

            for (int j = 0; j < magicnumbers.Length; j++)

               
            {
                yesno = ArSkirtingi(magicnumbers[j]);
               
                if ((yesno == true) && (magicnumbers[j]< 999999))
                {
                 //  Console.WriteLine(magicnumbers[j]);
                   // yesno = ArSkirtingi(magicnumbers[j] * 2);
                    duskaicia = ArSkirtingiDuSkaicia(magicnumbers[j], magicnumbers[j] * 2);

                    if ((duskaicia == true) && (magicnumbers[j] * 2 < 999999))
                    {
                      //  Console.WriteLine(magicnumbers[j]);
                      //  yesno = ArSkirtingi(magicnumbers[j] * 3);
                        duskaicia = ArSkirtingiDuSkaicia(magicnumbers[j], magicnumbers[j] * 3);

                        if ((duskaicia == true) && (magicnumbers[j] * 3 < 999999))
                        {
                       //    Console.WriteLine(magicnumbers[j]);
                        //    yesno = ArSkirtingi(magicnumbers[j] * 4);
                            duskaicia = ArSkirtingiDuSkaicia(magicnumbers[j], magicnumbers[j] * 4);


                            if ((duskaicia == true) && (magicnumbers[j] * 4 < 999999))
                            {
                                // Console.WriteLine(magicnumbers[j]);
                                // yesno = ArSkirtingi(magicnumbers[j] * 5);
                                duskaicia = ArSkirtingiDuSkaicia(magicnumbers[j], magicnumbers[j] * 5);

                                if ((duskaicia == true) && (magicnumbers[j] * 5 < 999999))
                                {
                                    //      Console.WriteLine(magicnumbers[j]);
                                    //       yesno = ArSkirtingi(magicnumbers[j] * 6);
                                duskaicia = ArSkirtingiDuSkaicia(magicnumbers[j], magicnumbers[j] * 6);
                                    if ((yesno == true) && (magicnumbers[j] * 6 < 999999))
                                        {
                                        Console.WriteLine(magicnumbers[j]);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            
        }
    }
}
