using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace myMoneyA
{
    [Activity(Label = "RelatoriosMenu")]
    public class RelatoriosMenu : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.RelatoriosMenu);

            Button btReceitas = FindViewById<Button>(Resource.Id.btReceitasTotais);
            Button btCatReceitas = FindViewById<Button>(Resource.Id.btReceitasPorCategoria);
            Button btSubCatReceitas = FindViewById<Button>(Resource.Id.btReceitasPorSubCategoria);
            Button btContasReceita = FindViewById<Button>(Resource.Id.btReceitasPorConta);
            Button btDespesas = FindViewById<Button>(Resource.Id.btDespesasTotais);
            Button btCatDespesas = FindViewById<Button>(Resource.Id.btDespesasPorCategoria);
            Button btSubCatDespesas = FindViewById<Button>(Resource.Id.btDespesasPorSubCategoria);
            Button btContaDespesas = FindViewById<Button>(Resource.Id.btDespesasPorConta);
            Button btSaldo = FindViewById<Button>(Resource.Id.btSaldo);
            Button btVoltar = FindViewById<Button>(Resource.Id.btVoltar);

            btVoltar.Click += delegate
            {
                var activity2 = new Intent(this, typeof(MainActivity));
                StartActivity(activity2);
            };


        }
    }
}