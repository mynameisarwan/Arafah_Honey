using Arafah_Honey.Data;
using Arafah_Honey.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Arafah_Honey.Features.Neraca
{
    public class DeleteNeracaByID
    {
        public class Command : IRequest {
            public string neraca_id { get; set; }   
        }

        public class CommanHandler : IRequestHandler<Command, Unit>
        {
            private readonly ArafahDataContext _dc;

            public CommanHandler(ArafahDataContext dc) => _dc = dc;
            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var sel = await _dc.tbl_mst_neraca.FindAsync(request.neraca_id);
                if (sel == null) return Unit.Value;
                _dc.tbl_mst_neraca.Remove(sel);
                await _dc.SaveChangesAsync();
                return Unit.Value;
            }
        }
    }
}
