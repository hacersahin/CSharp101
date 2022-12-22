internal class Program
{
    private static void Main(string[] args)
    {
        #region Dizi tanımlama ve değer atama

        int[] dizi = new int[20];
        dizi[5] = 30;
        Console.WriteLine(dizi[5]);

        // Şöyle de olabilir...

        string[] dizi1 = { "Bir", "İki", "Üç" };

        int[] dizi2 = { 2, -4, 6 };
        
        float[] dizi3 = { 2f, 1.2f, 7f };

        // Not : Ancak bu şekilde dizi belirtimini sadece dizi tanımlamalarında kullanabiliriz. Örneğin aşağıdaki gibi bir kullanım hatalıdır:

        //int[] dizi;
        //dizi ={ 1,2,3};

        int[] dizi4 = new int[] { 1, 2, 3 };

        int a = Convert.ToInt32(Console.ReadLine());
        int[] dizi5 = new int[a + 5];
        dizi[5] = 30;
        Console.WriteLine(dizi[5]);

        // birden fazla dizi tanımlama
        int[] dizi6 = new int[10], dizi7 = new int[20];

        #endregion

        #region foreach döngüsü

        int[] dizi8 = { 3, 2, 6, 7 };

        foreach (int eleman in dizi)
            Console.WriteLine(eleman);

        #endregion

        #region Çok boyutlu diziler

        int[,] dizi9 = new int[3, 2];

        int[,] dizi10 = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

        int[,,] dizi11 = new int[3, 2, 2]; // 3 boyutlu dizi

        int[,,] dizi12 = { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } }, { { 9, 10 }, { 11, 12 } } };

        // Dizi elemanlarını for döngüsü ile değiştirmek

        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 2; j++)
                for (int k = 0; k < 2; k++)
                    dizi12[i, j, k] = 20;

        // Düzensiz diziler
        int[][] dizi13 = new int[3][];
        dizi13[0] = new int[3];
        dizi13[1] = new int[4];
        dizi13[2] = new int[2];


        #endregion

        #region Dizilerde kullanılan bazı metotlar

        // GetLenght ****************
        int[] dizi14 = { 1, 4, 7, 9 };
        Console.WriteLine(dizi14.GetLength(0));

        //----
        int[,] dizi15 = { { 2, 4, 2 }, { 7, 10, 4 }, { 7, 12, 6 }, { 2, 1, 12 } };

        byte boyut = (byte)dizi15.GetLength(1);
        
        Console.WriteLine(a);

        //---
        int[][] dizi16 = new int[3][];
        dizi16[0] = new int[] { 1, 2, 3 };
        dizi16[1] = new int[] { 4, 5, 6, 7 };
        dizi16[2] = new int[] { 8, 9 };
        for (int i = 0; i < dizi16.GetLength(0); i++)
            for (int j = 0; j < dizi16[i].GetLength(0); j++)
                Console.WriteLine("dizi16[{0}][{1}]={2}", i, j, dizi16[i][j]); // dizinin bütün elemanlarını teker teker ekrana yazar.

        // CreateInstance ***********

        Array dizi17 = Array.CreateInstance(typeof(int), 5); // int türünden 5 elemanlı dizi17 adında bir dizi tanımlandı ve dizinin her bir elemanına int türünün varsayılan değeri atandı.

        Array dizi18 = Array.CreateInstance(typeof(int), 3, 2, 5); // Burada 3X2X5 boyutunda int türünden 3 boyutlu bir dizi oluşturuldu.

        // İlginç bir kullanım
        int[] dizi19 = new int[5] { 2, 3, 6, 8, 7 };
        Array dizi20 = Array.CreateInstance(typeof(int), dizi19); // Burada 2X3X6X8X7 boyutunda beş boyutlu bir dizi oluşturuldu..

        // Dikkat ! : CreateInstance yöntemiyle oluşturulan dizilere DiziAdi[0,4] gibi bir yöntemle erişilemez. Peki nasıl olcak bu iş...

        Array dizi21 = Array.CreateInstance(typeof(int), 5, 4, 3);

        for (int i = 0; i <= dizi21.GetUpperBound(0); i++) // Bir dizinin son indeks numarasını verir.
            for (int j = 0; j <= dizi21.GetUpperBound(1); j++)
                for (int k = 0; k <= dizi21.GetUpperBound(2); k++)
                    dizi21.SetValue(i + j + k, i, j, k); // Bir dizinin belirli bir indeksini belirli bir değerle değiştirir.
        for (int i = 0; i <= dizi21.GetUpperBound(0); i++)
            for (int j = 0; j <= dizi21.GetUpperBound(1); j++)
                for (int k = 0; k <= dizi21.GetUpperBound(2); k++)
                    Console.WriteLine(dizi21.GetValue(i, j, k)); // Bir dizinin belirli bir indeksini tutar.

        // Dizi kopyalamak *************

        int[] dizi22 = { 1, 2, 3, 4 };
        int[] dizi23 = new int[10];
        dizi22.CopyTo(dizi23, 3); // Burada dizi22'in tüm elemanları dizi23'e 3. indeksten itibaren kopyalanıyor.

        //
        int[] dizi24 = { 1, 2, 3, 4 };
        int[] dizi25 = new int[10];
        Array.Copy(dizi24, dizi25, 3); // Burada 3 tane eleman dizi24'den dizi25'e kopyalanır. Kopyalama işlemi 0. indeksten itibaren başlar.

        //
        int[] dizi26 = { 1, 2, 3, 4, 5, 6, 7 };
        int[] dizi27 = new int[10];
        Array.Copy(dizi26, 2, dizi27, 7, 3); // Burada dizi26'nın 2. indeksinden itibaren 3 eleman, dizi27'ye 7. indeksten itibaren kopyalanıyor.

        // Dizi sıralama ****************

        Array metinsel = Array.CreateInstance(typeof(string), 8);

        metinsel.SetValue("İstanbul", 0);
        metinsel.SetValue("Bursa", 1);
        metinsel.SetValue("Ankara", 2);
        metinsel.SetValue("Adıyaman", 3);
        metinsel.SetValue("Trabzon", 4);
        metinsel.SetValue("Rize", 5);
        metinsel.SetValue("Amasya", 6);
        metinsel.SetValue("Muğla", 7);
        
        Console.WriteLine("Sırasız dizi:");
        
        foreach (string isim in metinsel)
            Console.Write(isim + " ");
        
        Console.WriteLine("\n\nSıralı dizi:");
        
        Array.Sort(metinsel);
        
        foreach (string isim in metinsel)
            Console.Write(isim + " ");

        Console.WriteLine("\n\n\n");

        //
        Array sayisal = Array.CreateInstance(typeof(int), 8);

        sayisal.SetValue(200, 0);
        sayisal.SetValue(10, 1);
        sayisal.SetValue(6, 2);
        sayisal.SetValue(3, 3);
        sayisal.SetValue(1, 4);
        sayisal.SetValue(0, 5);
        sayisal.SetValue(-5, 6);
        sayisal.SetValue(12, 7);
        
        Console.WriteLine("Sırasız dizi:");
        
        foreach (int sayi in sayisal)
            Console.Write(sayi + " ");
        
        Console.WriteLine("\n\nSıralı dizi:");
        
        Array.Sort(sayisal);
        
        foreach (int sayi in sayisal)
            Console.Write(sayi + " ");

        Console.WriteLine("\n\n\n");

        // Dizilerde arama *************
        int[] dizi28 = { 500, 35, 56,2,8 };

        Array.Sort(dizi28);
        
        Console.Write(Array.BinarySearch(dizi28, 56)); // BinarySearch metodu, bir nesneyi bir dizi içinde arar, eğer bulursa bulduğu nesnenin indeksini tutar, bulamazsa negatif bir sayı tutar. BinarySearch'ü kullanabilmek için diziyi daha önce Sort ile sıralamalıyız.

        Console.WriteLine("\n\n\n");
        //
        string[] dizi29 = { "Ankara", "Bursa", "Kastamonu", "Bolu", "Manisa", "Aydın", "Kocaeli", "Ağrı", "Rize", "Çankırı" };

        Array.Sort(dizi);

        Console.Write(Array.BinarySearch(dizi, 3, 4, "Manisa")); // BinarySearch burada 3. indeksten itibaren 4 eleman içinde "yakup"u arar. Bulursa indeksini tutar. Bulamazsa negatif bir sayı tutar. NOT : Yalnızca tek boyutlu diziler Sort ile sıralanabilir, dolayısıyla da çok boyutlu dizilerde hem Sort ile sıralama hem de BinarySearch ile arama yapmak imkansızdır.




        #endregion







        Console.ReadKey();
    }
}