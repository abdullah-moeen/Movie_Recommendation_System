﻿using Movie_Recommendation_System.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Movie_Recommendation_System.Models
{
    public class Watchlist
    {
        public int Id { get; set; }
        public string userId { get; set; }
        [ForeignKey("MovieInstance")]
        public int? movieId { get; set; }
        public Movies MovieInstance { get; set; }

    }
}