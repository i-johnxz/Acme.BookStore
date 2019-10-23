using Acme.BookStore.Application.Contracts;
using Acme.BookStore.Domain;
using AutoMapper;

namespace Acme.BookStore.Application
{
    public class BookStoreApplicationAutoMapperProfile : Profile
    {
        public BookStoreApplicationAutoMapperProfile()
        {
            CreateMap<Book, BookDto>();
            CreateMap<CreateUpdateBookDto, Book>();
        }
    }
}