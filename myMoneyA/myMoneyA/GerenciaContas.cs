using System;
using System.Collections.Generic;

using Android.App;
using Android.Views;
using Android.Widget;
using myMoneyA.model;

namespace myMoneyA
{

    public class GerenciaContas : BaseAdapter<Conta>

    {
        List<Conta> Contas;
        ContaMain C;

        public GerenciaContas(List<Conta> dd, ContaMain act)
        {
            Contas = dd;
            C = act;
        }

        public override Conta this[int position]
        {
            get
            {
                return Contas[position];
            }
        }

        public override int Count
        {
            get
            {
                return Contas.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;
            if (view == null)
            {
                view = C.LayoutInflater.Inflate(Resource.Layout.ItemConta, null);
            }

            view.FindViewById<TextView>(Resource.Id.txtConta).Text = Contas[position].Tipo;

            view.FindViewById<Button>(Resource.Id.btAtualizarConta);
            Button btnApagar = view.FindViewById<Button>(Resource.Id.btApagarConta);

            btnApagar.Click += delegate {
                C.Apagar_Conta(position);
                this.NotifyDataSetChanged();
            };

            return view;
        }
    }
}