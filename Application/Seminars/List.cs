using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Seminars
{
    public class List
    {
        public class Query : IRequest<List<Seminar>> { }


        public class Handler : IRequestHandler<Query, List<Seminar>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;

            }
            public async Task<List<Seminar>> Handle(Query request, CancellationToken cancellationToken)
            {
                var seminars = await _context.Seminars.ToListAsync();

                return seminars;
            }
        }
    }
}
