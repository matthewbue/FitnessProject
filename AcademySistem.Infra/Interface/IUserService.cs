using AcademySistem.Domain.DTO;
using AcademySistem.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademySistem.Infra.Interface
{
    public interface IUserService
    {
        ReturnDefault Create(UserCreateDTO entrada);
    }
}
