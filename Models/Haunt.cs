using System;
using System.Data.Entity;

namespace haunt_map.Models
{
    public class Haunt
    {
        public int ID { get; set; } //ID
        public string Title { get; set; } //Tite of the story
        public string Story { get; set; } //Content of the story
        public double latitude { get; set; } //Latitude of the Place
        public double longitude { get; set; } //Longitude of the Place
        public int UserId { get; set; } //ID of the user who made it
    }

    public class HauntDBContext : DbContext
    {
        public DbSet<Haunt> Haunts { get; set; }
    }
}