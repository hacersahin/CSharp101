using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    private static void Main(string[] args)
    {

        //#region 1. if - else
        //// if else deyimi sayesinde belli bir koşul sağlandığında söz konusu komutlar çalıştırılır, o belli koşullar sağlanmadığında çalıştırılmaz ya da başka komutlar çalıştırılır.
        ////
        //// Syntax :

        //// if (koşul)
        ////    komut1;
        //// else
        ////    komut2;
        ////
        //// veya
        ////
        //// if (koşul)
        ////  {
        ////    komutlar1
        ////  }
        //// else
        ////  {
        ////    komutlar2
        ////  }

        //int a = 5, b = 7;


        //if (a < b)
        //    Console.WriteLine("a b'den küçük");
        //else
        //    Console.WriteLine("a b'den küçük değil");

        //// Diğer bir örnek

        //int c = 5, d = 7;

        //if (c < d)
        //{
        //    Console.WriteLine("c d'den küçük");
        //    Console.WriteLine(c);
        //}
        //else
        //{
        //    Console.WriteLine("c d'den küçük değil");
        //    Console.WriteLine(d);
        //}

        //// if else yapılarında else kısmının bulunması zorunlu değildir. Bu durumda sadece koşul sağlandığında bir şeyler yapılacak, koşul sağlanmadığında bir şeyler yapılmayacaktır. 

        //int e = 5, f = 7;

        //if (e > f)
        //    Console.WriteLine("e f'den küçük");

        //// Şöyle de bir kullanım mümkündür

        Console.Write("Cinsiyetinizi girin (e, k): ");

        char cins = Convert.ToChar(Console.ReadLine());

        if (cins == 'e')
            Console.Write("Erkeksiniz....");
        else if (cins == 'k')
            Console.Write("Kadınsınız....");
        else
            Console.Write("Lütfen cinsiyetinizi doğru giriniz!");

        //#endregion

        #region 2. switch -case
        // switch deyimi bazı if else deyimlerinin yaptığı işi daha az kodla yapar. Genellikle bazı karmaşık if else bloklarını kurmaktansa switch'i kullanmak programın anlaşılırlığını artırır. Ancak tabii ki basit if else bloklarında bu komutun kullanılması gereksizdir.
        //
        // Syntax :

        //switch (ifade)
        //{
        //    case sabit1:
        //        komut1;
        //        break;
        //    case sabit2:
        //        komut2;
        //        break;
        //    default:
        //        komut3;
        //        break;
        //}
        // Bazı bilinmesi gerekenler
        //
        // *) İfadenin ürettiği değer hangi case sabitinde varsa o "case"deki komutlar işletilir. Eğer ifadenin ürettiği değer hiçbir case sabitinde yoksa default casedeki komutlar işletilir.
        // *) Aynı birden fazla case sabiti olamaz
        //
        //int g = 4;

        //switch (g)
        //{
        //    case 4:
        //        Console.Write("deneme1");
        //        break;
        //    case 4:
        //        Console.Write("deneme2");
        //        break;
        //    case 5:
        //        Console.Write("deneme3");
        //        break;
        //    default:
        //        Console.Write("deneme4");
        //        break;
        //}
        //
        // *) herhangi bir case'e ait komutların "break;" satırı ile sonlandırılması gerekmektedir. Eğer sonlandırılmazsa program hata verir.
        // doğru kullanım
        int h = 4;

        switch (h)
        {
            case 4:
                string i = Console.ReadLine(); // Ekran okuması
                Console.Write(i);
                break;
            default:
                Console.Write("deneme4");
                break;
        }
        // *) Eğer programımızın bir case'deyken farklı bir case'e gitmesini istiyorsak "goto" anahtar sözcüğünü kullanırız
        int j = 5;

        switch (j)
        {
            case 4:
                string k1 = Console.ReadLine();
                Console.Write(k1);
                break;
            case 5:
                Console.Write("Şimdi case 4'e gideceksiniz.");
                goto case 4;
            default:
                Console.Write("deneme4");
                break;
        }

        // *) goto satırı kullanılmışsa break; satırının kullanılmasına gerek yoktur.

        // *) Eğer farklı case sabitlerinin aynı komutları çalıştırmasını istiyorsak şöyle bir program yazılabilir

        int k = 7;

        switch (k)
        {
            case 4:
            case 5:
                string l = Console.ReadLine(); // ekrandan okuma yapar..
                Console.Write(l);
                break;
            default:
                Console.Write("deneme4");
                break;
        }

        #endregion





    }








}
