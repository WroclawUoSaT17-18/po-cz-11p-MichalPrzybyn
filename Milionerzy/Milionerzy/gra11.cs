using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Milionerzy
{
    [Activity(Label = "gra11")]
    public class gra11 : Activity
    {
        string content1;
        protected override void OnCreate(Bundle savedInstanceState)
        {
         string zczytaj(string plik1)
            {   
                AssetManager assets = this.Assets;
                using (StreamReader sr = new StreamReader(assets.Open("pytanie1.txt")))
                {
                    content1 = sr.ReadLine();

                }

                string[] str1 = content1.Split(new char[] { ',' });
                Random rnd1 = new Random();
                int n1 = rnd1.Next(1, 10);
                int x1 = 0 + 5 * n1;
                plik1 = str1[x1];
                return plik1;
                // odpa1 = str1[x1 + 1];
                // odpb1 = str1[x1 + 2];
                //odpc1 = str1[x1 + 3];
                // odpd1 = str1[x1 + 4];

                //  mpytanko1.Text = plik1;
                //  mOdpowiedzA1.Text = odpa1;
                //  mOdpowiedzB1.Text = odpb1;
                //  mOdpowiedzC1.Text = odpc1;
                //  mOdpowiedzD1.Text = odpd1;
            }

        }
    }
}