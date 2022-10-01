namespace Proyecto.Models
{
    public class Reservas
    {

        [Key]
        public int id_reserva { get; set; }
        public string? id_usuario { get; set; }
        public string? id_doctor { get; set; }
        [Required]
        public string? especialidad { get; set; }
        public date fecha { get; set; }
        [Required]
        
    }
}
