﻿using System;
using System.Collections.Generic;
using EzGame.Domain.Core.Services;
using EzGame.Domain.Core.Services.Entities;

namespace EzGame.Domain.Entities
{
    public class Platform : BaseEntity<string>
    {
        public Platform()
        {
            CreatedTime = DateTime.Now;
            Id = IdGenerator.NewGuid();
            LastModifiedTime = DateTime.Now;
        }

        public string Title { get; set; }
        public string Logo { get; set; }
        //relations
        public virtual IEnumerable<GamePlatform> GamePlatform { get; set; }

    }
}