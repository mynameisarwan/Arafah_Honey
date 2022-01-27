using Arafah_Honey.Data;
using Arafah_Honey.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Arafah_Honey.Features.Neraca
{
    public class GetNeracaByID
    {
        public class Query : IRequest<Neracas> 
        {
            public string neraca_id { get; set; }
        }

        public class QueryHandler : IRequestHandler<Query, Neracas>
        {
            private readonly ArafahDataContext _db;

            public QueryHandler(ArafahDataContext db) => _db = db;
            public async Task<Neracas> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _db.tbl_mst_neraca.FindAsync(request.neraca_id);
            }
        }
    }
}
