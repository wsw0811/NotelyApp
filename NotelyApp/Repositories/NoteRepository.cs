using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotelyApp.Models;

namespace NotelyApp.Repositories
{
    public class NoteRepository : INoteRepository
    {
        private readonly List<NoteModel> _notes;

        public NoteRepository()
        {
            _notes = new List<NoteModel>();
        }

        public NoteModel FindNoteById(Guid id)
        {
            var note = _notes.Find(n => n.Id == id);

            return note;
        }

        public List<NoteModel> FindNoteBySubject(string subject = null)
        {
            var note = _notes.FindAll(n => n.Subject == subject);
            return note;
        } 
        public IEnumerable<NoteModel> GetAllNotes()
        {
            return _notes;
        }

        public void SaveNote(NoteModel noteModel)
        {
            noteModel.Id = Guid.NewGuid();
            _notes.Add(noteModel);
        }
        
        public NoteModel EditNote(Guid id) 
        {
            NoteModel noteModel = new NoteModel();
            var note = _notes.Find(n => n.Id == id);
            note.Subject = noteModel.Subject;
            note.Detail = noteModel.Detail;
            return note;
        }

        public void DeleteNote(NoteModel noteModel)
        {
            _notes.Remove(noteModel);
        }
    }
}
