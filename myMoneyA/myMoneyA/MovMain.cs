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
        BDMovimento BDMov;
        ListView list;
        protected override void OnCreate (Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.MovMain);

            var BDMov = new BDMovimento();

            Mov = new List<Movimento>();
            Mov = BDMov.GetMovimentos();

            BDMov.Dispose();

            list = FindViewById<ListView>(Resource.Id.listaMov);
            GerenciaMov gl = new GerenciaMov(Mov, this);

            list.Adapter = gl;

            Button btCadastrar = FindViewById<Button>(Resource.Id.btCadastrarMov);



        }
        public void Apagar_Movimento (int id) {
            if (Mov.Count > 0) {
                BDMov = new BDMovimento();
                BDMov.DeletarMovimento(Mov[id]);
                BDMov.Dispose();
                Mov.RemoveAt(id);
            }
        }
    }
}