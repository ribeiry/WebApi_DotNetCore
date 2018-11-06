using System.Collections.Generic;
using System.Linq;

namespace WebApi_DotNetCore.Models
{
    public class FuncionarioRepositorio : IFuncionarioRepositorio
    {
        private readonly FuncionarioContext _context;

        public FuncionarioRepositorio(FuncionarioContext context)
        {
            _context = context;
            Add(new Funcionario{Nome = "Item1"});
        }
        public IEnumerable<Funcionario> GetAll()
        {
            return _context.Funcionarios.ToList();
        }
        public void Add(Funcionario funcionario)
        {
            _context.Funcionarios.Add(funcionario);
            _context.SaveChanges();
        }
        public Funcionario Find(long key)
        {
            return _context.Funcionarios.FirstOrDefault(t => t.Chave == key);
        }
        public void Remove(long key)
        {
            var entity = _context.Funcionarios.First(t => t.Chave == key);
            _context.Funcionarios.Remove(entity);
            _context.SaveChanges();
        }
        public void Update(Funcionario funcionario)
        {
            _context.Funcionarios.Update(funcionario);
            _context.SaveChanges();
        }
    }
}