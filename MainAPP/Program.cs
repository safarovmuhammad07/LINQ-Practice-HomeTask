// See https://aka.ms/new-console-template for more information

using MainAPP;

Console.WriteLine("Start!!!");

List<Student> students =
[
    new Student
    {
        Id = 1,
        FirstName = "John",
        LastName = "Doe",
        Age = 12,
        Gender = Gender.Male,
        Status = Status.Active,
        DateOfStart = new DateTime(2023, 1, 15),
        DateOfFinish = new DateTime(2024, 12, 15)
    },

    new Student
    {
        Id = 2,
        FirstName = "Jane",
        LastName = "Smith",
        Age = 22,
        Gender = Gender.Female,
        Status = Status.Inactive,
        DateOfStart = new DateTime(2021, 6, 1),
        DateOfFinish = new DateTime(2023, 6, 1)
    },

    new Student
    {
        Id = 3,
        FirstName = "Alex",
        LastName = "Johnson",
        Age = 29,
        Gender = Gender.Male,
        Status = Status.Active,
        DateOfStart = new DateTime(2024, 8, 20),
        DateOfFinish = new DateTime(2026, 5, 30)
    }
];



/*//Task 1
//Using a list of Student objects, write a LINQ query to select the students whose gender is "Male". Print result in foreach statement with method LINQ.
    //Учитывая список объектов Student, напишите запрос LINQ, чтобы выбрать учащихся, чей пол — Male. Распечатайте результат в операторе foreach.
var studentsQuery = students.Where(a=>a.Gender == Gender.Female).ToList();
foreach (var sq in studentsQuery)
{
    Console.WriteLine(sq.FirstName + " " + sq.LastName + " " + sq.Age + " " + sq.Gender + " " + sq.Status + " " + sq.DateOfStart + " " + sq.DateOfFinish);
}

*//*
//Task 2
//Using a list of Student objects, write a LINQ query to select the students whose status is "InActive". Print result in foreach statement.
//Имея список объектов Student, напишите запрос LINQ, чтобы выбрать учащихся со статусом InActive. Распечатайте результат в операторе foreach.

var studentsQuery = students.Where(a=>a.Status == Status.Inactive).ToList();
foreach (var sq in studentsQuery)
{
    Console.WriteLine(sq.FirstName + " " + sq.LastName + " " + sq.Age + " " + sq.Gender + " " + sq.Status + " " + sq.DateOfStart + " " + sq.DateOfFinish);
}
*/
/*
//Task 3
//Using a list of Student objects, write a LINQ query to select the students whose date of birth is greater 2000 year. Print result in foreach statement.
//Используя список объектов Student, напишите запрос LINQ, чтобы выбрать студентов, дата рождения которых больше 2000 года. Распечатайте результат в операторе foreach.


var studentsQuery = students.Where(s => s.Age< 25 ).ToList();
foreach (var sq in studentsQuery)
{
    Console.WriteLine(sq.FirstName + " " + sq.LastName + " " + sq.Age + " " + sq.Gender + " " + sq.Status + " " + sq.DateOfStart + " " + sq.DateOfFinish);

}
*/


/*
//Task 4
//Using a list of Student objects, write a LINQ query to select students who are currently studying and are over 20 years old. Print the result in a foreach statement.
//Используя список объектов Student, напишите запрос LINQ, чтобы выбрать студентов старше 20 лет, которые в настоящее время учатся. Выведите результат в операторе foreach.

var studentsquery = students.Where(a => a is { Age: > 20, Status: Status.Active }).ToList();

foreach (var sq in studentsquery)
{
    Console.WriteLine(sq.FirstName + " " + sq.LastName + " " + sq.Age + " " + sq.Gender + " " + sq.Status + " " + sq.DateOfStart + " " + sq.DateOfFinish);
}
*/


/*
Task 5
//Using a list of Student objects, write a LINQ query to select students who started studying in 16 years old. Print the result in a foreach statement.
//Используя список объектов Student, напишите запрос LINQ, чтобы выбрать учащихся, которые начали учиться в 16 лет. Выведите результат в операторе foreach.

var studentsquery=students.Where(a => (a.DateOfStart.Year-(DateTime.Now.Year-a.Age)>=16)).ToList();

foreach (var sq in studentsquery)
{
    Console.WriteLine(sq.FirstName + " " + sq.LastName + " " + sq.Age + " " + sq.Gender + " " + sq.Status + " " + sq.DateOfStart + " " + sq.DateOfFinish);
}
*/

/*
//Task 6
//Using a list of Student objects, write a LINQ query to select students who started studying when he was at least become an adult(+18). Print the result in a foreach statement.
//Используя список объектов Student, напишите запрос LINQ, чтобы выбрать учащихся, которые начали учиться, когда они, по крайней мере, стали взрослыми (+18). Выведите результат в операторе foreach.
 

var studentsQuery = students.Where(a => (a.DateOfStart.Year-(DateTime.Now.Year-a.Age)>=18)).ToList();
foreach (var sq in studentsQuery)
{
    Console.WriteLine(sq.FirstName + " " + sq.LastName + " " + sq.Age + " " + sq.Gender + " " + sq.Status + " " + sq.DateOfStart + " " + sq.DateOfFinish);
}
*/

/*
//Task 7
//Using a list of Student objects, write a LINQ query to select students who's FisrtName start with letter "A" or "I" . Print the result in a foreach statement.
//Используя список объектов Student, напишите запрос LINQ, чтобы выбрать учащихся, имя которых начинается с буквы «A» или «I». Выведите результат в операторе foreach.


var studentsQuery = students.Where(a => a.FirstName.StartsWith("A") || a.FirstName.StartsWith("I")).ToList();
foreach (var sq in studentsQuery)
{
    Console.WriteLine(sq.FirstName + " " + sq.LastName + " " + sq.Age + " " + sq.Gender + " " + sq.Status + " " + sq.DateOfStart + " " + sq.DateOfFinish);
}

*/

/*
//Task 8
//Using a list of Student objects, write a LINQ query to select students who's FisrtName and LastName start with same letter. Print the result in a foreach statement.
//Используя список объектов Student, напишите запрос LINQ, чтобы выбрать учащихся, чьи имена FisrtName и LastName начинаются с одинаковыми буквы. Выведите результат в операторе foreach.


var studentsQuery = students.Where(a => a.FirstName[0]==a.LastName[0]).ToList();
foreach (var sq in studentsQuery)
{
    Console.WriteLine(sq.FirstName + " " + sq.LastName + " " + sq.Age + " " + sq.Gender + " " + sq.Status + " " + sq.DateOfStart + " " + sq.DateOfFinish);
}
*/
/*
//Task 9
//Using a list of Student objects, write a LINQ query to select students who become an adult in time of studying. Print the result in a foreach statement.
//Используя список объектов Student, напишите запрос LINQ, чтобы выбрать учащихся, которые станут взрослыми во время учебы. Выведите результат в операторе foreach.


var studentsQuery = students.Where(s => s.Age - (DateTime.Now.Year - s.DateOfStart.Year) < 18 && s.Age - (DateTime.Now.Year - s.DateOfFinish.Year) >= 18).ToList();

foreach (var student in studentsQuery)
{
    Console.WriteLine($"{student.FirstName} {student.LastName} - Age: {student.Age}, Started: {student.DateOfStart.Year}, Finished: {student.DateOfFinish.Year}");
}
*/

/*
//Task 10
//Using a list of Student objects, write a LINQ query to select students who are not a female, are active, studying more than 2 years and are smaller than 16 years. Print the result in a foreach statement.
//Используя список объектов Student, напишите запрос LINQ, чтобы выбрать студентов, которые не являются женщинами, активны, учатся более 2 лет и младше 16 лет. Выведите результат в операторе foreach.


var studentsQuery = students.Where(s => s is { Gender: Gender.Male, Status: Status.Active } && (s.DateOfFinish.Year - s.DateOfStart.Year) > 2 && s.Age < 16) .ToList();

foreach (var student in studentsQuery)
{
    Console.WriteLine($"{student.FirstName} {student.LastName} - Age: {student.Age}, Gender: {student.Gender}, Years of Study: {s.DateOfFinish.Year - s.DateOfStart.Year}");
}
*/

