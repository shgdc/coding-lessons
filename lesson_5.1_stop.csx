// we now want to work with two rectangles
// so we need to have two copies of all the lines and have different variable names for the two rectangles
// task: rename all variable names below by having them start with "r1_"
// to make this much easier, see Rename Symbol here: https://code.visualstudio.com/docs/editor/refactoring#_rename-symbol

float r1_edgeA; // Kante des Rechtecks
float r1_edgeB; // Kante des Rechtecks

float r1_surface; // Fläche des Rechtecks
float r1_circumference; // Umfang des Rechtecks
bool r1_isSquare; // Ist das Rechteck ein Quadrat?

r1_edgeA = 12.5f;
r1_edgeB = 9.25f;
r1_edgeB = r1_edgeA;

r1_surface = r1_edgeA * r1_edgeB;
r1_circumference = 2f * (r1_edgeA + r1_edgeB);
r1_isSquare = r1_edgeA == r1_edgeB;

Console.WriteLine("The two edges of the rectangle are " + r1_edgeA + " and " + r1_edgeB + ".");
Console.WriteLine("The surface of the rectangle is " + r1_surface + ".");
Console.WriteLine("The circumference of the rectangle is " + r1_circumference + ".");
Console.WriteLine("The rectancle is " + (!r1_isSquare?"not ":"")+ "a square.");
