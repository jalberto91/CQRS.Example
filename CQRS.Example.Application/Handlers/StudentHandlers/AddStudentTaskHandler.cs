using CQRS.Example.Application.Commands.StudentCoomands;
using CQRS.Example.Domain.Entities;
using CQRS.Example.Infraestructure.Data.Contexts;
using MediatR;

namespace CQRS.Example.Application.Handlers.StudentHandlers
{
    public class AddStudentTaskHandler : IRequestHandler<AddStudentCommand, Student>
    {
        private readonly CqrsExampleContext context;

        public AddStudentTaskHandler(CqrsExampleContext context)
        {
            this.context = context;
        }

        public async Task<Student> Handle(AddStudentCommand request, CancellationToken cancellationToken)
        {
            var studenForAdd = new Student
            {
                GroupNumber = request.student.GroupNumber,
                ListNumber = request.student.ListNumber,
                Name = request.student.Name
            };

            this.context.Add(studenForAdd);
            await this.context.SaveChangesAsync(cancellationToken);

            return studenForAdd;
        }
    }
}