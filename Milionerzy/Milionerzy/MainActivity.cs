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
        private ListView mpytanie1;
        private Button mOdpowiedzA;
        private List<string> mPytanie;
        private string plik;
        private string odpa;
        private string odpb;
        private string odpc;
        private string odpd;
        private string content;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);


            SetContentView(Resource.Layout.Main);
          

            Button mGrajmy = FindViewById<Button>(Resource.Id.Grajmy);

            mGrajmy.Click += (object sender, EventArgs args) =>

        {
            FragmentTransaction transaction = FragmentManager.BeginTransaction();
            imie nowagra = new imie();
            nowagra.Show(transaction, "dialog_fragment");
            base.OnCreate(savedInstanceState);


            SetContentView(Resource.Layout.gra1);
            mpytanko1 = FindViewById<TextView>(Resource.Id.pytanko1);
            mOdpowiedzA = FindViewById<Button>(Resource.Id.odpA);

            mOdpowiedzA.Click += delegate
            {
                base.OnCreate(savedInstanceState);


                SetContentView(Resource.Layout.gra2);
            };


          
            AssetManager assets = this.Assets;
            using (StreamReader sr = new StreamReader(assets.Open("pytanie.txt")))
            {
                content = sr.ReadLine();
                
            }
            

            string[] str = content.Split(new char[] { ',' });
            string plik = str[0];
            string odpa = str[1];
           
            mpytanko1.Text = plik;
            mOdpowiedzA.Text = odpa;
         
         
           






        
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

