using CQRS.Example.Domain.Entities;
using MediatR;

namespace CQRS.Example.Application.Queries.StudentQueries
{
    public record GetStudentByIdTaskQuery(string id) : IRequest<Student>;
}