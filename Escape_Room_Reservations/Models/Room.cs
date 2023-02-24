using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace Escape_Room_Reservations.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int GoodForAmountOfPeople { get; set; }
        [NotMapped]
        public Image Image { get; set; }
    }
}
