using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Escape_Room_Reservations.Models;

namespace Escape_Room_Reservations.Data
{
    public class ApplicationDbContext : IdentityDbContext
	{
		public DbSet<Room> Rooms { get; set; }
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
		public DbSet<Escape_Room_Reservations.Models.User> User { get; set; }
		public DbSet<Escape_Room_Reservations.Models.Reservations> Reservations { get; set; }
	}
}