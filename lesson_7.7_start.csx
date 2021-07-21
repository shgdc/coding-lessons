// create a new file called square.csx
// define a new class for squares called Square
// make class Square derive from class Rectangle
// --> you define a class B that derives from a class A by writing: class B : A 
// --> by deriving class Square from class Rectangle
//     * you say that a Square is a type of Rectangle
//     * because of that you can use in class Square all variables, properties and methods from Rectangle
// add a constructor to class Square
// --> you know it has to be called like the class, so Square
// --> you know it has to be public to be usable for creating squares
// --> take a look at the Rectangle constructor
// --> it starts like this: public Rectangle (string n, float a, float b)
// --> the constructor Square does not need two float parameters but only one
// --> that is because all sides of a Square are equal
// --> so the constructor Square should start like this: public Square (string n, float e)
// --> but since Square builds on Rectangle it needs to call the Rectangle constructor
// --> you write this as follows: public Square (string n, float e) : base (n,e,e)
// --> see https://nhoxbypass.medium.com/constructor-and-inheritance-in-c-4a43ef68582
// --> see https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/base
// --> in our case, the body of the Square constructor can remain empty
// copy the Report property from Rectangle and modify it
// --> note that VS Code underlines Report and says: 
// --> "'Square.Report' hides inherited member 'Rectangle.Report'. Use the new keyword if hiding was intended."
// --> add new at the beginning of the declaration of the Report property
// copy the Circumference property from rectangle
// add "new" to the beginning as above
// --> modify the return value to make use of what is special about a square
// --> add a statement writing a message to the console to make sure this property is used
// in this file load square.csx, create two squares and output the reports