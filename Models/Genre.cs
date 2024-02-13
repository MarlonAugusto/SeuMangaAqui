﻿namespace SeuMangaAqui.Models
{
    public class Genre
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public ICollection<Manga> Mangas { get; set; }
    }
}
