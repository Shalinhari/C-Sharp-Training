using System;
public class GenericProgram
{
    private string name;
    public void SetName(string name)
    {
        this.name = name;
    }
    public String GetName()
    {
        return name;
    }
}
class program { 
    public static void Main(string[] args)
    {
        GenericProgram obj = new GenericProgram();
        obj.SetName("Shalin");
        Console.WriteLine(obj.GetName());   
    }
}


