using System.Threading;
using System.Collections.Generic;
using System.Diagnostics;
using MediatR;
using Domain;
using System.Threading.Tasks;
using Persistence;
using Microsoft.EntityFrameworkCore;

namespace Application.Activities
{
    public class List
    {
        public class Query : IRequest<List<Domain.Activity>> { }

        public class Handler : IRequestHandler<Query, List<Domain.Activity>>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }
            public async Task<List<Domain.Activity>> Handle(Query request, CancellationToken cancellationToken)
            {
                var activities = await _context.Activities.ToListAsync();
                return activities;
            }
        }

    }
}