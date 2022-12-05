using JediNotes.Models;
using JediNotes.ViewModels;

namespace JediNotes.Services
{
    public class JediNoteService : IJediNoteService
    {
        private NoteContext _context;

        public JediNoteService(NoteContext context)
        {
            _context = context;
        }

        public List<JediNote> GetJediNotes()
        {
            List<JediNote> jediNotes = new List<JediNote>();

            try
            {
                jediNotes = _context.Set<JediNote>().ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return jediNotes;
        }

        public List<JediNote> GetJediNotes(string owner)
        {
            List<JediNote> jediNotes = new List<JediNote>();

            try
            {
                jediNotes = _context.JediNote.Where(x => x.Owner == owner).ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return jediNotes;
        }

        public List<JediNote> GetJediNotesOrdered(string order)
        {
            List<JediNote> jediNotes = new List<JediNote>();

            try
            {
                if(string.Equals(order, "asc", StringComparison.OrdinalIgnoreCase))
                {
                    jediNotes = _context.JediNote.OrderBy(x => x.Created).ToList();
                }
                if (string.Equals(order, "desc", StringComparison.OrdinalIgnoreCase))
                {
                    jediNotes = _context.JediNote.OrderByDescending(x => x.Created).ToList();
                }
                else
                {
                    jediNotes = _context.Set<JediNote>().ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return jediNotes;
        }

        public JediNote GetNote(int id)
        {
            JediNote jediNote = new JediNote();

            try
            {
                jediNote = _context.Find<JediNote>(id);
            }
            catch (Exception)
            {
                throw;
            }

            return jediNote;
        }

        public ResponseModel SaveNote(JediNote jediNote)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                JediNote _temp = GetNote(jediNote.ID);
                if (_temp != null)
                {
                    _temp.ID = jediNote.ID;
                    _temp.Title = jediNote.Title;
                    _temp.Body = jediNote.Body;
                    _temp.Created = jediNote.Created;
                    _temp.Updated = DateTime.Now;
                    _temp.Owner = jediNote.Owner;
                    _temp.JediRank = jediNote.JediRank;

                    _context.Update<JediNote>(_temp);
                    model.Message = "Updated the note successfully";
                }
                else
                {
                    _context.Add<JediNote>(jediNote);
                    model.Message = "Added the note successfully";
                }

                _context.SaveChanges();
                model.IsSuccess = true;
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Message = "Error : " + ex.Message;
            }
            return model;
        }

        public ResponseModel DeleteNote(int id)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                JediNote _temp = GetNote(id);
                if( _temp != null)
                {
                    _context.Remove<JediNote>(_temp);
                    _context.SaveChanges();
                    model.IsSuccess = true;
                    model.Message = "Note deleted successfully";
                }
                else
                {
                    model.IsSuccess = false;
                    model.Message = "Note is not found";
                }
            }
            catch(Exception ex)
            {
                model.IsSuccess = false;
                model.Message = "Error : " + ex.Message;
            }

            return model;
        }

    }
}
