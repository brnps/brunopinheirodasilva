using BrunoPinheiroDaSilva.Models;
using Domain;
using System;
using System.Linq;
using System.Web.Http;

namespace BrunoPinheiroDaSilva.Controllers
{
    public class PatrimonioController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get()
        {
            try
            
           {
                PatrimonioModel patrimonio = new PatrimonioModel();
                return Ok(patrimonio.ListarPatrimonio(null));
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
                PatrimonioModel patrimonio = new PatrimonioModel();
                return Ok(patrimonio.ListarPatrimonio(id).FirstOrDefault());
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }

        }

        [HttpPost]
        public IHttpActionResult Post(PatrimonioDTO patrimonio)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                PatrimonioModel _patrimonio = new PatrimonioModel();
                _patrimonio.Insert(patrimonio);

                return Ok(_patrimonio.ListarPatrimonio(null));
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }
            
        }

        [HttpPut]
        public IHttpActionResult Put(int id, [FromBody]PatrimonioDTO patrimonio)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                PatrimonioModel _patrimonio = new PatrimonioModel();
                patrimonio.Id = id;
                _patrimonio.Update(patrimonio);

                return Ok(_patrimonio.ListarPatrimonio(id).FirstOrDefault());
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
                PatrimonioModel _patrimonio = new PatrimonioModel();
                _patrimonio.Delete(id);
                return Ok("Deletado com Sucesso");
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }

        }
    }
}
