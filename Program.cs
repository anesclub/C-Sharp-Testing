using System;
using System.Text;


// Functions are used to group re-usable code together in a single
// unit that can be customized with parameters.

// Functions have a return type, name, and optional parameters
float MilesToKm(float miles) {
    float result = miles * 1.6f;
    return result;
}

// A function with no return value has a 'void' type
void PrintWithPrefix(string thestr) {
    Console.WriteLine($"::> {thestr}");
}

// Call first function
Console.WriteLine($"The result is {MilesToKm(8.0f)}");
Console.WriteLine($"The result is {MilesToKm(52.0f)}");

// Call second function
PrintWithPrefix("Test string");
PrintWithPrefix("Another test string");

int NumbSample = 3;
SimpleMulti(NumbSample);


void SimpleMulti (int number)
{   
    for (int i = 0; i <= 20; i++)
    {
        Console.WriteLine($"{i} * {number} = {i*number} " );
    }
}