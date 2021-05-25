public class Point2D : IComparable<Point2D> // TypeDefIndex: 9293
{
	// Fields
	protected double mX; // 0x10
	protected double mY; // 0x18

	// Properties
	public virtual double X { get; set; }
	public virtual double Y { get; set; }
	public float Xf { get; }
	public float Yf { get; }

	// Methods

	// RVA: 0x275A420 Offset: 0x275A521 VA: 0x275A420 Slot: 5
	public virtual double get_X() { }

	// RVA: 0x275A430 Offset: 0x275A531 VA: 0x275A430 Slot: 6
	public virtual void set_X(double value) { }

	// RVA: 0x275A440 Offset: 0x275A541 VA: 0x275A440 Slot: 7
	public virtual double get_Y() { }

	// RVA: 0x275A450 Offset: 0x275A551 VA: 0x275A450 Slot: 8
	public virtual void set_Y(double value) { }

	// RVA: 0x275A460 Offset: 0x275A561 VA: 0x275A460
	public float get_Xf() { }

	// RVA: 0x275A480 Offset: 0x275A581 VA: 0x275A480
	public float get_Yf() { }

	// RVA: 0x275A4A0 Offset: 0x275A5A1 VA: 0x275A4A0
	public void .ctor() { }

	// RVA: 0x275A4D0 Offset: 0x275A5D1 VA: 0x275A4D0
	public void .ctor(double x, double y) { }

	// RVA: 0x275A510 Offset: 0x275A611 VA: 0x275A510
	public void .ctor(Point2D p) { }

	// RVA: 0x275A570 Offset: 0x275A671 VA: 0x275A570 Slot: 3
	public override string ToString() { }

	// RVA: 0x275A7A0 Offset: 0x275A8A1 VA: 0x275A7A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x275A7B0 Offset: 0x275A8B1 VA: 0x275A7B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x275A860 Offset: 0x275A961 VA: 0x275A860
	public bool Equals(Point2D p) { }

	// RVA: 0x275A870 Offset: 0x275A971 VA: 0x275A870
	public bool Equals(Point2D p, double epsilon) { }

	// RVA: 0x275A9A0 Offset: 0x275AAA1 VA: 0x275A9A0 Slot: 4
	public int CompareTo(Point2D other) { }

	// RVA: 0x275AAC0 Offset: 0x275ABC1 VA: 0x275AAC0 Slot: 9
	public virtual void Set(double x, double y) { }

	// RVA: 0x275AB10 Offset: 0x275AC11 VA: 0x275AB10 Slot: 10
	public virtual void Set(Point2D p) { }

	// RVA: 0x275AB80 Offset: 0x275AC81 VA: 0x275AB80
	public void Add(Point2D p) { }

	// RVA: 0x275AC20 Offset: 0x275AD21 VA: 0x275AC20
	public void Add(double scalar) { }

	// RVA: 0x275AC90 Offset: 0x275AD91 VA: 0x275AC90
	public void Subtract(Point2D p) { }

	// RVA: 0x275AD30 Offset: 0x275AE31 VA: 0x275AD30
	public void Subtract(double scalar) { }

	// RVA: 0x275ADA0 Offset: 0x275AEA1 VA: 0x275ADA0
	public void Multiply(Point2D p) { }

	// RVA: 0x275AE40 Offset: 0x275AF41 VA: 0x275AE40
	public void Multiply(double scalar) { }

	// RVA: 0x275AEB0 Offset: 0x275AFB1 VA: 0x275AEB0
	public void Divide(Point2D p) { }

	// RVA: 0x275AF50 Offset: 0x275B051 VA: 0x275AF50
	public void Divide(double scalar) { }

	// RVA: 0x275AFC0 Offset: 0x275B0C1 VA: 0x275AFC0
	public void Negate() { }

	// RVA: 0x275B020 Offset: 0x275B121 VA: 0x275B020
	public double Magnitude() { }

	// RVA: 0x275B110 Offset: 0x275B211 VA: 0x275B110
	public double MagnitudeSquared() { }

	// RVA: 0x275B190 Offset: 0x275B291 VA: 0x275B190
	public double MagnitudeReciprocal() { }

	// RVA: 0x275B280 Offset: 0x275B381 VA: 0x275B280
	public void Normalize() { }

	// RVA: 0x275B3B0 Offset: 0x275B4B1 VA: 0x275B3B0
	public double Dot(Point2D p) { }

	// RVA: 0x275B440 Offset: 0x275B541 VA: 0x275B440
	public double Cross(Point2D p) { }

	// RVA: 0x275B4D0 Offset: 0x275B5D1 VA: 0x275B4D0
	public void Clamp(Point2D low, Point2D high) { }

	// RVA: 0x275B630 Offset: 0x275B731 VA: 0x275B630
	public void Abs() { }

	// RVA: 0x275B6E0 Offset: 0x275B7E1 VA: 0x275B6E0
	public void Reciprocal() { }

	// RVA: 0x275B790 Offset: 0x275B891 VA: 0x275B790
	public void Translate(Point2D vector) { }

	// RVA: 0x275B830 Offset: 0x275B931 VA: 0x275B830
	public void Translate(double x, double y) { }

	// RVA: 0x275B8A0 Offset: 0x275B9A1 VA: 0x275B8A0
	public void Scale(Point2D vector) { }

	// RVA: 0x275B940 Offset: 0x275BA41 VA: 0x275B940
	public void Scale(double scalar) { }

	// RVA: 0x275B9B0 Offset: 0x275BAB1 VA: 0x275B9B0
	public void Scale(double x, double y) { }

	// RVA: 0x275BA20 Offset: 0x275BB21 VA: 0x275BA20
	public void Rotate(double radians) { }

	// RVA: 0x275BB10 Offset: 0x275BC11 VA: 0x275BB10
	public void RotateDegrees(double degrees) { }

	// RVA: 0x275BB30 Offset: 0x275BC31 VA: 0x275BB30
	public static double Dot(Point2D lhs, Point2D rhs) { }

	// RVA: 0x275BBC0 Offset: 0x275BCC1 VA: 0x275BBC0
	public static double Cross(Point2D lhs, Point2D rhs) { }

	// RVA: 0x275BC50 Offset: 0x275BD51 VA: 0x275BC50
	public static Point2D Clamp(Point2D a, Point2D low, Point2D high) { }

	// RVA: 0x275BD10 Offset: 0x275BE11 VA: 0x275BD10
	public static Point2D Min(Point2D a, Point2D b) { }

	// RVA: 0x275BE50 Offset: 0x275BF51 VA: 0x275BE50
	public static Point2D Max(Point2D a, Point2D b) { }

	// RVA: 0x275BF90 Offset: 0x275C091 VA: 0x275BF90
	public static Point2D Abs(Point2D a) { }

	// RVA: 0x275C050 Offset: 0x275C151 VA: 0x275C050
	public static Point2D Reciprocal(Point2D a) { }

	// RVA: 0x275C100 Offset: 0x275C201 VA: 0x275C100
	public static Point2D Perpendicular(Point2D lhs, double scalar) { }

	// RVA: 0x275C1B0 Offset: 0x275C2B1 VA: 0x275C1B0
	public static Point2D Perpendicular(double scalar, Point2D rhs) { }

	// RVA: 0x275C260 Offset: 0x275C361 VA: 0x275C260
	public static Point2D op_Addition(Point2D lhs, Point2D rhs) { }

	// RVA: 0x275C380 Offset: 0x275C481 VA: 0x275C380
	public static Point2D op_Addition(Point2D lhs, double scalar) { }

	// RVA: 0x275C470 Offset: 0x275C571 VA: 0x275C470
	public static Point2D op_Subtraction(Point2D lhs, Point2D rhs) { }

	// RVA: 0x275C590 Offset: 0x275C691 VA: 0x275C590
	public static Point2D op_Subtraction(Point2D lhs, double scalar) { }

	// RVA: 0x275C680 Offset: 0x275C781 VA: 0x275C680
	public static Point2D op_Multiply(Point2D lhs, Point2D rhs) { }

	// RVA: 0x275C7A0 Offset: 0x275C8A1 VA: 0x275C7A0
	public static Point2D op_Multiply(Point2D lhs, double scalar) { }

	// RVA: 0x275C890 Offset: 0x275C991 VA: 0x275C890
	public static Point2D op_Multiply(double scalar, Point2D lhs) { }

	// RVA: 0x275C980 Offset: 0x275CA81 VA: 0x275C980
	public static Point2D op_Division(Point2D lhs, Point2D rhs) { }

	// RVA: 0x275CAA0 Offset: 0x275CBA1 VA: 0x275CAA0
	public static Point2D op_Division(Point2D lhs, double scalar) { }

	// RVA: 0x275CB90 Offset: 0x275CC91 VA: 0x275CB90
	public static Point2D op_UnaryNegation(Point2D p) { }

	// RVA: 0x275CC70 Offset: 0x275CD71 VA: 0x275CC70
	public static bool op_LessThan(Point2D lhs, Point2D rhs) { }

	// RVA: 0x275CCA0 Offset: 0x275CDA1 VA: 0x275CCA0
	public static bool op_GreaterThan(Point2D lhs, Point2D rhs) { }

	// RVA: 0x275CCD0 Offset: 0x275CDD1 VA: 0x275CCD0
	public static bool op_LessThanOrEqual(Point2D lhs, Point2D rhs) { }

	// RVA: 0x275CD00 Offset: 0x275CE01 VA: 0x275CD00
	public static bool op_GreaterThanOrEqual(Point2D lhs, Point2D rhs) { }
}

