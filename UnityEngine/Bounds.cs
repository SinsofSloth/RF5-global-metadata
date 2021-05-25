[RequiredByNativeCodeAttribute] // RVA: 0xC4690 Offset: 0xC4791 VA: 0xC4690
[NativeHeaderAttribute] // RVA: 0xC4690 Offset: 0xC4791 VA: 0xC4690
[NativeHeaderAttribute] // RVA: 0xC4690 Offset: 0xC4791 VA: 0xC4690
[NativeTypeAttribute] // RVA: 0xC4690 Offset: 0xC4791 VA: 0xC4690
[NativeHeaderAttribute] // RVA: 0xC4690 Offset: 0xC4791 VA: 0xC4690
[NativeClassAttribute] // RVA: 0xC4690 Offset: 0xC4791 VA: 0xC4690
[NativeHeaderAttribute] // RVA: 0xC4690 Offset: 0xC4791 VA: 0xC4690
public struct Bounds : IEquatable<Bounds> // TypeDefIndex: 2857
{
	// Fields
	private Vector3 m_Center; // 0x0
	[NativeNameAttribute] // RVA: 0xC9AC0 Offset: 0xC9BC1 VA: 0xC9AC0
	private Vector3 m_Extents; // 0xC

	// Properties
	public Vector3 center { get; set; }
	public Vector3 size { get; set; }
	public Vector3 extents { get; set; }
	public Vector3 min { get; }
	public Vector3 max { get; }

	// Methods

	// RVA: 0x37B9D0 Offset: 0x37BAD1 VA: 0x37B9D0
	public void .ctor(Vector3 center, Vector3 size) { }

	// RVA: 0x37BA90 Offset: 0x37BB91 VA: 0x37BA90 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x37BB00 Offset: 0x37BC01 VA: 0x37BB00 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x37BB10 Offset: 0x37BC11 VA: 0x37BB10 Slot: 4
	public bool Equals(Bounds other) { }

	// RVA: 0x37BBB0 Offset: 0x37BCB1 VA: 0x37BBB0
	public Vector3 get_center() { }

	// RVA: 0x37BBC0 Offset: 0x37BCC1 VA: 0x37BBC0
	public void set_center(Vector3 value) { }

	// RVA: 0x37BBD0 Offset: 0x37BCD1 VA: 0x37BBD0
	public Vector3 get_size() { }

	// RVA: 0x37BC60 Offset: 0x37BD61 VA: 0x37BC60
	public void set_size(Vector3 value) { }

	// RVA: 0x37BD00 Offset: 0x37BE01 VA: 0x37BD00
	public Vector3 get_extents() { }

	// RVA: 0x37BD10 Offset: 0x37BE11 VA: 0x37BD10
	public void set_extents(Vector3 value) { }

	// RVA: 0x37BD20 Offset: 0x37BE21 VA: 0x37BD20
	public Vector3 get_min() { }

	// RVA: 0x37BDC0 Offset: 0x37BEC1 VA: 0x37BDC0
	public Vector3 get_max() { }

	// RVA: 0x2AF94C0 Offset: 0x2AF95C1 VA: 0x2AF94C0
	public static bool op_Equality(Bounds lhs, Bounds rhs) { }

	// RVA: 0x2AF95E0 Offset: 0x2AF96E1 VA: 0x2AF95E0
	public static bool op_Inequality(Bounds lhs, Bounds rhs) { }

	// RVA: 0x37BE60 Offset: 0x37BF61 VA: 0x37BE60
	public void SetMinMax(Vector3 min, Vector3 max) { }

	// RVA: 0x37BE70 Offset: 0x37BF71 VA: 0x37BE70
	public void Encapsulate(Vector3 point) { }

	// RVA: 0x37BE80 Offset: 0x37BF81 VA: 0x37BE80
	public void Encapsulate(Bounds bounds) { }

	// RVA: 0x37BEC0 Offset: 0x37BFC1 VA: 0x37BEC0
	public void Expand(float amount) { }

	// RVA: 0x37BED0 Offset: 0x37BFD1 VA: 0x37BED0 Slot: 3
	public override string ToString() { }

	[NativeMethodAttribute] // RVA: 0xCDD70 Offset: 0xCDE71 VA: 0xCDD70
	// RVA: 0x37BEE0 Offset: 0x37BFE1 VA: 0x37BEE0
	public bool Contains(Vector3 point) { }

	// RVA: 0x2AF9C60 Offset: 0x2AF9D61 VA: 0x2AF9C60
	private static bool Contains_Injected(ref Bounds _unity_self, ref Vector3 point) { }
}

