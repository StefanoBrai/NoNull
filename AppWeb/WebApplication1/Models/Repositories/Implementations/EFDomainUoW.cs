using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.Repositories.Abstractions;

namespace WebApplication1.Models.Repositories.Implementations
{
    public class EFDomainUoW : DomainUoW
    {
        private NoNullProjectContext ctx;
        public ProfessionistRepository ProfessionistRepository { get; set; }

        public EFDomainUoW(NoNullProjectContext ctx, ProfessionistRepository professionistRepository)
        {
            this.ctx = ctx;
            ProfessionistRepository = professionistRepository;
        }

        public async Task<IEnumerable<Professionist>> FindAllAsync()
        {
            return await ProfessionistRepository.FindAll().AsQueryable()
                .Include(p => p.Destination).ToListAsync();
        }
    }
}
