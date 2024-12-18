﻿namespace Tarefa3.Domain.Models
{
    public class CharacterResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Species { get; set; }
        public string Gender { get; set; }
        public string Image { get; set; }
        public Origin Origin { get; set; }
        public Location Location { get; set; }
    }
    public class Origin
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }

    public class Location
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }

}
