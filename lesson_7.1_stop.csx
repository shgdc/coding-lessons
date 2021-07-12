// man kann folgendes beobachten:
// die Kanten werden nur noch einmal in der Klasse deklariert und nicht mehr für jedes Objekt
// der Zugriff auf die Kanten mit z.B. r1.edgeA ist deutlich verschieden von r1_edgeA, obwohl er sehr ähnlich aussieht
// bei r1.edgeA und r2.edgeA handelt es sich um den Zugriff auf zwei Variablen, die in unterschiedlichen Objekten existieren
// bei r1_edgeA und r2_edgeA handelt es ich um den Zugriff auf zwei Variablen, die im gleichen Programmkontext existieren
// nämlich hier dem Hauptprogramm

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
