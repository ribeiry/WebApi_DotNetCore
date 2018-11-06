using Microsoft.EntityFrameworkCore;

namespace WebApi_DotNetCore.Models
{
    public class FuncionarioContext : DbContext
    {
        public FuncionarioContext(DbContextOptions<FuncionarioContext> options)
        :base(options)
        {

        }
        public DbSet<Funcionario> Funcionarios {get; set;}
    }
}