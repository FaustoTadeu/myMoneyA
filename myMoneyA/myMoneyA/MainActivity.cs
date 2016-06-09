using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using myMoneyA.controller;
using System;

namespace myMoneyA
{
    [Activity(Label = "My Money", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it

            var bd = new BDConta();
            bd.InserirConta(new model.Conta {Tipo = "Dinheiro" });
            bd.InserirConta(new model.Conta { Tipo = "Cartão de Crédito" });
            bd.Dispose();

            var bdC = new BDCategoria();
            bdC.InserirCategoria(new model.Categoria { Nome = "Educação" });
            bdC.InserirCategoria(new model.Categoria { Nome = "Livros", CatPai = 1 });
            bdC.Dispose();

            DateTime dia = new DateTime(2016, 09, 15);
            var bdM = new BDMovimento();
            bdM.InserirMovimento(new model.Movimento { Descricao = "Compra de Livros", Tipo = "Crédito", Data = dia, Valor = 200.00, Categoria_fk = 1, Conta_fk = 1 });
            bdM.Dispose();

            Button btContas = FindViewById<Button>(Resource.Id.btGerContas);
            Button btCategorias = FindViewById<Button>(Resource.Id.btGerCategorias);
            Button btMovimento = FindViewById<Button>(Resource.Id.btGerMovimento);
            Button btRelatorios = FindViewById<Button>(Resource.Id.btGerRelatorios);
            Button btSair = FindViewById<Button>(Resource.Id.btSair);

            btContas.Click += delegate
            {
                var activity2 = new Intent(this, typeof(ContaMain));
                StartActivity(activity2);
            };

            btCategorias.Click += delegate {
                var activity2 = new Intent(this, typeof(CatMain));
                StartActivity(activity2);
            };

            btMovimento.Click += delegate {
                var activity2 = new Intent(this, typeof(MovMain));
                StartActivity(activity2);
            };

            btRelatorios.Click += delegate
            {
                var activity2 = new Intent(this, typeof(RelatoriosMenu));
                StartActivity(activity2);
            };

            btSair.Click += delegate
            {
                System.Environment.Exit(0);
             };
        }
    }
}

