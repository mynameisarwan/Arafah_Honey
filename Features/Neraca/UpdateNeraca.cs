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
    public class UpdateNeraca
    {
        public class UpdCommand : IRequest<Neracas>
        {
            public string neraca_id { get; set; }
            public DateTime tanggal_neraca { get; set; }
            public string keterangan { get; set; }
            public string debitkredit { get; set; }
            public decimal nominal { get; set; }
            public decimal qty { get; set; }
        }

        public class CommandHandler : IRequestHandler<UpdCommand, Neracas>
        {
            private readonly ArafahDataContext _dc;

            public CommandHandler(ArafahDataContext dc) => _dc = dc;
            public async Task<Neracas> Handle(UpdCommand request, CancellationToken cancellationToken)
            {
                var upd = await _dc.tbl_mst_neraca.FindAsync(request.neraca_id);
                if (upd == null) return null;
                upd.keterangan = request.keterangan;
                upd.debitkredit = request.debitkredit;
                upd.nominal = request.nominal;
                upd.tanggal_neraca = request.tanggal_neraca;
                upd.QTY = request.qty;
                await _dc.SaveChangesAsync(cancellationToken);
                return upd;
            }
        }
    }
}
