float edgeA; // Kante des Rechtecks
float edgeB; // Kante des Rechtecks

float surface; // Fläche des Rechtecks
float circumference; // Umfang des Rechtecks
bool isSquare; // Ist das Rechteck ein Quadrat?

edgeA = 12.5f;
edgeB = 9.25f;
//edgeB = edgeA;

surface = edgeA * edgeB;
circumference = 2f * (edgeA + edgeB);
isSquare = edgeA == edgeB;

Console.WriteLine("The two edges of the rectangle are " + edgeA + " and " + edgeB + ".");
Console.WriteLine("The surface of the rectangle is " + surface + ".");
Console.WriteLine("The circumference of the rectangle is " + circumference + ".");
if (isSquare) Console.WriteLine("The rectancle is a square.");
if (!isSquare) Console.WriteLine("The rectancle is not a square.");