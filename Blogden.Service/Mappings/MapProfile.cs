using AutoMapper;
using Blogden.Core.DTOs;
using Blogden.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogden.Service.Mappings
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Author, AuthorDTO>().ReverseMap();
            CreateMap<Blog, BlogDTO>().ReverseMap();
            CreateMap<Comment, CommentDTO>().ReverseMap();
            CreateMap<Author, AuthorWithBlogsDTO>();
            CreateMap<Blog, BlogWithCommentsDTO>();
        }
    }
}
