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
        private ListView mpytanie1;
        private Button mOdpowiedzA1;
        private Button mOdpowiedzB1;
        private Button mOdpowiedzC1;
        private Button mOdpowiedzD1;
        private Button mOdpowiedzA2;
        private Button mOdpowiedzB2;
        private Button mOdpowiedzC2;
        private Button mOdpowiedzD2;
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

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
              SetContentView(Resource.Layout.Main);
            
            Button mGrajmy = FindViewById<Button>(Resource.Id.Grajmy);
      
            mGrajmy.Click +=  (object sender, EventArgs args) =>

      {
            {
              
               base.OnCreate(savedInstanceState);
               SetContentView(Resource.Layout.gra1);

                mpytanko1 = FindViewById<TextView>(Resource.Id.pytanko1);
                mOdpowiedzA1 = FindViewById<Button>(Resource.Id.odpA1);
                mOdpowiedzB1 = FindViewById<Button>(Resource.Id.odpB1);
                mOdpowiedzC1 = FindViewById<Button>(Resource.Id.odpC1);
                mOdpowiedzD1= FindViewById<Button>(Resource.Id.odpD1);
             gra11 onl = new gra11();
              AssetManager assets = this.Assets;
              using (StreamReader sr = new StreamReader(assets.Open("pytanie1.txt")))
              {
                  content1 = sr.ReadLine();

              }

              string[] str1 = content1.Split(new char[] { ',' });
              Random rnd1 = new Random();
              int n1 = rnd1.Next(1, 10);
              int x1 = 0 + 5 * n1;
              string plik1 = str1[x1];


              Random liczba = new Random();
              int z1 = liczba.Next(1, 4);
              string odpa1 = str1[x1 + z1];
              string odpb1 = str1[x1 + z1];
              string odpc1 = str1[x1 + z1];
              string odpd1 = str1[x1 + z1];




              mpytanko1.Text = plik1;
              mOdpowiedzA1.Text = odpa1;
              mOdpowiedzB1.Text = odpb1;
              mOdpowiedzC1.Text = odpc1;
              mOdpowiedzD1.Text = odpd1;

              mOdpowiedzA1.Click += (object sender2, EventArgs args2) =>
              {


                  Random rnd2 = new Random();
                  int n2 = rnd2.Next(10, 19);
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

                  mOdpowiedzA1.Click += (object sender3, EventArgs args3) =>
                  {
                      Random rnd3 = new Random();
                      int n3 = rnd3.Next(20, 29);
                      int x3 = 0 + 5 * n3;
                      string plik3 = str1[x3];
                      string odpa3 = str1[x3 + 1];
                      string odpb3 = str1[x3 + 2];
                      string odpc3 = str1[x3 + 3];
                      string odpd3 = str1[x3 + 4];
                      mpytanko1.Text = plik3;
                      mOdpowiedzA1.Text = odpa3;
                      mOdpowiedzB1.Text = odpb2;
                      mOdpowiedzC1.Text = odpc3;
                      mOdpowiedzD1.Text = odpd3;


                  };
              };

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

