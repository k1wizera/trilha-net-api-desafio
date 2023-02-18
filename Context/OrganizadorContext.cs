using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;
using TrilhaApiDesafio.Models;

namespace TrilhaApiDesafio.Context
{
    public class OrganizadorContext : DbContext
    {
        public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}