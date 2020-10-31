using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DAL_EAD_ProjetoDS
{
    public class Conexao
    {
        public static SqlConnection Conectar()
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = ProjetoDS_EAD; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
                    //Pegar o camninho na propriedade Banco
                    conn.Open();
                return conn;
            }
            catch
            {
                throw new Exception("Não foi possível conectar. Tente novamente!");
            }
        }

    }
}
