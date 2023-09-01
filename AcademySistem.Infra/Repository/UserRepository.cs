using AcademySistem.Domain.Model;
using AcademySistem.Infra.Context;
using AcademySistem.Infra.Interface;
using Microsoft.EntityFrameworkCore;
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

        public User GetById(int entrada)
        {
            var result =_academySistemContext.Users.Where(x => x.Id == entrada).FirstOrDefault();
            return result;
        }

        public void Update(User entrada)
        {
            _academySistemContext.Entry(entrada).State = EntityState.Modified;
            _academySistemContext.SaveChanges();
        }
    }
}
