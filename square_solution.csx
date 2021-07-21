#load "rectangle.csx"

class Square : Rectangle {

    public float Edge {
        get {return EdgeA;} // doesn't matter whether EdgeA or EdgeB as they are equal by construction
    }

    public Square (string n, float e) : base (n, e, e) {
    }

    new public string Report {
        get {
            string report;
            report = "The edge of square " + Name + " is " + EdgeA + "." + Environment.NewLine;
            report += "The surface of square " + Name + " is " + Surface + "." + Environment.NewLine;
            report += "The circumference of square " + Name + " is " + Circumference + "." + Environment.NewLine;
            report += "Rectangle " + Name + " is " + (!IsSquare?"not ":"") + "a square." +  Environment.NewLine;
            return report;
            }
    } 

}