// so far we have directly assigned values to public variables of Rectangle objects
// that approach is often not ideal, so let's look at a better one
// let's make the variables private and use a special, additional method to assign values to them
// to make the variables private, you start the declaration with the Access Modifier "private"
// the special method for setting the variables is called a constructor
// it is called a constructor because it can be used to create a new object and initialize its values
// here are key points about constructors:
// in contrast to normal methods constructors are declared without a return type
// constructors are called exactly like their class
// constructors can have parameters
// a class can have several constructors
// tasks:
// 1) hide the variables of the class
// 2) create a constructor to set all variables of the class
// 3) modify the rest of the program as necessary

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
    public string name;
    public float edgeA;
    public float edgeB;
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

Rectangle r1 = new Rectangle();
Rectangle r2 = new Rectangle();

r1.name = "R1";
r1.edgeA = 12.5f;
r1.edgeB = 9.25f;
r1.edgeB = r1.edgeA;

r1.name = "R2";
r2.edgeA = 12.5f;
r2.edgeB = 9.25f;

Output(r1);
Output(r2);