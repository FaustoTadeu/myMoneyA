using System;
using SQLite;


namespace myMoneyA.model {

    public class Conta {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Tipo { get; set; }


        public override string ToString () {
            return string.Format("{0}", Tipo);
        }
    }
}