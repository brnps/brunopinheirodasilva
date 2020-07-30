using Domain;
using Repository;
using System;
using System.Collections.Generic;

namespace BrunoPinheiroDaSilva.Models
{
    public class PatrimonioModel
    {   
        public List<PatrimonioDTO> ListarPatrimonio(int? id)
        {
            try
            {
                var patrimonioDB = new PatrimonioDAO();
                return patrimonioDB.ListarPatrimonio(id);
            }
            catch (Exception ex)
            {

                throw new Exception ($"Erro ao listar Patrimonio: Erro => {ex.Message}");
            }
        }

        public void Insert(PatrimonioDTO patrimonio) 
        {
            try
            {
                var patrimonioDB = new PatrimonioDAO();
                patrimonioDB.InsertPatrimonio(patrimonio);
            }
            catch (Exception ex)
            {

                throw new Exception($"Erro ao inserir Patrimonio: Erro => {ex.Message}");
            }
        }

        public void Update(PatrimonioDTO patrimonio)
        {
            try
            {
                var patrimonioDB = new PatrimonioDAO();
                patrimonioDB.UpdatePatrimonio(patrimonio);
            }
            catch (Exception ex)
            {

                throw new Exception($"Erro ao atualizar Patrimonio: Erro => {ex.Message}");
            }
        }

        public void Delete(int id)
        {
            try
            {
                var patrimonioDB = new PatrimonioDAO();
                patrimonioDB.DeletePatrimonio(id);
            }
            catch (Exception ex)
            {

                throw new Exception($"Erro ao deletar Patrimonio: Erro => {ex.Message}");
            }
        }
    }
}