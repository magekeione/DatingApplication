using System;

namespace DatingApp.API.Dtos
{
    public class PhotosForDetaliedDtos
    {
        public int Id { get; set; }

        public string URL { get; set; }

        public string Description { get; set; }

        public DateTime DataAdded { get; set; }

        public bool IsMain { get; set; }
    }
}