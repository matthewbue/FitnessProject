using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademySistem.Domain.DTO
{
    public class UserCreateDTO
    {
        public string Name { get; set; }
        public string Datadenascimento { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
