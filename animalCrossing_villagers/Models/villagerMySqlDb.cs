using System;
using MySql.Data.MySqlClient;
using Microsoft.AspNetCore;
using Microsoft.Extensions;
using animalCrossing_villagers.Models;
using System.Xml.Linq;
using Mysqlx.Notice;

namespace animalCrossing_villagers.Models
{
	public class villagerMySqlDb
	{
        MySqlConnection conn;
		private void GetConnection()
		{
			string connectionString = "server=localhost;database=AC_VillagersDB;userId=root;password=sqlDBPassword;";
			conn = new MySqlConnection(connectionString);
		}

		public bool AddNewVillagers(Villagers villagers)
		{
            GetConnection();
			MySqlCommand sqlProcedure = new MySqlCommand("addNewVillagers", conn);

			sqlProcedure.Connection = conn;
			sqlProcedure.CommandType = System.Data.CommandType.StoredProcedure;
			sqlProcedure.Parameters.AddWithValue("nam", villagers.Name);
            sqlProcedure.Parameters.AddWithValue("iImage", villagers.IconImage);
            sqlProcedure.Parameters.AddWithValue("pImage", villagers.PhotoImage);
            sqlProcedure.Parameters.AddWithValue("hImage", villagers.HouseImage);
            sqlProcedure.Parameters.AddWithValue("species", villagers.Species);
            sqlProcedure.Parameters.AddWithValue("gender", villagers.Gender);
            sqlProcedure.Parameters.AddWithValue("personality", villagers.Personality);
            sqlProcedure.Parameters.AddWithValue("hobby", villagers.Hobby);
            sqlProcedure.Parameters.AddWithValue("bday", villagers.Birthday);
            sqlProcedure.Parameters.AddWithValue("catchP", villagers.Catchphrase);
            sqlProcedure.Parameters.AddWithValue("favSong", villagers.FavoriteSong);
            sqlProcedure.Parameters.AddWithValue("favSaying", villagers.FavoriteSaying);
            sqlProcedure.Parameters.AddWithValue("sty1", villagers.Style1);
            sqlProcedure.Parameters.AddWithValue("sty2", villagers.Style2);
            sqlProcedure.Parameters.AddWithValue("col1", villagers.Color1);
            sqlProcedure.Parameters.AddWithValue("col2", villagers.Color2);
            sqlProcedure.Parameters.AddWithValue("wallPap", villagers.Wallpaper);
            sqlProcedure.Parameters.AddWithValue("flooring", villagers.Flooring);
            sqlProcedure.Parameters.AddWithValue("furnList", villagers.FurnitureList);
            sqlProcedure.Parameters.AddWithValue("fName", villagers.Filename);
            sqlProcedure.Parameters.AddWithValue("entryID", villagers.UniqueEntryID);

            int i = sqlProcedure.ExecuteNonQuery();

            if (i >= 1)
            {
                return true;
            }

            return false;

        }

	}
}

