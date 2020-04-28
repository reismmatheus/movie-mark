using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieMark.Models
{
    public class AdminViewModels
    {
        public class AdminCreateViewModel
        {
            public string Email { get; set; }
            public string Senha { get; set; }
            public string ConfirmacaoSenha { get; set; }
            public string TipoConta { get; set; }

        }
    }
}
