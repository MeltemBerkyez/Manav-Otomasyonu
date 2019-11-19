using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manavyenideneme2
{
    class Program
    {
        static void Main(string[] args)
        {
           
                #region Kabzımal kısmı
                int kilo1 = 0, kilo2 = 0, kilo3 = 0, kilo4 = 0, kilo5 = 0, kilo6 = 0, kilo7 = 0, kilo8 = 0, kilo9 = 0;
                int Pkilo = 60, Kkilo = 50, Bkilo = 55, Skilo = 70, Mkilo = 80, Ukilo = 70, KYkilo = 60, Vkilo = 65, SFkilo = 55;
            enbas:

                Console.WriteLine("Sebze mi,meyve mi istiyorsunuz?");
                string secim = Console.ReadLine().ToLower();
                int toplam = 0;
                ArrayList meyveler = new ArrayList() { "1____Muz****10tl", "2____Üzüm****8tl", "3____Kayısı****5tl", "4____Vişne****7tl", "5____Şeftali****6tl" };
                ArrayList sebzeler = new ArrayList() { "1____Patlıcan****5tl", "2____Kabak****4tl", "3____Biber****2tl", "4____Salatalık****3tl" };
                ArrayList sepet = new ArrayList();
            ilk:
                if (secim == "sebze")
                {

                    Console.WriteLine("ÜRÜN LİSTESİ: Sebzeler");
                    Console.WriteLine("Kod" + "___" + "Ürün");

                    foreach (var item in sebzeler)


                    {
                        Console.WriteLine(item);


                    }

                    Console.WriteLine("İstediğiniz sebzenin kodunu giriniz.");
                    int secim2 = Convert.ToInt32(Console.ReadLine());




                    switch (secim2)

                    {

                        case 1:
                            sepet.Add("Patlıcan");
                        ana:
                            Console.WriteLine("Kaç kilo istersiniz");
                            kilo1 = Convert.ToInt32(Console.ReadLine());
                            if (Pkilo >= kilo1)
                            {
                                Pkilo = Pkilo - kilo1;
                                sepet.Add(kilo1 + "kg");
                                Console.WriteLine("Başka sebze ister misiniz?(E/H)");
                                string cevap = Console.ReadLine().ToUpper();
                                kilo1 = 5 * kilo1;


                                if (cevap == "E")
                                {
                                    sebzeler.Remove("1____Patlıcan****5tl");

                                    goto ilk;
                                }
                                else if (cevap == "H")
                                {
                                    Console.WriteLine("Meyve ister misiniz?");
                                    string w = Console.ReadLine().ToUpper();
                                    if (w == "E")
                                        goto ilk2;
                                    else
                                        goto fatura();
                                }
                                else
                                    goto enbas;
                            }
                            else
                            {
                                Console.WriteLine("En fazla {0} kilo alabilirsiniz", Pkilo);
                                goto ana;
                            }
                            break;
                        case 2:
                            sepet.Add("Kabak");
                        ana2:
                            Console.WriteLine("Kaç kilo istersiniz");
                            kilo2 = Convert.ToInt32(Console.ReadLine());
                            if (Kkilo >= kilo2)
                            {
                                Kkilo = Kkilo - kilo2;
                                sepet.Add(kilo2 + "kg");
                                Console.WriteLine("Başka sebze ister misiniz?(E/H)");
                                string cevap2 = Console.ReadLine().ToUpper();
                                kilo2 = 4 * kilo2;
                                if (cevap2 == "E")
                                {

                                    sebzeler.Remove("2____Kabak****4tl");

                                    goto ilk;
                                }
                                else if (cevap2 == "H")
                                {
                                    Console.WriteLine("Meyve ister misiniz?");
                                    string w = Console.ReadLine().ToUpper();
                                    if (w == "E")
                                        goto ilk2;
                                    else
                                        goto fatura;
                                }
                                else
                                    goto enbas;
                            }
                            else
                            {
                                Console.WriteLine("En fazla {0} kilo alabilirsiniz", Kkilo);
                                goto ana2;
                            }
                            break;
                        case 3:
                        ana3:
                            sepet.Add("Biber");

                            Console.WriteLine("Kaç kilo istersiniz");
                            kilo3 = Convert.ToInt32(Console.ReadLine());

                            if (Bkilo > kilo3)
                            {
                                Bkilo = Bkilo - kilo3;
                                sepet.Add(kilo3 + "kg");
                                Console.WriteLine("Başka sebze ister misiniz?(E/H)");
                                string cevap3 = Console.ReadLine().ToUpper();
                                kilo3 = 2 * kilo3;
                                if (cevap3 == "E")
                                {

                                    sebzeler.Remove("3____Biber****2tl");

                                    goto ilk;
                                }
                                else if (cevap3 == "H")
                                {
                                    Console.WriteLine("Meyve ister misiniz?");
                                    string w = Console.ReadLine().ToUpper();
                                    if (w == "E")
                                        goto ilk2;
                                    else
                                        goto fatura;
                                }
                                else
                                    goto enbas;
                            }
                            else
                            {
                                Console.WriteLine("En fazla {0} kilo alabilirsiniz", Bkilo);
                                goto ana3;
                            }
                            break;
                        case 4:
                            sepet.Add("Salatalık");
                        ana4:
                            Console.WriteLine("Kaç kilo istersiniz");
                            kilo4 = Convert.ToInt32(Console.ReadLine());
                            if (Skilo > kilo4)
                            {
                                Skilo = Skilo - kilo4;
                                sepet.Add(kilo4 + "kg");
                                Console.WriteLine("Başka sebze ister misiniz?(E/H)");
                                string cevap4 = Console.ReadLine().ToUpper();
                                kilo4 = 3 * kilo4;
                                if (cevap4 == "E")
                                {

                                    sebzeler.Remove("4____Salatalık****3tl");
                                    goto ilk;
                                }
                                else if (cevap4 == "H")
                                {
                                    Console.WriteLine("Meyve ister misiniz?(E/H)");
                                    string w = Console.ReadLine().ToUpper();
                                    if (w == "E")
                                        goto ilk2;
                                    else
                                        goto fatura;

                                }
                                else
                                    goto enbas;
                            }
                            else
                            {
                                Console.WriteLine("En fazla {0} kilo alabilirsiniz", Skilo);
                                goto ana;
                            }
                            break;


                    }
                

                ilk2:
                    if (secim == "meyve")
                    {

                        Console.WriteLine("ÜRÜN LİSTESİ: Meyveler");
                        Console.WriteLine("Kod" + "___" + "Ürün");

                        foreach (var item in meyveler)


                        {
                            Console.WriteLine(item);


                        }

                        Console.WriteLine("İstediğiniz meyvenin kodunu giriniz.");
                        int secim3 = Convert.ToInt32(Console.ReadLine());




                        switch (secim3)

                        {

                            case 1:
                                sepet.Add("Muz");
                            ana5:
                                Console.WriteLine("Kaç kilo istersiniz");
                                kilo5 = Convert.ToInt32(Console.ReadLine());
                                if (Mkilo >= kilo5)
                                {
                                    Mkilo = Mkilo - kilo5;
                                    sepet.Add(kilo5 + "kg");
                                    Console.WriteLine("Başka meyve ister misiniz?(E/H)");
                                    string cevap = Console.ReadLine().ToUpper();
                                    kilo5 = 10 * kilo5;


                                    if (cevap == "E")
                                    {
                                        sebzeler.Remove("1____Muz****10tl");

                                        goto ilk2;
                                    }
                                    else if (cevap == "H")
                                    {
                                        Console.WriteLine("Sebze ister misiniz?");
                                        string w = Console.ReadLine().ToUpper();
                                        if (w == "E")
                                            goto ilk;
                                        else
                                            goto fatura;
                                    }
                                    else
                                        goto enbas;
                                }
                                else
                                {
                                    Console.WriteLine("En fazla {0} kilo alabilirsiniz", Mkilo);
                                    goto ana5;
                                }
                                break;
                            case 2:

                                sepet.Add("Üzüm");
                            ana6:
                                Console.WriteLine("Kaç kilo istersiniz");
                                kilo6 = Convert.ToInt32(Console.ReadLine());
                                if (Ukilo >= kilo6)
                                {
                                    Ukilo = Ukilo - kilo6;
                                    sepet.Add(kilo6 + "kg");
                                    Console.WriteLine("Başka meyve ister misiniz?(E/H)");
                                    string cevap2 = Console.ReadLine().ToUpper();
                                    kilo6 = 8 * kilo6;
                                    if (cevap2 == "E")
                                    {

                                        sebzeler.Remove("2____Üzüm****8tl");

                                        goto ilk2;
                                    }
                                    else if (cevap2 == "H")
                                    {
                                        Console.WriteLine("Sebze ister misiniz?");
                                        string w = Console.ReadLine().ToUpper();
                                        if (w == "E")
                                            goto ilk;
                                        else
                                            goto fatura;
                                    }
                                    else
                                        goto enbas;
                                }
                                else
                                {
                                    Console.WriteLine("En fazla {0} kilo alabilirsiniz", Ukilo);
                                    goto ana6;
                                }
                                break;
                            case 3:
                            ana7:
                                sepet.Add("Kayısı");

                                Console.WriteLine("Kaç kilo istersiniz");
                                kilo7 = Convert.ToInt32(Console.ReadLine());

                                if (KYkilo > kilo7)
                                {
                                    KYkilo = KYkilo - kilo7;
                                    sepet.Add(kilo7 + "kg");
                                    Console.WriteLine("Başka meyve ister misiniz?(E/H)");
                                    string cevap3 = Console.ReadLine().ToUpper();
                                    kilo7 = 5 * kilo7;
                                    if (cevap3 == "E")
                                    {

                                        sebzeler.Remove("3____Kayısı****5tl");

                                        goto ilk2;
                                    }
                                    else if (cevap3 == "H")
                                    {
                                        Console.WriteLine("Sebze ister misiniz?");
                                        string w = Console.ReadLine().ToUpper();
                                        if (w == "E")
                                            goto ilk;
                                        else
                                            goto fatura;
                                    }
                                    else
                                        goto enbas;
                                }
                                else
                                {
                                    Console.WriteLine("En fazla {0} kilo alabilirsiniz", KYkilo);
                                    goto ana7;
                                }
                                break;
                            case 4:
                                sepet.Add("Vişne");
                            ana8:
                                Console.WriteLine("Kaç kilo istersiniz");
                                kilo8 = Convert.ToInt32(Console.ReadLine());
                                if (Vkilo > kilo8)
                                {
                                    Vkilo = Vkilo - kilo8;
                                    sepet.Add(kilo8 + "kg");
                                    Console.WriteLine("Başka meyve ister misiniz?(E/H)");
                                    string cevap4 = Console.ReadLine().ToUpper();
                                    kilo8 = 7 * kilo8;
                                    if (cevap4 == "E")
                                    {

                                        sebzeler.Remove("4____Vişne****7tl");
                                        goto ilk2;
                                    }
                                    else if (cevap4 == "H")
                                    {
                                        Console.WriteLine("Meyve ister misiniz?(E/H)");
                                        string w = Console.ReadLine().ToUpper();
                                        if (w == "E")
                                            goto ilk;
                                        else
                                            goto fatura;

                                    }
                                    else
                                        goto enbas;
                                }
                                else
                                {
                                    Console.WriteLine("En fazla {0} kilo alabilirsiniz", Vkilo);
                                    goto ana8;
                                }
                                break;
                            case 5:
                                sepet.Add("Şeftali");
                            ana9:
                                Console.WriteLine("Kaç kilo istersiniz");
                                kilo9 = Convert.ToInt32(Console.ReadLine());
                                if (SFkilo > kilo9)
                                {
                                    SFkilo = SFkilo - kilo9;
                                    sepet.Add(kilo9 + "kg");
                                    Console.WriteLine("Başka meyve ister misiniz?(E/H)");
                                    string cevap4 = Console.ReadLine().ToUpper();
                                    kilo9 = 6 * kilo9;
                                    if (cevap4 == "E")
                                    {

                                        sebzeler.Remove("5____Şeftali * ***6tl");
                                        goto ilk2;
                                    }
                                    else if (cevap4 == "H")
                                    {
                                        Console.WriteLine("Sebze ister misiniz?(E/H)");
                                        string w = Console.ReadLine().ToUpper();
                                        if (w == "E")
                                            goto ilk;
                                        else
                                            goto fatura;

                                    }
                                    else
                                        goto enbas;
                                }
                                else
                                {
                                    Console.WriteLine("En fazla {0} kilo alabilirsiniz", SFkilo);
                                    goto ana9;
                                }
                                break;


                        }

                        Console.ReadLine();
                        #endregion
                        #region Manav kısmı
                        #endregion
                    }
                }
            }
        static int Fatura(int t)
                    {
            
                        t = kilo1 + kilo2 + kilo3 + kilo4 + kilo5 + kilo6 + kilo7 + kilo8 + kilo9;
                        Console.WriteLine("Kabzımal Sepetim:");
                        foreach (var item in sepet)

                        {

                            Console.WriteLine(item);

                        }

    Console.WriteLine("Fatura Tutarı:" + toplam);
                    }
        }
    }


}
    }
}
