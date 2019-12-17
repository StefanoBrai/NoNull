using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.Repositories.Abstractions
{
    public interface DomainUoW
    {
        ProfessionistRepository ProfessionistRepository { get; set; }
        Task<IEnumerable<Professionist>> FindAllAsync();
    }
}
