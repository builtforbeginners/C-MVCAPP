﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbModel
{
    public class ContextFactory : System.Data.Entity.DropCreateDatabaseIfModelChanges<RentalMovieDBContext>
    {
    }
}
