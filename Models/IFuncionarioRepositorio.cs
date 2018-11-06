using System.Collections.Generic;

namespace WebApi_DotNetCore.Models
{
    public interface IFuncionarioRepositorio
    {
        void Add(Funcionario funcionario);
        IEnumerable<Funcionario> GetAll();
        Funcionario Find(long key);
        void Remove(long key);
        void Update(Funcionario funcionario);
    }
}