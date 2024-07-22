using Student_Business.IService;
using Student_Data.IRepo;
using Student_Data.Model;

namespace Student_Business.Service
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepo _studentRepo;

        public StudentService(IStudentRepo studentRepo)
        {
            _studentRepo = studentRepo;
        }

        public async Task DeleteStudent(int id)
        {
            try 
            { 
                await _studentRepo.DeleteStudent(id);
            }
            catch(Exception) { throw; }
        }

        public async Task<Student> GetById(int id)
        {
            try 
            {
                return await _studentRepo.GetById(id);
            }
            catch(Exception) { throw; }
        }

        public async Task<IEnumerable<DropdownList>> GetCityByStateList(int id)
        {
            try
            {
                return await _studentRepo.GetCityByState(id);
            }
            catch(Exception) { throw; }
        }

        public async Task InsertStudent(Student student)
        {
            try
            {
                await _studentRepo.InsertStudent(student);
            }
            catch (Exception) { throw; }
        }

        public async Task<IEnumerable<DropdownList>> StateList()
        {
            try
            {
                return await _studentRepo.StateList();
            }
            catch (Exception) { throw; }
        }

        public async Task<IEnumerable<StudentResponse>> StudentList()
        {
            try
            {
                return await _studentRepo.StudentList();
            }
            catch (Exception) { throw; }
        }

        public async Task UpdateStudent(Student student)
        {
            try
            {
                 await _studentRepo.UpdateStudent(student);
            }
            catch (Exception) { throw; }
        }
    }
}
