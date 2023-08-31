using AcademySistem.Domain.DTO;
using AcademySistem.Domain.Model;
using AcademySistem.Infra.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademySistem.Aplicattion.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public ReturnDefault Create(UserCreateDTO entrada)
        {
            var Objetouser = new User();
            Objetouser.Telefone = entrada.Telefone;
            Objetouser.Senha = entrada.Senha;
            Objetouser.Name = entrada.Name;
            Objetouser.Email = entrada.Email;
            Objetouser.Datadenascimento = entrada.Datadenascimento;
            Objetouser.Cpf = entrada.Cpf;
            _userRepository.Create(Objetouser);
            return new ReturnDefault("Criado com sucesso.", Objetouser);
        }
        public ReturnDefault GetAll()
        {
            var result = _userRepository.GetAll();
            return new ReturnDefault("Sucesso", result);
        }
        public ReturnDefault Delete(int entrada)
        {
            _userRepository.Delete(entrada);
            return new ReturnDefault("Sucesso", "");
        }
    }
}
