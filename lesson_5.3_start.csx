// at the end of the script for lesson 5.2 there are four lines of output for each of the two rectangles
// these two blocks differ only in the variables being used
// in this script, one set of these four output lines have been moved into the method Output
// it is important to understand the difference between the instructions outside and within methods
// the instructions outside methods are executed one after the other from the top of the script to the bottom
// the instructions within a method are not executed right away; instead they are executed whenever the method is called
// in the method, the variables have been renamed to be general, i.e. edgeA and no longer e.g. r1_edgeA
// for each variable to be used in method Output, a variable declaration is made in the round brackets after the name
// these are called the parameters of the method
// the method is then called two times at the end of the script
// when calling the method, values are provided in the round brackets after the method name
// these are called arguments

void Output(string name, float edgeA, float edgeB, float surface, float circumference, bool isSquare) {
    Console.WriteLine("The two edges of rectangle " + name + " are " + edgeA + " and " + edgeB + ".");
    Console.WriteLine("The surface of rectangle " + name + " is " + surface + ".");
    Console.WriteLine("The circumference of rectangle " + name + " is " + circumference + ".");
    Console.WriteLine("Rectangle " + name + " is " + (!isSquare?"not ":"")+ "a square.");
}

float r1_edgeA; // Kante des Rechtecks
float r1_edgeB; // Kante des Rechtecks

float r1_surface; // Fläche des Rechtecks
float r1_circumference; // Umfang des Rechtecks
bool r1_isSquare; // Ist das Rechteck ein Quadrat?

float r2_edgeA; // Kante des Rechtecks
float r2_edgeB; // Kante des Rechtecks

float r2_surface; // Fläche des Rechtecks
float r2_circumference; // Umfang des Rechtecks
bool r2_isSquare; // Ist das Rechteck ein Quadrat?

r1_edgeA = 12.5f;
r1_edgeB = 9.25f;
r1_edgeB = r1_edgeA;

r1_surface = r1_edgeA * r1_edgeB;
r1_circumference = 2f * (r1_edgeA + r1_edgeB);
r1_isSquare = r1_edgeA == r1_edgeB;

r2_edgeA = 12.5f;
r2_edgeB = 9.25f;

r2_surface = r2_edgeA * r2_edgeB;
r2_circumference = 2f * (r2_edgeA + r2_edgeB);
r2_isSquare = r2_edgeA == r2_edgeB;

Output("R1", r1_edgeA, r1_edgeB, r1_surface, r1_circumference, r1_isSquare);
Output("R2", r2_edgeA, r2_edgeB, r2_surface, r2_circumference, r2_isSquare);