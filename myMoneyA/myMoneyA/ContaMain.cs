using System.Collections.Generic;
using Android.App;
using Android.OS;
using myMoneyA.model;
using myMoneyA.controller;
using Android.Widget;

namespace myMoneyA
{
    [Activity(Label = "Gerenciador de Contas")]
    public class ContaMain : Activity
    {
        List<Conta> Contas;
        BDConta BDConta;
        ListView list;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ContaMain);

            BDConta = new BDConta();

            Contas = new List<Conta>();
            Contas = BDConta.GetContas();

            BDConta.Dispose();

            list = FindViewById<ListView>(Resource.Id.listaContas);
            GerenciaContas gl = new GerenciaContas(Contas, this);

            list.Adapter = gl;

            Button btCadastrar = FindViewById <Button>(Resource.Id.btGerContas);


        }

        public void Apagar_Conta (int id) {
            if (Contas.Count > 0) {
                BDConta = new BDConta();
                BDConta.DeletarConta(Contas[id]);
                BDConta.Dispose();
                Contas.RemoveAt(id);
            }
           
        }
    }
}