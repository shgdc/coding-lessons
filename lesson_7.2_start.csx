// bisher werden den öffentlichen Variablen der Objekte nach der Erstellung der Objekte von außen Werte zugewiesen
// besser ist es diese Variablen zu verbergen und ihre Werte mit Hilfe einer besonderen zusätzlichen Methode zu setzen
// verbergen kann man Variablen mit dem Access Modifier "private"
// die besondere Methode zum Setzen der Variablen nennt man einen Konstruktur
// im Gegensatz zu einer normalen Methode werden Konstruktoren ohne Typ für einen Rückgabewert definiert
// Konstruktoren heißen genauso wie ihre Klasse
// Konstruktoren können Parameter haben; 
// eine Klasse kann mehrere Konstruktoren haben
// Aufgaben:
//   1) verberge die Variablen der Klasse 
//   2) erstelle einen Konstruktor, um die Variablen zu setzen
//   3) passe den Rest des Programms entsprechend an

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