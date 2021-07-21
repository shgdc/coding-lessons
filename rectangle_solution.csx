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
            report = "The two edges of rectangle " + Name + " are " + EdgeA + " and " + EdgeB + "." + Environment.NewLine;
            report += "The surface of rectangle " + Name + " is " + Surface + "." + Environment.NewLine;
            report += "The circumference of rectangle " + Name + " is " + Circumference + "." + Environment.NewLine;
            report += "Rectangle " + Name + " is " + (!IsSquare?"not ":"") + "a square." +  Environment.NewLine;
            return report;
        }
    }
}