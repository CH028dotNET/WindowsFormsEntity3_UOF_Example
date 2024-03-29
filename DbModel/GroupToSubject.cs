﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbModel
{
    public class GroupToSubject
    {
        [Key, Column(Order = 0)]
        public int GroupId { get; set; }
        [Key, Column(Order = 1)]
        public int SubjectId { get; set; }

        [ForeignKey("GroupId")]
        public virtual Groups Groups { get; set; }
        [ForeignKey("SubjectId")]
        public virtual Subjects Subjects { get; set; }     
    }
}
