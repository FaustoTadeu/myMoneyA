using System.Collections.Generic;
using Android.App;
using Android.OS;
using myMoneyA.model;
using myMoneyA.controller;
using Android.Widget;

namespace myMoneyA {
    [Activity(Label = "Gerenciador de Movimentações")]
    public class MovMain : Activity {
        List<Movimento> Mov;
        protected override void OnCreate (Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.MovMain);

            var BDMov = new BDMovimento();

            Mov = new List<Movimento>();
            Mov = BDMov.GetMovimentos();

            BDMov.Dispose();

            ListView list = FindViewById<ListView>(Resource.Id.listaMov);
            GerenciaMov gl = new GerenciaMov(Mov, this);

            list.Adapter = gl;

            Button btCadastrar = FindViewById<Button>(Resource.Id.btCadastrarMov);



        }
    }
}