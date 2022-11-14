using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace app_diario.Models
{
    public class nota
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Titulo { get; set; }
        public string Texto { get; set; }
        public DateTime Data { get; set; }

    }
}
