using Interface;

class Program
{
    static void Main(string[] args)
    {
        Teacher t1 = new Teacher("George", 50);
        Student s1 = new Student("John", 20);

        t1.SayPersonal();
        s1.SayPersonal();

        ((IPersonal)t1).Introduce();
        ((IPersonal)s1).Introduce();

        IPersonal i1 = new Teacher("Henry", 60);
        i1.SayPersonal();
        i1.Introduce();
    }
}