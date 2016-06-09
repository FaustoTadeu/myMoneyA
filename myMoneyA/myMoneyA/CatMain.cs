using System.Collections.Generic;
using Android.App;
using Android.OS;
using myMoneyA.model;
using myMoneyA.controller;
using Android.Widget;

namespace myMoneyA {
    [Activity(Label = "Gerenciador de Categorias")]
    public class CatMain : Activity {
        List<Categoria> Cat;
        BDCategoria BDCat;
        ListView list;
        protected override void OnCreate (Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.CatMain);

            var BDCat = new BDCategoria();

            Cat = new List<Categoria>();
            Cat = BDCat.GetCategorias();

            BDCat.Dispose();

            list = FindViewById<ListView>(Resource.Id.listaCat);
            GerenciaCat gl = new GerenciaCat(Cat, this);

            list.Adapter = gl;

            Button btCadastrar = FindViewById<Button>(Resource.Id.btGerContas);

        }

        public void Apagar_Categoria (int id) {
            if (Cat.Count > 0) {
                BDCat = new BDCategoria();
                BDCat.DeletarCategoria(Cat[id]);
                BDCat.Dispose();
                Cat.RemoveAt(id);
            }
        }
        }
    }