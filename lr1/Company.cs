using System;

public class Company
{
    public string name { get; set; } = "";
    public int employee { get; set; } = 0;

    public Company(string name, int employee)
    {
        this.name = name;
        this.employee = employee;
    }
}