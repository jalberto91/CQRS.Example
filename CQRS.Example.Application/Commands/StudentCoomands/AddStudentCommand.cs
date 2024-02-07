using CQRS.Example.Domain.Entities;
using MediatR;

namespace CQRS.Example.Application.Commands.StudentCoomands
{
    public record AddStudentCommand(Student student) : IRequest<Student>;
}