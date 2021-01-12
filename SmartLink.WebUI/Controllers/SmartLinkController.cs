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
    public class SmartLinkController : ControllerBase
    {
        private readonly Muzicup_RBTContext _context;
        private readonly IDataRepository<Content1> _repo;
        public SmartLinkController(Muzicup_RBTContext context, IDataRepository<Content1> repo)
        {
            _context = context;
            _repo = repo;
        }
       
        [HttpGet("{id}")]
        public IActionResult GetContent([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var contentHyperLinks = _context.ContentHyperLinks.ToList();
            var data = _context.Content1.Where(ex => ex.AlbumId == id).Select(z => new SmartLinkVM
            {
                ArtistName = z.Artist.NameEn,
                ContentName = z.NameEn,
                AlbumName = z.Album.NameEn,
                TrackUrl = "https://api.muzicup.com//Portal/5/Content/"+z.Track.FileData.FilePath,
                ImageUrl = "https://api.muzicup.com//Portal/5/Content/" + z.Image.FileData.FilePath,
                ContentId = z.Id,
                Channels = Channels(z.Id , contentHyperLinks)
            }).FirstOrDefault();

            if (data == null)
            {
                return NotFound();
            }

            return Ok(data);
        }
        public List<ChannelVM> Channels(int ContentId , List<ContentHyperLinks> lst)
        {

            var data = lst.Where(z => z.ContentId == ContentId).ToList();
            if (data != null)
            {
                var dt = data.Select(ex => new ChannelVM
                {
                    ChannelLogo = "https://api.muzicup.com//Portal/5/Content/" + ex.Channel.LogoPath,
                    ChannelName = ex.Channel.DisplayName,
                    TrackUrl = ex.Url

                }).ToList();
                return dt;
            }
            else
            {
                return new List<ChannelVM>();
            }
        }


    }
}
