using Assessment3.Loggers;
using Assessment3.NoteModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3.Note_Repository
{
    public class NoteRepository
    {
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gouri\Documents\QuestDb.mdf;Integrated Security=True;Connect Timeout=30;";
        public void CreateNote(Note note)
        {
            using (var connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();
                    var insertQuery = "INSERT INTO Notes(Title, Content,CreatedAt,UpdatedAt) VALUES (@Title, @Content, @CreatedAt, @UpdatedAt)";
                    using (var command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Title", note.Title);
                        command.Parameters.AddWithValue("@Content", note.Content);
                        command.Parameters.AddWithValue("@CreatedAt", note.CreatedAt);
                        command.Parameters.AddWithValue("@UpdatedAt", note.UpdatedAt);
                        command.ExecuteNonQuery();
                    }
                    Logger.LogInfo($"Note created: {note.Title}");
                }
                catch (Exception ex)
                {
                    Logger.LogError("Error while creating note", ex);
                }
            }
        }
        public List<Note> GetAllNotes()
        {
            var notes = new List<Note>();
            using (var connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();
                    var query = "SELECT ID, Title, Content, CreatedAt, UpdatedAt FROM Notes";
                    using (var command = new SqlCommand(query, connection))
                    {
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            notes.Add(new Note
                            {
                                ID = reader.GetInt32(0),
                                Title = reader.GetString(1),
                                Content = reader.GetString(2),
                                CreatedAt = reader.GetDateTime(3),
                                UpdatedAt = reader.GetDateTime(4)
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Logger.LogError("Error while fetching notes", ex);

                }
            }
            return notes;
        }
        public void UpdateNote(Note note)
        {

            using (var connection = new SqlConnection(connString))
            {
                connection.Open();
                try
                {
                    var updatequery = "UPDATE Notes SET Title = @Title, Content = @Content, UpdatedAt = @UpdatedAt WHERE ID = @ID";
                    using (var command = new SqlCommand(updatequery, connection))
                    {
                        command.Parameters.AddWithValue("@ID", note.ID);
                        command.Parameters.AddWithValue("@Title", note.Title);
                        command.Parameters.AddWithValue("@Content", note.Content);
                        command.Parameters.AddWithValue("@UpdatedAt", note.UpdatedAt);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Logger.LogInfo($"Note updated: {note.ID}");
                        }
                        else
                        {
                            Logger.LogInfo($"No note found with ID: {note.ID} to update.");
                        }
                    }
                }

                catch (Exception ex)
                {
                    Logger.LogError("Error while updating note", ex);
                }
            }
        }
        public void DeleteNote(int noteId)
        {
            try
            {
                using (var connection = new SqlConnection(connString))
                {
                    connection.Open();

                    var checkQuery = "SELECT COUNT(*) FROM Notes WHERE ID = @ID";
                    using (var command = new SqlCommand(checkQuery, connection))
                    {
                        command.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = noteId;
                        int count = (int)command.ExecuteScalar();

                        if (count > 0)
                        {
                            var deleteQuery = "DELETE FROM Notes WHERE ID = @ID";
                            using (var deleteCommand = new SqlCommand(deleteQuery, connection))
                            {
                                deleteCommand.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = noteId;
                                deleteCommand.ExecuteNonQuery();
                                Logger.LogInfo($"Note deleted: ID {noteId}");
                            }
                        }
                        else
                        {
                            Logger.LogInfo($"No note found with ID: {noteId} to delete.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("Error while deleting note", ex);
            }

        }
    }
}
