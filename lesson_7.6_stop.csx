// the program is now about as short and simple as it can get
// we declare and initialize two rectangles and create output for each
#load "rectangle.csx"
Rectangle r1 = new Rectangle("R1", 12.5f,12.5f);
Rectangle r2 = new Rectangle("R2", 12.5f, 9.25f);

Console.Write(r1.Report);
Console.Write(r2.Report);