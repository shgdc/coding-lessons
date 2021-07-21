void Output(string name, float edgeA, float edgeB, float surface, float circumference, bool isSquare) {
    Console.WriteLine("The two edges of rectangle " + name + " are " + edgeA + " and " + edgeB + ".");
    Console.WriteLine("The surface of rectangle " + name + " is " + surface + ".");
    Console.WriteLine("The circumference of rectangle " + name + " is " + circumference + ".");
    Console.WriteLine("Rectangle " + name + " is " + (!isSquare?"not ":"")+ "a square.");
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

float r1_edgeA; // Kante des Rechtecks
float r1_edgeB; // Kante des Rechtecks

float r2_edgeA; // Kante des Rechtecks
float r2_edgeB; // Kante des Rechtecks

r1_edgeA = 12.5f;
r1_edgeB = 9.25f;
r1_edgeB = r1_edgeA;

r2_edgeA = 12.5f;
r2_edgeB = 9.25f;


Output("R1", r1_edgeA, r1_edgeB, surface(r1_edgeA,r1_edgeB), circumference(r1_edgeA,r1_edgeB), isSquare(r1_edgeA,r1_edgeB));
Output("R2", r2_edgeA, r2_edgeB, surface(r2_edgeA,r2_edgeB), circumference(r2_edgeA,r2_edgeB), isSquare(r2_edgeA,r2_edgeB));
