using Domain;
using Repository;
using System;
using System.Collections.Generic;

namespace BrunoPinheiroDaSilva.Models
{
    public class MarcaModel
    {   
        public List<MarcaDTO> ListarMarca(int? id = null)
        {
            try
            {
                var marcaDB = new MarcaDAO();
                return marcaDB.ListarMarca(id);
            }
            catch (Exception ex)
            {

                throw new Exception ($"Erro ao listar Marca: Erro => {ex.Message}");
            }
        }
        public List<PatrimonioDTO> ListarMarcaPatrimonio(int? id = null)
        {
            try
            {
                var patrimonioDB = new PatrimonioDAO();
                return patrimonioDB.ListarPatrimonioMarca(id);
            }
            catch (Exception ex)
            {

                throw new Exception($"Erro ao listar Marca: Erro => {ex.Message}");
            }
        }

        public void Insert(MarcaDTO marca) 
        {
            try
            {
                var marcaDB = new MarcaDAO();
                marcaDB.InsertMarca(marca);
            }
            catch (Exception ex)
            {

                throw new Exception($"Erro ao inserir Marca: Erro => {ex.Message}");
            }
        }

        public void Update(MarcaDTO marca)
        {
            try
            {
                var marcaDB = new MarcaDAO();
                marcaDB.UpdateMarca(marca);
            }
            catch (Exception ex)
            {

                throw new Exception($"Erro ao atualizar Marca: Erro => {ex.Message}");
            }
        }

        public void Delete(int id)
        {
            try
            {
                var marcaDB = new MarcaDAO();
                marcaDB.DeleteMarca(id);
            }
            catch (Exception ex)
            {

                throw new Exception($"Erro ao deletar Marca: Erro => {ex.Message}");
            }
        }
    }
}