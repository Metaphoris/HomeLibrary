﻿namespace DomainModel
{
    public class Country
    {
        public int CountryID { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}