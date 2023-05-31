﻿namespace WebAPI.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public string Description { get; set; }
        public ICollection<Owner> Owners { get; set;}
    }
}