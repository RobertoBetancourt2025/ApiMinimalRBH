using ApiMinimalRBH.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiMinimalRBH.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class SumaController : ControllerBase
    {
        private ISumaService _sumaService;

        public SumaController(ISumaService sumaService)
        {
            _sumaService = sumaService;
        }

        [HttpGet(Name ="SumaGet")]
        public string GetSuma(int numero1, int numero2)
        {
            return _sumaService.GetSuma(numero1,numero2);
        }
    }
}
