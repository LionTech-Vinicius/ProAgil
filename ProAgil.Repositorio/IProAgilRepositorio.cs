using System.Threading.Tasks;
using ProAgil.Dominio;

namespace ProAgil.Repositorio
{
    public interface IProAgilRepositorio
    {
         void Add<T>(T entity) where T : class;
         void Update<T>(T entity) where T : class;
         void Delete<T>(T entity) where T : class;
         Task<bool> SaveChangesAsync();

         //Eventos
         Task<Evento[]> GetAllEventosAsyncByTema(string tema, bool includePalestrantes = false);
         Task<Evento[]> GetAllEventosAsync(bool includePalestrantes = false);
         Task<Evento> GetEventosAsyncById(int EventoId, bool includePalestrantes = false);

         //Palestrante
         Task<Palestrante[]> GetAllPalestranteAsyncByNome(string nome, bool includeEventos = false);
         Task<Palestrante> GetPalestranteAsync(int PalestranteId, bool includeEventos = false);
    }
}