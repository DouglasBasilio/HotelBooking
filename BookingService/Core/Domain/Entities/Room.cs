using Domain.ValueObjects;

namespace Domain.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public bool InMaintenace { get; set; }
        public Price Price { get; set; }
        public bool IsAvailable
        {
            get
            {
                if (this.InMaintenace || this.HasGuest)
                {
                    return false;
                }

                return true;
            }
        }

        public bool HasGuest
        {
            // Verificar se tem bookings abertos para esta Room
            get { return true; }
        }
    }
}
