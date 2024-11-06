using Assessment3.Note_Repository;
using Assessment3.NoteModel;
using Assessment3.Loggers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Assessment3.Operation
{
    public class Operations
    {
        private readonly NoteRepository noteRepository;

        public Operations()
        {
            noteRepository = new NoteRepository();
        }

        public void CreateNote()
        {
            try
            {
                Console.WriteLine("Enter the title of the note:");
                string title = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(title))
                {
                    Console.WriteLine("Enter a valid title");
                    Logger.LogError("Title was invalid in Creation method.");
                    return;
                }

                Console.WriteLine("Enter the content:");
                string content = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(content))
                {
                    Console.WriteLine("Content can't be empty");
                    Logger.LogError("Content was empty in Creation method.");
                    return;
                }

                var notes = new Note
                {
                    Title = title,
                    Content = content,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };

                noteRepository.CreateNote(notes);
                Console.WriteLine("Created successfully!");
                Logger.LogInfo($"Note created: {title}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred.");
                Logger.LogError("Error in Creation method", ex);
            }
        }

        public void ViewNotes()
        {
            try
            {
                var notes = noteRepository.GetAllNotes();

                if (notes == null || notes.Count == 0)
                {
                    Console.WriteLine("List of notes is empty");
                    Logger.LogInfo("No notes found.");
                }
                else
                {
                    foreach (var note in notes)
                    {
                        Console.WriteLine($"ID: {note.ID}, Title: {note.Title}, Created At: {note.CreatedAt}, Content Snippet: {note.Content.Substring(0, Math.Min(50, note.Content.Length))}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while retrieving notes.");
                Logger.LogError("Error in ViewNotes method", ex);
            }
        }

        public void UpdateNote()
        {
            try
            {
                Console.WriteLine("Enter the ID of the note to update:");
                var id = int.Parse(Console.ReadLine());

                var notes = noteRepository.GetAllNotes();
                if (notes == null || notes.Count == 0)
                {
                    Console.WriteLine("List of notes is empty");
                    Logger.LogError("No notes available to update.");
                    return;
                }

                var updateNotes = notes.FirstOrDefault(n => n.ID == id);
                if (updateNotes == null)
                {
                    Console.WriteLine("Enter a valid ID");
                    return;
                }

                Console.WriteLine("Enter a new title (or type 'exit' to cancel):");
                string newTitle = Console.ReadLine();
                if (!string.IsNullOrEmpty(newTitle) && newTitle != "exit")
                {
                    updateNotes.Title = newTitle;
                }

                Console.WriteLine("Enter new content (or type 'exit' to cancel):");
                string newContent = Console.ReadLine();
                if (!string.IsNullOrEmpty(newContent) && newContent != "exit")
                {
                    updateNotes.Content = newContent;  // Fixed the bug here (was updating Title instead of Content)
                }

                updateNotes.UpdatedAt = DateTime.Now;
                noteRepository.UpdateNote(updateNotes);

                Console.WriteLine("Updated successfully!");
                Logger.LogInfo($"Note updated: ID {updateNotes.ID}, New Title: {updateNotes.Title}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while updating the note.");
                Logger.LogError("Error in UpdateNote method", ex);
            }
        }

        public void DeleteNote()
        {
            try
            {
                Console.WriteLine("Enter the ID of the note to delete:");
                var id = int.Parse(Console.ReadLine());

                var notes = noteRepository.GetAllNotes();
                if (notes == null || notes.Count == 0)
                {
                    Console.WriteLine("List of notes is empty");
                    Logger.LogError("No notes available to delete.");
                    return;
                }

                var deleteNote = notes.FirstOrDefault(n => n.ID == id);
                if (deleteNote == null)
                {
                    Console.WriteLine("Enter a valid ID");
                    return;
                }

                Console.WriteLine("Are you sure? The note will be permanently deleted.");
                Console.WriteLine("Enter 'yes' to confirm or 'no' to cancel:");
                var confirm = Console.ReadLine().ToLower();
                if (confirm == "yes")
                {
                    noteRepository.DeleteNote(id);
                    Console.WriteLine("Deleted successfully!");
                    Logger.LogInfo($"Note deleted: ID {id}");
                }
                else
                {
                    Console.WriteLine("Deletion cancelled.");
                    Logger.LogInfo($"Note deletion cancelled: ID {id}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while deleting the note.");
                Logger.LogError("Error in DeleteNote method", ex);
            }
        }
    }
}
