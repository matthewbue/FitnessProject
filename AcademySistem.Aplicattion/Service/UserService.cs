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

        public ReturnDefault GetById(int entrada)
        {
            var result = _userRepository.GetById(entrada);
            return new ReturnDefault("Lista retornada com sucesso", result);
        }

        public ReturnDefault Update(UserUpdateDTO entrada)
        {
            var result = _userRepository.GetById(entrada.Id);
            if (!string.IsNullOrEmpty(entrada.Telefone))
            {
                result.Telefone = entrada.Telefone;
            }
            if (!string.IsNullOrEmpty(entrada.Cpf))
            {
                result.Cpf = entrada.Cpf;
            }
            if (!string.IsNullOrEmpty(entrada.Email))
            {
                result.Email = entrada.Email;
            }
            if (!string.IsNullOrEmpty(entrada.Name))
            {
               result.Name = entrada.Name;
            }
            if (!string.IsNullOrEmpty(entrada.Datadenascimento))
            {
                result.Datadenascimento = entrada.Datadenascimento;
            }
            if (!string.IsNullOrEmpty(entrada.Senha))
            {
                result.Senha = entrada.Senha;
            }
            _userRepository.Update(result);
            return new ReturnDefault("Modificado com sucesso.", result);
        }
    }
}
