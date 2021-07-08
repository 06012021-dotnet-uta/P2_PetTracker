﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer
{
    public partial class Forum
    {
        public Forum()
        {
            ForumImgs = new HashSet<ForumImg>();
            Posts = new HashSet<Post>();
        }

        public int ForumId { get; set; }
        public bool IsClaimed { get; set; }
        public int PetId { get; set; }

        public virtual Pet Pet { get; set; }
        public virtual ICollection<ForumImg> ForumImgs { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}