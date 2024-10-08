﻿namespace MusicStore.Domain.Models
{
    public class Artist : BaseEntity
    {
        public required string Name { get; set; }
        public required string ImageAvatarURL { get; set; }
        public required string Description { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Tags { get; set; } // For tagging, will be comma seperated in frontend using JS



        // Many-to-many relationship with Track
        public List<Track> Tracks { get; set; } = new List<Track>();

        // Many-to-many relationship with Album
        public List<Album> Albums { get; set; } = new List<Album>();

    }
}
