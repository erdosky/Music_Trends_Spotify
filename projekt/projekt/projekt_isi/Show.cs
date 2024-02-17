
using System.Collections.Generic;

namespace projekt_isi {
    //metoda wyświetlania danych
    public class Show {
        public void View(List<SpotifyTrack> tracks, ListView List) {
            if (tracks.Count > 0) {
                List.Clear();
                List.Columns.Add("Place", 100);
                List.Columns.Add("Name", 250);
                List.Columns.Add("Artist", 250);
                List.Columns.Add("Album", 250);
                List.GridLines = true;
                List.FullRowSelect = true;
                foreach (var Track in tracks) {
                    string[] tab = new string[4];
                    ListViewItem item;

                    tab[0] = Track.Place.ToString();
                    tab[1] = Track.Name;
                    tab[2] = Track.Artistname;
                    tab[3] = Track.Albumname;
                    item = new ListViewItem(tab);
                    List.Items.Add(item);
                }
            }
            else {
                MessageBox.Show("There is no data to show");
            }
        }

       
        }
    }