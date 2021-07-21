void Output(string name, float edgeA, float edgeB, float surface, float circumference, bool isSquare) {
    Console.WriteLine("The two edges of rectangle " + name + " are " + edgeA + " and " + edgeB + ".");
    Console.WriteLine("The surface of rectangle " + name + " is " + surface + ".");
    Console.WriteLine("The circumference of rectangle " + name + " is " + circumference + ".");
    Console.WriteLine("Rectangle " + name + " is " + (!isSquare?"not ":"")+ "a square.");
}
void Output(Rectangle r) {
    Output (r.Name, r.EdgeA, r.EdgeB, r.surface(), r.circumference(), r.isSquare());
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

    public Rectangle (string n, float a, float b) {
        name = n;
        edgeA = a;
        edgeB = b;
    }

    public float circumference () {
        return 2 * (edgeA + edgeB);
    }

    public float surface () {
        return edgeA * edgeB;
    }
    public bool isSquare () {
        return edgeA == edgeB;
    }
}

Rectangle r1 = new Rectangle("R1", 12.5f,12.5f);
Rectangle r2 = new Rectangle("R2", 12.5f, 9.25f);

Output(r1);
Output(r2);