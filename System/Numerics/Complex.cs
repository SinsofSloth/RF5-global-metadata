[Serializable]
public struct Complex : IEquatable<Complex>, IFormattable // TypeDefIndex: 3403
{
	// Fields
	public static readonly Complex Zero; // 0x0
	public static readonly Complex One; // 0x10
	public static readonly Complex ImaginaryOne; // 0x20
	private static readonly double s_sqrtRescaleThreshold; // 0x30
	private static readonly double s_asinOverflowThreshold; // 0x38
	private static readonly double s_log2; // 0x40
	private double m_real; // 0x0
	private double m_imaginary; // 0x8

	// Properties
	public double Real { get; }
	public double Imaginary { get; }

	// Methods

	// RVA: 0x22A10 Offset: 0x22B11 VA: 0x22A10
	public void .ctor(double real, double imaginary) { }

	// RVA: 0x22A20 Offset: 0x22B21 VA: 0x22A20
	public double get_Real() { }

	// RVA: 0x22A30 Offset: 0x22B31 VA: 0x22A30
	public double get_Imaginary() { }

	// RVA: 0x22A40 Offset: 0x22B41 VA: 0x22A40 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x22B00 Offset: 0x22C01 VA: 0x22B00 Slot: 4
	public bool Equals(Complex value) { }

	// RVA: 0x22B60 Offset: 0x22C61 VA: 0x22B60 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x22BC0 Offset: 0x22CC1 VA: 0x22BC0 Slot: 3
	public override string ToString() { }

	// RVA: 0x22BD0 Offset: 0x22CD1 VA: 0x22BD0 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x1BA5DD0 Offset: 0x1BA5ED1 VA: 0x1BA5DD0
	private static void .cctor() { }
}

