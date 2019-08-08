﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ArkDefence.AspNetCore.Host.Models
{
    public class Person : ISoftDelete
    {
        public Person(string sub)
        {
            UserIdentifier = sub ?? throw new ArgumentNullException(nameof(sub));
            CreationTime = DateTime.UtcNow;
        }

        [Key]
        public long Id { get; set; }
        /// <summary>
        /// jwt sub property
        /// </summary>
        public string UserIdentifier { get; set; }
        public string Name { get; set; }
        [Url]
        public string ImageUri { get; set; }
        public DateTime CreationTime { get; set; }
        public bool Deleted { get; set; }
        public DateTime DeletionTime { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }

        public string TennantId { get; set; }
        public Tennant Tennant { get; set; } 

        [InverseProperty("Person")]
        public List<Card> Cards { get; set; }

        public List<PersonSystemController> PersonSystemControllers { get; set; }
    }
}
