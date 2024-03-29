﻿using AutoMapper;
using System;
using WorkoutBuddy.BusinessLogic.Implementation.Comments.Models;
using WorkoutBuddy.Entities;

namespace WorkoutBuddy.BusinessLogic.Implementation.ManageSplits
{
    public class CommentProfile : Profile
    {
        public CommentProfile()
        {
            CreateMap<CommentModel, Comment>()
                .ForMember(a => a.Idcomment, a => a.MapFrom(s => Guid.NewGuid()))
                .ForMember(a => a.CommentText, a => a.MapFrom(s => s.CommentText))
                .ForMember(a => a.Idsplit, a => a.MapFrom(s => s.ParentSplitID))
                .ForMember(a => a.IdparentComm, a => a.MapFrom(s => s.ParentCommentId))
                .ForMember(a => a.IdsplitNavigation, a => a.Ignore())
                .ForMember(a => a.IdparentCommNavigation, a => a.Ignore());
        }
    }
}
