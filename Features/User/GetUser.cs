using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arafah_Honey.Models;
using System.Threading;
using Arafah_Honey.Data;
using Microsoft.EntityFrameworkCore;

namespace Arafah_Honey.Features.Users
{
    public class GetUser
    {
        public class UserAuthCommand : IRequest<User> {
            public string UserName { get; set; }
            public string UserPassword { get; set; }
        }
        public class CommandHandlers : IRequestHandler<UserAuthCommand, User>
        {
            private readonly ArafahDataContext _db;

            public CommandHandlers(ArafahDataContext db) => _db = db;
            public async Task<User> Handle(UserAuthCommand request, CancellationToken cancellationToken)
            {
                return await _db.tbl_mst_user.FirstOrDefaultAsync(x => x.UserName == request.UserName && x.UserPassword == request.UserPassword);
            }
        }
    }
}
