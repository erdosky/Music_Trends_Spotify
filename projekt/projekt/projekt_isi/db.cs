using MySql.Data.MySqlClient;
using projekt_isi;
using System.Diagnostics;
using System.Text;

public class db
{
    
    public string connectionString = "" +
        "datasource=127.0.0.1;" +
        "port=3306;" +
        "username=root;" +
        "password=;" +
        "SslMode = none;"
        ;

    //funkcja do exportu utworów z bazy danych
    public void Export(List<SpotifyTrack> TrackList)
    {
        
        MySqlConnection databaseConnection = new MySqlConnection(connectionString); 
        MySqlCommand commandDatabase;
        MySqlDataReader reader; 
        try
        {
            databaseConnection.Close();
            databaseConnection.Open();
            StringBuilder sCommand = new StringBuilder();
            //procesy ETL
            sCommand.Append("DELETE FROM spotify.tracks; ");
            sCommand.Append("INSERT INTO spotify.tracks (`Place`, `Name`, `Artists`, `Album`) VALUES");
            List<string> Rows = new List<string>();
            foreach (var place in TrackList)
            {
                Rows.Add(
                string.Format("({0},\"{1}\",\"{2}\",\"{3}\")",
                place.Place,
                place.Name,
                place.Artistname,
                place.Albumname.Replace("\"","'")
                ));
            }
            sCommand.Append(string.Join(",", Rows));
            sCommand.Append(";");
            string query3 = sCommand.ToString();
            Debug.WriteLine(query3);
            commandDatabase = new MySqlCommand(query3, databaseConnection);
            commandDatabase.ExecuteNonQuery();
            databaseConnection.Close();
            MessageBox.Show("Data successfuly exported!");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    //funkcja do importu utworów z bazy danych
    public void Import(List<SpotifyTrack> TrackList) {
        MySqlConnection databaseConnection = new MySqlConnection(connectionString);
        MySqlCommand commandDatabase;
        MySqlDataReader reader;
        try {
            databaseConnection.Close();
            databaseConnection.Open();
            
            string query = "SELECT * FROM spotify.tracks;";
            commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            reader = commandDatabase.ExecuteReader();
            TrackList.Clear();
            if (reader.HasRows) {
                while (reader.Read()) {
                    TrackList.Add(new SpotifyTrack {
                        Place = Int32.Parse(reader.GetString(0)),
                        Name = reader.GetString(1),
                        Artistname = reader.GetString(2),
                        Albumname = reader.GetString(3)
                    });
                }
            }
            else {
                MessageBox.Show("There is no data in database.");
            }
            reader.Close();
            databaseConnection.Close();
            MessageBox.Show("Data successfuly imported!");
        }
        catch (Exception ex) {
            MessageBox.Show(ex.Message);
        }
    }
}