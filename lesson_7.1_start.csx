// der nächste Schritt besteht darin, für die Rechtecke eine Klasse einzuführen. 
// Die Gemeinsamkeiten der Rechtecke werden dabei an einer Stelle definiert. 
// Man kann sich die Klasse wie eine allgemeine Vorlage vorstellen, mit der man beliebig viele konkrete Objekte erzeugen kann.
// unten ist zunächst die Klasse definiert und das erste Rechteck mit Hilfe der Klasse neu als Objekt definiert worden.
// Schau Dir die beiden Zeile genau an, in denen das Rechteck erzeugt wird. In den Kommentaren dort werden die Zeilen erklärt.
// leider gibt es eine Reihe Fehlermeldungen; diese liegen daran, dass die Variablen einer Klasse von außen nicht zugreifbar sind, wenn sie wie hier edgeB deklariert werden;
// um dies zu korrieren, deklariere edgeB wie edgeA mit dem sogenannten Access Modifier "public"
// Aufgabe: ändere das zweite Rechteck entsprechend um; 
// Aufgabe: füge eine zusätzliche Methode Output hinzu, die ein Rectangle als einzigen Parameter hat und verwende sie

void Output(string name, float edgeA, float edgeB, float surface, float circumference, bool isSquare) {
    Console.WriteLine("The two edges of rectangle " + name + " are " + edgeA + " and " + edgeB + ".");
    Console.WriteLine("The surface of rectangle " + name + " is " + surface + ".");
    Console.WriteLine("The circumference of rectangle " + name + " is " + circumference + ".");
    Console.WriteLine("Rectangle " + name + " is " + (!isSquare?"not ":"")+ "a square.");
}

class Rectangle {
    public string name;
    public float edgeA;
    float edgeB;
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

float r2_edgeA; // Kante des Rechtecks
float r2_edgeB; // Kante des Rechtecks

Rectangle r1;           // die Variable r1 wird mit der von uns definierten Klasse als Typ deklariert
r1 = new Rectangle();   // der Variable r1 wird ein neues Objekt der Klasse Rectangle zugewiesen; 
                        // dafür wird eine besondere Methode der Klasse aufgerufen, die automatisch erzeugt wird; diese Methode heißt Standard-Konstruktor

r1.name = "R1";
r1.edgeA = 12.5f;
r1.edgeB = 9.25f;
r1.edgeB = r1.edgeA;

r2_edgeA = 12.5f;
r2_edgeB = 9.25f;

Output(r1.name, r1.edgeA, r1.edgeB, surface(r1.edgeA,r1.edgeB), circumference(r1.edgeA,r1.edgeB), isSquare(r1.edgeA,r1.edgeB));
Output("R2", r2_edgeA, r2_edgeB, surface(r2_edgeA,r2_edgeB), circumference(r2_edgeA,r2_edgeB), isSquare(r2_edgeA,r2_edgeB));
