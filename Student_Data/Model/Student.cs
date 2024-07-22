namespace Student_Data.Model;

public class Student
{
    public int Id { get; set; }
    public int StateId {  get; set; }
    public int CityId {  get; set; }
    public string Name { get; set; }
    public string? Address { get; set; }
    public string Email { get; set; }
    public long PhoneNo { get; set; }
}
