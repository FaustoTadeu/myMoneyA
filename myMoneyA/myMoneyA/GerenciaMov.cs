using System.Collections.Generic;

using Android.App;
using Android.Views;
using Android.Widget;
using myMoneyA.model;

namespace myMoneyA {

    public class GerenciaMov : BaseAdapter<Movimento> {
        List<Movimento> Mov;
        MovMain C;

        public GerenciaMov (List<Movimento> dd, MovMain act) {
            Mov = dd;
            C = act;
        }

        public override Movimento this[int position] {
            get {
                return Mov[position];
            }
        }

        public override int Count {
            get {
                return Mov.Count;
            }
        }

        public override long GetItemId (int position) {
            return position;
        }

        public override View GetView (int position, View convertView, ViewGroup parent) {
            View view = convertView;
            if (view == null) {
                view = C.LayoutInflater.Inflate(Resource.Layout.ItemMov, null);
            }

            view.FindViewById<TextView>(Resource.Id.txtMov).Text = Mov[position].Descricao + " - " + Mov[position].Tipo + " - " + Mov[position].Data.ToString() + " - " + Mov[position].Valor.ToString();

            view.FindViewById<Button>(Resource.Id.btAtualizarMov);
            Button btnApagar = view.FindViewById<Button>(Resource.Id.btApagarMov);

            btnApagar.Click += delegate {
                C.Apagar_Movimento(position);
                this.NotifyDataSetChanged();
            };

            return view;
        }
    }
}