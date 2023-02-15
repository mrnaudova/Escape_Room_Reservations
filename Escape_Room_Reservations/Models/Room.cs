using System.ComponentModel.DataAnnotations;

namespace Escape_Room_Reservations.Models
{
	public class Room
	{
		[Key]
		public string NumberId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int MaxPersons { get; set; }
	}
}
