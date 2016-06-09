using System;
using SQLite;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using myMoneyA.model;

namespace myMoneyA.controller {

    public class BDMovimento : IDisposable {

        private SQLiteConnection conexaoSQLite;

        public BDMovimento () {
            conexaoSQLite = new SQLiteConnection(Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "mymoney"));

           conexaoSQLite.CreateTable<Movimento>();
        }
        public void InserirMovimento (Movimento mov) {
            conexaoSQLite.Insert(mov);
        }
        public void AtualizarMovimento (Movimento mov) {
            conexaoSQLite.Update(mov);
        }
        public void DeletarMovimento (Movimento mov) {
            conexaoSQLite.Delete(mov);
        }
        public Movimento GetMovimento (int codigo) {
            return conexaoSQLite.Table<Movimento>().FirstOrDefault(c => c.Id == codigo);
        }
        public List<Movimento> GetMovimentos () {
            return conexaoSQLite.Table<Movimento>().OrderBy(c => c.Descricao).ToList();
        }
        public void Dispose () {
            conexaoSQLite.Dispose();
        }
    }
}