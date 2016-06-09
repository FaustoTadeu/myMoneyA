using System.Collections.Generic;

using Android.App;
using Android.Views;
using Android.Widget;
using myMoneyA.model;

namespace myMoneyA {

    public class GerenciaCat : BaseAdapter<Categoria> {
        List<Categoria> Cat;
        Activity C;

        public GerenciaCat (List<Categoria> dd, Activity act) {
            Cat = dd;
            C = act;
        }

        public override Categoria this[int position] {
            get {
                return Cat[position];
            }
        }

        public override int Count {
            get {
                return Cat.Count;
            }
        }

        public override long GetItemId (int position) {
            return position;
        }

        public override View GetView (int position, View convertView, ViewGroup parent) {
            View view = convertView;
            if (view == null) {
                view = C.LayoutInflater.Inflate(Resource.Layout.ItemCat, null);
            }

            view.FindViewById<TextView>(Resource.Id.txtCat).Text = Cat[position].Nome + " - "+Cat[position].CatPai.ToString();

            view.FindViewById<Button>(Resource.Id.btAtualizarConta);
            view.FindViewById<Button>(Resource.Id.btApagarConta);



            return view;
        }
    }
}