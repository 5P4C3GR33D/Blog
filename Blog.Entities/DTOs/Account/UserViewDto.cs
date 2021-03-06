﻿using System;
using System.Collections.Generic;
using Blog.Entities.DTOs.Picture;
using Blog.Entities.DTOs.Post;

namespace Blog.Entities.DTOs.Account
{
	public class UserViewDto
	{
		public Guid Id { get; set; }

		public string UserName { get; set; }

		public string Email { get; set; }

		public Guid RoleId { get; set; }

		public string RoleName { get; set; }

		public string InstagramLink { get; set; }

		public string YoutubeLink { get; set; }

		public string FacebookLink { get; set; }

		public string LinkedInLink { get; set; }

		public string TwitterLink { get; set; }
		
		public PictureViewDTO AvatarViewDTO { get; set; }

		public List<PostViewDTO> PostViewDTOs { get; set; }
	}
}
