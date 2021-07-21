// you could establish access to the private object variables through private methods
// but there is a special approach in c# exactly for the job of access to private variables
// this approach is called "properties", see https://www.w3schools.com/cs/cs_properties.asp

// one benefit of the properties approach is to enable us to prevent assigning unwanted values to variables
// here is some info on properties:
// a property is typically declared for a given private variable
// the property has the same name as the variable except that it starts with a capital letter
// properties are a combination of a variable and three predefined access methods called get, set and init
// the access methods can but do not need to be defined
// for instance, by not defining a set method one can prevent write access to the variable
// tasks:
// 1) add two properties EdgeA and EdgeB to the class
// 2) define only the get methods for these properties
// 3) modify the rest of the program

void Output(string name, float edgeA, float edgeB, float surface, float circumference, bool isSquare) {
    Console.WriteLine("The two edges of rectangle " + name + " are " + edgeA + " and " + edgeB + ".");
    Console.WriteLine("The surface of rectangle " + name + " is " + surface + ".");
    Console.WriteLine("The circumference of rectangle " + name + " is " + circumference + ".");
    Console.WriteLine("Rectangle " + name + " is " + (!isSquare?"not ":"")+ "a square.");
}
void Output(Rectangle r) {
    Output (r.name, r.edgeA, r.edgeB, surface(r.edgeA, r.edgeB), circumference(r.edgeA, r.edgeB), isSquare(r.edgeA, r.edgeB));
}

class Rectangle {
    string name;
    float edgeA;
    float edgeB;

    public Rectangle (string n, float a, float b) {
        name = n;
        edgeA = a;
        edgeB = b;
    }
}

float circumference (float a, float b) {
    return 2 * (a + b);
}

float surface (float a, float b) {
    return a * b;
}

bool isSquare (float a, float b) {
    return a == b;
}

Rectangle r1 = new Rectangle("R1", 12.5f,12.5f);
Rectangle r2 = new Rectangle("R2", 12.5f, 9.25f);

Output(r1);
Output(r2);