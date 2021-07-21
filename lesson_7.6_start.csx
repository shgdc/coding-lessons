// tasks
// - create a new file called rectangles.csx and move the definition of class Rectangle into it
// - load the file rectangles.csx into the current file by adding: #load "rectangle.csx"

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
    public string Report {
        get {
            string report;
            report = "The two edges of rectangle " + name + " are " + edgeA + " and " + edgeB + "." + Environment.NewLine;
            report += "The surface of rectangle " + name + " is " + Surface + "." + Environment.NewLine;
            report += "The circumference of rectangle " + name + " is " + Circumference + "." + Environment.NewLine;
            report += "Rectangle " + name + " is " + (!IsSquare?"not ":"") + "a square." +  Environment.NewLine;
            return report;
        }
    }
}

Rectangle r1 = new Rectangle("R1", 12.5f,12.5f);
Rectangle r2 = new Rectangle("R2", 12.5f, 9.25f);

Console.Write(r1.Report);
Console.Write(r2.Report);