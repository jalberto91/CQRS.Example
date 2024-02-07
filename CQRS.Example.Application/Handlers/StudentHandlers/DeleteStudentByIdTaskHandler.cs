using CQRS.Example.Application.Commands.StudentCoomands;
using CQRS.Example.Domain.Entities;
using CQRS.Example.Infraestructure.Data.Contexts;
using MediatR;

namespace CQRS.Example.Application.Handlers.StudentHandlers
{
    public class DeleteStudentByIdTaskHandler : IRequestHandler<DeleteStudentCommand, bool>
    {
        private readonly CqrsExampleContext context;

        public DeleteStudentByIdTaskHandler(CqrsExampleContext context)
        {
            this.context = context;
        }

        public async Task<bool> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
        {
            Student studentForDele = await this.context.Students.FindAsync(request.id);
            if (studentForDele == null)
            {
                return false;
            }
            this.context.Students.Remove(studentForDele);
            await this.context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}