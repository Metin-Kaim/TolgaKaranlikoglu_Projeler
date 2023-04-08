using System.Numerics;

namespace TolgaKaranlikoglu_Ders1
{
    public class NewMath
    {
        public static void Main(string[] args)
        {
            NewMath newMath = new();
            int secim;
            do
            {
                Console.WriteLine("Yapmak istediginiz islemi secin:\n");
                Console.WriteLine("1. Minimum sayiyi bul");
                Console.WriteLine("2. Maximum sayiyi bul");
                Console.WriteLine("3. Faktoriyel hesabi yap");
                Console.WriteLine("4. Diziyi sirala");
                Console.WriteLine("~5. ISLEMI SONLANDIR~\n\n");

                Console.Write("Seciminiz: ");
                secim = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (secim)
                {
                    case 1:
                        newMath.Min();
                        break;
                    case 2:
                        newMath.Max();
                        break;
                    case 3:
                        newMath.Factoriel();
                        break;
                    case 4:
                        newMath.Sort();
                        break;
                    case 5:
                        Console.WriteLine("Uygulama sonlandiriliyor...");
                        break;
                    default:

                        break;
                }


            } while (secim != 5);
            Console.WriteLine("Uygulama sonlandi.");
        }

        public void Min()
        {
            float ilkSayi, ikinciSayi, sonuc;
            Console.Write("Ilk sayi: ");
            ilkSayi = float.Parse(Console.ReadLine());
            Console.Write("Ikinci sayi: ");
            ikinciSayi = float.Parse(Console.ReadLine());

            if (ilkSayi > ikinciSayi)
            {
                sonuc = ikinciSayi;
            }
            else if (ilkSayi < ikinciSayi)
            {
                sonuc = ilkSayi;
            }
            else
            {
                sonuc = ilkSayi;
            }

            Console.WriteLine($"Sonuç: {sonuc}\n\n");
        }
        public void Max()
        {
            float ilkSayi, ikinciSayi, sonuc;
            Console.Write("Ilk sayi: ");
            ilkSayi = float.Parse(Console.ReadLine());
            Console.Write("Ikinci sayi: ");
            ikinciSayi = float.Parse(Console.ReadLine());

            if (ilkSayi < ikinciSayi)
            {
                sonuc = ikinciSayi;
            }
            else if (ilkSayi > ikinciSayi)
            {
                sonuc = ilkSayi;
            }
            else
            {
                sonuc = ilkSayi;
            }

            Console.WriteLine($"Sonuç: {sonuc}\n\n");
        }
        public void Factoriel()
        {
            int sayi;
            BigInteger sonuc = 1;
            Console.Write("Sayi: ");
            sayi = int.Parse(Console.ReadLine());

            while (sayi > 1)
            {
                sonuc *= sayi;
                sayi--;
            }

            Console.WriteLine($"Sonuç: {sonuc} \n\n");

        }
        public void Sort()
        {
            List<float> sayilar = new List<float>();
            int secim;
            do
            {
                Console.WriteLine("1. Diziye eleman ekle\n2. Diziyi sirala");
                Console.Write("Seciminiz: ");
                secim = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (secim)
                {
                    case 1:
                        Console.Write("Sayi girin: ");
                        float sayi = float.Parse(Console.ReadLine());
                        sayilar.Add(sayi);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Dizi siralaniyor...");
                        Console.Write("Girdiler: ");
                        foreach (var item in sayilar)
                        {
                            Console.Write($"{item}, ");
                        }
                        Console.WriteLine();

                        var n = sayilar.Count;
                        bool swapRequired;
                        for (int i = 0; i < n - 1; i++)
                        {
                            swapRequired = false;
                            for (int j = 0; j < n - i - 1; j++)
                                if (sayilar[j] > sayilar[j + 1])
                                {
                                    var tempVar = sayilar[j];
                                    sayilar[j] = sayilar[j + 1];
                                    sayilar[j + 1] = tempVar;
                                    swapRequired = true;
                                }
                            if (swapRequired == false)
                                break;
                        }
                        Console.Write("Sirali dizi: ");
                        foreach (var item in sayilar)
                        {
                            Console.Write($"{item}, ");
                        }
                        Console.WriteLine("\n");
                        break;
                    default:
                        Console.WriteLine("Gecersiz islem. Tekrar deneyin...");
                        break;
                }

            } while (secim != 2);
        }

    }
}
