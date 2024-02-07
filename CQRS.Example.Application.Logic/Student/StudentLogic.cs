using CQRS.Example.Application.Commands.StudentCoomands;
using CQRS.Example.Application.Contracts;
using CQRS.Example.Application.Queries.StudentQueries;
using MediatR;
using CQRSDomain = CQRS.Example.Domain.Entities;

namespace CQRS.Example.Application.Logic.Student
{
    public class StudentLogic : IStudentLogic
    {
        private readonly IMediator mediator;

        public StudentLogic(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task<CQRSDomain.Student> AddStudent(CQRSDomain.Student student)
        {
            try
            {
                var command = new AddStudentCommand(student);
                return await this.mediator.Send(command);
            }
            catch (Exception ex)
            {
                Exception exception = new(ex.Message, ex);
                throw exception;
            }
        }

        public async Task<bool> DeleteStudentById(string id)
        {
            var command = new DeleteStudentCommand(id);
            return await this.mediator.Send(command);
        }

        public async Task<CQRSDomain.Student> GetStudentById(string id)
        {
            try
            {
                var query = new GetStudentByIdTaskQuery(id);
                var student = await this.mediator.Send(query);
                return student;
            }
            catch (Exception ex)
            {
                Exception exception = new(ex.Message, ex);
                throw exception;
            }
        }

        public async Task<IEnumerable<CQRSDomain.Student>> GetStudents()
        {
            try
            {
                return await this.mediator.Send(new GetStudentsTaskQuery());
            }
            catch (Exception ex)
            {
                Exception exception = new(ex.Message, ex);
                throw exception;
            }
        }

        public async Task<CQRSDomain.Student> UpdateStudent(CQRSDomain.Student studentForUpdate)
        {
            try
            {
                var command = new UpdateStudentCommand(studentForUpdate);
                return await this.mediator.Send(command);
            }
            catch (Exception ex)
            {
                Exception exception = new(ex.Message, ex);
                throw exception;
            }
        }
    }
}