using AutoMapper;
using LibraryManagement.API.DTOs.Author;
using LibraryManagement.API.DTOs.Book;
using LibraryManagement.API.DTOs.Borrow;
using LibraryManagement.API.DTOs.Member;
using LibraryManagement.API.Models;

namespace LibraryManagement.API.AutoMapper___Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Mapping Author
            CreateMap<Author, AuthorDto>().ReverseMap();
            CreateMap<Author, AuthorCreateDto>().ReverseMap();
            CreateMap<Author, UpdateAuthorDto>().ReverseMap();

            //Mapping Book
            CreateMap<Book, BookDto>().ReverseMap();
            CreateMap<CreateBookDto, Book>();

            //Mapping Borrow
            CreateMap<Borrow, BorrowReadDto>()
                .ForMember(dest => dest.BookTitle, opt => opt.MapFrom(src => src.Book.Title))
                .ForMember(dest => dest.MemberName, opt => opt.MapFrom(src => src.Member.Name));

            CreateMap<BorrowCreateDto, Borrow>();
            CreateMap<BorrowUpdateDto, Borrow>();

            //Mapping Member
            CreateMap<Member, MemberDto>();
            CreateMap<CreateMemberDto, Member>();
            CreateMap<UpdateMemberDto, Member>();

        }
    }
}
