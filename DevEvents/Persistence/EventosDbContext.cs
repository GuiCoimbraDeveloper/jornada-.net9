using DevEvents.Entities;

namespace DevEvents.Persistence
{
    public class EventosDbContext 
    {
        public EventosDbContext()
        {
            Eventos = new List<Evento>();
        }

        public List<Evento> Eventos { get; set; }
    }
}
