using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Cors;
using Microsoft.AspNetCore.Mvc;
using SmartLink.DataModel.Model;
using SmartLink.DataModel.ModelVM;
using SmartLink.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartLink.WebUI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class AlbumsController : ControllerBase
    {
        private readonly Muzicup_RBTContext _context;
        private readonly IDataRepository<Track> _repo;
        public AlbumsController(Muzicup_RBTContext context, IDataRepository<Track> repo)
        {
            _context = context;
            _repo = repo;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<LandingPageTrackCard_VM> Get(string searchWord)
        {

            var data = _context.Album.Select(ex => new LandingPageTrackCard_VM
            {
                AlbumId = ex.Id,
                AlbumRoutingName =  ex.RoutingName.ToString().Replace(" ", String.Empty),
                AlbumName = ex.NameEn.ToString().Replace(" ", String.Empty),
                ArtistName = ex.Artist.NameEn.ToString().Replace(" ", String.Empty),
                AlbumImagePath = "https://api.muzicup.com//Portal/5/Content/" + ex.Image.FileData.FilePath,

            }).Take(16).ToList();
            return data;
        }

    }
}
