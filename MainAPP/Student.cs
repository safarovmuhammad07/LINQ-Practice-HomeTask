using System.Security.Principal;

namespace MainAPP;

public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public Gender Gender { get; set; }
    public Status Status { get; set; }
    public DateTime DateOfStart  { get; set; }
    public DateTime DateOfFinish { get; set; }
}