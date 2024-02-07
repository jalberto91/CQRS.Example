using CQRS.Example.Application.Commands.StudentCoomands;
using CQRS.Example.Domain.Entities;
using CQRS.Example.Infraestructure.Data.Contexts;
using MediatR;

namespace CQRS.Example.Application.Handlers.StudentHandlers
{
    public class UpdateStudentTaskHandler : IRequestHandler<UpdateStudentCommand, Student>
    {
        private readonly CqrsExampleContext context;

        public UpdateStudentTaskHandler(CqrsExampleContext context)
        {
            this.context = context;
        }

        public async Task<Student> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
        {
            this.context.Update(request.studentForUpdate);
            await this.context.SaveChangesAsync(cancellationToken);

            return request.studentForUpdate;
        }
    }
}