using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANAVyeni
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Kabzımal kısmı
            double kilo1 = 0, kilo2 = 0, kilo3 = 0, kilo4 = 0, kilo5 = 0, kilo6 = 0, kilo7 = 0, kilo8 = 0, kilo9 = 0;
            double Pkilo = 60, Kkilo = 50, Bkilo = 55, Skilo = 70, Mkilo = 80, Ukilo = 70, KYkilo = 60, Vkilo = 65, SFkilo = 55;
            double kiloa = 0, kilob = 0, kiloc = 0, kilod = 0, kiloe = 0, kilof = 0, kilog = 0, kiloh = 0, kiloj = 0;
        enbas:

            Console.WriteLine("Sebze mi,meyve mi istiyorsunuz?");
            string secim = Console.ReadLine().ToLower();
            double toplam = 0;
            double toplam2 = 0;
            ArrayList meyveler = new ArrayList() { "1____Muz****10tl", "2____Üzüm****8tl", "3____Kayısı****5tl", "4____Vişne****7tl", "5____Şeftali****6tl" };
            ArrayList sebzeler = new ArrayList() { "1____Patlıcan****5tl", "2____Kabak****4tl", "3____Biber****2tl", "4____Salatalık****3tl" };
            ArrayList sepet = new ArrayList();
            ArrayList musterisepet = new ArrayList();
            ArrayList manavtezgah = new ArrayList();
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
                        manavtezgah.Add("1___Patlıcan___" + 5 * 1.20 + "tl");
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
                                string w1 = Console.ReadLine().ToUpper();
                                if (w1 == "Evet")
                                {
                                    secim = "meyve";
                                    goto ilk2;
                                }
                                else
                                {

                                    goto fatura;

                                }
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
                        manavtezgah.Add("2___Kabak___" + 4 * 1.20 + "tl");
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
                                {
                                    secim = "meyve";
                                    goto ilk2;
                                }
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

                        sepet.Add("Biber");
                        manavtezgah.Add("1___Biber___" + 2 * 1.20 + "tl");
                    ana3:
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
                                if (w == "E") { 
                                    secim = "meyve";
                                    goto ilk2;
                                }
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
                        manavtezgah.Add("4___Salatalık___" + 3 * 1.20 + "tl");
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
                                {
                                    secim= "meyve";
                                    goto ilk2;
                                }
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
                        manavtezgah.Add("5___Muz___" + 10 * 1.30 + "tl");
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
                                {
                                    secim = "sebze";
                                    goto ilk;
                                }
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
                        manavtezgah.Add("6___Üzüm___" + 8 * 1.30 + "tl");
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
                                {
                                    secim = "sebze";
                                    goto ilk;
                                }
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
                        manavtezgah.Add("7___Kayısı___" + 5 * 1.30 + "tl");

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
                                {
                                    secim = "sebze";
                                    goto ilk;
                                }
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
                        manavtezgah.Add("8___Vişne___" + 7 * 1.30 + "tl");
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
                                Console.WriteLine("Sebze ister misiniz?(E/H)");
                                string w = Console.ReadLine().ToUpper();
                                if (w == "E")
                                {
                                    secim = "sebze";
                                    goto ilk;
                                }
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
                        manavtezgah.Add("9___Şeftali___" + 6 * 1.30 + "tl");
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
                                {
                                    secim = "sebze";
                                    goto ilk;
                                }
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


            }
        fatura:
            {
                toplam = kilo1 + kilo2 + kilo3 + kilo4 + kilo5 + kilo6 + kilo7 + kilo8 + kilo9;
                Console.WriteLine("Kabzımal Sepetim:");
                foreach (var item in sepet)

                {

                    Console.WriteLine(item);

                }

                Console.WriteLine("Fatura Tutarı:" + toplam);

                Console.WriteLine("Manav reyonu için M 'ye basın");
                string msec = Console.ReadLine().ToLower();
            #endregion
            #region Manav kısmı
            manavbas:
                if (msec == "m")
                {
                    Console.WriteLine("ÜRÜNLER");
                    Console.WriteLine("Kod" + "___" + "Ürün");
                    foreach (var item in manavtezgah)

                    {

                        Console.WriteLine(item);

                    }
                    Console.WriteLine("İstediğiniz ürünün kodunu giriniz.");
                    int secal = Convert.ToInt32(Console.ReadLine());
                    switch (secal)
                    {
                        case 1:
                        mbas:
                            Console.WriteLine("Kaç kilo istersiniz");
                            kiloa = Convert.ToInt32(Console.ReadLine());
                            if (kilo1 >= kiloa)
                            {
                                kilo1 = kilo1 - kiloa;
                                musterisepet.Add(kiloa + "kg");
                                Console.WriteLine("Başka birşey ister misiniz?(E/H)");
                                string cevap = Console.ReadLine().ToUpper();


                                kiloa = 5 * 1.20 * kiloa;


                                if (cevap == "E")
                                {

                                    goto manavbas;
                                }
                                else

                                    goto manavfatura;


                            }
                            else
                            {
                                Console.WriteLine("En fazla {0} kilo alabilirsiniz", kilo1);
                                goto mbas;
                            }
                            break;
                        case 2:
                        mbas2:
                            Console.WriteLine("Kaç kilo istersiniz");
                            kilob = Convert.ToInt32(Console.ReadLine());
                            if (kilo2 >= kilob)
                            {
                                kilo2 = kilo2 - kilob;
                                musterisepet.Add(kilob + "kg");
                                Console.WriteLine("Başka birşey ister misiniz?(E/H)");
                                string cevap = Console.ReadLine().ToUpper();


                                kilob = 4 * 1.20 * kilob;


                                if (cevap == "E")
                                {

                                    goto manavbas;
                                }
                                else

                                    goto manavfatura;


                            }
                            else
                            {
                                Console.WriteLine("En fazla {0} kilo alabilirsiniz", kilo2);
                                goto mbas2;
                            }
                            break;
                        case 3:
                        mbas3:
                            Console.WriteLine("Kaç kilo istersiniz");
                            kiloc = Convert.ToInt32(Console.ReadLine());
                            if (kilo3 >= kiloc)
                            {
                                kilo3 = kilo3 - kiloc;
                                musterisepet.Add(kilob + "kg");
                                Console.WriteLine("Başka birşey ister misiniz?(E/H)");
                                string cevap = Console.ReadLine().ToUpper();


                                kiloc = 2 * 1.20 * kiloc;


                                if (cevap == "E")
                                {

                                    goto manavbas;
                                }
                                else

                                    goto manavfatura;


                            }
                            else
                            {
                                Console.WriteLine("En fazla {0} kilo alabilirsiniz", kilo3);
                                goto mbas3;
                            }
                            break;
                        case 4:
                        mbas4:
                            Console.WriteLine("Kaç kilo istersiniz");
                            kilod = Convert.ToInt32(Console.ReadLine());
                            if (kilo4 >= kilod)
                            {
                                kilo4 = kilo4 - kilod;
                                musterisepet.Add(kilod + "kg");
                                Console.WriteLine("Başka birşey ister misiniz?(E/H)");
                                string cevap = Console.ReadLine().ToUpper();


                                kilod = 3 * 1.20 * kilod;


                                if (cevap == "E")
                                {

                                    goto manavbas;
                                }
                                else

                                    goto manavfatura;


                            }
                            else
                            {
                                Console.WriteLine("En fazla {0} kilo alabilirsiniz", kilo4);
                                goto mbas4;
                            }
                            break;
                        case 5:
                        mbas5:
                            Console.WriteLine("Kaç kilo istersiniz");
                            kiloe = Convert.ToInt32(Console.ReadLine());
                            if (kilo5 >= kiloe)
                            {
                                kilo5 = kilo5 - kiloe;
                                musterisepet.Add(kiloe + "kg");
                                Console.WriteLine("Başka birşey ister misiniz?(E/H)");
                                string cevap = Console.ReadLine().ToUpper();


                                kiloe = 10 * 1.30 * kiloe;


                                if (cevap == "E")
                                {

                                    goto manavbas;
                                }
                                else

                                    goto manavfatura;


                            }
                            else
                            {
                                Console.WriteLine("En fazla {0} kilo alabilirsiniz", kilo5);
                                goto mbas5;
                            }
                            break;
                        case 6:
                        mbas6:
                            Console.WriteLine("Kaç kilo istersiniz");
                            kilof = Convert.ToInt32(Console.ReadLine());
                            if (kilo6 >= kilof)
                            {
                                kilo6 = kilo6 - kilof;
                                musterisepet.Add(kilof + "kg");
                                Console.WriteLine("Başka birşey ister misiniz?(E/H)");
                                string cevap = Console.ReadLine().ToUpper();


                                kilof = 8 * 1.30 * kilof;


                                if (cevap == "E")
                                {

                                    goto manavbas;
                                }
                                else

                                    goto manavfatura;


                            }
                            else
                            {
                                Console.WriteLine("En fazla {0} kilo alabilirsiniz", kilo6);
                                goto mbas6;
                            }
                            break;
                        case 7:
                        mbas7:
                            Console.WriteLine("Kaç kilo istersiniz");
                            kilog = Convert.ToInt32(Console.ReadLine());
                            if (kilo7 >= kilog)
                            {
                                kilo7 = kilo7 - kilog;
                                musterisepet.Add(kilog + "kg");
                                Console.WriteLine("Başka birşey ister misiniz?(E/H)");
                                string cevap = Console.ReadLine().ToUpper();


                                kilog = 5 * 1.30 * kilog;


                                if (cevap == "E")
                                {

                                    goto manavbas;
                                }
                                else

                                    goto manavfatura;


                            }
                            else
                            {
                                Console.WriteLine("En fazla {0} kilo alabilirsiniz", kilo7);
                                goto mbas7;
                            }
                            break;
                        case 8:
                        mbas8:
                            Console.WriteLine("Kaç kilo istersiniz");
                            kiloh = Convert.ToInt32(Console.ReadLine());
                            if (kilo8 >= kiloh)
                            {
                                kiloh = kilo8 - kiloh;
                                musterisepet.Add(kiloh + "kg");
                                Console.WriteLine("Başka birşey ister misiniz?(E/H)");
                                string cevap = Console.ReadLine().ToUpper();


                                kiloh = 7 * 1.30 * kiloh;


                                if (cevap == "E")
                                {

                                    goto manavbas;
                                }
                                else

                                    goto manavfatura;


                            }
                            else
                            {
                                Console.WriteLine("En fazla {0} kilo alabilirsiniz", kilo8);
                                goto mbas8;
                            }
                            break;
                        case 9:
                        mbas9:
                            Console.WriteLine("Kaç kilo istersiniz");
                            kiloj = Convert.ToInt32(Console.ReadLine());
                            if (kilo9 >= kiloj)
                            {
                                kilo9 = kilo9 - kiloj;
                                musterisepet.Add(kiloj + "kg");
                                Console.WriteLine("Başka birşey ister misiniz?(E/H)");
                                string cevap = Console.ReadLine().ToUpper();


                                kiloj = 6 * 1.30 * kiloj;


                                if (cevap == "E")
                                {

                                    goto manavbas;
                                }
                                else

                                    goto manavfatura;


                            }
                            else
                            {
                                Console.WriteLine("En fazla {0} kilo alabilirsiniz", kilo9);
                                goto mbas9;
                            }
                            break;
                        default:
                            goto manavbas;
                            break;
                    }
                manavfatura:
                    {
                        toplam2 = kiloa + kilob + kiloc + kilod + kiloe + kilof + kilog + kiloh + kiloj;
                        Console.WriteLine("Manav Sepetim:");
                        foreach (var item in musterisepet)

                        {

                            Console.WriteLine(item);

                        }

                        Console.WriteLine("Manav Fatura Tutarı:" + toplam2);
                    }

                }
            }
            Console.ReadLine();
        }

        #endregion

        



    }
}


