using ApiHospitalesAzure2023.Models;
using ApiHospitalesAzure2023.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiHospitalesAzure2023.Controllers
{
    //PARA ACCEDER A LA URL: http://servicioapi.com/api/hospitales
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalesController : ControllerBase
    {
        private RepositoryHospital repo;

        public HospitalesController(RepositoryHospital repo)
        {
            this.repo = repo;
        }

        //IMPLEMENTAMOS LOS METODOS

        //ESTE METODO GET SE VA A EJECUTAR CUANDO PONGA LA RUTA: api/controller
        //http://servicioapi.com/api/hospitales
        [HttpGet]
        public ActionResult<List<Hospital>> GetHospitales()
        {
            return this.repo.GetHospitales();
        }

        //http://servicioapi.com/api/hospitales/ID
        [HttpGet("{id}")]
        public ActionResult<Hospital> FindHospital(int id)
        {
            return this.repo.FindHospital(id);
        }



    }
}
