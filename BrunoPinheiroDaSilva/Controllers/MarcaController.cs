using BrunoPinheiroDaSilva.Models;
using Domain;
using System;
using System.Linq;
using System.Web.Http;

namespace BrunoPinheiroDaSilva.Controllers
{
    public class MarcaController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get()
        {
            try
            {
                MarcaModel marca = new MarcaModel();
                return Ok(marca.ListarMarca());
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }            
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            try
            {
                MarcaModel marca = new MarcaModel();
                return Ok(marca.ListarMarca(id).FirstOrDefault());
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }

        }
        [HttpGet]
        [Route("api/Marca/{id}/patrimonios")]
        public IHttpActionResult GetPatrimonioMarca(int id)
        {
            try
            {
                MarcaModel marca = new MarcaModel();
                return Ok(marca.ListarMarcaPatrimonio(id));
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }

        }

        [HttpPost]
        public IHttpActionResult Post(MarcaDTO marca)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                MarcaModel _marca = new MarcaModel();
                _marca.Insert(marca);

                return Ok(_marca.ListarMarca());
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }
            
        }

        [HttpPut]
        public IHttpActionResult Put(int id, [FromBody]MarcaDTO marca)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                MarcaModel _marca = new MarcaModel();
                marca.MarcaId = id;
                _marca.Update(marca);

                return Ok(_marca.ListarMarca(id).FirstOrDefault());
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }
            
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                MarcaModel _marca = new MarcaModel();
                _marca.Delete(id);
                return Ok("Deletado com Sucesso");
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }

        }
    }
}
