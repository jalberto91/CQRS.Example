using CQRS.Example.Application.Queries.StudentQueries;
using CQRS.Example.Domain.Entities;
using CQRS.Example.Infraestructure.Data.Contexts;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CQRS.Example.Application.Handlers.StudentHandlers
{
    public class GetStudentsTaskHandler : IRequestHandler<GetStudentsTaskQuery, IEnumerable<Student>>
    {
        private readonly CqrsExampleContext context;

        public GetStudentsTaskHandler(CqrsExampleContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Student>> Handle(GetStudentsTaskQuery request, CancellationToken cancellationToken)
        {
            var students = await this.context.Students.ToListAsync(cancellationToken);
            return students;
        }
    }
}