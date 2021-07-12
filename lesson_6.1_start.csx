// das Ziel dieser Datei ist zu zeigen, wie umständlich, unübersichtlich und fehleranfällig es ist, mit mehreren Objekten auf diese Weise zu arbeiten
// als erste Verbesserung werden wir die Berechnungen von Fläche, Umfang und ob das Rechteck ein Quadrat ist in Methoden auslagern.
// unten ist dies am Beispiel von Umfang geschehen; zur weiteren Vereinfachung wurden die Umfangsvariablen entfernt und bei der Ausgabe direkt die neue Umfangsmethode aufgerufen
// Aufgabe: ändere den Code entsprechend für die anderen beiden berechneten Werte

void Output(string name, float edgeA, float edgeB, float surface, float circumference, bool isSquare) {
    Console.WriteLine("The two edges of rectangle " + name + " are " + edgeA + " and " + edgeB + ".");
    Console.WriteLine("The surface of rectangle " + name + " is " + surface + ".");
    Console.WriteLine("The circumference of rectangle " + name + " is " + circumference + ".");
    Console.WriteLine("Rectangle " + name + " is " + (!isSquare?"not ":"")+ "a square.");
}

float circumference (float a, float b) {
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

Output("R1", r1_edgeA, r1_edgeB, r1_surface, circumference(r1_edgeA,r1_edgeB), r1_isSquare);
Output("R2", r2_edgeA, r2_edgeB, r2_surface, circumference(r2_edgeA,r2_edgeB), r2_isSquare);
