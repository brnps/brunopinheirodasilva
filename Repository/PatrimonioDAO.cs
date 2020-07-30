using Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Repository
{
    public class PatrimonioDAO
    {
        public string stringConnection = ConfigurationManager.ConnectionStrings["Dev"].ConnectionString;
        public IDbConnection connection;
        public PatrimonioDAO()
        {            
            connection = new SqlConnection(stringConnection);
            connection.Open();
        }

        public List<PatrimonioDTO> ListarPatrimonio(int? id)
        {
            var listaPatrimonio = new List<PatrimonioDTO>();
            try
            {                
                IDbCommand selectCmd = connection.CreateCommand();

                if (id == null)
                    selectCmd.CommandText = "SELECT * FROM Patrimonio";
                else
                    selectCmd.CommandText = $"SELECT * FROM Patrimonio WHERE ID = {id}";

                IDataReader result = selectCmd.ExecuteReader();
                while (result.Read())
                {
                    var pat = new PatrimonioDTO
                    {
                        Id = Convert.ToInt32(result["Id"]),
                        Nome = Convert.ToString(result["Nome"]),
                        MarcaId = Convert.ToInt32(result["MarcaId"]),
                        Descricao = Convert.ToString(result["Descricao"]),
                        NumeroTombo = Convert.ToInt32(result["NumeroTombo"])
                    };

                listaPatrimonio.Add(pat);

                }

                return listaPatrimonio;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally 
            {
                connection.Close();
            }            
        }

        public List<PatrimonioDTO> ListarPatrimonioMarca(int? id)
        {
            var listaPatrimonio = new List<PatrimonioDTO>();
            try
            {
                IDbCommand selectCmd = connection.CreateCommand();
                selectCmd.CommandText = $"SELECT P.Id, P.Nome, P.MarcaId, P.Descricao, P.NumeroTombo FROM Marca M LEFT JOIN Patrimonio P ON M.MarcaId = P.MarcaId WHERE P.MarcaId = {id}";


                IDataReader result = selectCmd.ExecuteReader();
                while (result.Read())
                {
                    var pat = new PatrimonioDTO
                    {
                        Id = Convert.ToInt32(result["Id"]),
                        Nome = Convert.ToString(result["Nome"]),
                        MarcaId = Convert.ToInt32(result["MarcaId"]),
                        Descricao = Convert.ToString(result["Descricao"]),
                        NumeroTombo = Convert.ToInt32(result["NumeroTombo"])
                    };

                    listaPatrimonio.Add(pat);
                }

                return listaPatrimonio;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public void InsertPatrimonio(PatrimonioDTO patrimonio)
        {
            try
            {
                IDbCommand insertCmd = connection.CreateCommand();
                insertCmd.CommandText = "INSERT INTO Patrimonio (Nome, MarcaId, Descricao, NumeroTombo) VALUES (@Nome, @MarcaId, @Descricao, @NumeroTombo)";

                IDbDataParameter paramNome = new SqlParameter("Nome", patrimonio.Nome);
                insertCmd.Parameters.Add(paramNome);
                IDbDataParameter paramMarcaId = new SqlParameter("MarcaId", patrimonio.MarcaId);
                insertCmd.Parameters.Add(paramMarcaId);
                IDbDataParameter paramDescricao = new SqlParameter("Descricao", patrimonio.Descricao);
                insertCmd.Parameters.Add(paramDescricao);
                IDbDataParameter paramNumeroTombo = new SqlParameter("NumeroTombo", patrimonio.NumeroTombo);
                insertCmd.Parameters.Add(paramNumeroTombo);

                insertCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }            
        }
        public void UpdatePatrimonio(PatrimonioDTO patrimonio)
        {
            try
            {
                IDbCommand updateCmd = connection.CreateCommand();
                updateCmd.CommandText = "UPDATE Patrimonio SET Nome = @Nome, MarcaId = @MarcaId, Descricao = @Descricao, NumeroTombo = @NumeroTombo WHERE ID = @id";

                IDbDataParameter paramNome = new SqlParameter("Nome", patrimonio.Nome);
                updateCmd.Parameters.Add(paramNome);
                IDbDataParameter paramMarcaId = new SqlParameter("MarcaId", patrimonio.MarcaId);
                updateCmd.Parameters.Add(paramMarcaId);
                IDbDataParameter paramDescricao = new SqlParameter("Descricao", patrimonio.Descricao);
                updateCmd.Parameters.Add(paramDescricao);
                IDbDataParameter paramNumeroTombo = new SqlParameter("NumeroTombo", patrimonio.NumeroTombo);
                updateCmd.Parameters.Add(paramNumeroTombo);

                IDbDataParameter paramId = new SqlParameter("Id", patrimonio.Id);
                updateCmd.Parameters.Add(paramId);

                updateCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }            
        }
        public void DeletePatrimonio(int id)
        {
            try
            {
                IDbCommand deleteCmd = connection.CreateCommand();
                deleteCmd.CommandText = "DELETE FROM Patrimonio WHERE ID = @id";

                IDbDataParameter paramId = new SqlParameter("Id", id);
                deleteCmd.Parameters.Add(paramId);

                deleteCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }            
        }
    }
}