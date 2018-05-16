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
        private TextView mpytanko2;
        private TextView koniec;
        private ListView mpytanie1;
        private Button mOdpowiedzA1;
        private Button mOdpowiedzB1;
        private Button mOdpowiedzC1;
        private Button mOdpowiedzD1;
        private Button mOdpowiedzA2;
        private Button mOdpowiedzB2;
        private Button mOdpowiedzC2;
        private Button mOdpowiedzD2;
        private Button mPowrot;
        private List<string> mPytanie;
        private string plik;
        private string odpa1;
        private string odpb1;
        private string odpc1;
        private string odpd1;
        private string odpa2;
        private string odpb2;
        private string odpc2;
        private string odpd2;
        private string content1;
        private string content2;
        private int wynik;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);

            Button mGrajmy = FindViewById<Button>(Resource.Id.Grajmy);
            
            mGrajmy.Click += (object sender, EventArgs args) =>

            {
                {
                    int licznik = 1;
                    int zdobycz = 0;
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

                    Random rnd1 = new Random();
                    int n1 = rnd1.Next(0, 4);
                    int x1 = 5 * n1;

                   

                    string plik1 = str1[x1];
                    string odpa1 = str1[x1+1];
                    string odpb1 = str1[x1+2];
                    string odpc1 = str1[x1+3];
                    string odpd1 = str1[x1+4];

                    mpytanko1.Text = plik1;
                    mOdpowiedzA1.Text = odpa1;
                    mOdpowiedzB1.Text = odpb1;
                    mOdpowiedzC1.Text = odpc1;
                    mOdpowiedzD1.Text = odpd1;

                    mOdpowiedzA1.Click += (object sender2, EventArgs args2) =>
                    {


                        Random rnd2 = new Random();
                        int n2 = rnd2.Next(0, 4);
                        int x2 = 0 + 5 * n2;


                        string plik2 = str1[x2];
                        string odpa2 = str1[x2+1];
                        string odpb2 = str1[x2+2];
                        string odpc2 = str1[x2+3];
                        string odpd2 = str1[x2+4];

                        mpytanko1.Text = plik2;
                        mOdpowiedzA1.Text = odpa2;
                        mOdpowiedzB1.Text = odpb2;
                        mOdpowiedzC1.Text = odpc2;
                        mOdpowiedzD1.Text = odpd2;
                        licznik++;
                        zdobycz++;
                        if (licznik == 6)
                        {
                            base.OnCreate(savedInstanceState);
                            
                            SetContentView(Resource.Layout.koniec);
                            Button mPowrot = FindViewById<Button>(Resource.Id.powrot);


                            TextView koniec = FindViewById<TextView>(Resource.Id.koniecc);
                            string wynik = "Zdobyłeś " + zdobycz +"/6 PKT :)";
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


                        Random rnd2 = new Random();
                        int n2 = rnd2.Next(0, 4);
                        int x2 = 0 + 5 * n2;


                        string plik2 = str1[x2];
                        string odpa2 = str1[x2 + 1];
                        string odpb2 = str1[x2 + 2];
                        string odpc2 = str1[x2 + 3];
                        string odpd2 = str1[x2 + 4];

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
                            string wynik = "Zdobyłeś " +zdobycz +"/6 PKT :)";
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


                        Random rnd2 = new Random();
                        int n2 = rnd2.Next(0, 4);
                        int x2 = 0 + 5 * n2;


                        string plik2 = str1[x2];
                        string odpa2 = str1[x2 + 1];
                        string odpb2 = str1[x2 + 2];
                        string odpc2 = str1[x2 + 3];
                        string odpd2 = str1[x2 + 4];

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
                            string wynik = "Zdobyłeś " +zdobycz +"/6 PKT :)";
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
                        Random rnd2 = new Random();
                        int n2 = rnd2.Next(0, 4);
                        int x2 = 0 + 5 * n2;


                        string plik2 = str1[x2];
                        string odpa2 = str1[x2 + 1];
                        string odpb2 = str1[x2 + 2];
                        string odpc2 = str1[x2 + 3];
                        string odpd2 = str1[x2 + 4];

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
                        string wynik = "Zdobyłeś " +zdobycz +"/6 PKT :)";
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

