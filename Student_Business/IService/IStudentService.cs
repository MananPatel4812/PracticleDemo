using Student_Data.Model;

namespace Student_Business.IService;

public interface IStudentService
{
    Task InsertStudent(Student student);
    Task<IEnumerable<StudentResponse>> StudentList();
    Task<IEnumerable<DropdownList>> StateList();
    Task<IEnumerable<DropdownList>> GetCityByStateList(int id);
    Task UpdateStudent(Student student);
    Task<Student> GetById(int id);
    Task DeleteStudent(int id);
}
