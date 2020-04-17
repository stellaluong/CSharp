using System;

namespace FamilyTree
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Status { get; set; }

        public Person Father { get; set; }

        public Person Mother { get; set; }

        public string GetDescription()
        {
            var startTxt = $"{FirstName} {LastName} (Id:{Id}) Father: {Father?.FirstName} (Id:{Father?.Id}) Mother: {Mother?.FirstName} (Id:{Mother?.Id})";

            return startTxt;

        }


        public void ShowPerson()
        {
            if (Id != 0) Console.WriteLine($"Id: {Id}");
            if (FirstName != null) Console.WriteLine($"First Name: {FirstName}");
            if (LastName != null) Console.WriteLine($"Last Name: {LastName}");
            if (Status != null) Console.WriteLine($"{Status}");
            if (Father != null) Console.WriteLine($"Father's name: {Father.FirstName}, ID: {Father.Id}");
            if (Mother != null) Console.WriteLine($"Mother's name: {Mother.FirstName}, ID: {Mother.Id}");
        }

    }
}