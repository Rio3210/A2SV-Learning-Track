using System;

class shape {
    public string name { get; set; }
    public virtual double CalculateArea() {
        return 0;
    }
}

class circle : shape {
    public double radius { get; set; }
    public override double CalculateArea() {
        return Math.PI * radius * radius;
    }
}

class rectangle : shape {
    public double width { get; set; }
    public double height { get; set; }
    public override double CalculateArea() {
        return width * height;
    }
}

class triangle : shape {
    public double width { get; set; }
    public double height { get; set; }
    public override double CalculateArea() {
        return width * height / 2;
    }
}

class Program {
    static void PrintShapeArea(shape s) {
        Console.WriteLine("The area of the {0} is {1}", s.name, s.CalculateArea());
    }
    static void Main(string[] args) {
        circle c = new circle();
        c.name = "Circle";
        c.radius = 2;
        PrintShapeArea(c);

        rectangle r = new rectangle();
        r.name = "Rectangle";
        r.width = 2;
        r.height = 3;
        PrintShapeArea(r);

        triangle t = new triangle();
        t.name = "Triangle";
        t.width = 2;
        t.height = 3;
        PrintShapeArea(t);
    }
}
