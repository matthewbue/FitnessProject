using AcademySistem.Domain.Model;
using AcademySistem.Infra.Context;
using AcademySistem.Infra.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademySistem.Infra.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AcademySistemContext _academySistemContext;
        public UserRepository(AcademySistemContext academySistemContext)
        {
            _academySistemContext = academySistemContext;
        }

        public User Create(User entrada)
        {
            _academySistemContext.Users.Add(entrada);
            _academySistemContext.SaveChanges();
            return entrada;
        }
        public async Task<List<User>> GetAll()
        {
            return _academySistemContext.Users.ToList();
        }
    }
}
