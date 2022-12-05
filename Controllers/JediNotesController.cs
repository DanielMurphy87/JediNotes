using JediNotes.Models;
using JediNotes.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JediNotes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JediNotesController : ControllerBase
    {
        IJediNoteService _jediService;

        public JediNotesController(IJediNoteService jediService)
        {
            _jediService = jediService;
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult GetAllNotes()
        {
            try
            {
                var notes = _jediService.GetJediNotes();
                if (notes == null)
                {
                    return NotFound();
                }
                return Ok(notes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]/owner")]
        public IActionResult GetAllNotes(string owner)
        {
            try
            {
                var notes = _jediService.GetJediNotes(owner);
                if (notes == null)
                {
                    return NotFound();
                }
                return Ok(notes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult GetJediNotesOrdered(string order)
        {
            try
            {
                var notes = _jediService.GetJediNotesOrdered(order);
                if (notes == null)
                {
                    return NotFound();
                }
                return Ok(notes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult GetNoteByID(int id)
        {
            try
            {
                var note = _jediService.GetNote(id);
                if(note == null)
                {
                    return NotFound();
                }
                return Ok(note);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult SaveNote(JediNote jediModel)
        {
            try
            {
                var model = _jediService.SaveNote(jediModel);
                return Ok(model);
            }
            catch(Exception)
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        [Route("[action]")]
        public IActionResult DeleteNote(int id)
        {
            try
            {
                var model = _jediService.DeleteNote(id);
                return Ok(model);
            }
            catch(Exception)
            {
                return BadRequest();
            }
        }
    }
}
