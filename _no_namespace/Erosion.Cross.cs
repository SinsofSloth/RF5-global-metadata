[DefaultMemberAttribute] // RVA: 0x159DC0 Offset: 0x159EC1 VA: 0x159DC0
private struct Erosion.Cross // TypeDefIndex: 9712
{
	// Fields
	public float c; // 0x0
	public float px; // 0x4
	public float nx; // 0x8
	public float pz; // 0xC
	public float nz; // 0x10

	// Properties
	public float max { get; }
	public float min { get; }
	public float sum { get; }
	public float avg { get; }
	public float avgAround { get; }
	public float maxAround { get; }
	public float minAround { get; }
	public bool isNaN { get; }
	public float Item { get; set; }

	// Methods

	// RVA: 0x37A440 Offset: 0x37A541 VA: 0x37A440
	public void .ctor(float c, float px, float nx, float pz, float nz) { }

	// RVA: 0x37A460 Offset: 0x37A561 VA: 0x37A460
	public void .ctor(Erosion.Cross src) { }

	// RVA: 0x37A480 Offset: 0x37A581 VA: 0x37A480
	public void .ctor(Erosion.Cross c1, Erosion.Cross c2) { }

	// RVA: 0x37A4C0 Offset: 0x37A5C1 VA: 0x37A4C0
	public void .ctor(float[] m, int sizeX, int sizeZ, int i) { }

	// RVA: 0x37A4D0 Offset: 0x37A5D1 VA: 0x37A4D0
	public void .ctor(bool[] m, int sizeX, int sizeZ, int i) { }

	// RVA: 0x37A4E0 Offset: 0x37A5E1 VA: 0x37A4E0
	public void .ctor(Matrix m, int i) { }

	// RVA: 0x37A4F0 Offset: 0x37A5F1 VA: 0x37A4F0
	public void ToMatrix(float[] m, int sizeX, int sizeZ, int i) { }

	// RVA: 0x37A500 Offset: 0x37A601 VA: 0x37A500
	public void ToMatrix(Matrix m, int i) { }

	// RVA: 0x37A510 Offset: 0x37A611 VA: 0x37A510
	public void Percent() { }

	// RVA: 0x37A580 Offset: 0x37A681 VA: 0x37A580
	public void ClampPositive() { }

	// RVA: 0x37A5C0 Offset: 0x37A6C1 VA: 0x37A5C0
	public float get_max() { }

	// RVA: 0x37A5D0 Offset: 0x37A6D1 VA: 0x37A5D0
	public float get_min() { }

	// RVA: 0x37A5E0 Offset: 0x37A6E1 VA: 0x37A5E0
	public float get_sum() { }

	// RVA: 0x37A600 Offset: 0x37A701 VA: 0x37A600
	public float get_avg() { }

	// RVA: 0x37A630 Offset: 0x37A731 VA: 0x37A630
	public float get_avgAround() { }

	// RVA: 0x37A650 Offset: 0x37A751 VA: 0x37A650
	public float get_maxAround() { }

	// RVA: 0x37A6F0 Offset: 0x37A7F1 VA: 0x37A6F0
	public float get_minAround() { }

	// RVA: 0x37A790 Offset: 0x37A891 VA: 0x37A790
	public void Multiply(Erosion.Cross c2) { }

	// RVA: 0x37A7D0 Offset: 0x37A8D1 VA: 0x37A7D0
	public void Multiply(float f) { }

	// RVA: 0x37A810 Offset: 0x37A911 VA: 0x37A810
	public void Add(Erosion.Cross c2) { }

	// RVA: 0x37A850 Offset: 0x37A951 VA: 0x37A850
	public void Divide(Erosion.Cross c2) { }

	// RVA: 0x37A8A0 Offset: 0x37A9A1 VA: 0x37A8A0
	public void Divide(float f) { }

	// RVA: 0x37A8E0 Offset: 0x37A9E1 VA: 0x37A8E0
	public void Subtract(float f) { }

	// RVA: 0x37A920 Offset: 0x37AA21 VA: 0x37A920
	public void SubtractInverse(float f) { }

	// RVA: 0x37A960 Offset: 0x37AA61 VA: 0x37A960
	public float GetMultipliedMax(Erosion.Cross c2) { }

	// RVA: 0x37A9A0 Offset: 0x37AAA1 VA: 0x37A9A0
	public float GetMultipliedSum(Erosion.Cross c2) { }

	// RVA: 0x37A9E0 Offset: 0x37AAE1 VA: 0x37A9E0
	public bool get_isNaN() { }

	// RVA: 0x37AA60 Offset: 0x37AB61 VA: 0x37AA60
	public float get_Item(int n) { }

	// RVA: 0x37AAB0 Offset: 0x37ABB1 VA: 0x37AAB0
	public void set_Item(int n, float value) { }

	// RVA: 0x37AB00 Offset: 0x37AC01 VA: 0x37AB00
	public void SortByHeight(int[] sorted) { }

	[IteratorStateMachineAttribute] // RVA: 0x1B5AC0 Offset: 0x1B5BC1 VA: 0x1B5AC0
	// RVA: 0x37AB10 Offset: 0x37AC11 VA: 0x37AB10
	public IEnumerable<int> Sorted() { }

	// RVA: 0x2AE9F00 Offset: 0x2AEA001 VA: 0x2AE9F00
	public static Erosion.Cross op_Addition(Erosion.Cross c1, Erosion.Cross c2) { }

	// RVA: 0x2AE9F40 Offset: 0x2AEA041 VA: 0x2AE9F40
	public static Erosion.Cross op_Addition(Erosion.Cross c1, float f) { }

	// RVA: 0x2AE9F80 Offset: 0x2AEA081 VA: 0x2AE9F80
	public static Erosion.Cross op_Subtraction(Erosion.Cross c1, Erosion.Cross c2) { }

	// RVA: 0x2AE9FC0 Offset: 0x2AEA0C1 VA: 0x2AE9FC0
	public static Erosion.Cross op_Subtraction(float f, Erosion.Cross c2) { }

	// RVA: 0x2AEA000 Offset: 0x2AEA101 VA: 0x2AEA000
	public static Erosion.Cross op_Subtraction(Erosion.Cross c1, float f) { }

	// RVA: 0x2AEA040 Offset: 0x2AEA141 VA: 0x2AEA040
	public static Erosion.Cross op_Multiply(Erosion.Cross c1, Erosion.Cross c2) { }

	// RVA: 0x2AEA080 Offset: 0x2AEA181 VA: 0x2AEA080
	public static Erosion.Cross op_Multiply(float f, Erosion.Cross c2) { }

	// RVA: 0x2AEA0C0 Offset: 0x2AEA1C1 VA: 0x2AEA0C0
	public static Erosion.Cross op_Multiply(Erosion.Cross c1, float f) { }

	// RVA: 0x2AEA100 Offset: 0x2AEA201 VA: 0x2AEA100
	public static Erosion.Cross op_Division(Erosion.Cross c1, float f) { }

	// RVA: 0x37ABC0 Offset: 0x37ACC1 VA: 0x37ABC0
	public Erosion.Cross PercentObsolete() { }

	// RVA: 0x37AC40 Offset: 0x37AD41 VA: 0x37AC40
	public Erosion.Cross ClampPositiveObsolete() { }
}

