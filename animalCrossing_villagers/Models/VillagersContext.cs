using System;
using MySql.Data.MySqlClient;
using animalCrossing_villagers.Models;
namespace animalCrossing_villagers.Models
{
	public class VillagersContext
	{
		public string ConnectionString { get; set; }

		public VillagersContext(string connectionString)
		{
			this.ConnectionString = connectionString;
		}

		private MySqlConnection GetSqlConnection()
		{
			return new MySqlConnection(ConnectionString);
		}

		public List<Villagers> GetVillagers()
		{
			List<Villagers> villList = new List<Villagers>();

            using var connection = new MySqlConnection(ConnectionString);
            connection.Open();

            using MySqlCommand sqlCommand = new MySqlCommand("select * from AC_VillagersDB.villagers", connection);
            using MySqlDataReader reader = sqlCommand.ExecuteReader();

			while (reader.Read())
			{
				villList.Add(new Villagers()
				{
					Name = reader.GetString("Name"),
					IconImage = reader.GetString("Icon Image"),
					PhotoImage = reader.GetString("Photo Image"),
					HouseImage = reader.GetString("Home Image"),
					Species = reader.GetString("Species"),
                    Gender = reader.GetString("Gender"),
                    Personality = reader.GetString("Personality"),
					Hobby = reader.GetString("Hobby"),
                    Birthday = reader.GetString("Birthday"),
                    Catchphrase = reader.GetString("Catchphrase"),
                    FavoriteSong = reader.GetString("Favorite Song"),
                    FavoriteSaying = reader.GetString("Favorite Saying"),
                    Style1 = reader.GetString("Style 1"),
                    Style2 = reader.GetString("Style 2"),
                    Color1 = reader.GetString("Color 1"),
                    Color2 = reader.GetString("Color 2"),
                    Wallpaper = reader.GetString("Wallpaper"),
                    FurnitureNameList = reader.GetString("FurnitureNameList"),
                    Filename = reader.GetString("Filename"),
                    UniqueEntryID = reader.GetString("UniqueEntryID")
                });
			};
			connection.Close();

			return villList;
        }
	}
}

