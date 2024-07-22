using Microsoft.AspNetCore.Mvc;
using Student_Business.IService;
using Student_Data.Model;

namespace PracticleDemo.Controllers;

public class StudentController : Controller
{
    private readonly IStudentService _studentService;

    public StudentController(IStudentService studentService)
    {
         _studentService = studentService;
    }

    public async Task<IActionResult> StudentList()
    {
        var studentresponse = new StudentModel();
        studentresponse.StateList =await _studentService.StateList();
        studentresponse.StudentList = await _studentService.StudentList();

        return View(studentresponse);
    }

    public async Task<IActionResult> AddStudent()
    { 
        var studentResponse = new StudentModel();
        studentResponse.StateList = await _studentService.StateList();
        return View(studentResponse);
    }

    [HttpPost]
    public async Task<IActionResult> AddStudent(Student student) 
    { 
        await _studentService.InsertStudent(student);
        return RedirectToAction("StudentList", "Student");
    }

    public async Task<JsonResult> GetCitybyState(int stateId)
    {
        var city = await _studentService.GetCityByStateList(stateId);
        return Json(city);
    }

    public async Task<IActionResult> UpdateStudent(int id)
    {
        var studentresponse = new StudentModel();
        studentresponse.StateList = await _studentService.StateList();
        return View(studentresponse);
    }

    public async Task<JsonResult> GetStudentById(int id)
    {
        var response = await _studentService.GetById(id);
        return Json(response);
    }


    [HttpPost]
    public async Task<IActionResult> UpdateStudent(Student student)
    {
        await _studentService.UpdateStudent(student);
        return RedirectToAction("StudentList", "Student");
    }
    [HttpPost]
    public async Task<IActionResult> DeleteStudent(int id)
    {
        await _studentService.DeleteStudent(id);
        return RedirectToAction("StudentList", "Student");
    }
}
