using DependencyInversion.Interfaces;

// Realização da inversão de controle na classe RecuperarSenha e tirando a responsabildade da classe MySqlConnection
namespace DependencyInversion.Infra
{
    public class RecuperarSenha
    {
        private IDataBaseConnection conexaoBanco;

        public RecuperarSenha(IDataBaseConnection dataBaseConnection)
        {
            conexaoBanco = dataBaseConnection;
        }
        //codigo para realizar as operações
    }
}