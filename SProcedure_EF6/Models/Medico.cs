using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SProcedure_EF6.Models
{
    public class Medico
    {
        //Key Data Annotations não é necessário
        //Informar class+ID
        public int medicoID { get; set; }
        public string nome { get; set; }
        public string celular { get; set; }

        public string especialidade { get; set; }

        public int rating { get; set; }

        public decimal preco { get; set; }
    }
}