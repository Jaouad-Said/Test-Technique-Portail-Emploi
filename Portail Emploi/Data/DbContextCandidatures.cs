using Microsoft.EntityFrameworkCore;
using Portail_Emploi.Models;

namespace Portail_Emploi.Data
{
    public class DbContextCandidatures: DbContext
    {
        public DbContextCandidatures(DbContextOptions<DbContextCandidatures> options) : base(options)
        {

        }

        public DbSet<Candidat> Candidats { get; set; }
        public DbSet<Resume> Resumes { get; set; }
    }
}
