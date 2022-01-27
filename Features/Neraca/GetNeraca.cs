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
    public class GetNeraca
    {
        public class Query : IRequest<IEnumerable<Neracas>> { }
        public class QueryHandler : IRequestHandler<Query, IEnumerable<Neracas>>
        {
            private readonly ArafahDataContext _db;

            public QueryHandler(ArafahDataContext db) => this._db = db;
            public async Task<IEnumerable<Neracas>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _db.tbl_mst_neraca.ToListAsync(cancellationToken);
            }
        }
    }
}
