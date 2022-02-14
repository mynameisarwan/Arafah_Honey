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
    public class AddNeraca
    {
        public class Command : IRequest<string> {
            public DateTime tanggal_neraca { get; set; }
            public string keterangan { get; set; }
            public string debitkredit { get; set; }
            public decimal nominal { get; set; }
            public decimal qty { get; set; }
        }

        public class CommandHandler : IRequestHandler<Command, string>
        {
            private readonly ArafahDataContext _dc;

            public CommandHandler(ArafahDataContext dc) => _dc = dc;
            public async Task<string> Handle(Command request, CancellationToken cancellationToken)
            {
                var ins = new Neracas
                {
                    neraca_id = Guid.NewGuid().ToString(),
                    tanggal_neraca = request.tanggal_neraca,
                    keterangan = request.keterangan,
                    debitkredit = request.debitkredit,
                    nominal = request.nominal,
                    QTY = request.qty
                };


                await _dc.tbl_mst_neraca.AddAsync(ins,cancellationToken);
                await _dc.SaveChangesAsync(cancellationToken);
                return ins.neraca_id;
            }
        }
    }
}
