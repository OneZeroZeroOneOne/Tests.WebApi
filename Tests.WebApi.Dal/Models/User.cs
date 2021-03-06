﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Tests.WebApi.Dal.Models
{
    public partial class User
    {
        public User()
        {
            Subscriptions = new HashSet<Subscription>();
            UserEmployees = new HashSet<UserEmployee>();
            UserQuizzes = new HashSet<UserQuiz>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int RoleId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string AvatarUrl { get; set; }

        public virtual Role Role { get; set; }
        public virtual UserSecurity UserSecurity { get; set; }
        public virtual ICollection<Subscription> Subscriptions { get; set; }
        public virtual ICollection<UserEmployee> UserEmployees { get; set; }
        public virtual ICollection<UserQuiz> UserQuizzes { get; set; }
    }
}
