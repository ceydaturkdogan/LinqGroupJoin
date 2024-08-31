//Aşağıdaki görevleri yerine getirin:

//Tabloyu Tanımlayın:

//Student ve Class isimli iki sınıf oluşturun. Her bir sınıf için uygun veri türlerini kullanarak C# sınıflarını tanımlayın.

//Veri Listelemesi:


//LINQ Sorgusu:

//Öğrenciler ve sınıflar arasında group join işlemi yaparak, her sınıfın altında o sınıfa ait olan öğrencilerin listelendiği bir sonuç elde edin. Sonuçları sınıf adıyla birlikte, o sınıfa ait öğrencilerin isimleriyle birlikte ekrana yazdıran bir LINQ sorgusu yazın.

using LinqGroupJoin;

List<Student> students = new List<Student>
{
    new Student{StudentName="Ali", StudentId=1,ClassId=1},
    new Student{StudentName="Ayşe", StudentId=2,ClassId=2},
    new Student{StudentName="Mehmet", StudentId=3,ClassId=1},
    new Student{StudentName="Fatma", StudentId=4,ClassId=3},
    new Student{StudentName="Ahmet", StudentId=5,ClassId=2}

};

List<Class> classes = new List<Class>
{
    new Class{Name="Math", ClassId=1},
    new Class{Name="Turkish",ClassId=2},
    new Class{Name="Chemistry",ClassId=3},

};


var groupedStudent = classes.GroupJoin(students,
    c => c.ClassId,
    s => s.ClassId,
    (c,s ) => new
    {
        Classes = c.Name,
        Name =s

    }
    );



foreach (var student in groupedStudent)
{
    Console.WriteLine($"{student.Classes}");
        foreach(var s in student.Name)
    {
        Console.WriteLine($"{s.StudentName}");
    }
}