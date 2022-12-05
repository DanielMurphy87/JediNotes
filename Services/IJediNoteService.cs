using JediNotes.Models;
using JediNotes.ViewModels;


namespace JediNotes.Services
{
    public interface IJediNoteService
    {
        List<JediNote> GetJediNotes();

        List<JediNote> GetJediNotes(string owner);

        List<JediNote> GetJediNotesOrdered(string order);

        JediNote GetNote(int id);

        ResponseModel SaveNote(JediNote note);

        ResponseModel DeleteNote(int id);

    }
}
