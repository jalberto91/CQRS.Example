using CQRS.Example.Domain.Entities;

namespace CQRS.Example.Application.Contracts
{
    public interface IStudentLogic
    {
        Task<IEnumerable<Student>> GetStudents();

        Task<Student> GetStudentById(string id);

        Task<Student> AddStudent(Student student);

        Task<bool> DeleteStudentById(string id);

        Task<Student> UpdateStudent(Student studentForUpdate);
    }
}