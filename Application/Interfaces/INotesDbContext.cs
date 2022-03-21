using Domain;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface INotesDbContext
    {
        DbSet<Note> Notes { get; set; }

        /// <summary>
        /// Save DbContext changes into Db
        /// </summary>
        /// <param CancellationToken="cancellationToken"></param>
        /// <returns></returns>
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
