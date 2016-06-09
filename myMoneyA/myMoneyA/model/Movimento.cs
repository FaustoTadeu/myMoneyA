using System;
using SQLite;


namespace myMoneyA.model {
    public class Movimento {

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(200)]
        public string Descricao { get; set; }

        public string Tipo { get; set; }

        public DateTime Data { get; set; }

        public double Valor { get; set; }

        public int Conta_fk { get; set; }

        public int Categoria_fk { get; set; }

        public override string ToString () {
            return string.Format("{0} {1} {2} {3} {4} {5} {6}", Descricao, Tipo, Data, Valor, Conta_fk, Categoria_fk);
        }
    }
}
