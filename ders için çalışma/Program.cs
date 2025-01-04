//// ALAN ÇEVRE HESAPLAMA//
//double r, alan, cevre;
//double pi = 3.14;
//Console.WriteLine("Dairenin yarı çapını gir");
//r = Convert.ToInt32(Console.ReadLine());

//alan = pi * Math.Pow(r, 2);
//cevre = 2 * pi * r;
//Console.WriteLine("çevre:" + cevre);
//Console.WriteLine("alan:" + alan);

//KENARLARI ABCD KARE Mİ DİKDÖRTGEN Mİ
//using System.ComponentModel.Design;

//double a, b, c, d;

//Console.WriteLine("kenarları gir");
//a = Convert.ToDouble(Console.ReadLine());
//b = Convert.ToDouble(Console.ReadLine());
//c = Convert.ToDouble(Console.ReadLine());
//d = Convert.ToDouble(Console.ReadLine());

//if (a + c == b + d)
//{
//    Console.WriteLine("karedir");
//}
//else
//{
//    Console.Write("Kare degildir");
//}
//Console.ReadLine();

//Bir uçak 15 dk boyunca düzgün hızlanarak hızı 480 km/s oluyor. Sonra
//20 dk sabit hızla gidiyor ve 15 dk boyunca düzgün yavaşlayarak hızı
//sıfır oluyor. Herhangi  bir t anında  hızı veren kod

//double v, t;
//Console.WriteLine("hangi zaman");
//t = Convert.ToDouble(Console.ReadLine());
//if (t < 15)
//{
//    v = 32 * t;
//    Console.Write(v);
//}
//else
//{
//    if (t > 35)
//    {
//        v = 1600 - (32 * t);
//    }
//    else
//    {
//        v = 480;
//    }
//    Console.Write(v);
//}
//Console.ReadLine();

//1 ile 25 arasındaki tam sayıların karelerinin çarpımını bulan  
//programın algoritma ve akış diyagramını çiziniz. 



//int a;
//double b;
//for (a = 1; a <= 25; a++)
//{
//    b =  Math.Pow(a, 2);
//    Console.WriteLine(b);
//}

// ax2 + bx +c = 0 tipindeki bir denklemin köklerini bulan programın 
//algoritma ve akış diyagramı çizin


//1-100 arasında kaç asal sayı vardır gösteren programın  algoritma 
//akış diyagramını çiziniz.

//int sayi, adet = 4;
//for (sayi = 8; sayi <= 100; sayi++)
//{
//    if ((sayi % 2) != 0)
//    {
//        if ((sayi % 3) != 0)
//        {
//            if ((sayi % 5) != 0)
//            {
//                if ((sayi % 7) != 0)
//                    adet++;
//            }
//        }
//    }
//}
//Console.Write("Adet = " + adet);
//Console.ReadLine();


//Girilen sayının smith sayısı olup olmadığını bulan programın 
//algoritma ve akış diyagramını çiziniz. 
//int sayi, x, i = 2, top = 0, top1 = 0, y;
//Console.Write("Sayıyı Giriniz = ");
//sayi = Convert.ToInt32(Console.ReadLine());
//x = sayi;
//while (sayi > 10)
//{
//    top = top + sayi % 10;
//    sayi = sayi / 10;
//}
//top = top + sayi;
//while (x > 1)
//{
//    if ((x % i) == 0)
//    {
//        if (i == 2 || i == 3 || i == 5 || i == 7)
//        {
//            top1 = top1 + i;
//            x = x / i;
//        }
//        else
//        {
//            y = i;
//            while (y > 10)
//            {
//                top1 = top1 + y % 10;
//                y = y / 10;
//            }
//            top1 = top1 + y;
//            x = x / i;
//        }
//    }
//    else
//        i++;
//}
//if (top == top1)
//{
//    Console.Write("Smith");
//}
//else
//{
//    Console.Write("smith değil");
//}

//for (int i =1; i <= 5; i++)
//{
//    Console.Write("a1" + i);
//    Console.WriteLine("aç");
//}

//for (double emre= 10.5; emre < 100; emre= emre + 0.9)
//{
//    Console.WriteLine(emre);
//}
//string a = "Seni";
//string b = "Kere seviyorum <3";
//int s = 1;
//while (true)
//{
//    s++;
//    Console.WriteLine(a + "  " + s + "  " + b); 
//        }
//}

//Console.WriteLine("\nÖrnek 10: String içinde karakter sayma");
//string metin;
//metin = Console.ReadLine();
//int sesliHarfSayisi = 0;
//for (int i = 0; i < metin.Length; i++)
//{
//    char harf = char.ToLower(metin[i]);
//    if (harf == 'a' || harf == 'e' || harf == 'ı' || harf == 'i' ||
//        harf == 'o' || harf == 'ö' || harf == 'u' || harf == 'ü')
//    {
//        sesliHarfSayisi++;
//    }
//}
//Console.WriteLine($"Sesli harf sayısı: {sesliHarfSayisi}");
//int tersYukseklik = 20;
//for (int i = tersYukseklik; i >= 1; i--)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}

// Örnek 23: İç İçe Döngülerle Çarpım Tablosu
// 1'den 10'a kadar olan sayıların çarpım tablosu

//for (int i = 1; i <= 10; i++)
//{
//    for (int j = 1; j <= 10; j++)
//    {
//        Console.Write($"{i}x{j}={i * j}\t");
//    }
//    Console.WriteLine();
//}
//Dizi Elemanlarını Tersten Yazdırma
// Bir diziyi tersten yazdırma
//int[] ters = { 5, 6, 7, 8, 9, 10};
//for (int i = ters.Length  -6; i >= 0; i++)
//{
//    Console.WriteLine(ters[i]);
//}

// Bir kelime içinde belirli bir harfin kaç kez geçtiğini sayma

//string metin = "programlama";
//char arananHarf = 'a';
//int harfSayisi = 0;
//for (int i = 0; i < metin.Length; i++)
//{
//    if (metin[i] == arananHarf)
//    {
//        harfSayisi++;
//    }  
//}
//Console.WriteLine($"'{arananHarf}' harfi {harfSayisi} kez geçiyor");
//Console.WriteLine(metin.Length);

//Pisagor Üçlüleri Bulma


//int limit = 50;
//for (int a = 1; a <= limit; a++)
//{
//    for (int b = a + 1; b <= limit; b++)
//    {
//        int c = (int)Math.Sqrt(a * a + b * b);    
//        if (c <= limit && a * a + b * b == c * c)
//        {
//            Console.WriteLine($"Pisagor üçlüsü: {a}, {b}, {c}");
//        }
//    }
//}

//int sayi1 = 48, sayi2 = 36;
//sayi1=Convert.ToInt32(Console.ReadLine());
//sayi2 = Convert.ToInt32(Console.ReadLine());
//while (sayi2 != 0)
//{
//    int temp = sayi2;
//    sayi2 = sayi1 % sayi2;
//    sayi1 = temp;

//}
//Console.WriteLine($"EBOB: {sayi1}");

//int terim = 100;
//double pi = 0;
//for (int i = 0; i < terim; i++)
//{
//    pi += Math.Pow(-1, i) / (2 * i + 1);
//}
//pi *= 4;
//Console.WriteLine($"Pi sayısı yaklaşık değeri: {pi}");
//int sayi8 = 12345;
//int rakamlarToplami = 0;
//sayi8=Convert.ToInt32(Console.ReadLine());  
//for (int i = sayi8; i > 0; i /= 10)
//{
//    rakamlarToplami += i % 10;
//}
//Console.WriteLine($"{sayi8} sayısının rakamları toplamı: {rakamlarToplami}");
//double kilo, boy, vki;
//Console.WriteLine("Vucüt kilonu gir");
//kilo=Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Vucüt boyu gir");
//boy = Convert.ToDouble(Console.ReadLine());

//vki= (kilo/(Math.Pow(boy,2)));

//Console.WriteLine(vki); 

//if (vki > 40) 

//{
//    Console.WriteLine("OBEZ");

//}
//else if ((vki > 30) && (vki < 40))
//{
//    Console.WriteLine("AZ OBEZ");
//}
//else if ((vki > 25) && (vki <30))
//{
//    Console.WriteLine(" Normalin biraaz üstü kilo");
//}
//else if ((vki > 17) && (vki < 25))
//{
//    Console.WriteLine("Sağlıklı birey");
//}
//if (vki < 17) 
//{
//    Console.WriteLine("ZARGANA");
//}

//Random random = new Random();
//int sayi = random.Next(0, 100);
//int tahmin;
//bool doğru = true;
//int hak = 10;

//Console.WriteLine( "SAYI TAHMİN ET");
//tahmin=Convert.ToInt32(Console.ReadLine());

//while (hak > 0)
//{
//    if (tahmin == sayi)
//    {
//        Console.WriteLine("Kalan hak: " + hak + "          " + hak + ".hakta Doğru tahmin ettiniz");
//        break;
//    }
//    else  
//    {
//        hak--;
//        Console.WriteLine("SAYI TAHMİN ET");
//        tahmin = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Kalan hak: " + hak + "          " +" Yanlış tahmin");
//    }
//}
//int yukseklik = 10;
//for (int i = yukseklik -2 ; i >=1 ; i--)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}

//using System;

//class Program
//{
//    static void Main(string[] args)
////    {
//Console.WriteLine("İkinci Dereceden Denklem Çözücü (ax² + bx + c = 0)");
//Console.WriteLine("------------------------------------------------");

//try
//{
//    // Katsayıları kullanıcıdan al
//    Console.Write("a değerini giriniz: ");
//    double a = Convert.ToDouble(Console.ReadLine());

//    Console.Write("b değerini giriniz: ");
//    double b = Convert.ToDouble(Console.ReadLine());

//    Console.Write("c değerini giriniz: ");
//    double c = Convert.ToDouble(Console.ReadLine());

//    // a = 0 kontrolü
//    if (a == 0)
//    {
//        Console.WriteLine("a = 0 olduğu için bu ikinci dereceden bir denklem değildir.");
//        return;
//    }

//    // Diskriminantı hesapla
//    double delta = b * b - 4 * a * c;

//    // Kökleri hesapla ve yazdır
//    if (delta > 0)
//    {
//        double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
//        double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
//        Console.WriteLine("\nDenklemin iki gerçek kökü vardır:");
//        Console.WriteLine($"x₁ = {x1:F2}");
//        Console.WriteLine($"x₂ = {x2:F2}");
//    }
//    else if (delta == 0)
//    {
//        double x = -b / (2 * a);
//        Console.WriteLine("\nDenklemin çakışık iki kökü vardır:");
//        Console.WriteLine($"x₁ = x₂ = {x:F2}");
//    }
//    else
//    {
//        double realPart = -b / (2 * a);
//        double imaginaryPart = Math.Sqrt(-delta) / (2 * a);
//        Console.WriteLine("\nDenklemin iki karmaşık kökü vardır:");
//        Console.WriteLine($"x₁ = {realPart:F2} + {imaginaryPart:F2}i");
//        Console.WriteLine($"x₂ = {realPart:F2} - {imaginaryPart:F2}i");
//    }
//}
//catch (FormatException)
//{
//    Console.WriteLine("Hata: Lütfen geçerli sayısal değerler giriniz.");
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Beklenmeyen bir hata oluştu: {ex.Message}");
//}

//Console.WriteLine("\nProgramı kapatmak için bir tuşa basınız...");
//Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        while (true)
//        {
//            Ana menü
//            Console.WriteLine("\n=== Denklem Çözücü ===");
//            Console.WriteLine("1. Birinci Derece Denklem (ax + b = 0)");
//            Console.WriteLine("2. İkinci Derece Denklem (ax² + bx + c = 0)");
//            Console.WriteLine("3. Üçüncü Derece Denklem (x³ + ax² + bx + c = 0)");
//            Console.WriteLine("4. Çıkış");
//            Console.Write("Seçiminiz (1-4): ");

//            Kullanıcı seçimi
//            int secim = Convert.ToInt32(Console.ReadLine());

//            Çıkış kontrolü
//            if (secim == 4)
//            {
//                Console.WriteLine("Program sonlandırılıyor...");
//                break;
//            }

//            Seçime göre işlem yap
//            switch (secim)
//            {
//                case 1:
//                    BirinciDereceDenklem();
//                    break;
//                case 2:
//                    IkinciDereceDenklem();
//                    break;
//                case 3:
//                    UcuncuDereceDenklem();
//                    break;
//                default:
//                    Console.WriteLine("Geçersiz seçim!");
//                    break;
//            }

//            Console.WriteLine("\nDevam etmek için bir tuşa basın...");
//            Console.ReadKey();
//            Console.Clear();
//        }
//    }

//    static void BirinciDereceDenklem()
//    {
//        Console.WriteLine("\n=== Birinci Derece Denklem Çözücü ===");
//        Console.WriteLine("ax + b = 0 biçimindeki denklem için:");

//        Katsayıları al
//        Console.Write("a değerini girin: ");
//        double a = Convert.ToDouble(Console.ReadLine());
//        Console.Write("b değerini girin: ");
//        double b = Convert.ToDouble(Console.ReadLine());

//        Çözüm kontrolü
//        if (a == 0)
//        {
//            if (b == 0)
//                Console.WriteLine("Denklemin sonsuz çözümü var.");
//            else
//                Console.WriteLine("Denklemin çözümü yok.");
//        }
//        else
//        {
//            double x = -b / a;
//            Console.WriteLine($"Denklemin kökü: x = {x:F2}");
//        }
//    }

//    static void IkinciDereceDenklem()
//    {
//        Console.WriteLine("\n=== İkinci Derece Denklem Çözücü ===");
//        Console.WriteLine("ax² + bx + c = 0 biçimindeki denklem için:");

//        Katsayıları al
//        Console.Write("a değerini girin: ");
//        double a = Convert.ToDouble(Console.ReadLine());
//        Console.Write("b değerini girin: ");
//        double b = Convert.ToDouble(Console.ReadLine());
//        Console.Write("c değerini girin: ");
//        double c = Convert.ToDouble(Console.ReadLine());

//        if (a == 0)
//        {
//            Console.WriteLine("a = 0 olamaz. Bu bir ikinci derece denklem değil!");
//            return;
//        }

//        Diskriminant hesapla
//        double delta = b * b - 4 * a * c;

//        Kökleri hesapla
//        if (delta > 0)
//        {
//            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
//            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
//            Console.WriteLine($"Denklemin iki farklı kökü var:");
//            Console.WriteLine($"x₁ = {x1:F2}");
//            Console.WriteLine($"x₂ = {x2:F2}");
//        }
//        else if (delta == 0)
//        {
//            double x = -b / (2 * a);
//            Console.WriteLine($"Denklemin tek kökü var:");
//            Console.WriteLine($"x = {x:F2}");
//        }
//        else
//        {
//            Console.WriteLine("Denklemin reel kökü yok!");
//        }
//    }

//    static void UcuncuDereceDenklem()
//    {
//        Console.WriteLine("\n=== Üçüncü Derece Denklem Çözücü ===");
//        Console.WriteLine("x³ + ax² + bx + c = 0 biçimindeki denklem için:");

//        Katsayıları al
//        Console.Write("a değerini girin: ");
//        double a = Convert.ToDouble(Console.ReadLine());
//        Console.Write("b değerini girin: ");
//        double b = Convert.ToDouble(Console.ReadLine());
//        Console.Write("c değerini girin: ");
//        double c = Convert.ToDouble(Console.ReadLine());

//        Basit kök bulma yöntemi: -10 ile 10 arasındaki tam sayıları dene
//        bool kokBulundu = false;
//        Console.WriteLine("\nReel kökler aranıyor...");

//        for (double x = -10; x <= 10; x += 0.5)
//        {
//            Denklemi hesapla: x³ +ax² +bx + c
//            double sonuc = x * x * x + a * x * x + b * x + c;

//            Eğer sonuç 0'a çok yakınsa, bu bir köktür
//            if (Math.Abs(sonuc) < 0.01)
//            {
//                Console.WriteLine($"Yaklaşık bir kök bulundu: x = {x:F2}");
//                kokBulundu = true;
//            }
//        }

//        if (!kokBulundu)
//        {
//            Console.WriteLine("Bu aralıkta reel kök bulunamadı.");
//            Console.WriteLine("Not: Bu basit yöntem tüm kökleri bulmayabilir.");
//        }
//    }
////using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        while (true)
//        {
//            // Ana menü
//            Console.WriteLine("\n=== Çokgen Hesaplayıcı ===");
//            Console.WriteLine("1. Üçgen");
//            Console.WriteLine("2. Dörtgen");
//            Console.WriteLine("3. Beşgen");
//            Console.WriteLine("4. Altıgen");
//            Console.WriteLine("5. Yedigen");
//            Console.WriteLine("6. Sekizgen");
//            Console.WriteLine("7. Çıkış");
//            Console.Write("\nBir çokgen seçin (1-7): ");

//            int secim = Convert.ToInt32(Console.ReadLine());

//            if (secim == 7)
//            {
//                Console.WriteLine("Program sonlandırılıyor...");
//                break;
//            }

//            switch (secim)
//            {
//                case 1:
//                    CokgenHesapla("Üçgen", 3);
//                    break;
//                case 2:
//                    CokgenHesapla("Dörtgen", 4);
//                    break;
//                case 3:
//                    CokgenHesapla("Beşgen", 5);
//                    break;
//                case 4:
//                    CokgenHesapla("Altıgen", 6);
//                    break;
//                case 5:
//                    CokgenHesapla("Yedigen", 7);
//                    break;
//                case 6:
//                    CokgenHesapla("Sekizgen", 8);
//                    break;
//                default:
//                    Console.WriteLine("Geçersiz seçim!");
//                    break;
//            }

//            Console.WriteLine("\nDevam etmek için bir tuşa basın...");
//            Console.ReadKey();
//            Console.Clear();
//        }
//    }

//    static void CokgenHesapla(string cokgenAdi, int kenarSayisi)
//    {
//        Console.WriteLine($"\n=== {cokgenAdi} Hesaplayıcı ===");

//        // Kenar uzunluklarını al
//        double[] kenarlar = new double[kenarSayisi];
//        for (int i = 0; i < kenarSayisi; i++)
//        {
//            Console.Write($"{i + 1}. kenar uzunluğunu girin: ");
//            kenarlar[i] = Convert.ToDouble(Console.ReadLine());
//        }

//        // Çevre hesapla
//        double cevre = 0;
//        foreach (double kenar in kenarlar)
//        {
//            cevre += kenar;
//        }

//        // İç ve dış açıları hesapla
//        double tekIcAci = ((kenarSayisi - 2) * 180.0) / kenarSayisi;
//        double tekDisAci = 360.0 / kenarSayisi;
//        double toplamIcAci = (kenarSayisi - 2) * 180;

//        // Sonuçları yazdır
//        Console.WriteLine($"\nSonuçlar:");
//        Console.WriteLine($"Çevre: {cevre:F2} birim");
//        Console.WriteLine($"Bir iç açı: {tekIcAci:F2} derece");
//        Console.WriteLine($"Bir dış açı: {tekDisAci:F2} derece");
//        Console.WriteLine($"İç açılar toplamı: {toplamIcAci:F2} derece");

//        // Kenar bilgilerini yazdır
//        Console.WriteLine("\nKenar uzunlukları:");
//        for (int i = 0; i < kenarSayisi; i++)
//        {
//            Console.WriteLine($"{i + 1}. kenar: {kenarlar[i]:F2} birim");
//        }

//        // Düzgün çokgen kontrolü
//        bool duzgun = true;
//        for (int i = 1; i < kenarSayisi; i++)
//        {
//            if (kenarlar[i] != kenarlar[0])
//            {
//                duzgun = false;
//                break;
//            }
//        }

//        if (duzgun)
//        {
//            Console.WriteLine("\nBu bir düzgün çokgendir (tüm kenarları eşit).");
//        }
//        else
//        {
//            Console.WriteLine("\nBu bir düzgün çokgen değildir (kenarları eşit değil).");
//        }
//    }
//}//}
//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//while (true)
//{
//    Console.WriteLine("\n=== Yıldızlarla Şekil Çizme Programı ===");
//    Console.WriteLine("1. Üçgen");
//    Console.WriteLine("2. Ters Üçgen");
//    Console.WriteLine("3. Kare");
//    Console.WriteLine("4. Elmas");
//    Console.WriteLine("5. Baklava Dilimi");
//    Console.WriteLine("6. Çıkış");
//    Console.Write("Seçiminiz (1-6): ");

//    int secim = Convert.ToInt32(Console.ReadLine());

//    if (secim == 6)
//    {
//        Console.WriteLine("Program sonlandırılıyor...");
//        break;
//    }

//    Console.Write("Şeklin boyutunu girin (3-20 arası): ");
//    int boyut = Convert.ToInt32(Console.ReadLine());

//    switch (secim)
//    {
//        case 1:
//            Ucgen(boyut);
//            break;
//        case 2:
//            TersUcgen(boyut);
//            break;
//        case 3:
//            Kare(boyut);
//            break;
//        case 4:
//            Elmas(boyut);
//            break;
//        case 5:
//            BaklavaDilimi(boyut);
//            break;
//        default:
//            Console.WriteLine("Geçersiz seçim!");
//            break;
//    }

//    Console.WriteLine("\nDevam etmek için bir tuşa basın...");
//    Console.ReadKey();
//    Console.Clear();
//}


//    static void Ucgen(int boyut)
//{
//    Console.WriteLine("\nÜçgen:\n");
//    for (int i = 1; i <= boyut; i++)
//    {
//        // Boşlukları yazdır
//        for (int j = 1; j <= boyut - i; j++)
//        {
//            Console.Write(" ");
//        }
//        // Yıldızları yazdır
//        for (int k = 1; k <= 2 * i - 1; k++)
//        {
//            Console.Write("*");
//        }
//        Console.WriteLine();
//    }
//}

//static void TersUcgen(int boyut)
//{
//    Console.WriteLine("\nTers Üçgen:\n");
//    for (int i = boyut; i >= 1; i--)
//    {
//        // Boşlukları yazdır
//        for (int j = 1; j <= boyut - i; j++)
//        {
//            Console.Write(" ");
//        }
//        // Yıldızları yazdır
//        for (int k = 1; k <= 2 * i - 1; k++)
//        {
//            Console.Write("*");
//        }
//        Console.WriteLine();
//    }
//}

//static void Kare(int boyut)
//{
//    Console.WriteLine("\nKare:\n");
//    for (int i = 1; i <= boyut; i++)
//    {
//        for (int j = 1; j <= boyut; j++)
//        {
//            // Kenarları çiz, içi boş kare için
//            if (i == 1 || i == boyut || j == 1 || j == boyut)
//                Console.Write("* ");
//            else
//                Console.Write("  ");
//        }
//        Console.WriteLine();
//    }
//}

//static void Elmas(int boyut)
//{
//    Console.WriteLine("\nElmas:\n");
//    // Üst yarı
//    for (int i = 1; i <= boyut; i++)
//    {
//        for (int j = 1; j <= boyut - i; j++)
//        {
//            Console.Write(" ");
//        }
//        for (int k = 1; k <= 2 * i - 1; k++)
//        {
//            Console.Write("*");
//        }
//        Console.WriteLine();
//    }
//    // Alt yarı
//    for (int i = boyut - 1; i >= 1; i--)
//    {
//        for (int j = 1; j <= boyut - i; j++)
//        {
//            Console.Write(" ");
//        }
//        for (int k = 1; k <= 2 * i - 1; k++)
//        {
//            Console.Write("*");
//        }
//        Console.WriteLine();
//    }
//}

//static void BaklavaDilimi(int boyut)
//{
//    Console.WriteLine("\nBaklava Dilimi:\n");
//    // Üst yarı
//    for (int i = 1; i <= boyut; i++)
//    {
//        // Dış boşluklar
//        for (int j = 1; j <= boyut - i; j++)
//        {
//            Console.Write(" ");
//        }
//        // Kenar yıldızları
//        Console.Write("*");
//        // İç kısım
//        if (i > 1)
//        {
//            for (int k = 1; k <= 2 * i - 3; k++)
//            {
//                Console.Write(" ");
//            }
//            Console.Write("*");
//        }
//        Console.WriteLine();
//    }
//    // Alt yarı
//    for (int i = boyut - 1; i >= 1; i--)
//    {
//        // Dış boşluklar
//        for (int j = 1; j <= boyut - i; j++)
//        {
//            Console.Write(" ");
//        }
//        // Kenar yıldızları
//        Console.Write("*");
//        // İç kısım
//        if (i > 1)
//        {
//            for (int k = 1; k <= 2 * i - 3; k++)
//            {
//                Console.Write(" ");
//            }
//            Console.Write("*");
//        }
//        Console.WriteLine();
//    }
//}


//KARE şeKLİ
//for (int i = 1; i <= 5; i++)
//{
//    Console.Write("* ");
//}

//for (int j = 1; j < 5; j++)
//{
//    Console.WriteLine("*         *");
//}
//for (int k = 1; k < 7; k++)
//{
//    Console.Write("* ");
//}

//Console.WriteLine("\nTers Üçgen:\n");
//for (int i = 5; i >= 1; i--)
//{
//    // Boşlukları yazdır
//    for (int j = 1; j <= 5 - i; j++)
//    {
//        Console.Write(" ");
//    }
//    // Yıldızları yazdır
//    for (int k = 1; k <= 2 * i - 1; k++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}
//  for (int i = 5; i >= 1; i--)
//{
//    // Boşlukları yazdır
//    for (int j = 1; j <= 5 - i; j++)
//    {
//        Console.Write(" ");
//    }
//    // Yıldızları yazdır
//    for (int k = 1; k <= 2 * i - 1; k++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}


//Console.WriteLine("\nElmas:\n");
//// Üst yarı
//for (int i = 1; i <= 5; i++)
//{
//    for (int j = 1; j <= 5 - i; j++)
//    {
//        Console.Write(" ");
//    }
//    for (int k = 1; k <= 2 * i - 1; k++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}
// Alt yarı
//for (int i = 5 - 1; i >= 1; i--)
//{
//    for (int j = 1; j <= 5 - i; j++)
//    {
//        Console.Write(" ");
//    }
//    for (int k = 1; k <= 2 * i - 1; k++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}


//// Değişken Tanımlaması:
//int degisken = 15;
//// Atama Operatör Kullanımı:
//Console.WriteLine(new string('-', 20) + "\n-> C# Atama Operatör Örnekleri");
//Console.WriteLine("-> [{0}] degisken += 5 Sonucu: {1}", degisken, (degisken += 5));
//Console.WriteLine("-> [{0}] degisken -= 12 Sonucu: {1}", degisken, (degisken -= 12));
//Console.WriteLine("-> [{0}] degisken *= 2 Sonucu: {1}", degisken, (degisken *= 2));
//Console.WriteLine("bir sayı gir");
//a = int.Parse(Conne("-> [{0}] degisken /= 4 Sonucu: {1}", degisken, (degisken /= 4));
//Console.WriteLine(new string('-', 20));
//int a, b = 1, c;
//Console.WriteLisole.ReadLine());
////MOD ALMAA//
//for (int i = a; i != 0; i--)                                         //MOD ALMAA//

//{
//    b = b * i;
//    Console.WriteLine(b);
//}
//using System.Globalization;
//using System.Xml;

//string islem;
//double sonuc;
//bool quit =true;
//while (quit)
//{

//    Console.WriteLine("işlem seç");

//    islem = (Console.ReadLine());

//    switch (islem)

//    {
//        case "*":
//            {
//                Console.WriteLine("sayı 1");
//                int a = Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine("sayı 2");
//                int b = Convert.ToInt32(Console.ReadLine());


//                sonuc = a * b;
//                Console.WriteLine(a + " x " + b + "=" + sonuc);

//            }
//            break;
//        case "-":
//            {
//                Console.WriteLine("sayı 1");
//                int a = Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine("sayı 2");
//                int b = Convert.ToInt32(Console.ReadLine());


//                sonuc = a - b;
//                Console.WriteLine(a + " - " + b + "=" + sonuc);

//            }
//            break;
//        case "+":
//            {
//                Console.WriteLine("sayı 1");
//                int a = Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine("sayı 2");
//                int b = Convert.ToInt32(Console.ReadLine());


//                sonuc = a + b;
//                Console.WriteLine(a + " + " + b + "=" + sonuc);

//            }
//            break;
//        case "/":
//            {
//                Console.WriteLine("sayı 1");
//                int a = Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine("sayı 2");
//                int b = Convert.ToInt32(Console.ReadLine());


//                sonuc = a / b;
//                Console.WriteLine(a + " / " + b + "=" + sonuc);

//            }
//            break;

//        case "0":
//            {

//                Console.WriteLine("işlem sonlanmıştır");
//                quit = false;
//            }
//            break;


//    }
//}
//}
//Console.WriteLine("sayi al");
//int sayi;sayi =Convert.ToInt32(Console.ReadLine());
//int fak = 1;
//for (int  i= sayi; i > 0 ; i--)
//{
//    fak *=  i;

//}
//Console.WriteLine(fak);

//Ebob
//    using System;

//int a, b, c=0, d=0,ebob=0, ekok=0;
//a =Convert.ToInt32(Console.ReadLine());
//b = Convert.ToInt32(Console.ReadLine());
//c = a;
//d = b;
//int min = Math.Min(a, b);
//for (int i = 1; i <= min; i++)
//{
//    if (a % i == 0 && b % i == 0)
//    {
//        ebob = i; // Ortak bölen bulunduğunda güncelle
//         ekok = ((d * c) / ebob);
//    }

//}
//Console.WriteLine(ebob+"  "+ ekok);

//Basamak değeri bulma 
//mod kullanarak

// using System;

// class Program
// {
//     static void Main()
//     {
//         // Kullanıcıdan sayı al
//         Console.Write("Bir sayı giriniz: ");
//         int sayi = Convert.ToInt32(Console.ReadLine());

//         // Sayının mutlak değerini al (negatif sayıları pozitife çevir)
//         int pozitifSayi = Math.Abs(sayi);

//         // Sayıyı basamaklarına ayır ve yazdır
//         Console.WriteLine("\nBasamaklar:");

//         int basamakSayisi = 0;
//         int geciciSayi = pozitifSayi;

//         // Sayı 0 olana kadar devam et
//         while (geciciSayi > 0)
//         {
//             // Son basamağı al (sayının 10'a bölümünden kalan)
//             int basamak = geciciSayi % 10;

//             // Basamağı yazdır
//             Console.WriteLine($"Basamak {basamakSayisi + 1}: {basamak}");

//             // Sayıyı 10'a böl (son basamağı at)
//             geciciSayi = geciciSayi / 10;

//             // Basamak sayısını artır
//             basamakSayisi++;
//         }

//         // Toplam basamak sayısını yazdır
//         Console.WriteLine($"\nBu sayı {basamakSayisi} basamaklıdır.");
//     }
// }

//Console.WriteLine("Kaç elemanlı Fibonacci serisi istiyorsunuz?");
//int n = int.Parse(Console.ReadLine());
//int a = 0, b = 1, c;

//Console.WriteLine("Fibonacci Serisi:");
//Console.WriteLine(a);
//Console.WriteLine(b);

//for (int i = 2; i < n; i++)
//{
//    c = a + b;
//    Console.WriteLine(c);
//    a = b;
//    b = c;
//}
//double radyan, grand;
//double pi = 3.14 ;  
//Console.WriteLine("Dereceyi giriniz:");
//int derece;derece= Convert.ToInt32(Console.ReadLine());
//radyan = (derece * pi) /  180;
//grand = (radyan * 200) / pi;
//Console.WriteLine("Radyan: " + radyan);
//Console.WriteLine("grad: " + grand);


//. .ÖRNEK 1

//int k = Convert.ToInt32(Console.ReadLine());
//int say=0, max=0, bölen = 0;

//while (k != 1)
//{
//    say++;
//    if (k % 2 == 0)
//    {
//        k = k / 2;
//        bölen = k;
//    }
//    else
//    {
//        k = 3 * k + 1;
//        bölen= 0;    
//    }

//}
//if (max < k)
//{
//    max = k;
//} 

//            Console.WriteLine("Maks: " + max);
//Console.WriteLine("İslem: " + say);
//Console.WriteLine("Soncift: " + bölen);
//Console.ReadLine();
//// Üst yarı
//for (int i = 1; i <= 5; i++)
//{
//    for (int j = 1; j <= 5 - i; j++)
//    {
//        Console.Write(" ");
//    }
//    for (int k = 1; k <= 2 * i - 1; k++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}


for (int i = 5 ; i >= 1; i--)
{
    for (int j = 1; j <= 5 - i; j++)
    {
        Console.Write(" ");
    }
    for (int k = 1; k <= 2 * i - 1; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
        }