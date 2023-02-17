using System.ComponentModel.DataAnnotations;

namespace animalCrossing_villagers.Models
{
    public class Villagers
    {
        //private VillagersContext context;

        public string? Name { get; set; }
        public string? IconImage { get; set; }
        public string? PhotoImage { get; set; }
        public string? HouseImage { get; set; }
        public string? Species { get; set; }
        public string? Gender { get; set; }
        public string? Personality { get; set; }
        public string? Hobby { get; set; }
        //[DataType(DataType.Date)]
        public string? Birthday { get; set; }
        public string? Catchphrase { get; set; }
        public string? FavoriteSong { get; set; }
        public string? FavoriteSaying { get; set; }
        public string? Style1 { get; set; }
        public string? Style2 { get; set; }
        public string? Color1 { get; set; }
        public string? Color2 { get; set; }
        public string? Wallpaper { get; set; }
        public string? FurnitureList { get; set; }
        public string? Filename { get; set; }
        public string? UniqueEntryID { get; set; }
    }
}

