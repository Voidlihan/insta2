﻿using _inst.Models.Comment;
using _inst.Models.Posts;
using AutoMapper;
using Domain.Model;

namespace _inst.MapperProfile
{
    public class CommentProfile : Profile
    {
        public CommentProfile()
        {
            CreateMap<Comment, CommentCreateViewModel>();
            CreateMap<CommentCreateViewModel, Comment>()/*.ForMember(x => x.Id, opt => opt.Ignore())*/; ;
            CreateMap<Comment, CommentIndexViewModel>();
            CreateMap<CommentIndexViewModel, Comment>();
        }
    }
}