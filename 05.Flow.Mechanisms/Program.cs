using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    private static void Main(string[] args)
    {

        #region 1. if - else
        // if else deyimi sayesinde belli bir koşul sağlandığında söz konusu komutlar çalıştırılır, o belli koşullar sağlanmadığında çalıştırılmaz ya da başka komutlar çalıştırılır.
        //
        // Syntax :

        // if (koşul)
        //    komut1;
        // else
        //    komut2;
        //
        // veya
        //
        // if (koşul)
        //  {
        //    komutlar1
        //  }
        // else
        //  {
        //    komutlar2
        //  }

        int a = 5, b = 7;


        if (a < b)
            Console.WriteLine("a b'den küçük");
        else
            Console.WriteLine("a b'den küçük değil");

        // Diğer bir örnek

        int c = 5, d = 7;

        if (c < d)
        {
            Console.WriteLine("c d'den küçük");
            Console.WriteLine(c);
        }
        else
        {
            Console.WriteLine("c d'den küçük değil");
            Console.WriteLine(d);
        }

        // if else yapılarında else kısmının bulunması zorunlu değildir. Bu durumda sadece koşul sağlandığında bir şeyler yapılacak, koşul sağlanmadığında bir şeyler yapılmayacaktır. 

        int e = 5, f = 7;

        if (e > f)
            Console.WriteLine("e f'den küçük");

        // Şöyle de bir kullanım mümkündür

        Console.Write("Cinsiyetinizi girin (e, k): ");

        char cins = Convert.ToChar(Console.ReadLine());

        if (cins == 'e')
            Console.Write("Erkeksiniz....");
        else if (cins == 'k')
            Console.Write("Kadınsınız....");
        else
            Console.Write("Lütfen cinsiyetinizi doğru giriniz!");

        #endregion

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

        #region 3. for

        int toplam = 0;
        for (int i1 = 1; i1 <= 3; i1++)
            toplam += i1;
        Console.Write("toplam={0}", toplam);

        //
        // girdiğimiz herhangi bir sayının faktöriyelini bulma

        float s;
        int si, f1;
        bool a1 = true;
        for (; a1;)
        {
            Console.Write("Lütfen faktoriyelinin alınmasını istediğiniz sayıyı girin: ");

            s = Convert.ToSingle(Console.ReadLine());
            
            si = (int)s;
            
            if (si != s || s < 1)
            {
                Console.WriteLine("Lütfen pozitif tam sayı girin.");
                a1 = true;
            }
            else
            {
                a1 = false;
                
                for (f = 1; si > 1; si--)
                    f *= si;
                
                Console.WriteLine("Faktöriyeli={0}", f);
            }
        }

        //
        //int a2;
        //for (int i = 0; i < 1; i++)
        //    a2 = 5;
        //Console.Write(a2); //Bu program çalışmaz, çünkü a değişkeni döngüden önce tanımlanmasına rağmen ilk değer verilmiyor.


        //1'den 1000'e (sınırlar dâhil) kadar olan sayılar içerisinde 5'e tam bölünen, ancak 7'ye tam bölünemeyen sayıları alt alta listeleyen, bu sayıların kaç tane olduğunu ve toplamını yazan bir program yazınız.

        int toplam1 = 0, sayi = 0, i = 5;
        for (; i < 1001; i += 5)
        {
            if (i % 35 == 0)
                continue;
            sayi++;
            toplam += i;
            Console.WriteLine(i);
        }
        Console.WriteLine("Sayısı: " + sayi);
        Console.WriteLine("Toplam: " + toplam1);

        // Konsol ekranına girilen 0 ile 100 (sınırlar dâhil) arasındaki 10 notun en büyüğünü, en küçüğünü ve ortalamasını yazan programı yazınız.

        int bs = 0, toplam2 = 0, ks = 0;

        for (int a2 = 0, b1; a2 < 10; a2++)
        {
            Console.Write(a2 + 1 + ". notu giriniz: ");
            b1 = Convert.ToInt32(Console.ReadLine());
            if (b1 > 100 || b1 < 0)
            {
                Console.Write("Yanlış not girdiniz. Lütfen tekrar ");
                a2--;
                continue;
            }
            if (a2 == 0)
            {
                bs = b;
                ks = b;
            }
            else
            {
                if (b1 > bs)
                    bs = b1;
                if (b1 < ks)
                    ks = b1;
            }
            toplam += b1;
        }
        Console.Write("En büyük: {0}\nEn küçük: {1}\nOrtalama: " + toplam / 10, bs, ks);


        #endregion

        #region 4. while


        #endregion

        #region 5. do while



        #endregion


    }








}
