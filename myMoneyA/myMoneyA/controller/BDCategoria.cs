using System;
using SQLite;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using myMoneyA.model;

namespace myMoneyA.controller {

    public class BDCategoria : IDisposable {

        private SQLiteConnection conexaoSQLite;

        public BDCategoria () {
            conexaoSQLite = new SQLiteConnection(Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "mymoney"));

            conexaoSQLite.CreateTable<Categoria>();
        }
        public void InserirCategoria (Categoria cat) {
            conexaoSQLite.Insert(cat);
        }
        public void AtualizarCategoria (Categoria cat) {
            conexaoSQLite.Update(cat);
        }
        public void DeletarCategoria (Categoria cat) {
            conexaoSQLite.Delete(cat);
        }
        public Categoria GetCategoriaId (int codigo) {
            return conexaoSQLite.Table<Categoria>().FirstOrDefault(c => c.Id == codigo);
        }
        public List<Categoria> GetCategorias () {
            return conexaoSQLite.Table<Categoria>().OrderBy(c => c.Nome).ToList();
        }
        public void Dispose () {
            conexaoSQLite.Dispose();
        }
    }        
}
