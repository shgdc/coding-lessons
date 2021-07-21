// we are missing one more step to complete the class Rectangle
// that step is about the output
// if you look at the Output method, it writes text to the console
// ask yourself: what would we do if we wanted to output the text somewhere else?
// we would have to repeat much of the Output method and that is not good practice
// the better approach is to separate constructing the text from actually doing the output
// that way we can do different kinds of output while always using the same text
// a good approach for constructing the text is defining a Report property in the Rectangle class
// the one thing to know for that is how to create a string that has several lines
// you do that by using the special character Environment.NewLine where a new line is needed
// tasks
// 1) create a new property called Report in the Rectangle class
// 2) in the get access method construct and return a string with the same text written by the Output method
// 3) delete the Output methods and use this Report property instead

void Output(string name, float edgeA, float edgeB, float surface, float circumference, bool isSquare) {
    Console.WriteLine("The two edges of rectangle " + name + " are " + edgeA + " and " + edgeB + ".");
    Console.WriteLine("The surface of rectangle " + name + " is " + surface + ".");
    Console.WriteLine("The circumference of rectangle " + name + " is " + circumference + ".");
    Console.WriteLine("Rectangle " + name + " is " + (!isSquare?"not ":"")+ "a square.");
}
void Output(Rectangle r) {
    Output (r.Name, r.EdgeA, r.EdgeB, r.Surface, r.Circumference, r.IsSquare);
}

class Rectangle {
    string name;
    float edgeA;
    float edgeB;

    public string Name {
        get {return name;}
    }    
    public float EdgeA {
        get {return edgeA;}
    }

    public float EdgeB {
        get {return edgeB;}
    }

    public float Circumference {
        get {return 2 * (edgeA + edgeB);}
    }

    public float Surface {
        get {return edgeA * edgeB;}
    }

    public bool IsSquare {
        get {return edgeA == edgeB;}
    }
    public Rectangle (string n, float a, float b) {
        name = n;
        edgeA = a;
        edgeB = b;
    }
}

Rectangle r1 = new Rectangle("R1", 12.5f,12.5f);
Rectangle r2 = new Rectangle("R2", 12.5f, 9.25f);

Output(r1);
Output(r2);