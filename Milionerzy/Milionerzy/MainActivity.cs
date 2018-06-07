using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

using Android.Views;
using System;
using Android.Content;
using System.Threading;
using Android.Graphics;
using System.IO;
using Android.Content.Res;
using System.Linq;
using static Android.Renderscripts.Sampler;

namespace Milionerzy
{
    [Activity(Label = "Milionerzy", MainLauncher = true)]





    public class MainActivity : Activity
    {


        private Button mGrajmy;
        private Button mRekord;
        private Button mWyjscie;
        private Button mGra;
        private Button gra2a;
        private TextView mpytanko1;

        private TextView koniec;
        private ListView mpytanie1;
        private Button mOdpowiedzA1;
        private Button mOdpowiedzB1;
        private Button mOdpowiedzC1;
        private Button mOdpowiedzD1;

        private Button mPowrot;
        private List<string> mPytanie;
        private string plik;
        private string odpa1;
        private string odpb1;
        private string odpc1;
        private string odpd1;

        private string content1;

        private int wynik;


        public Button MGrajmy { get => mGrajmy; set => mGrajmy = value; }
        public Button MRekord { get => mRekord; set => mRekord = value; }
        public Button MWyjscie { get => mWyjscie; set => mWyjscie = value; }
        public Button MGra { get => mGra; set => mGra = value; }
        public Button Gra2a { get => gra2a; set => gra2a = value; }
        public TextView Koniec { get => koniec; set => koniec = value; }
        public ListView Mpytanie1 { get => mpytanie1; set => mpytanie1 = value; }
        public Button MPowrot { get => mPowrot; set => mPowrot = value; }
        public List<string> MPytanie { get => mPytanie; set => mPytanie = value; }
        public string Plik { get => plik; set => plik = value; }
        public string Odpa1 { get => odpa1; set => odpa1 = value; }
        public string Odpb1 { get => odpb1; set => odpb1 = value; }
        public string Odpc1 { get => odpc1; set => odpc1 = value; }
        public string Odpd1 { get => odpd1; set => odpd1 = value; }
        public int Wynik { get => wynik; set => wynik = value; }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            int licznik = 0;
            int zdobycz = 0;
            int x1;
            Random rnd1 = new Random();
            int n1;
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);

            Button mGrajmy = FindViewById<Button>(Resource.Id.Grajmy);

            mGrajmy.Click += (object sender, EventArgs args) =>

            {
                {

                    List<int> poprawne = new List<int>();
                    poprawne.Add(0);
                    poprawne.Add(0);
                    poprawne.Add(1);
                    poprawne.Add(0);
                    poprawne.Add(0);

                    poprawne.Add(0);
                    poprawne.Add(1);
                    poprawne.Add(0);
                    poprawne.Add(0);
                    poprawne.Add(0);

                    poprawne.Add(0);
                    poprawne.Add(0);
                    poprawne.Add(1);
                    poprawne.Add(0);
                    poprawne.Add(0);

                    poprawne.Add(0);
                    poprawne.Add(0);
                    poprawne.Add(0);
                    poprawne.Add(1);
                    poprawne.Add(0);

                    poprawne.Add(0);
                    poprawne.Add(0);
                    poprawne.Add(0);
                    poprawne.Add(0);
                    poprawne.Add(1);

                    poprawne.Add(0);
                    poprawne.Add(0);
                    poprawne.Add(1);
                    poprawne.Add(0);
                    poprawne.Add(0);

                    poprawne.Add(0);
                    poprawne.Add(0);
                    poprawne.Add(0);
                    poprawne.Add(1);
                    poprawne.Add(0);

                    poprawne.Add(0);
                    poprawne.Add(0);
                    poprawne.Add(0);
                    poprawne.Add(0);
                    poprawne.Add(1);

                    poprawne.Add(0);
                    poprawne.Add(0);
                    poprawne.Add(1);
                    poprawne.Add(0);
                    poprawne.Add(0);

                    poprawne.Add(0);
                    poprawne.Add(1);
                    poprawne.Add(0);
                    poprawne.Add(0);
                    poprawne.Add(0);
                    base.OnCreate(savedInstanceState);
                    SetContentView(Resource.Layout.gra1);

                    mpytanko1 = FindViewById<TextView>(Resource.Id.pytanko1);
                    mOdpowiedzA1 = FindViewById<Button>(Resource.Id.odpA1);
                    mOdpowiedzB1 = FindViewById<Button>(Resource.Id.odpB1);
                    mOdpowiedzC1 = FindViewById<Button>(Resource.Id.odpC1);
                    mOdpowiedzD1 = FindViewById<Button>(Resource.Id.odpD1);

                    AssetManager assets = this.Assets;
                    using (StreamReader sr = new StreamReader(assets.Open("pytanie1.txt")))
                    {
                        content1 = sr.ReadLine();

                    }

                    string[] str1 = content1.Split(new char[] { ',' });


                    n1 = rnd1.Next(0, 10);
                    x1 = 5 * n1;
                    string plik1 = str1[x1];
                    string odpa1 = str1[x1 + 1];
                    string odpb1 = str1[x1 + 2];
                    string odpc1 = str1[x1 + 3];
                    string odpd1 = str1[x1 + 4];

                    mpytanko1.Text = plik1;
                    mOdpowiedzA1.Text = odpa1;
                    mOdpowiedzB1.Text = odpb1;
                    mOdpowiedzC1.Text = odpc1;
                    mOdpowiedzD1.Text = odpd1;

                    mOdpowiedzA1.Click += (object sender2, EventArgs args2) =>
                    {

                        if (poprawne[x1 + 1] == 1)
                        {
                            zdobycz++;

                        }
                        Random rnd2 = new Random();
                        int n2 = rnd2.Next(0, 10);
                        x1 = 0 + 5 * n2;


                        string plik2 = str1[x1];
                        string odpa2 = str1[x1 + 1];
                        string odpb2 = str1[x1 + 2];
                        string odpc2 = str1[x1 + 3];
                        string odpd2 = str1[x1 + 4];

                        mpytanko1.Text = plik2;
                        mOdpowiedzA1.Text = odpa2;
                        mOdpowiedzB1.Text = odpb2;
                        mOdpowiedzC1.Text = odpc2;
                        mOdpowiedzD1.Text = odpd2;



                        licznik++;
                        if (licznik == 6)
                        {
                            base.OnCreate(savedInstanceState);

                            SetContentView(Resource.Layout.koniec);
                            Button mPowrot = FindViewById<Button>(Resource.Id.powrot);


                            TextView koniec = FindViewById<TextView>(Resource.Id.koniecc);
                            string wynik = "Zdobyłeś " + zdobycz + "/" + licznik;
                            koniec.Text = wynik;



                            mPowrot.Click += (object sender4, EventArgs args4) =>
                            {
                                base.OnCreate(savedInstanceState);
                                SetContentView(Resource.Layout.Main);


                            };
                        }


                    };
                    mOdpowiedzB1.Click += (object sender2, EventArgs args2) =>
                    {
                        if (poprawne[x1 + 2] == 1)
                        {
                            zdobycz++;

                        }


                        Random rnd2 = new Random();
                        int n2 = rnd2.Next(0, 10);
                        x1 = 0 + 5 * n2;


                        string plik2 = str1[x1];
                        string odpa2 = str1[x1 + 1];
                        string odpb2 = str1[x1 + 2];
                        string odpc2 = str1[x1 + 3];
                        string odpd2 = str1[x1 + 4];

                        mpytanko1.Text = plik2;
                        mOdpowiedzA1.Text = odpa2;
                        mOdpowiedzB1.Text = odpb2;
                        mOdpowiedzC1.Text = odpc2;
                        mOdpowiedzD1.Text = odpd2;





                        licznik++;

                        if (licznik == 6)
                        {
                            base.OnCreate(savedInstanceState);

                            SetContentView(Resource.Layout.koniec);
                            Button mPowrot = FindViewById<Button>(Resource.Id.powrot);
                            TextView koniec = FindViewById<TextView>(Resource.Id.koniecc);
                            string wynik = "Zdobyłeś " + zdobycz + "/" + licznik;
                            koniec.Text = wynik;
                            mPowrot.Click += (object sender4, EventArgs args4) =>
                            {
                                base.OnCreate(savedInstanceState);
                                SetContentView(Resource.Layout.Main);


                            };
                        }
                    };
                    mOdpowiedzC1.Click += (object sender2, EventArgs args2) =>
                    {
                        if (poprawne[x1 + 3] == 1)
                        {
                            zdobycz++;

                        }

                        Random rnd2 = new Random();
                        int n2 = rnd2.Next(0, 10);
                        x1 = 0 + 5 * n2;


                        string plik2 = str1[x1];
                        string odpa2 = str1[x1 + 1];
                        string odpb2 = str1[x1 + 2];
                        string odpc2 = str1[x1 + 3];
                        string odpd2 = str1[x1 + 4];

                        mpytanko1.Text = plik2;
                        mOdpowiedzA1.Text = odpa2;
                        mOdpowiedzB1.Text = odpb2;
                        mOdpowiedzC1.Text = odpc2;
                        mOdpowiedzD1.Text = odpd2;





                        licznik++;

                        if (licznik == 6)
                        {
                            base.OnCreate(savedInstanceState);


                            SetContentView(Resource.Layout.koniec);
                            Button mPowrot = FindViewById<Button>(Resource.Id.powrot);
                            TextView koniec = FindViewById<TextView>(Resource.Id.koniecc);
                            string wynik = "Zdobyłeś " + zdobycz + "/" + licznik;
                            koniec.Text = wynik;
                            mPowrot.Click += (object sender4, EventArgs args4) =>
                            {

                                base.OnCreate(savedInstanceState);
                                SetContentView(Resource.Layout.Main);


                            };
                        }
                    };
                    mOdpowiedzD1.Click += (object sender2, EventArgs args2) =>
                    {
                        if (poprawne[x1 + 4] == 1)
                        {
                            zdobycz++;

                        }
                        Random rnd2 = new Random();
                        int n2 = rnd2.Next(0, 10);
                        x1 = 0 + 5 * n2;


                        string plik2 = str1[x1];
                        string odpa2 = str1[x1 + 1];
                        string odpb2 = str1[x1 + 2];
                        string odpc2 = str1[x1 + 3];
                        string odpd2 = str1[x1 + 4];

                        mpytanko1.Text = plik2;
                        mOdpowiedzA1.Text = odpa2;
                        mOdpowiedzB1.Text = odpb2;
                        mOdpowiedzC1.Text = odpc2;
                        mOdpowiedzD1.Text = odpd2;




                        licznik++;


                    };
                    if (licznik == 6)
                    {
                        base.OnCreate(savedInstanceState);

                        SetContentView(Resource.Layout.koniec);
                        TextView koniec = FindViewById<TextView>(Resource.Id.koniecc);
                        string wynik = "Zdobyłeś " + zdobycz + "/" + licznik;
                        koniec.Text = wynik;
                        Button mPowrot = FindViewById<Button>(Resource.Id.powrot);
                        mPowrot.Click += (object sender4, EventArgs args4) =>
                        {
                            base.OnCreate(savedInstanceState);
                            SetContentView(Resource.Layout.Main);

                        };
                    }



                };



            };

            Button mRekord = FindViewById<Button>(Resource.Id.rekord);
            mRekord.Click += delegate
            {

                base.OnCreate(savedInstanceState);

                SetContentView(Resource.Layout.rekordy);
            };


            Button mWyjscie = FindViewById<Button>(Resource.Id.Wyjscie);
            mWyjscie.Click += delegate
            {
                Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
            };



        }


    }



}

