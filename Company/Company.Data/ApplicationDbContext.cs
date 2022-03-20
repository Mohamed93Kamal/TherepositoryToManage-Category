using Company.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Data
{
    public class madDbContext : IdentityDbContext<User>
    {
        public madDbContext(DbContextOptions<madDbContext> options)
            : base(options)
        {
        }
    }
}
