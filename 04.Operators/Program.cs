internal class Program
{
    private static void Main(string[] args)
    {


        #region 1. Matematiksel operatörler
        // Diğer operatörlere göre daha değişik işlem yapan % operatörü (mod alma)

        int a = 5 % 2; // 5 sayısının 2'ye bölümü işleminde kalan değer a değişkenine atandı.

        Console.WriteLine("Sonuç 1 : " + a + "\n");

        #endregion

        #region 1.1. Değişik bir durum
        // Eğer işlem yapılan her iki operand farklı türdeyse sonuç daha üst kapasiteli türde tutulur.

        float b = 5 / 2f; // Burada 5 sayısı da float gibi davranmış ve sonuç ondalıklı çıkmıştır.

        Console.WriteLine("Sonuç 1.1 : " + b + "\n");

        #endregion

        #region 1.2. Ancak durumu ...

        float c = 2 / 5 / 2f; // Burada sonuç 0 çıkar. Çünkü zaten işlem yapılırken sonuç daha floata (2f) gelmeden sıfırlanmıştı.

        Console.WriteLine("Sonuç 1.2 : " + c + "\n");


        #endregion

        #region 1.3. Diğer bir durum ...

        float d = 2f / 5 / 2; // Burada ise zincirleme olarak her işlemin sonucu floatlaşmakta ve sonuç ondalıklı çıkmaktadır.

        Console.WriteLine("Sonuç 1.3 : " + d + "\n");


        #endregion

        #region 1.4. Daha da ilginci ...

        float e = 2f / 5 / 2 / 2 / 4 / 8 / 4 / 5 / 3; // Burada ise zincirleme olarak her işlemin sonucu floatlaşmakta ve sonuç ondalıklı çıkmaktadır.

        Console.WriteLine("Sonuç 1.4 : " + e + "\n");


        #endregion

        #region 2. Bir artırma ve eksiltme operatörleri
        // C#'ın en çok kullanılan operatörlerindendir. Önüne veya sonuna geldiği değişkeni bir artırır veya bir eksiltirler, sabitlere uygulanamazlar.Ön ek ve son ek olmak üzere iki şekilde kullanılabilirler.

        int fonceki = 5;

        int fsonraki = ++fonceki; // Ön ek örneği - ++ operatörü hem fonceki değerini bir artırdı hem de bu değeri tuttu ve değeri fsonraki ye atandı

        Console.WriteLine("Sonuç 2 : Önceki değer " + fonceki + " , sonraki değer " + fsonraki + "\n");

        int gonceki = 10;

        int gsonraki = gonceki++; // Son ek örneği - önce gonceki değeri gsonraki'ye atanır, sonra gonceki değeri 1 artırılır.

        Console.WriteLine("Sonuç 2.1 : Önceki değer " + gonceki + " , sonraki değer " + gsonraki + "\n");

        // Karışık gibi sanki :)

        int h = 5;

        int i = h++; // i=6
        
        int j = i--; // j=5

        int k = 10; // 

        int l = --k; // l=9

        Console.WriteLine("Sonuç 2.2 : h={0}\ti={1}\tj={2}\tl={3}\n", h, i, j, l); // WriteLine metodunun biraz farklı kullanım şekli

        // Not ! - Bir artırma ve bir azaltma operatörleri byte, sbyte, short ve ushort türlerindeki değişkenlere uygulanmaz.


        #endregion

        #region 3. Karşılaştırma operatörleri
        // Bu operatörler şunlardır: < (küçüktür), > (büyüktür), <= (küçük eşittir), >= (büyük eşittir), == (eşittir), != (eşit değildir).
        
        bool m = 4 < 6; // true
        
        bool n = 6 > 5;
        
        bool o = 7 <= 7;
        
        bool p = 9 >= 12;
        
        bool q = 10 == 12;
        
        bool r = 1 != 8;
        
        Console.WriteLine("Sonuç 3 :\n{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n", m, n, o, p, q, r);

        #endregion

        #region 4. as operatörü
        // Tüm değişken türlerinden object'e ve object'ten referans değişkenlerine dönüşüm yapar. Dönüşüm gerçekleşmiyorsa null değer döndürür
        
        object s = "50";
        string t = s as string; // s değişgeni string olarak t değişgenine atanacaktır.

        Console.WriteLine("Sonuç 4 : {0}\n", t);

        int u = 50;
        object v = u as object;

        Console.WriteLine("Sonuç 4.1 : {0}\n", v);

        #endregion

        #region 5. is operatörü
        // Verilen değişken, sabit ya da ifadenin türünü kontrol eder. Eğer söz konusu değişken, sabit ya da ifade verilen türle uyumluysa "true" değilse "false" değeri üretir. Eğer söz konusu değişken, sabit ya da ifadenin türü her zaman true ya da false üretiliyorsa derleyici uyarı verir, ancak bu uyarı derlemeye engel değildir.

        int w = 50;

        bool y = w is int;
        
        bool z = w is double;
        
        bool A = 12 is byte;
        
        bool B = 'c' is string;
        
        bool C = 12f + 7 is int;

        Console.WriteLine("Sonuç 5 :\n{0}\n{1}\n{2}\n{3}\n{4}\n", y, z, A, B, C);

        #endregion

        #region 6. Mantıksal operatörler
        // Bu operatörler true veya false sabit ya da değişkenleri mantıksal ve, veya, değil işlemine sokarlar. Bunlar && (ve), || (veya) ve ! (değil) operatörleridir.

        bool D = 35 > 10 && 10 == 50; //false

        bool E = 35 > 10 && 10 != 50; //true
        
        bool F = 5 is int || 12 * 3 == 200; //true
        
        bool G = 5 < 4 || 45 / 5 == 9; //true
        
        bool H = !(5 < 4); //true

        Console.WriteLine("Sonuç 6 :\n{0}\n{1}\n{2}\n{3}\n{4}\n", D, E, F, G, H);

        #endregion

        #region 7. Atama operatörleri
        // Şimdiye kadar çok kullandığımız = operatörüyle ilgili bilinmesi gereken bir iki durum var.

        // *) = operatörünün sol tarafında kesinlikle yalnızca bir tane değişken olmalı. Örneğin aşağıdaki gibi bir kullanım hatalıdır.
        //int I = 0, J = 0;
        //K + L = 20;

        // *) = operatöründe işlemler "sağdan sola" gerçekleşir ve = operatörü operandlarıyla birlikte atadığı değeri tutar


        byte M = 75, N = 31, O;
        
        O = N = M;

        Console.WriteLine("Sonuç 7 : " + N + " " + M + " " + O + "\n");

        #endregion

        #region 8. İşlemli atama operatörleri

        //a = a + b; yerine a+= b;
        //a = a - b; yerine a-= b;
        //a = a * b; yerine a*= b;
        //a = a / b; yerine a/= b;
        //a = a % b; yerine a%= b;
        //a = a << b; yerine a<<= b;
        //a = a >> b; yerine a>>= b;
        //a = a & b; yerine a&= b;
        //a = a ^ b; yerine a^= b;
        //a = a | b; yerine a|= b;

        //kullanılabilir.

        #endregion

        #region 9. ?: operatörü
        // Bu operatör C#'da üç operand alan tek operatördür. Verilen koşula göre verilen değerlerden (object türünden) birini tutar.
        // 
        // Syntax : koşul?doğruysa_değer:yanlışsa_değer

        Console.WriteLine("C# amcayı sevdiniz mi ki ne? (e, h): ");

        string cevap = Console.ReadLine();// ekrandan değer okuma
        
        Console.WriteLine(cevap == "e" ? "D'accord. C'est bon !!..Right answer...." : "E napalım...Belki başka bahara..." + "\n");

        #endregion

        #region 10. İşaret değiştirme operatörü
        // Pozitif - negatif durumu yani

        int P = 50;

        int Q = -P;
        
        int R = -23;

        int S = -(P + Q + R);

        int T = -12;

        Console.WriteLine("Sonuç 10 :\n{0}\n{1}\n{2}\n{3}\n{4}\n", P, Q, R, S, T);

        #endregion

        #region 11. typeof operatörü
        // Herhangi bir değişken türünün tip karşılığını "Type" türünden tutar

        Type U = typeof(int); // System.Int32

        Type W = typeof(string); // System.String

        Console.WriteLine("Sonuç 11 :\n{0}\n{1}\n", U,W);

        #endregion



        Console.ReadKey();
    }
}