using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SelfieAwokie.Domain;
using System.Collections.Generic;
using System.Linq;


namespace WepApiSelfie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SelfiesController : ControllerBase
    {
        #region Get
        [HttpGet]
        public IEnumerable<Selfie> TestAMoi()
        {
            return Enumerable.Range(1, 10).Select(item => new Selfie() { Id = item });
        }
        #endregion
    }
}
