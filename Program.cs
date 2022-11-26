namespace ATMApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sifre = 12345, sifreKontrol = 0, sifreHak, islemTuru, cikis = 6;
            int girilenTutar, krediTutari, vade = 0, vadeliTutar = 0;
            int[] bakiye = new int[7];
            bakiye[0] = 10000;

            Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                "                  Şifrenizi Giriniz (12345): ");

            for (sifreHak = 2; sifreHak >= 0; sifreHak--)
            {
                if (sifreKontrol != 12345)
                {
                    sifreKontrol = int.Parse(Console.ReadLine());
                }

                if (sifreKontrol != sifre)
                {
                    Console.Clear();
                    Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n");
                    Console.Write($"          Girilen şifre ile kayıtlı şifreniz uyuşmuyor..\n\n" +
                        $"                  Kalan deneme hakkınız : {sifreHak} \n" +
                        $"                Şifrenizi tekrar giriniz :  ");
                }

                else
                {
                    cikis = 6;
                    while (cikis == 6)
                    {
                        Console.Clear();
                        Console.Write("           ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                      "                1 - Bakiye sorgulama :\n" +
                                      "                2 - Para çekim işlemleri :\n" +
                                      "                3 - Para yatırma işlemleri :\n" +
                                      "                4 - Vadeli hesap işlemleri :\n" +
                                      "                5 - Döviz hesabı işlemleri :\n" +
                                      "                6 - Altın hesabı işlemleri :\n" +
                                      "                7 - Çıkış                  :\n\n" +
                                      "         -> Yapmak istediğiniz işlem türünü girin : ");

                        islemTuru = int.Parse(Console.ReadLine());

                        if (islemTuru == 1)
                        {
                            Console.Clear();
                            Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n");
                            Console.Write($"           Vadesiz hesap bakiyeniz : {bakiye[0]}\n" +
                                          $"           Vadeli hesap bakiyeniz  : {bakiye[1]}\n" +
                                          $"           Dolar hesabı bakiyeniz  : {bakiye[2]}\n" +
                                          $"           Euro hesabı bakiyeniz   : {bakiye[3]}\n" +
                                          $"           Altın hesabı bakiyeniz  : {bakiye[4]}\n" +
                                          $"           Borç durumunuz          : {bakiye[6]}\n\n" +
                                          $"           Menüye geri dönmek için 0 giriniz : \n\n" +
                                          $"        -> Yapmak istediğiniz işlem türünü girin : ");

                            islemTuru = int.Parse(Console.ReadLine());

                            Console.WriteLine("\n           Menüye geri dönülüyor, lütfen bekleyiniz ...");
                            Thread.Sleep(1000);
                        }

                        else if (islemTuru == 2)
                        {
                            while (cikis == 6)
                            {
                                Console.Clear();
                                Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                             $"           Güncel vadesiz hesap bakiyeniz : {bakiye[0]}\n\n" +
                                             $"           Menüye dönmek için 0 giriniz   :\n" +
                                             $"           Çekmek istediğiniz tutarı giriniz : ");

                                girilenTutar = int.Parse(Console.ReadLine());

                                if (girilenTutar > 0 && (girilenTutar <= bakiye[0]))
                                {
                                    Console.Clear();
                                    bakiye[0] -= girilenTutar;
                                    Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                                 $"              Güncel vadesiz hesap bakiyeniz : {bakiye[0]}\n\n" +
                                                 $"              Menüye geri dönülüyor, lütfen bekleyiniz ...\n");
                                    cikis = 5;
                                    sifreHak++;
                                    sifreKontrol = 12345;
                                    Thread.Sleep(3000);
                                }

                                else if (girilenTutar == 0)
                                {
                                    cikis = 5;
                                }

                                else if (girilenTutar > bakiye[0])
                                {
                                    Console.Clear();
                                    Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                                 $" Girilen tutar hesap bakiyenizden fazla, lütfen birazdan tekrar giriniz..");
                                    Thread.Sleep(3000);
                                }

                                else
                                {
                                    Console.Clear();
                                    Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                                 $"       Girilen tutar hatalı, lütfen birazdan tekrar giriniz..");
                                    Thread.Sleep(3000);
                                }
                            }
                        }

                        else if (islemTuru == 3)
                        {
                            while (cikis == 6)
                            {
                                Console.Clear();
                                Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                             $"           Güncel vadesiz hesap bakiyeniz : {bakiye[0]}\n\n" +
                                             $"           Menüye dönmek için 0 giriniz   :\n" +
                                             $"           Yatırmak istediğiniz tutarı giriniz : ");

                                girilenTutar = int.Parse(Console.ReadLine());

                                if (girilenTutar > 0)
                                {
                                    Console.Clear();
                                    bakiye[0] += girilenTutar;
                                    Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                                 $"              Güncel vadesiz hesap bakiyeniz : {bakiye[0]}\n\n" +
                                                 $"              Menüye geri dönülüyor, lütfen bekleyiniz ...\n");
                                    cikis = 5;
                                    sifreHak++;
                                    sifreKontrol = 12345;
                                    Thread.Sleep(3000);
                                }

                                else if (girilenTutar == 0)
                                {
                                    cikis = 5;
                                }

                                else
                                {
                                    Console.Clear();
                                    Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                                 $"      0'dan küçük tutar giremezsiniz, lütfen tekrar giriniz..");
                                    Thread.Sleep(3000);
                                }
                            }
                        }

                        else if (islemTuru == 4)
                        {
                            Console.Clear();
                            Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                         $"                Vadeli hesap bakiyeniz  = {bakiye[1]}\n" +
                                         $"                Vadesiz hesap bakiyeniz = {bakiye[0]}\n\n" +
                                         $"                Kredi çekmek için 1 giriniz  :\n" +
                                         $"                Vadeli hesaba para yatırmak için 2 giriniz :\n\n" +
                                         $"                Menüye dönmek için 0 giriniz : \n\n" +
                                         $"           -> Yapmak istediğiniz işlem türünü girin : ");

                            islemTuru = int.Parse(Console.ReadLine());

                            if (islemTuru == 0)
                            {
                                cikis = 5;
                                sifreHak++;
                                sifreKontrol = 12345;
                                Thread.Sleep(3000);
                            }

                            else if (islemTuru == 1)
                            {
                                while (cikis == 6)
                                {
                                    Console.Clear();
                                    Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                                 $"                Vadesiz hesap bakiyeniz = {bakiye[0]}\n\n" +
                                                 $"                1.000TL'den küçük miktarda çekim yapamazsınız..\n" +
                                                 $"                10.000TL'den küçük tutarlarda 12 Ay vadeye kadar %1.63 faiz\n" +
                                                 $"                10.000TL'den küçük tutarlarda 12 Ay üzeri vadeye %1.99 faiz\n" +
                                                 $"                10.000TL'den büyük tutarlarda 12 Ay vadeye kadar %2.75 faiz\n" +
                                                 $"                10.000TL'den büyük tutarlarda 12 Ay üzeri vadeye %2.99 faiz\n\n" +
                                                 $"                Vade seçenekleri : 12 Ay altı ve 12 Ay üzeri\n\n" +
                                                 $"                Kullanmak istediğiniz kredi tutarını TL cinsinden giriniz : ");

                                    krediTutari = int.Parse(Console.ReadLine());

                                    Console.Write("\n                İstediğiniz Vade süresini giriniz : ");

                                    vade = int.Parse(Console.ReadLine());

                                    if (vade < 3 || krediTutari < 1000)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Hatalı şart girdiniz, vade ve tutar şartlarını kontrol ederek tekrar giriniz..\n");
                                        Thread.Sleep(3000);
                                    }

                                    else if (vade < 12 && krediTutari < 10000)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("10.000TL'den küçük tutarlarda 12 Ay vadeye kadar %1.63 faiz işlemi seçildi...\n");
                                        bakiye[0] += krediTutari;
                                        bakiye[6] = (int)(((krediTutari / 100) * 1.65) * vade + krediTutari);
                                        Console.WriteLine($"Borç Durumunuz   : {bakiye[6]}\n" +
                                                          $"Güncel Bakiyeniz : {bakiye[0]}\n");
                                        Console.WriteLine("İşlem tamamlandı, menüye geri dönülüyor..\n");
                                        sifreKontrol = 12345;
                                        cikis = 5;
                                        sifreHak++;
                                        Thread.Sleep(3000);
                                    }

                                    else if (vade < 12 && krediTutari > 10000)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("10.000TL'den büyük tutarlarda 12 Ay vadeye kadar %2.75 faiz işlemi seçildi...\n");
                                        bakiye[0] += krediTutari;
                                        bakiye[6] = (int)(((krediTutari / 100) * 2.75) * vade + krediTutari);
                                        Console.WriteLine($"Borç Durumunuz   : {bakiye[6]}\n" +
                                                          $"Güncel Bakiyeniz : {bakiye[0]}\n");
                                        Console.WriteLine("İşlem tamamlandı, menüye geri dönülüyor..\n");
                                        sifreKontrol = 12345;
                                        cikis = 5;
                                        sifreHak++;
                                        Thread.Sleep(3000);
                                    }

                                    else if (vade > 12 && krediTutari < 10000)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("10.000TL'den küçük tutarlarda 12 Ay üzeri vadeye kadar %1.99 faiz işlemi seçildi...\n");
                                        bakiye[0] += krediTutari;
                                        bakiye[6] = (int)(((krediTutari / 100) * 1.99) * vade + krediTutari);
                                        Console.WriteLine($"Borç Durumunuz   : {bakiye[6]}\n" +
                                                          $"Güncel Bakiyeniz : {bakiye[0]}\n");
                                        Console.WriteLine("İşlem tamamlandı, menüye geri dönülüyor..\n");
                                        sifreKontrol = 12345;
                                        cikis = 5;
                                        sifreHak++;
                                        Thread.Sleep(3000);
                                    }

                                    else if (vade > 12 && krediTutari > 10000)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("10.000TL'den küçük tutarlarda 12 Ay vadeye kadar %2.99 faiz işlemi seçildi...\n");
                                        bakiye[0] += krediTutari;
                                        bakiye[6] = (int)(((krediTutari / 100) * 2.99) * vade + krediTutari);
                                        Console.WriteLine($"Borç Durumunuz   : {bakiye[6]}\n" +
                                                          $"Güncel Bakiyeniz : {bakiye[0]}\n");
                                        Console.WriteLine("İşlem tamamlandı, menüye geri dönülüyor..\n");
                                        sifreKontrol = 12345;
                                        cikis = 5;
                                        sifreHak++;
                                        Thread.Sleep(3000);
                                    }
                                }
                            }

                            else if (islemTuru == 2)
                            {
                                while (cikis == 6)
                                {
                                    Console.Clear();
                                    Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                                 $"                Vadesiz hesap bakiyeniz = {bakiye[0]}\n" +
                                                 $"                Vadeli hesap bakiyeniz  = {bakiye[1]}\n\n" +
                                                 $"                Vade Seçenekleri :\n" +
                                                 $"                3  Ay  Vade Yıllık %10 Faiz :\n" +
                                                 $"                6  Ay  Vade Yıllık %11.5 Faiz :\n" +
                                                 $"                9  Ay  Vade Yıllık %12.25 Faiz :\n" +
                                                 $"                12 Ay  Vade Yıllık %13.10 Faiz:\n\n" +
                                                 $"                Vadeli Hesabınıza aktarmak istediğiniz miktarı TL cinsinden giriniz : ");

                                    vadeliTutar = int.Parse(Console.ReadLine());

                                    Console.Write("\n              İstediğiniz Vade süresini girin : ");

                                    vade = int.Parse(Console.ReadLine());

                                    if (vade == 3)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("3 Ay Vade Yıllık %10 Faiz işlemi seçildi...\n");
                                        bakiye[0] -= vadeliTutar;

                                        for (int i = 0; i < vade; i++)
                                        {
                                            bakiye[1] += (int)(vadeliTutar * 0.83);
                                        }

                                        Console.WriteLine($"{vade} Ay sonunda hesabınızdan çekilebilir tutar : {bakiye[1]}\n");
                                        Console.WriteLine("İşlem tamamlandı, menüye geri dönülüyor..\n");
                                        sifreKontrol = 12345;
                                        cikis = 5;
                                        sifreHak++;
                                        Thread.Sleep(3000);
                                    }

                                    else if (vade == 6)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("6 Ay Vade Yıllık %11.50 Faiz işlemi seçildi...\n");
                                        bakiye[0] -= vadeliTutar;

                                        for (int i = 0; i < vade; i++)
                                        {
                                            bakiye[1] += (int)(vadeliTutar * 0.95);
                                        }

                                        Console.WriteLine($"{vade} Ay sonunda hesabınızdan çekilebilir tutar : {bakiye[1]}\n");
                                        Console.WriteLine("İşlem tamamlandı, menüye geri dönülüyor..\n");
                                        sifreKontrol = 12345;
                                        cikis = 5;
                                        sifreHak++;
                                        Thread.Sleep(3000);
                                    }

                                    else if (vade == 3)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("9 Ay Vade Yıllık %12.25 Faiz işlemi seçildi...\n");
                                        bakiye[0] -= vadeliTutar;

                                        for (int i = 0; i < vade; i++)
                                        {
                                            bakiye[1] += (int)(vadeliTutar * 1.02);
                                        }

                                        Console.WriteLine($"{vade} Ay sonunda hesabınızdan çekilebilir tutar : {bakiye[1]}\n");
                                        Console.WriteLine("İşlem tamamlandı, menüye geri dönülüyor..\n");
                                        sifreKontrol = 12345;
                                        cikis = 5;
                                        sifreHak++;
                                        Thread.Sleep(3000);
                                    }

                                    else if (vade == 3)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("12 Ay Vade Yıllık %13.10 Faiz işlemi seçildi...\n");
                                        bakiye[0] -= vadeliTutar;

                                        for (int i = 0; i < vade; i++)
                                        {
                                            bakiye[1] += (int)(vadeliTutar * 1.09);
                                        }

                                        Console.WriteLine($"{vade} Ay sonunda hesabınızdan çekilebilir tutar : {bakiye[1]}\n");
                                        Console.WriteLine("İşlem tamamlandı, menüye geri dönülüyor..\n");
                                        sifreKontrol = 12345;
                                        cikis = 5;
                                        sifreHak++;
                                        Thread.Sleep(3000);
                                    }
                                }
                            }
                        }

                        else if (islemTuru == 5)
                        {
                            Console.Clear();
                            Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                         $"             Dolar hesap bakiyeniz = {bakiye[2]}\n" +
                                         $"             Euro hesap bakiyeniz  = {bakiye[3]}\n\n" +
                                         $"             Dolar işlemleri için 1 giriniz :\n" +
                                         $"             Euro işlemleri için 2 giriniz  :\n\n" +
                                         $"             Menüye dönmek için 0 giriniz   : \n\n" +
                                         $"        -> Yapmak istediğiniz işlem türünü girin : ");

                            islemTuru = int.Parse(Console.ReadLine());

                            if (islemTuru == 0)
                            {
                                cikis = 5;
                                sifreHak++;
                                sifreKontrol = 12345;
                                Thread.Sleep(3000);
                            }

                            else if (islemTuru == 1)
                            {
                                Console.Clear();
                                Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                             $"                Güncel dolar kuru 14,37 tl'dir.\n\n" +
                                             $"                Dolar satın almak için 1 giriniz :\n" +
                                             $"                Dolar bozdurmak için 2 giriniz   :\n\n" +
                                             $"           -> Yapmak istediğiniz işlem türünü girin : ");

                                islemTuru = int.Parse(Console.ReadLine());

                                if (islemTuru == 1)
                                {
                                    while (cikis == 6)
                                    {
                                        Console.Clear();
                                        Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                                     $"             Hesabınızdaki dolar tutarı  : {bakiye[2]}\n" +
                                                     $"             Vadesiz TL hesabı tutarınız : {bakiye[0]}\n\n" +
                                                     $"             Kaç Türk Lirası ile dolar almak istediğinizi giriniz : ");
                                        girilenTutar = int.Parse(Console.ReadLine());

                                        if ((girilenTutar <= bakiye[0]) && girilenTutar > 0)
                                        {
                                            bakiye[0] -= girilenTutar;
                                            bakiye[2] += (int)(girilenTutar / 14.37);
                                            Console.Clear();
                                            Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                                          "                  İşlem başarıyla tamamlandı...\n\n" +
                                                         $"                  Güncel Vadesiz hesap bakiyeniz : {bakiye[0]}\n" +
                                                         $"                  Güncel Dolar hesabı bakiyeniz  : {bakiye[2]}\n\n" +
                                                          "                  Menüye dönmek için lütfen bekleyiniz...");
                                            cikis = 5;
                                            sifreHak++;
                                            sifreKontrol = 12345;
                                            Thread.Sleep(3000);
                                        }

                                        else if (girilenTutar > bakiye[0])
                                        {
                                            Console.Clear();
                                            Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                                          " Vadesiz hesabından işlem için yeterli miktarda bakiye bulunmuyor\n" +
                                                          " Tekrar girmek için lütfen bekleyiniz...\n");
                                            Thread.Sleep(3000);

                                        }

                                        else if (girilenTutar < 0)
                                        {
                                            Console.Clear();
                                            Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                                          "               0'dan küçük bir değer giremezsiniz...\n" +
                                                          "               Lütfen tekrar girmek için bekleyiniz...\n");
                                            Thread.Sleep(3000);
                                        }
                                    }
                                }

                                else if (islemTuru == 2)
                                {
                                    while (cikis == 6)
                                    {
                                        Console.Clear();
                                        Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                                     $"             Hesabınızdaki dolar tutarı  : {bakiye[2]}\n" +
                                                     $"             Vadesiz TL hesabı tutarınız : {bakiye[0]}\n\n" +
                                                     $"             Kaç Dolar satmak istediğinizi giriniz : ");

                                        girilenTutar = int.Parse(Console.ReadLine());

                                        if ((girilenTutar <= bakiye[2]) && girilenTutar > 0)
                                        {
                                            bakiye[2] -= girilenTutar;
                                            bakiye[0] += (int)(girilenTutar * 14.37);
                                            Console.Clear();
                                            Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                                          "                  İşlem başarıyla tamamlandı...\n\n" +
                                                         $"                  Güncel Vadesiz hesap bakiyeniz : {bakiye[0]}\n" +
                                                         $"                  Güncel Dolar hesabı bakiyeniz  : {bakiye[2]}\n\n" +
                                                          "                  Menüye dönmek için lütfen bekleyiniz...");
                                            cikis = 5;
                                            sifreHak++;
                                            sifreKontrol = 12345;
                                            Thread.Sleep(3000);
                                        }

                                        else if (girilenTutar > bakiye[0])
                                        {
                                            Console.Clear();
                                            Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                                          " Dolar hesabında işlem için yeterli miktarda bakiye bulunmuyor\n" +
                                                          " Tekrar girmek için lütfen bekleyiniz...\n");
                                            Thread.Sleep(3000);

                                        }

                                        else if (girilenTutar < 0)
                                        {
                                            Console.Clear();
                                            Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                                          "               0'dan küçük bir değer giremezsiniz...\n" +
                                                          "               Lütfen tekrar girmek için bekleyiniz...\n");
                                            Thread.Sleep(3000);
                                        }
                                    }
                                }
                            }

                            else if (islemTuru == 2)
                            {
                                Console.Clear();
                                Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                             $"                Güncel Euro kuru 15,03 tl'dir.\n\n" +
                                             $"                Euro satın almak için 1 giriniz :\n" +
                                             $"                Euro bozdurmak için 2 giriniz   :\n\n" +
                                             $"           -> Yapmak istediğiniz işlem türünü girin : ");

                                islemTuru = int.Parse(Console.ReadLine());

                                if (islemTuru == 1)
                                {
                                    while (cikis == 6)
                                    {
                                        Console.Clear();
                                        Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                                     $"             Hesabınızdaki Euro tutarı  : {bakiye[3]}\n" +
                                                     $"             Vadesiz TL hesabı tutarınız : {bakiye[0]}\n\n" +
                                                     $"             Kaç Türk Lirası ile Euro almak istediğinizi giriniz : ");
                                        girilenTutar = int.Parse(Console.ReadLine());

                                        if ((girilenTutar <= bakiye[0]) && girilenTutar > 0)
                                        {
                                            bakiye[0] -= girilenTutar;
                                            bakiye[3] += (int)(girilenTutar / 15.03);
                                            Console.Clear();
                                            Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                                          "                  İşlem başarıyla tamamlandı...\n\n" +
                                                         $"                  Güncel Vadesiz hesap bakiyeniz : {bakiye[0]}\n" +
                                                         $"                  Güncel Euro hesabı bakiyeniz  : {bakiye[3]}\n\n" +
                                                          "                  Menüye dönmek için lütfen bekleyiniz...");
                                            cikis = 5;
                                            sifreHak++;
                                            sifreKontrol = 12345;
                                            Thread.Sleep(3000);
                                        }

                                        else if (girilenTutar > bakiye[0])
                                        {
                                            Console.Clear();
                                            Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                                          " Vadesiz hesabından işlem için yeterli miktarda bakiye bulunmuyor\n" +
                                                          " Tekrar girmek için lütfen bekleyiniz...\n");
                                            Thread.Sleep(3000);

                                        }

                                        else if (girilenTutar < 0)
                                        {
                                            Console.Clear();
                                            Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                                          "               0'dan küçük bir değer giremezsiniz...\n" +
                                                          "               Lütfen tekrar girmek için bekleyiniz...\n");
                                            Thread.Sleep(3000);
                                        }
                                    }
                                }

                                else if (islemTuru == 2)
                                {
                                    while (cikis == 6)
                                    {
                                        Console.Clear();
                                        Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                                     $"             Hesabınızdaki Euro tutarı  : {bakiye[3]}\n" +
                                                     $"             Vadesiz TL hesabı tutarınız : {bakiye[0]}\n\n" +
                                                     $"             Kaç Euro satmak istediğinizi giriniz : ");

                                        girilenTutar = int.Parse(Console.ReadLine());

                                        if ((girilenTutar <= bakiye[3]) && girilenTutar > 0)
                                        {
                                            bakiye[3] -= girilenTutar;
                                            bakiye[0] += (int)(girilenTutar * 14.37);
                                            Console.Clear();
                                            Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                                          "                  İşlem başarıyla tamamlandı...\n\n" +
                                                         $"                  Güncel Vadesiz hesap bakiyeniz : {bakiye[0]}\n" +
                                                         $"                  Güncel Euro hesabı bakiyeniz  : {bakiye[3]}\n\n" +
                                                          "                  Menüye dönmek için lütfen bekleyiniz...");
                                            cikis = 5;
                                            sifreHak++;
                                            sifreKontrol = 12345;
                                            Thread.Sleep(3000);
                                        }

                                        else if (girilenTutar > bakiye[0])
                                        {
                                            Console.Clear();
                                            Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                                          " Euro hesabında işlem için yeterli miktarda bakiye bulunmuyor\n" +
                                                          " Tekrar girmek için lütfen bekleyiniz...\n");
                                            Thread.Sleep(3000);

                                        }

                                        else if (girilenTutar < 0)
                                        {
                                            Console.Clear();
                                            Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                                          "               0'dan küçük bir değer giremezsiniz...\n" +
                                                          "               Lütfen tekrar girmek için bekleyiniz...\n");
                                            Thread.Sleep(3000);
                                        }
                                    }
                                }
                            }
                        }

                        else if (islemTuru == 6)
                        {
                            Console.Clear();
                            Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                         $"             Altın hesap bakiyeniz = {bakiye[4]}\n" +
                                         $"             Altın işlemleri için 1 giriniz :\n" +
                                         $"             Menüye dönmek için 0 giriniz   :\n\n" +
                                         $"        -> Yapmak istediğiniz işlem türünü girin : ");

                            islemTuru = int.Parse(Console.ReadLine());

                            if (islemTuru == 0)
                            {
                                cikis = 5;
                                sifreHak++;
                                sifreKontrol = 12345;
                                Thread.Sleep(3000);
                            }

                            else if (islemTuru == 1)
                            {
                                Console.Clear();
                                Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                             $"                Güncel altın gramı 1000 tl'dir.\n\n" +
                                             $"                Altın satın almak için 1 giriniz :\n" +
                                             $"                Altın bozdurmak için 2 giriniz   :\n\n" +
                                             $"           -> Yapmak istediğiniz işlem türünü girin : ");

                                islemTuru = int.Parse(Console.ReadLine());

                                if (islemTuru == 1)
                                {
                                    while (cikis == 6)
                                    {
                                        Console.Clear();
                                        Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                                     $"             Hesabınızdaki Altın tutarı  : {bakiye[4]}\n" +
                                                     $"             Vadesiz TL hesabı tutarınız : {bakiye[0]}\n\n" +
                                                     $"             Altın almak istediğiniz TL tutarını giriniz (1.000 TL ve katları) : ");

                                        girilenTutar = int.Parse(Console.ReadLine());

                                        if ((girilenTutar <= bakiye[0]) && girilenTutar > 0)
                                        {
                                            bakiye[0] -= girilenTutar;
                                            bakiye[4] += (int)(girilenTutar / 1000);
                                            Console.Clear();
                                            Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                                          "                  İşlem başarıyla tamamlandı...\n\n" +
                                                         $"                  Güncel Vadesiz hesap bakiyeniz : {bakiye[0]}\n" +
                                                         $"                  Güncel Altın hesabı bakiyeniz  : {bakiye[4]}\n\n" +
                                                          "                  Menüye dönmek için lütfen bekleyiniz...");
                                            cikis = 5;
                                            sifreHak++;
                                            sifreKontrol = 12345;
                                            Thread.Sleep(3000);
                                        }

                                        else if (girilenTutar > bakiye[0])
                                        {
                                            Console.Clear();
                                            Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                                          " Vadesiz hesabından işlem için yeterli miktarda bakiye bulunmuyor\n" +
                                                          " Tekrar girmek için lütfen bekleyiniz...\n");
                                            Thread.Sleep(3000);

                                        }

                                        else if (girilenTutar < 0)
                                        {
                                            Console.Clear();
                                            Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                                          "               0'dan küçük bir değer giremezsiniz...\n" +
                                                          "               Lütfen tekrar girmek için bekleyiniz...\n");
                                            Thread.Sleep(3000);
                                        }
                                    }
                                }

                                else if (islemTuru == 2)
                                {
                                    while (cikis == 6)
                                    {
                                        Console.Clear();
                                        Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                                     $"             Hesabınızdaki Altın tutarı  : {bakiye[4]}\n" +
                                                     $"             Vadesiz TL hesabı tutarınız : {bakiye[0]}\n\n" +
                                                     $"             Kaç Gram Altın satmak istediğinizi giriniz : ");

                                        girilenTutar = int.Parse(Console.ReadLine());

                                        if ((girilenTutar <= bakiye[4]) && girilenTutar > 0)
                                        {
                                            bakiye[4] -= girilenTutar;
                                            bakiye[0] += (int)(girilenTutar * 1000);
                                            Console.Clear();
                                            Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                                          "                  İşlem başarıyla tamamlandı...\n\n" +
                                                         $"                  Güncel Vadesiz hesap bakiyeniz : {bakiye[0]}\n" +
                                                         $"                  Güncel Altın hesabı bakiyeniz  : {bakiye[4]}\n\n" +
                                                          "                  Menüye dönmek için lütfen bekleyiniz...");
                                            cikis = 5;
                                            sifreHak++;
                                            sifreKontrol = 12345;
                                            Thread.Sleep(3000);
                                        }

                                        else if (girilenTutar > bakiye[0])
                                        {
                                            Console.Clear();
                                            Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                                          " Altın hesabında işlem için yeterli miktarda bakiye bulunmuyor\n" +
                                                          " Tekrar girmek için lütfen bekleyiniz...\n");
                                            Thread.Sleep(3000);

                                        }

                                        else if (girilenTutar < 0)
                                        {
                                            Console.Clear();
                                            Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                                          "               0'dan küçük bir değer giremezsiniz...\n" +
                                                          "               Lütfen tekrar girmek için bekleyiniz...\n");
                                            Thread.Sleep(3000);
                                        }
                                    }
                                }
                            }

                            else if (islemTuru == 2)
                            {
                                Console.Clear();
                                Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                             $"                Güncel Euro kuru 15,03 tl'dir.\n\n" +
                                             $"                Euro satın almak için 1 giriniz :\n" +
                                             $"                Euro bozdurmak için 2 giriniz   :\n\n" +
                                             $"           -> Yapmak istediğiniz işlem türünü girin : ");

                                islemTuru = int.Parse(Console.ReadLine());

                                if (islemTuru == 1)
                                {
                                    while (cikis == 6)
                                    {
                                        Console.Clear();
                                        Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                                     $"             Hesabınızdaki Euro tutarı  : {bakiye[3]}\n" +
                                                     $"             Vadesiz TL hesabı tutarınız : {bakiye[0]}\n\n" +
                                                     $"             Kaç Türk Lirası ile Euro almak istediğinizi giriniz : ");
                                        girilenTutar = int.Parse(Console.ReadLine());

                                        if ((girilenTutar <= bakiye[0]) && girilenTutar > 0)
                                        {
                                            bakiye[0] -= girilenTutar;
                                            bakiye[3] += (int)(girilenTutar / 15.03);
                                            Console.Clear();
                                            Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                                          "                  İşlem başarıyla tamamlandı...\n\n" +
                                                         $"                  Güncel Vadesiz hesap bakiyeniz : {bakiye[0]}\n" +
                                                         $"                  Güncel Euro hesabı bakiyeniz  : {bakiye[3]}\n\n" +
                                                          "                  Menüye dönmek için lütfen bekleyiniz...");
                                            cikis = 5;
                                            sifreHak++;
                                            sifreKontrol = 12345;
                                            Thread.Sleep(3000);
                                        }

                                        else if (girilenTutar > bakiye[0])
                                        {
                                            Console.Clear();
                                            Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                                          " Vadesiz hesabından işlem için yeterli miktarda bakiye bulunmuyor\n" +
                                                          " Tekrar girmek için lütfen bekleyiniz...\n");
                                            Thread.Sleep(3000);

                                        }

                                        else if (girilenTutar < 0)
                                        {
                                            Console.Clear();
                                            Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                                          "               0'dan küçük bir değer giremezsiniz...\n" +
                                                          "               Lütfen tekrar girmek için bekleyiniz...\n");
                                            Thread.Sleep(3000);
                                        }
                                    }
                                }

                                else if (islemTuru == 2)
                                {
                                    while (cikis == 6)
                                    {
                                        Console.Clear();
                                        Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                                     $"             Hesabınızdaki Euro tutarı  : {bakiye[3]}\n" +
                                                     $"             Vadesiz TL hesabı tutarınız : {bakiye[0]}\n\n" +
                                                     $"             Kaç Euro satmak istediğinizi giriniz : ");

                                        girilenTutar = int.Parse(Console.ReadLine());

                                        if ((girilenTutar <= bakiye[3]) && girilenTutar > 0)
                                        {
                                            bakiye[3] -= girilenTutar;
                                            bakiye[0] += (int)(girilenTutar * 14.37);
                                            Console.Clear();
                                            Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                                          "                  İşlem başarıyla tamamlandı...\n\n" +
                                                         $"                  Güncel Vadesiz hesap bakiyeniz : {bakiye[0]}\n" +
                                                         $"                  Güncel Euro hesabı bakiyeniz  : {bakiye[3]}\n\n" +
                                                          "                  Menüye dönmek için lütfen bekleyiniz...");
                                            cikis = 5;
                                            sifreHak++;
                                            sifreKontrol = 12345;
                                            Thread.Sleep(3000);
                                        }

                                        else if (girilenTutar > bakiye[0])
                                        {
                                            Console.Clear();
                                            Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                                          " Euro hesabında işlem için yeterli miktarda bakiye bulunmuyor\n" +
                                                          " Tekrar girmek için lütfen bekleyiniz...\n");
                                            Thread.Sleep(3000);

                                        }

                                        else if (girilenTutar < 0)
                                        {
                                            Console.Clear();
                                            Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                                          "               0'dan küçük bir değer giremezsiniz...\n" +
                                                          "               Lütfen tekrar girmek için bekleyiniz...\n");
                                            Thread.Sleep(3000);
                                        }
                                    }
                                }
                            }
                        }

                        else if (islemTuru == 7)
                        {
                            Console.Clear();
                            Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                                "               ... Program sonlandırılıyor ...\n\n");
                            cikis = 0;
                            Environment.Exit(0);
                        }
                    }
                }
            }

            if (sifreHak < 0)
            {
                Console.Clear();
                Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                    "               Şifrenizi 3 kez yanlış girdiniz\n" +
                    "               Hesabınız bloke edildi\n" +
                    "               Müşteri hizmetleri ile irtibat kurunuz...\n\n\n");
            }

            else if (sifreHak >= 0)
            {
                Console.Clear();
                Console.Write("             ---- ATM Sistemine Hoşgeldiniz ----\n\n" +
                    "               ... Program sonlandırılıyor ...\n\n");
                cikis = 0;
                Environment.Exit(0);
            }
        }
    }
}