using System;
using System.ComponentModel.DataAnnotations;

namespace VidlyMovies.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateOfBirth { get; set; }

        public bool IsSubscribedToNewsletter  { get; set; }

        public MembershipType MembershipType { get; set; }

        public byte MembershipTypeId { get; set; }

    }
}