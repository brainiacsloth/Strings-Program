
{
    Console.WriteLine("This will write same line");
    Console.WriteLine("This will \n wrap to the next line");
    Console.WriteLine("This will \" print out the quotation mark");

    String firstName = "Vumboni";
    String lastName = "Msimango";
    //Concatenate

    Console.WriteLine(firstName + " " + lastName);  

    //functions with Strings
    Console.WriteLine(lastName.Length);
    //methods on Strings
    Console.WriteLine(firstName.ToUpper());
    //methods with a parameter, e.g., the contains (), it's case sensitive
    Console.WriteLine(lastName.Contains("Fu"));
    //access characters using index
    Console.WriteLine(firstName[0]);
    //index will tell us if the value is there and at what position
    Console.WriteLine("index of a is ");
    Console.WriteLine(lastName.IndexOf("a"));
    //substring, to grab from an index onwards
    Console.WriteLine(firstName.Substring(1));
    //LayoutKind can also give index and length, i.e., how many chars I want to grab
    Console.WriteLine(firstName.Substring(1, 2));
    Console.Read();
}