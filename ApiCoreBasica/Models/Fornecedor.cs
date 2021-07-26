using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCoreBasica.Models
{
    public class Fornecedor
    {
        public Guid Id { get; set; }  
        public string Nome { get; set; }
        public string Documento { get; set; }
        public int TipoFornecedor { get; set; }
        public bool Ativo { get; set; }
    }
}
