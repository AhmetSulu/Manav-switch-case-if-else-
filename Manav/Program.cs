using System;

namespace ManavUygulamasi
{

    class Program
    {
        static void Main(string[] args)

        {
            // Ürün Listeleme Ekranı

            Console.WriteLine("Shock Manavina hos geldiniz");
            Console.WriteLine("Elma = 2 TL");
            Console.WriteLine("Armut = 3 TL");
            Console.WriteLine("Cilek = 2 TL");
            Console.WriteLine("Muz = 3 TL");
            Console.WriteLine("Diger butun meyveler = 4");

            // Tercih alma ekranı switch-case yöntemi ile

            Console.WriteLine("Hangi meyveyi satın almak istersiniz? (Elma,Armut,Muz,Cilek,Diğer)");

            string chosen = Console.ReadLine()?.ToLower();

            switch (chosen)
            {
                case "elma":
                    Console.WriteLine("Sectiginiz urun fiyatı  2 TL");
                    break;
                case "armut":
                    Console.WriteLine("Sectiginiz urun fiyatı  3 TL");
                    break;
                case "cilek":
                    Console.WriteLine("Sectiginiz urun fiyatı 2 TL");
                    break;
                case "muz":
                    Console.WriteLine("Sectiginiz urun fiyatı 3 TL");
                    break;
                case "diger":
                    Console.WriteLine("Diger bütün meyveler 4 TL");
                    break;
                default:
                    Console.WriteLine("Sectiginiz Urun bulunmamaktadır.");
                    break;

            }

        }
    }
}


// if-else ile programlama



// Ürün fiyatlarını tanımlama

decimal Elma = 2;
decimal Armut = 3;
decimal Cilek = 2;
decimal Muz = 3;
decimal Diger = 4;

// Ürün listeleme ekranı

Console.WriteLine("Hangi meyveyi satın almak istiyorsunuz?");
Console.WriteLine("Elma  2 TL");
Console.WriteLine("Armut 3 TL");
Console.WriteLine("Cilek 2 TL");
Console.WriteLine("Muz 3 TL");
Console.WriteLine("Diger meyveler 4 TL");

string chosen = Console.ReadLine().ToLower();

// Secilen ürünü gösterme ekranı

if (chosen == "elma")
{
    Console.WriteLine($"Elma fiyatı: {Elma} TL");
}
else if (chosen == "armut")
{
    Console.WriteLine($"Armut fiyatı: {Armut} TL");
}
else if (chosen == "çilek")
{
    Console.WriteLine($"Çilek fiyatı: {Cilek} TL");
}
else if (chosen == "muz")
{
    Console.WriteLine($"Muz fiyatı: {Muz} TL");
}
else if (chosen == "diğer")
{
    Console.WriteLine($"Diğer meyvelerin fiyatı: {Diger} TL");
}
else
{
    Console.WriteLine("Geçersiz bir meyve seçtiniz.");
}


// Switch-case yapısı cok koşullarda daha okunabilir if-else yapısına göre daha anlaşılabilir.