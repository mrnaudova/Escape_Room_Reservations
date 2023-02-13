namespace Escape_Room_Reservations.Models
{
	public class User 
		
	{
		public User()
		{
			Lists = new List<Reservations>(); //туй го откраднах от старият проектт, трябва да е създаване на лист от/за резервации
											//което пък, подсказва, че може би съм объркала долууу
		}

		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int PhoneNumber { get; set; } //мисля, че int-овете бяха за числаа
		public virtual List<Reservations> Lists { get; set; } //това би трябвало да е списък от резервации,но може да съм го объркала със списък от списъци с  резервации, не съм програмист :|
	}
}
