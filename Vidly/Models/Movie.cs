﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }

        public Genre Genre { get; set; }

        [Required(ErrorMessage = "The Release Date field is required.")]
        public DateTime DateAdded { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [Display(Name = "Number in Stock")]
        [MinNumberOfMoviesInStock]
        public byte NumberInStock { get; set; }

        public byte NumberAvailable { get; set; }

    }
}