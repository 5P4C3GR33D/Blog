﻿using System;
using System.Collections.Generic;
using Blog.Entities.DTOs.Account;
using Blog.Entities.DTOs.Category;
using Blog.Entities.DTOs.Comment;
using Blog.Entities.DTOs.Language;
using Blog.Entities.DTOs.Picture;
using Blog.Entities.DTOs.Reaction;
using Blog.Entities.DTOs.Tag;

namespace Blog.Entities.DTOs.Post
{
	public class PostViewDTO
	{
		public Guid Id { get; set; }

		public string Title { get; set; }

		public string Text { get; set; }

		public string Description { get; set; }

		public int ViewsCounter { get; set; }

		public int LikeCounter { get; set; }

		public int DislikeCounter { get; set; }

		public bool CommentingPermission { get; set; }

		public int NumberOfComments { get; set; }

		public DateTime Created { get; set; }

		public DateTime Modified { get; set; }

		public Guid CategoryId { get; set; }
		public CategoryViewDTO CategoryViewDTO { get; set; }

		public Guid UserId { get; set; }
		public UserViewDto UserViewDto { get; set; }

		public Guid LanguageId { get; set; }
		public LanguageViewDTO LanguageViewDTO { get; set; }

		public List<PictureViewDTO> PictureViewDTOs { get; set; }

		public List<ReactionViewDTO> Reactions { get; set; }

		public List<CommentViewDTO> CommentViewDTOs { get; set; }

		public List<TagViewDTO> TagViewDTO { get; set; }
	}
}
