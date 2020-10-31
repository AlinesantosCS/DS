using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_EAD_ProjetoDS;
using System.Data;
using System.Data.SqlClient;

namespace DAL_EAD_ProjetoDS
{
    public class DAL_Login
    {
        public static string ValidarLogin(DTO_Login obj)
        {
            try
                //Inicia o bloco de tratamento de exception
            {
                string script = "SELECT * FROM Usuario WHERE(userName = @login OR email = @login) AND senha = @senha AND ativo = 'ativo';";
                // Cria a string com consulta de sql

                SqlCommand cm = new SqlCommand(script, Conexao.Conectar());
                //Cria o comando para rodar a instrução, passando instrução sql e conexão

                cm.Parameters.AddWithValue("@login", obj.Usuario);
                cm.Parameters.AddWithValue("@senha", obj.Senha);
                // Substitui as váriaveis na instrução sql pelos valores digitados pelo usuário

                SqlDataReader dados = cm.ExecuteReader();
                // Roda a instrução sql e atribui resultado no SqlDataReader

                while(dados.Read())
                    // Lê a próxima linha do resultado da sua instrução
                {
                    if (dados.HasRows)
                        // Verifica se existe a linha com as credenciais
                    {
                        return "Sucesso";
                    }
                }
                return ("Credenciais Inválidas");
            }
            catch(Exception ex)
            // Esse bloco é executado caso aconteça exceção no bloco try
            {
                //ex = new Exception("erro");
                throw new Exception(ex.Message);
            }
            finally
            {
                if (Conexao.Conectar().State != ConnectionState.Closed)
                {
                    Conexao.Conectar().Close();
                }
            }
        }
    }
}
