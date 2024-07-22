using Student_Data.Model;

namespace Student_Data.IRepo;

public interface IStudentRepo
{
    Task InsertStudent(Student student);
    Task<List<StudentResponse>> StudentList();
    Task<List<DropdownList>> StateList();
    Task<List<DropdownList>> GetCityByState(int id);
    Task UpdateStudent(Student student);
    Task <Student> GetById(int id);
    Task DeleteStudent(int id);
}
