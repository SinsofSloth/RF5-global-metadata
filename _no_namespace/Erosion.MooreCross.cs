private struct Erosion.MooreCross // TypeDefIndex: 9714
{
	// Fields
	public float c; // 0x0
	public float px; // 0x4
	public float nx; // 0x8
	public float pxpz; // 0xC
	public float nxpz; // 0x10
	public float pz; // 0x14
	public float nz; // 0x18
	public float pxnz; // 0x1C
	public float nxnz; // 0x20

	// Properties
	public bool isNaN { get; }
	public float max { get; }
	public float min { get; }
	public float sum { get; }

	// Methods

	// RVA: 0x37AC80 Offset: 0x37AD81 VA: 0x37AC80
	public void .ctor(float c, float px, float nx, float pz, float nz, float pxpz, float nxpz, float pxnz, float nxnz) { }

	// RVA: 0x37ACB0 Offset: 0x37ADB1 VA: 0x37ACB0
	public void .ctor(Erosion.MooreCross src) { }

	// RVA: 0x37ACD0 Offset: 0x37ADD1 VA: 0x37ACD0
	public void .ctor(float[] m, int sizeX, int sizeZ, int i) { }

	// RVA: 0x37ACE0 Offset: 0x37ADE1 VA: 0x37ACE0
	public void .ctor(Matrix m, int i) { }

	// RVA: 0x37ACF0 Offset: 0x37ADF1 VA: 0x37ACF0
	public void ToMatrix(float[] m, int sizeX, int sizeZ, int i) { }

	// RVA: 0x37AD00 Offset: 0x37AE01 VA: 0x37AD00
	public void ToMatrix(Matrix m, int i) { }

	// RVA: 0x37AD10 Offset: 0x37AE11 VA: 0x37AD10
	public void Percent() { }

	// RVA: 0x37ADB0 Offset: 0x37AEB1 VA: 0x37ADB0
	public bool get_isNaN() { }

	// RVA: 0x37ADC0 Offset: 0x37AEC1 VA: 0x37ADC0 Slot: 3
	public override string ToString() { }

	// RVA: 0x37ADD0 Offset: 0x37AED1 VA: 0x37ADD0
	public void ClampPositive() { }

	// RVA: 0x37AE40 Offset: 0x37AF41 VA: 0x37AE40
	public float get_max() { }

	// RVA: 0x37AE50 Offset: 0x37AF51 VA: 0x37AE50
	public float get_min() { }

	// RVA: 0x37AE60 Offset: 0x37AF61 VA: 0x37AE60
	public float get_sum() { }

	// RVA: 0x37AE80 Offset: 0x37AF81 VA: 0x37AE80
	public void Multiply(float f) { }

	// RVA: 0x37AEE0 Offset: 0x37AFE1 VA: 0x37AEE0
	public void Add(float f) { }

	// RVA: 0x37AF40 Offset: 0x37B041 VA: 0x37AF40
	public void Add(Erosion.MooreCross c2) { }

	// RVA: 0x37AFB0 Offset: 0x37B0B1 VA: 0x37AFB0
	public void Subtract(float f) { }

	// RVA: 0x37B010 Offset: 0x37B111 VA: 0x37B010
	public void SubtractInverse(float f) { }

	// RVA: 0x2AEBD10 Offset: 0x2AEBE11 VA: 0x2AEBD10
	public static Erosion.MooreCross op_Addition(Erosion.MooreCross c1, Erosion.MooreCross c2) { }

	// RVA: 0x2AEBD80 Offset: 0x2AEBE81 VA: 0x2AEBD80
	public static Erosion.MooreCross op_Addition(Erosion.MooreCross c1, float f) { }

	// RVA: 0x2AEBDE0 Offset: 0x2AEBEE1 VA: 0x2AEBDE0
	public static Erosion.MooreCross op_Subtraction(Erosion.MooreCross c1, Erosion.MooreCross c2) { }

	// RVA: 0x2AEBE50 Offset: 0x2AEBF51 VA: 0x2AEBE50
	public static Erosion.MooreCross op_Subtraction(float f, Erosion.MooreCross c2) { }

	// RVA: 0x2AEBEB0 Offset: 0x2AEBFB1 VA: 0x2AEBEB0
	public static Erosion.MooreCross op_Subtraction(Erosion.MooreCross c1, float f) { }

	// RVA: 0x2AEBF10 Offset: 0x2AEC011 VA: 0x2AEBF10
	public static Erosion.MooreCross op_Multiply(Erosion.MooreCross c1, Erosion.MooreCross c2) { }

	// RVA: 0x2AEBF80 Offset: 0x2AEC081 VA: 0x2AEBF80
	public static Erosion.MooreCross op_Multiply(float f, Erosion.MooreCross c2) { }

	// RVA: 0x2AEBFE0 Offset: 0x2AEC0E1 VA: 0x2AEBFE0
	public static Erosion.MooreCross op_Multiply(Erosion.MooreCross c1, float f) { }

	// RVA: 0x2AEC040 Offset: 0x2AEC141 VA: 0x2AEC040
	public static Erosion.MooreCross op_Division(Erosion.MooreCross c1, float f) { }

	// RVA: 0x37B070 Offset: 0x37B171 VA: 0x37B070
	public Erosion.MooreCross PercentObsolete() { }

	// RVA: 0x37B140 Offset: 0x37B241 VA: 0x37B140
	public Erosion.MooreCross ClampPositiveObsolete() { }
}

