namespace Escape_Room_Reservations.Models
{
	public class Reservations
	{
		public int Id { get; set; }//не съм сиг дали трябжа да има Id за съответната резервация, но го добавих
		public string AssigneeId { get; set; } //UserId на потребителят, на когото се води резервацията
		public virtual User? Assignee { get; set; }
		//двете property-ta горе ги откраднах от Пешо

		public DateTime DeadLine { get; set; }

		//---------------// не съм сигурна,  дали така трябваше да изпиша - "стая, на която е зададена резервацията"
		public int RoomId { get; set; } 
		public virtual Reservations? ReservationList { get; set; } 
		//----------------//

		public string Description { get; set; }
	}
}
