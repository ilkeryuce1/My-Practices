using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kredi_Hesaplama_
{
    public class Program
    {

        static void Main(string[] args)
        {
          

            int BirKur = 0;
            string banka = "";
            double tutar = 0;
            int ay = 0;
            string yesno = "";
            double faiz = 2;
            string kurum = "";
            string parola = "";
            double total = 1;


            Console.WriteLine("****Welcome To Bank App*****");
            Console.WriteLine("1-İş Bankası\n2-Garanti Bankası \n3-Halk Bankası");
            Console.Write("Hangi Bankadan Kredi Çekmek istersiniz : ");
            banka = Console.ReadLine();
            Console.Write("1-Bireysel müşteriler için : \n2-Kurumsal müşteriler için:\n");
            BirKur = Convert.ToInt32(Console.ReadLine());

            if (banka == "1")
            {

              
                KurumsalBireysel();
            }

            else if (banka == "2")
            {
                KurumsalBireysel();
            }
            else if (banka == "3")
            {
                KurumsalBireysel();
            }

           

                Console.ReadLine();






            void metot()
            {
            yukarı:
                Console.WriteLine("Çekmek istediğiniz tutarı giriniz:");
                tutar = Convert.ToInt32(Console.ReadLine());
                if (tutar < 1000)
                {
                    Console.WriteLine("1000 Tl den düşük kredı cekemezsınız:");
                    goto yukarı;
                }
                else
                {

                    Console.WriteLine("Kaç Ayda ödemek istersiniz :");
                    ay = Convert.ToInt32(Console.ReadLine());
                    if (ay < 12)
                    {
                        faiz =1.63 ;
                    }
                    else if (ay >= 12 && ay <= 24)
                    {
                        faiz = 1.5f;
                    }
                    else
                    {
                        faiz = 1.93f;
                    }
                    Console.WriteLine($"Faiz oranımız {faiz} devam etmek istermisiniz e/h");
                    yesno = Console.ReadLine();
                    total = (((tutar / 100) * faiz)*ay)+tutar;//FAizli tutar

                    switch (yesno)
                    {
                        case "e":
                            Console.WriteLine("Vade sonu Ödemeniz gereken tutar" + total);
                            Console.WriteLine("Aylık odemenız gereken tutar : " + total / ay); break;
                        case "h": Console.WriteLine("Yine Bekleriz"); break;
                        default:
                            break;
                    }
                    erken();


                }
            }


            void KurumsalBireysel()
            {

                if (BirKur == 1)
                {
                    metot();
                }
                else if (BirKur == 2)
                {

                    Console.Write("Kurum adı giriniz : ");
                    kurum = Console.ReadLine();

                    if (kurum == "ilker" || kurum == "ali" || kurum == "veli" || kurum == "elli" || kurum == "akbank")
                    {
                        Console.Write("parola giriniz:");
                        parola = Console.ReadLine();
                        if (parola == "1")
                        {
                            faiz -= 0.2f;
                            metot();
                        }
                    }
                    metot();
                }
            }


            void erken()
            {
              
                for (int i = 1; i <= ay; i++)
                {
                    Console.WriteLine($"{i}. ayı odeyınız ");
                 Console.ReadLine();
                    Console.WriteLine("erken odemek ıster mısınız e/h ");
                    string secim = Console.ReadLine();
                    if (secim == "e")
                    {
                        double aylıkodeme = tutar / ay;
                        for (int k = 1; k <= i; k++)
                        {

                            double aylıkfaiz = (tutar / 100) * (faiz / 12) * k; //Aylık faizli 

                            double odemetutarı = aylıkfaiz + aylıkodeme; //faizli aylık odeme 
                            tutar -= odemetutarı;

                        }
                        Console.WriteLine("Ödemeniz gereken tutar : " + (tutar));
                        i = ay;
                    }
                    else
                    {
                        i = 1;
                    }
                   

                }

                
            }
        }
       


    } 
}
