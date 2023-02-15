namespace Escape_Room_Reservations.Models
{
	public class User 
		
	{
		public User()
		{
			Lists = new List<Reservations>(); //туй го откраднах от старият проектт, трябва да е създаване на лист от/за резервации
											//което пък, подсказва, че може би съм объркала долууу
		}
		public int UserId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string PhoneNumber { get; set; } // код за валидация не можах да намеря...
		public virtual List<Reservations> Lists { get; set; } //това би трябвало да е списък от резервации,но може да съм го объркала със списък от списъци с  резервации, не съм програмист :|
	}
}
