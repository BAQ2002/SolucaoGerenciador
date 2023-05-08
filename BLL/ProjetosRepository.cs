using MODEL;
using DAL.DBContext;
using Microsoft.IdentityModel.Tokens;

namespace BLL
{
    public static class ProjetosRepository
    {
        public static void Add(Projeto _projeto)
        {
            using (var dbContext = new CUsersAntonSourceReposSolucaogerenciadorDalDatabaseDatabaseMdfContext())
            {
                dbContext.Add(_projeto);
                dbContext.SaveChanges();
            }
        }

        public static Projeto GetById(int Id)
        {
            using (var dbContext = new CUsersAntonSourceReposSolucaogerenciadorDalDatabaseDatabaseMdfContext())
            {
                var projeto = dbContext.Projetos.Single(P => P.Id == Id);
                return projeto;
            }
        }

        public static List<Projeto> GetAll()
        {
            using (var dbContext = new CUsersAntonSourceReposSolucaogerenciadorDalDatabaseDatabaseMdfContext())
            {
                var projeto = dbContext.Projetos.ToList();
                return projeto;
            }
        }

        public static void Update(Projeto _projeto)
        {
            using (var dbContext = new CUsersAntonSourceReposSolucaogerenciadorDalDatabaseDatabaseMdfContext())
            {
                var projeto = dbContext.Projetos.Single(P => P.Id == _projeto.Id);
                if (!_projeto.Gerente.IsNullOrEmpty())
                {
                    projeto.Gerente = _projeto.Gerente;
                }

                if (!_projeto.DataFinal.ToString().IsNullOrEmpty()) { 
                    projeto.DataFinal = _projeto.DataFinal;
                }

                if (!_projeto.Status.IsNullOrEmpty()) { 
                    projeto.Status = _projeto.Status;
                }

                dbContext.SaveChanges();
            }

        }

        public static void Excluir(Projeto _projeto)
        {
            using (var dbContext = new CUsersAntonSourceReposSolucaogerenciadorDalDatabaseDatabaseMdfContext())
            {
                var projeto = dbContext.Projetos.Single(P => P.Id == _projeto.Id);
                dbContext.Remove(projeto);
                dbContext.SaveChanges();
            }
        }

    }
}