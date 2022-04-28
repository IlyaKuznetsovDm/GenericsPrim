Person<int> tom = new Person<int>(546, "TOM");
Person<string> bob = new Person<string>("123sd", "Bob");
Console.WriteLine(tom.Id); 
Console.WriteLine(bob.Id);
class Person<T>
{
    public object Id { get;}   
    public string Name { get;}

    public Person(T id, string name)
    {
        Id = id;                                        //соз.конструктор
        Name = name;
    }
}



