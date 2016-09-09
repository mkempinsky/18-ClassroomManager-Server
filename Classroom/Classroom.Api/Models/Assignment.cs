﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Classroom.Api.Models
{
    public class Assignment
    {
    public int StudentId { get; set; }
    public int ProjectId { get; set; }

    public virtual Student Student { get; set; }
    public virtual Project Project { get; set;  }
    }
}