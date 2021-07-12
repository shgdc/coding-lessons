// wie man sieht kann man das Programm mit dem aktuellen Ansatz nicht wieder läuffähig machen, denn es fehlt Zugriff auf die Objekt-Variablen
// im nächsten Schritt stellen wir den Zugriff wieder her

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