using System;
using SQLite;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using myMoneyA.model;

namespace myMoneyA.controller {

    public class BDConta : IDisposable {

        private SQLiteConnection conexaoSQLite;

        public BDConta () {
            conexaoSQLite = new SQLiteConnection(Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "mymoney"));

            conexaoSQLite.CreateTable<Conta>();
        }
        public void InserirConta (Conta ct) {
            conexaoSQLite.Insert(ct);
        }
        public void AtualizarConta (Conta ct) {
            conexaoSQLite.Update(ct);
        }
        public void DeletarConta (Conta ct) {
            conexaoSQLite.Delete(ct);
        }
        public Conta GetContaId (int codigo) {
            return conexaoSQLite.Table<Conta>().FirstOrDefault(c => c.Id == codigo);
        }
        public List<Conta> GetContas () {
            return conexaoSQLite.Table<Conta>().OrderBy(c => c.Tipo).ToList();
        }
       public void Dispose () {
            conexaoSQLite.Dispose();
        }
    }
}