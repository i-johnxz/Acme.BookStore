using System;
using System.ComponentModel.DataAnnotations;
using Acme.BookStore.Domain.Shared;

namespace Acme.BookStore.Application.Contracts
{
    public class CreateUpdateBookDto
    {
        
        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        [Required]
        public BookType Type { get; set; } = BookType.Undefined;

        [Required]
        public DateTime PublishDate { get; set; }

        [Required]
        public float Price { get; set; }
    }
}