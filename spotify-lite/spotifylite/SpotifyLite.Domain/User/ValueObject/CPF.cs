using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyLite.Domain.User.ValueObject
{
    public class CPF
    {

        public CPF(string cpf)
        {
            this.Value = value?.Replace(".", "").Replace("-", "") ?? throw new ArgumentNullException(nameof(CPF));
        }

        public String Value { get; set; }
            
        }

        public string Value { get; private set; }

    }
}
