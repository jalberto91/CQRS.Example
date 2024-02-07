using CQRS.Example.Application.Queries.StudentQueries;
using CQRS.Example.Domain.Entities;
using CQRS.Example.Infraestructure.Data.Contexts;
using MediatR;

namespace CQRS.Example.Application.Handlers.StudentHandlers
{
    public class GetStudentByIdTaskHandler : IRequestHandler<GetStudentByIdTaskQuery, Student>
    {
        private readonly CqrsExampleContext context;

        public GetStudentByIdTaskHandler(CqrsExampleContext context)
        {
            this.context = context;
        }

        public async Task<Student> Handle(GetStudentByIdTaskQuery request, CancellationToken cancellationToken)
        {
            var student = await this.context.Students.FindAsync(request.id, cancellationToken);
            return student ?? null;
        }
    }
}