using Hotel.Data.Patterns;
using Hotel_Data.ProgramDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Service
{
    public  class Generel
    {

        public static ApplicationDbContext dbContext = OptionDb.ProgramDbContext();
    }
}
