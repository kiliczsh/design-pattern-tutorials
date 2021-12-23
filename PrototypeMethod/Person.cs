namespace PrototypeMethod;

public class Person
{
    public int Age;
    public DateTime BirthDate;
    public string Name;
    public IdInfo IdInfo;

    public Person(int age, DateTime birthDate, string name, IdInfo idInfo)
    {
        Age = age;
        BirthDate = birthDate;
        Name = name;
        IdInfo = idInfo;
    }

    public Person ShallowCopy()
    {
        return (Person) MemberwiseClone();
    }

    public Person DeepCopy()
    {
        var clone = (Person) MemberwiseClone();
        clone.IdInfo = new IdInfo(IdInfo.IdNumber);
        clone.Name = string.Copy(Name);
        return clone;
    }
}