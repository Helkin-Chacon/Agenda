using Agenda.Assembly.Shared;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Agenda.Assembly.Client.Services
{
    public class AgendaService : IAgendaService
    {
        private readonly HttpClient _httpclient;
        public AgendaService(HttpClient httpClient)
        {
            _httpclient = httpClient;
        }
        public async Task<Agendax> Buscar(int id)
        {
            return await
            _httpclient.GetFromJsonAsync<Agendax>($"api/agenda/{id}");
        }
        public async Task Eliminar_dato(int id)
        {
            await _httpclient.DeleteAsync($"api/agenda/{id}");
        }
        public async Task Guardar_dato(Agendax agenda)
        {
            if (agenda.Idagenda == 0)
            {
                await _httpclient.PostAsJsonAsync<Agendax>($"api/agenda",
                agenda);
            }
            else
            {
                await
                _httpclient.PutAsJsonAsync<Agendax>($"api/agenda/{agenda.Idagenda}", agenda);
            }
        }
        public async Task<IEnumerable<Agendax>> Mostrar()
        {
            return await
            _httpclient.GetFromJsonAsync<IEnumerable<Agendax>>($"api/agenda");
        }
    }
}
