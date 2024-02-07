using MediatR;

namespace CQRS.Example.Application.Commands.StudentCoomands
{
    public record DeleteStudentCommand(string id) : IRequest<bool>;
}