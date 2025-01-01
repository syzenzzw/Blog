using AutoMapper;
using BlogDoEltinho.Dtos.Comment;
using BlogDoEltinho.Dtos.PostDto;
using BlogDoEltinho.Dtos.RegisterUserDto;
using BlogDoEltinho.Models;
using Microsoft.AspNetCore.Identity;

namespace BlogDoEltinho.Mapping
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration() 
        {
            //Mapeadores dos comentários
            CreateMap<Comment, CommentDto>();
            CreateMap<Comment, CreateComment>();
            CreateMap<Comment, UpdateComment>();

            //Mapeadores dos posts
            CreateMap<Post, PostDto>();
            CreateMap<Post, CreatePostDto>();
            //Sem necessidade de Update..

            //Mapeadores do Usuario
            CreateMap<UserInfo, UserForRegisterDto>();
            CreateMap<UserInfo, UserRegisterResponseDto>();
        }
    }
}
