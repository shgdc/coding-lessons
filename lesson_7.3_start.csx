// man könnte den Zugriff auf die privaten Objekt-Variablen mit Hilfe von öffentlichen Methoden herstellen
// aber für genau diesen Zweck gibt es einen besonderen Ansatz, die sogenannten Object-Properties
// siehe https://www.w3schools.com/cs/cs_properties.asp
// diese ermöglichen es unter anderem dafür zu sorgen, dass den Objekt-Variablen keine unerwünschten Werte zugewiesen werden
// Object Properties heißen genauso wie die entsprechenden Variablen, werden aber groß geschrieben
// diese Objekteigenschaften sind wie eine Kombination aus einer Variable und drei festgelegten Zugriffsmethoden
// nämlich get, set und init
// die Zugriffsmethoden können, müssen aber nicht definiert werden
// durch Weglassen der get-Zugriffsmethode kann man z.B. Schreibzugriff verhindern
// Aufgaben:
// 1) füge der Klasse zwei Eigenschaften EdgeA und EdgeB hinzu
// 2) definiere jeweils nur die get-Methode für diese Eigenschaften
// 3) passe den Rest des Programms ensprechend an

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