using System.Diagnostics;
using System;
using Domain;
using MediatR;
using System.Threading.Tasks;
using System.Threading;
using Persistence;

namespace Application.Activities
{
    public class Details
    {
        public class Query : IRequest<Domain.Activity>
        {
            public Guid Id { get; set; }
        }
        public class Handler : IRequestHandler<Query, Domain.Activity>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }
            public async Task<Domain.Activity> Handle(Query request, CancellationToken cancellationToken)
            {
                var activity = await _context.Activities.FindAsync(request.Id);
                return activity;
            }
        }
    }
}