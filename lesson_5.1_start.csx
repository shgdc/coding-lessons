// we now want to work with two rectangles
// so we need to have two copies of all the lines and have different variable names for the two rectangles
// task: rename all variable names below by having them start with "r1_"
// to make this much easier, see Rename Symbol here: https://code.visualstudio.com/docs/editor/refactoring#_rename-symbol

float edgeA; // Kante des Rechtecks
float edgeB; // Kante des Rechtecks

float surface; // Fläche des Rechtecks
float circumference; // Umfang des Rechtecks
bool isSquare; // Ist das Rechteck ein Quadrat?

edgeA = 12.5f;
edgeB = 9.25f;
edgeB = edgeA;

surface = edgeA * edgeB;
circumference = 2f * (edgeA + edgeB);
isSquare = edgeA == edgeB;

Console.WriteLine("The two edges of the rectangle are " + edgeA + " and " + edgeB + ".");
Console.WriteLine("The surface of the rectangle is " + surface + ".");
Console.WriteLine("The circumference of the rectangle is " + circumference + ".");
Console.WriteLine("The rectancle is " + (!isSquare?"not ":"")+ "a square.");
