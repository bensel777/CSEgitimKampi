using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları

            //Console.Write("Merhaba Dünya");
            //Console.WriteLine("Selam");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion

            #region String Değişkenler

            //String
            //Değişken_türü değişken_adı;

            //string name;
            //name = "Bensel";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Bensel";
            //customerSurname = "Korkmaz";
            //customerPhone = "+90 8010112012";
            //customerEmail = "b@hotmail.com";
            //district = "vicky";
            //city = "Hull";

            //Console.WriteLine("****  Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İlertişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("------------------------------------------------");

            //Console.WriteLine();

            //customerName = "Tülay";
            //customerSurname = "Korkmaz";
            //customerPhone = "+90 5555 5555 55";
            //customerEmail = "tesr@gmail.com";
            //district = "hull";
            //city = "Vicky";

            //Console.WriteLine("------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İlertişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("------------------------------------------------");




            #endregion

            #region Int Değişkenler

            //int

            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;
            
            Console.WriteLine("**** Restoran Menü Fiyatları ****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger Fiyatı: " + hamburgerPrice + " TL");
            Console.WriteLine("-----Kola: " + cokePrice + " TL");
            Console.WriteLine("-----Su: " + waterPrice + " TL");
            Console.WriteLine("-----Patates Kızartması: " + friesPrice + " TL");
            Console.WriteLine("-----Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("-----Limonata: " + lemonadePrice + " TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatları ****");

            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice = 0;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;




            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice; 
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;
            

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL");
            Console.WriteLine("Patates Kızartması Tutarı: " + totalFriesPrice + " TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");

            Console.WriteLine();

            int totalPrice=totalCokePrice+ totalWaterPrice+ totalFriesPrice+ totalLemonadePrice+ totalHamburgerPrice+ totalPizzaPrice;

            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL");






            #endregion

            Console.Read();
        }
    }
}




//Yazdırma komutları