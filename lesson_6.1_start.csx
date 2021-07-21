// the goal of this file is to illustrate a particular problem
// namely how cumbersome, confusing and error-prone it is to work with multiple objects in this way
// as a first improvement we'll do the following:
// we will move the calculations of surface etc. into methods
// below this has been done for Circumference
// two more steps simplify things further:
// 1) the variables for circumference have been removed
// 2) the output calls the Circumference method
// task: modify the code in the same way for surface and isSquare

void Output(string name, float edgeA, float edgeB, float surface, float circumference, bool isSquare) {
    Console.WriteLine("The two edges of rectangle " + name + " are " + edgeA + " and " + edgeB + ".");
    Console.WriteLine("The surface of rectangle " + name + " is " + surface + ".");
    Console.WriteLine("The circumference of rectangle " + name + " is " + circumference + ".");
    Console.WriteLine("Rectangle " + name + " is " + (!isSquare?"not ":"")+ "a square.");
}
float Circumference (float a, float b) {
    return 2 * (a + b);
}

float r1_edgeA; // Kante des Rechtecks
float r1_edgeB; // Kante des Rechtecks

float r1_surface; // Fläche des Rechtecks
bool r1_isSquare; // Ist das Rechteck ein Quadrat?

float r2_edgeA; // Kante des Rechtecks
float r2_edgeB; // Kante des Rechtecks

float r2_surface; // Fläche des Rechtecks
bool r2_isSquare; // Ist das Rechteck ein Quadrat?

r1_edgeA = 12.5f;
r1_edgeB = 9.25f;
r1_edgeB = r1_edgeA;

r1_surface = r1_edgeA * r1_edgeB;
r1_isSquare = r1_edgeA == r1_edgeB;

r2_edgeA = 12.5f;
r2_edgeB = 9.25f;

r2_surface = r2_edgeA * r2_edgeB;
r2_isSquare = r2_edgeA == r2_edgeB;

Output("R1", r1_edgeA, r1_edgeB, r1_surface, Circumference(r1_edgeA,r1_edgeB), r1_isSquare);
Output("R2", r2_edgeA, r2_edgeB, r2_surface, Circumference(r2_edgeA,r2_edgeB), r2_isSquare);
