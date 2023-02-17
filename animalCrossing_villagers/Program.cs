using MySql.Data.MySqlClient;
using System;
using Microsoft.AspNetCore;
using Microsoft.Extensions;
using animalCrossing_villagers.Models;
using System.Xml.Linq;


namespace animalCrossing_villagers
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Villagers> villList = new List<Villagers>();
            
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.ConnectionString = "server=localhost;database=AC_VillagersDB;userId=root;password=sqlDBPassword;";

            using (MySqlConnection conn = new MySqlConnection(builder.ConnectionString))
            {
                conn.Open();
                string query = "SELECT * FROM AC_VillagersDB.villagers";

                MySqlCommand sqlCommand = new MySqlCommand(query, conn);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
           
                while (reader.Read())
                {
                    Villagers villager = new Villagers();
                    villager.Name = reader.GetString("Name");
                    villager.IconImage = reader.GetString("Icon Image");
                    villager.PhotoImage = reader.GetString("Photo Image");
                    villager.HouseImage = reader.GetString("House Image");
                    villager.Species = reader.GetString("Species");
                    villager.Gender = reader.GetString("Gender");
                    villager.Personality = reader.GetString("Personality");
                    villager.Hobby = reader.GetString("Hobby");
                    villager.Birthday = reader.GetString("Birthday");
                    villager.Catchphrase = reader.GetString("Catchphrase");
                    villager.FavoriteSong = reader.GetString("Favorite Song");
                    villager.FavoriteSaying = reader.GetString("Favorite Saying");
                    villager.Style1 = reader.GetString("Style 1");
                    villager.Style2 = reader.GetString("Style 2");
                    villager.Color1 = reader.GetString("Color 1");
                    villager.Color2 = reader.GetString("Color 2");
                    villager.Wallpaper = reader.GetString("Wallpaper");
                    villager.Flooring = reader.GetString("Flooring");
                    villager.FurnitureList = reader.GetString("Furniture List");
                    villager.Filename = reader.GetString("Filename");
                    villager.UniqueEntryID = reader.GetString("Unique Entry ID");

                    villList.Add(villager);
                }
            }
        }
    }
}





