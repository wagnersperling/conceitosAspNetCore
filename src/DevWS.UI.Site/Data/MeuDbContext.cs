using DevWS.UI.Site.Models;
using Microsoft.EntityFrameworkCore;

namespace DevWS.UI.Site.Data
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions<MeuDbContext> options)
            : base(options)
        {         
        }
        public DbSet<Aluno> Alunos { get; set; }
    }
}
//----------------------------------
// add-migration "Inicial" -Verbose
// update-database -Verbose
//----------------------------------
// remove-migration
//----------------------------------
//para testar sem migration
//create table Alunos(
//Nome varchar(max)
//)
//alter table alunos add Email varchar(max)
//alter table alunos add DataNascimento datetime
//alter table alunos add Id UNIQUEIDENTIFIER PRIMARY KEY default NEWID()