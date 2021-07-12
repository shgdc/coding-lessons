// we now want to work with two rectangles
// so we need to have two copies of all the lines and have different variable names for the two rectangles
// task: duplicate the variable declarations, the assignments and the output and rename the copied variable to start with "r2_"
// to make this much easier, see Find and Replace here: https://code.visualstudio.com/docs/editor/codebasics#_find-and-replace
// also, make the second rectangle non-square

float r1_edgeA; // Kante des Rechtecks
float r1_edgeB; // Kante des Rechtecks

float r1_surface; // Fläche des Rechtecks
float r1_circumference; // Umfang des Rechtecks
bool isSquare; // Ist das Rechteck ein Quadrat?

r1_edgeA = 12.5f;
r1_edgeB = 9.25f;
r1_edgeB = r1_edgeA;

r1_surface = r1_edgeA * r1_edgeB;
r1_circumference = 2f * (r1_edgeA + r1_edgeB);
isSquare = r1_edgeA == r1_edgeB;

Console.WriteLine("The two edges of the rectangle are " + r1_edgeA + " and " + r1_edgeB + ".");
Console.WriteLine("The surface of the rectangle is " + r1_surface + ".");
Console.WriteLine("The circumference of the rectangle is " + r1_circumference + ".");
Console.WriteLine("The rectancle is " + (!isSquare?"not ":"")+ "a square.");
