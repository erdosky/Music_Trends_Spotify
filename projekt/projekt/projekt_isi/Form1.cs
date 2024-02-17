using Newtonsoft.Json;
using SpotifyAPI.Web;
using System.Data;
using System.Diagnostics.Metrics;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using MySql.Data.MySqlClient;


namespace projekt_isi {
    public partial class Form1 : Form{

        public string connectionString = "" +
        "datasource=127.0.0.1;" +
        "port=3306;" +
        "username=root;" +
        "password=;" +
        "SslMode = none;" +
        "database=spotify;"
        ;

        public List<SpotifyTrack> trackList = new List<SpotifyTrack>();
        public Show ShowList = new Show();
        public string countryTag;
        public Form1(){
            InitializeComponent();
        }

        //pobieranie danych z API
        private async void GetData_Click(object sender, EventArgs e){
            List.Clear();
            //OAuth2.0
            var config = SpotifyClientConfig.CreateDefault().WithAuthenticator(new ClientCredentialsAuthenticator("a8860854819d4e7d8e178b4529e75124", "7b322add2a9049e0a34e1e6f94fdbd7a"));
            //RESTAPI
            var spotify = new SpotifyClient(config);
            try{
                var playlist = await spotify.Playlists.Get(countryTag);
                int i = 1;
                if (trackList.Count > 0){
                    trackList.Clear();
                }
                foreach (PlaylistTrack<IPlayableItem> item in playlist.Tracks.Items){
                    if (item.Track is FullTrack track){
                        var Artist = new List<string>();
                        foreach (var Art in track.Artists){
                            Artist.Add(Art.Name.ToString());
                        }
                        trackList.Add(new SpotifyTrack{
                            Place = i,
                            Name = track.Name.ToString(),
                            Albumname = track.Album.Name.ToString(),
                            Artistname = string.Join(", ", Artist)
                        });
                    }
                    i++;
                }
                ShowList.View(trackList, List);
                List.View = View.Details;
            }
            catch(Exception ex){
                MessageBox.Show("Pick the Area before Getting Data");
            }

        }

        //filtrowanie przy u¿yciu drugiego zrodla danych
        private async void Filter_Click(object sender, EventArgs e)
        {
            MySqlConnection databaseConnection = new MySqlConnection(connectionString); 
            MySqlCommand commandDatabase;
            MySqlDataReader reader;

            List.Clear();

            try
            {
                databaseConnection.Close();
                databaseConnection.Open();

                string query = "SELECT Place, Name, Artists, Album FROM tracks t " +
                   "JOIN artists_origin ao ON t.Artists = ao.artistname WHERE ao.country = '" + this.filterTextBox.Text + "';";
                commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                reader = commandDatabase.ExecuteReader();
                trackList.Clear();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        trackList.Add(new SpotifyTrack
                        {
                            Place = Int32.Parse(reader.GetString(0)),
                            Name = reader.GetString(1),
                            Artistname = reader.GetString(2),
                            Albumname = reader.GetString(3)
                        });
                    }
                }
                else
                {
                    MessageBox.Show("Na podanej liœcie top 50 nie ma artystów z podanego kraju.");
                }

                var country = "";
                switch (countryTag)
                {
                    case "37i9dQZEVXbNG2KDcFcKOF":
                        country = "World";
                        break;
                    case "37i9dQZEVXbMZ5PAcNTDXd":
                        country = "Polska";
                        break;
                    case "37i9dQZEVXbLp5XoPON0wI":
                        country = "USA";
                        break;
                    case "37i9dQZEVXbMwmF30ppw50":
                        country = "UK";
                        break;
                    case "37i9dQZEVXbK8BKKMArIyl":
                        country = "Niemcy";
                        break;
                }

                float percentage =(float) trackList.Count / 50 * 100;
                MessageBox.Show("Procentowo z top 50 z kraju " + country + " artystów  z kraju " + this.filterTextBox.Text + " jest " + percentage.ToString("F3") + "%");
                reader.Close();
                databaseConnection.Close();
                ShowList.View(trackList, List);
                List.View = View.Details;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //refresh/wyœwietlanie danch
        private void ViewData_Click(object sender, EventArgs e) {
            ShowList.View(trackList, List);
            List.View = View.Details;
        }
        //import listy z bazy danych
        private void ImportDB_Click(object sender, EventArgs e) {
            db data = new db();
            data.Import(trackList);
        }
        //export listy do bazy danych
        private void ExportDB_Click(object sender, EventArgs e){
            if (trackList.Count > 0) {
                db data = new db();
                data.Export(trackList);
            }
            else {
                MessageBox.Show("There is no data to export");
            }
        }

        //import pliku XML do listy utworów
        private void ImportXML_Click(object sender, EventArgs e) {
            trackList.Clear();
            XmlSerializer serializer = new XmlSerializer(typeof(List<SpotifyTrack>));
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Choose file";
            openFileDialog1.Filter = "All files (.)|*.*|XML File (.xml)|*.xml";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "") {
                using (Stream reader = new FileStream(openFileDialog1.FileName, FileMode.Open)) {
                    var tracks = (List<SpotifyTrack>)serializer.Deserialize(reader);
                    foreach (var track in tracks) {
                        trackList.Add(new SpotifyTrack {
                            Place = track.Place,
                            Name = track.Name,
                            Albumname = track.Albumname,
                            Artistname = track.Artistname
                        });
                    }
                }
            }
            MessageBox.Show("XML successfuly imported!");
            ShowList.View(trackList, List);
        }

        //export pliku XML do listy utworów
        private void ExportXML_Click(object sender, EventArgs e) {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save file";
            sfd.Filter = "XML File (.xml)|*.xml";
            sfd.ShowDialog();
            if (sfd.FileName != "") {
                XmlSerializer serializer = new XmlSerializer(typeof(List<SpotifyTrack>));
                using (TextWriter writer = new StreamWriter(sfd.FileName)) {
                    serializer.Serialize(writer, trackList);
                }
                MessageBox.Show("XML successfuly exported!");
            }

        }

        //import pliku JSON do listy utworów
        private void ImportJSON_Click(object sender, EventArgs e) {
            trackList.Clear();
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Choose file";
            openFileDialog1.Filter = "All files (.)|*.*|Json files (.json) |*.json";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "") {
                using (StreamReader reader = new StreamReader(openFileDialog1.FileName)) {
                    string json = reader.ReadToEnd();
                    trackList = JsonConvert.DeserializeObject<List<SpotifyTrack>>(json);
                }
            }
            MessageBox.Show("JSON successfuly imported!");
            ShowList.View(trackList, List);
        }

        //export pliku JSON do listy utworów
        private void ExportJSON_Click(object sender, EventArgs e) {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save file";
            sfd.Filter = "JSON File (.json)|*.json";
            sfd.ShowDialog();
            if (sfd.FileName != "") {
                var temp = JsonConvert.SerializeObject(trackList);
                File.WriteAllText(sfd.FileName, temp);
                MessageBox.Show("JSON successfuly exported!");
            }
        }

        //filtry dla danych obaszarów
        //ogólnoœwiatowy
        private void worldFiltr_CheckedChanged(object sender, EventArgs e) {
            this.countryTag = "37i9dQZEVXbNG2KDcFcKOF";
        }
        //polska
        private void PolandFiltr_CheckedChanged(object sender, EventArgs e) {
            this.countryTag = "37i9dQZEVXbMZ5PAcNTDXd";

        }
        //usa
        private void USAFilter_CheckedChanged(object sender, EventArgs e) {
            this.countryTag = "37i9dQZEVXbLp5XoPON0wI";

        }
        //wielka brytania
        private void UKFilter_CheckedChanged(object sender, EventArgs e) {
            this.countryTag = "37i9dQZEVXbMwmF30ppw50";

        }
        //niemcy
        private void GerFilter_CheckedChanged(object sender, EventArgs e) {
            this.countryTag = "37i9dQZEVXbK8BKKMArIyl";

        }
    }
}

