using System;

namespace MPicSorter.Objects
{
    public class Media
    {
        public Media(string name, DateTime dateOfCreation)
        {
            Name = name;
            DateOfCreation = dateOfCreation;
        }

        public DateTime DateOfCreation { get; set; }
        public string Name { get; set; }
    }
}