using Microsoft.EntityFrameworkCore;
using Student_Data.IRepo;
using Student_Data.Model;

namespace Student_Data.Repository;

public class StudentRepo : IStudentRepo
{
    private readonly StudentDbContext _context;

    public StudentRepo(StudentDbContext context)
    {
        _context = context;
    }

    public async  Task DeleteStudent(int id)
    {
        try
        {
            await _context.Database.ExecuteSqlInterpolatedAsync($" EXEC studentManager @type = 'Delete', @id={id}");
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<Student> GetById(int id)
    {
        try {
            var students =await _context.Students.FromSqlInterpolated($"EXEC studentManager @type='GetById' , @id={id}").ToListAsync();

            return students.FirstOrDefault();
        }
        catch(Exception) { throw; }
    }

    public async Task<List<DropdownList>> GetCityByState(int id)
    {
        try
        {
            return await _context.City.FromSqlRaw<DropdownList>($"EXEC studentManager @Type='GetCityByState' , @stateId={id}").ToListAsync();
        }
        catch (Exception) { throw; }
    }

    public async Task InsertStudent(Student student)
    {
        try
        {
            await _context.Database.ExecuteSqlInterpolatedAsync($" EXEC studentManager @type = 'Insert', @name={student.Name} , @address={student.Address}, @email= {student.Email}, @phoneno = {student.PhoneNo} , @cityId = {student.CityId}, @stateId = {student.StateId}");
        }
        catch (Exception) 
        {
            throw;
        }
    }

    public async Task<List<DropdownList>> StateList()
    {
        try
        {
            return await _context.State.FromSqlRaw<DropdownList>($"EXEC studentManager @Type='StateList'").ToListAsync();
        }
        catch (Exception) { throw; }
    }

    public async Task<List<StudentResponse>> StudentList()
    {
        try {
            return await _context.StudentList.FromSqlRaw<StudentResponse>($"EXEC studentManager @Type='GetAll'").ToListAsync();
        }
        catch (Exception) { throw; }
    }

    public async Task UpdateStudent(Student student)
    {
        try
        {
            await _context.Database.ExecuteSqlInterpolatedAsync($" EXEC studentManager @type = 'Update', @name={student.Name} , @address={student.Address}, @email= {student.Email}, @phoneno = {student.PhoneNo} , @cityId = {student.CityId}, @stateId = {student.StateId},@id={student.Id}");
        }
        catch (Exception)
        {
            throw;
        }
    }
}
