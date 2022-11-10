using Agenda.Assembly.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Agenda.Assembly.Client.Services
{
    public interface IAgendaService
    {
        Task Guardar_dato(Agendax agenda);
        Task Eliminar_dato(int id);
        Task<IEnumerable<Agendax>> Mostrar();
        Task<Agendax> Buscar(int id);
    }
}
