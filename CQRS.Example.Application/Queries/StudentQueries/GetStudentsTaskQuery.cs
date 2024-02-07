using CQRS.Example.Domain.Entities;
using MediatR;

namespace CQRS.Example.Application.Queries.StudentQueries
{
    public record GetStudentsTaskQuery : IRequest<IEnumerable<Student>>;
}