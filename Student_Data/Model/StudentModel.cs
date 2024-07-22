namespace Student_Data.Model
{
    public class StudentModel
    {
        public IEnumerable<StudentResponse>? StudentList { get; set; }
        public IEnumerable<DropdownList> StateList { get; set; }
        public Student student { get; set; }
    }
}
