using System;
using SQLite;


namespace myMoneyA.model {
    public class Categoria {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Nome { get; set; }

        public int CatPai { get; set; }

        public override string ToString () {
            return string.Format("{0} {1}", Nome, CatPai.ToString());
        }
    }
}
