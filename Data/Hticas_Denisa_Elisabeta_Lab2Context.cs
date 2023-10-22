using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hticas_Denisa_Elisabeta_Lab2.Models;

namespace Hticas_Denisa_Elisabeta_Lab2.Data
{
    public class Hticas_Denisa_Elisabeta_Lab2Context : DbContext
    {
        public Hticas_Denisa_Elisabeta_Lab2Context (DbContextOptions<Hticas_Denisa_Elisabeta_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Hticas_Denisa_Elisabeta_Lab2.Models.Book> Book { get; set; } = default!;
    }
}
