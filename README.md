<h1>Simple Spotify Application </h1>


<h3>Description</h3>
This is a simple application that uses the Spotify API for developers to display the most popular music currently in a given country. It allows users to select from different countries and displays information about artists, albums, and their position in the top 50. Additionally, the application enables data export to various formats, such as JSON and XML.


![projekt_spoti](https://github.com/erdosky/Music_Trends_Spotify/assets/138824670/7bb9c88d-378a-4354-be82-684ee38b9c8f)
<h3>Startup Instructions</h3>
To correctly launch and use the application, first, you need to start the MySQL database server in XAAMP Control Panel, go to the phpMyAdmin page, create a database named spotify, and then import the spotify.sql file into it.

<h3>Using the Filtering Function</h3>
To use the filtering function, first, you need to export the top 50 tracks from a given region to the database from within the application, and then use the filter function. The filter searches for tracks based on the country of origin of the artist, entered in the TextBox field.

<h3>Technologies:</h3>
<ul>
<li>C#</li>
<li>WindowsForms</li>
</ul>




<h3>Used packages:</h3>
<ul>
<li>My.SQL.Data (8.0.32)</li>
<li>Newtonsoft.Json (13.0.2)</li>
<li>SpotifyAPI.Web (7.0.0)</li>
</ul>
