// we now want to work with two rectangles
// so we need to have two copies of all the lines and have different variable names for the two rectangles
// task: duplicate the variable declarations, the assignments and the output and rename the copied variable to start with "r2_"
// to make this much easier, see Find and Replace here: https://code.visualstudio.com/docs/editor/codebasics#_find-and-replace
// also, make the second rectangle non-square

float r1_edgeA; // Kante des Rechtecks
float r1_edgeB; // Kante des Rechtecks

float r1_surface; // Fläche des Rechtecks
float r1_circumference; // Umfang des Rechtecks
bool r1_isSquare; // Ist das Rechteck ein Quadrat?

float r2_edgeA; // Kante des Rechtecks
float r2_edgeB; // Kante des Rechtecks

float r2_surface; // Fläche des Rechtecks
float r2_circumference; // Umfang des Rechtecks
bool r2_isSquare; // Ist das Rechteck ein Quadrat?

r1_edgeA = 12.5f;
r1_edgeB = 9.25f;
r1_edgeB = r1_edgeA;

r1_surface = r1_edgeA * r1_edgeB;
r1_circumference = 2f * (r1_edgeA + r1_edgeB);
r1_isSquare = r1_edgeA == r1_edgeB;

r2_edgeA = 12.5f;
r2_edgeB = 9.25f;

r2_surface = r2_edgeA * r2_edgeB;
r2_circumference = 2f * (r2_edgeA + r2_edgeB);
r2_isSquare = r2_edgeA == r2_edgeB;

Console.WriteLine("The two edges of rectangle R1 are " + r1_edgeA + " and " + r1_edgeB + ".");
Console.WriteLine("The surface of rectangle R1 is " + r1_surface + ".");
Console.WriteLine("The circumference of rectangle R1 is " + r1_circumference + ".");
Console.WriteLine("Rectangle R1 is " + (!r1_isSquare?"not ":"")+ "a square.");

Console.WriteLine("The two edges of rectangle r2 are " + r2_edgeA + " and " + r2_edgeB + ".");
Console.WriteLine("The surface of rectangle r2 is " + r2_surface + ".");
Console.WriteLine("The circumference of rectangle r2 is " + r2_circumference + ".");
Console.WriteLine("Rectangle r2 is " + (!r2_isSquare?"not ":"")+ "a square.");
