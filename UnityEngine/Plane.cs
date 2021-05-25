[UsedByNativeCodeAttribute] // RVA: 0xC47C0 Offset: 0xC48C1 VA: 0xC47C0
public struct Plane // TypeDefIndex: 2859
{
	// Fields
	private Vector3 m_Normal; // 0x0
	private float m_Distance; // 0xC

	// Properties
	public Vector3 normal { get; }
	public float distance { get; }

	// Methods

	// RVA: 0x37EED0 Offset: 0x37EFD1 VA: 0x37EED0
	public Vector3 get_normal() { }

	// RVA: 0x37EEE0 Offset: 0x37EFE1 VA: 0x37EEE0
	public float get_distance() { }

	// RVA: 0x37EEF0 Offset: 0x37EFF1 VA: 0x37EEF0
	public void .ctor(Vector3 inNormal, Vector3 inPoint) { }

	// RVA: 0x37EFC0 Offset: 0x37F0C1 VA: 0x37EFC0
	public void .ctor(Vector3 a, Vector3 b, Vector3 c) { }

	// RVA: 0x37EFE0 Offset: 0x37F0E1 VA: 0x37EFE0
	public void SetNormalAndPosition(Vector3 inNormal, Vector3 inPoint) { }

	// RVA: 0x37F0C0 Offset: 0x37F1C1 VA: 0x37F0C0
	public float GetDistanceToPoint(Vector3 point) { }

	// RVA: 0x37F180 Offset: 0x37F281 VA: 0x37F180
	public bool Raycast(Ray ray, out float enter) { }

	// RVA: 0x37F1C0 Offset: 0x37F2C1 VA: 0x37F1C0 Slot: 3
	public override string ToString() { }
}

