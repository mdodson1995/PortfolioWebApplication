//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalApplicationWReviewsMovies.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Movy
    {
        public int ID { get; set; }
        public string MovieName { get; set; }
        public string MovieGenre { get; set; }
        public System.DateTime ReleaseDate { get; set; }
        public byte[] MovieCover { get; set; }
    }
}