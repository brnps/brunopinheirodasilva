using Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;

namespace Repository
{
    public class MarcaDAO
    {
        public string stringConnection = ConfigurationManager.ConnectionStrings["Dev"].ConnectionString;
        public IDbConnection connection;
        public MarcaDAO()
        {            
            connection = new SqlConnection(stringConnection);
            connection.Open();
        }

        public List<MarcaDTO> ListarMarca(int? id)
        {
            var listaMarca = new List<MarcaDTO>();
            try
            {                
                IDbCommand selectCmd = connection.CreateCommand();

                if (id == null)
                    selectCmd.CommandText = "SELECT * FROM Marca";
                else
                    selectCmd.CommandText = $"SELECT * FROM Marca WHERE MarcaId = {id}";

                IDataReader result = selectCmd.ExecuteReader();
                while (result.Read())
                {                    
                    var mar = new MarcaDTO
                    {
                        MarcaId = Convert.ToInt32(result["MarcaId"]),
                        Nome = Convert.ToString(result["Nome"]),
                    };

                    listaMarca.Add(mar);

                }

                return listaMarca;
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

        public void InsertMarca(MarcaDTO marca)
        {
            try
            {
                IDbCommand insertCmd = connection.CreateCommand();
                insertCmd.CommandText = "INSERT INTO Marca (MarcaId, Nome) VALUES (@MarcaId, @Nome)";

                IDbDataParameter paramMarcaId = new SqlParameter("MarcaId", marca.MarcaId);
                insertCmd.Parameters.Add(paramMarcaId);
                IDbDataParameter paramNome = new SqlParameter("Nome", marca.Nome);
                insertCmd.Parameters.Add(paramNome);                

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
        public void UpdateMarca(MarcaDTO marca)
        {
            try
            {
                IDbCommand updateCmd = connection.CreateCommand();
                updateCmd.CommandText = "UPDATE Marca SET MarcaId = @MarcaId, Nome = @Nome WHERE MarcaId = @MarcaId";

                IDbDataParameter paramMarcaId = new SqlParameter("MarcaId", marca.MarcaId);
                updateCmd.Parameters.Add(paramMarcaId);
                IDbDataParameter paramNome = new SqlParameter("Nome", marca.Nome);
                updateCmd.Parameters.Add(paramNome);

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
        public void DeleteMarca(int id)
        {
            try
            {
                IDbCommand deleteCmd = connection.CreateCommand();
                deleteCmd.CommandText = "DELETE FROM Marca WHERE MarcaId = @Id";

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