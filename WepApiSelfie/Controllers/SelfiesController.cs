using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SelfieAwokie.Domain;
using SelfieAwookie.Infrastructure.Data;
using System.Collections.Generic;
using System.Linq;


namespace WepApiSelfie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SelfiesController : ControllerBase
    {
        #region Properties
        private readonly ISelfieRepository _repository;
        #endregion
        #region constructor
        public SelfiesController(ISelfieRepository repository)
        {
            _repository = repository;
        }
        #endregion
        #region Get
        /*
        [HttpGet]
        
        public IEnumerable<Selfie> TestAMoi()
        {
            return Enumerable.Range(1, 10).Select(item => new Selfie() { Id = item });
        }
        */
        [HttpGet]
        public IActionResult TestAMoi()
        {
            var selfieList = this._repository.GetAll();
            var model = selfieList.Select(item => new { Title = item.Title, WookieId = item.Wookie.Id, NbSelfieFromWookie = item.Wookie.Selfies.Count});
            return this.Ok(model);
        }
        #endregion
    }
}
