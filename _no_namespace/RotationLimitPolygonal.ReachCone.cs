[Serializable]
public class RotationLimitPolygonal.ReachCone // TypeDefIndex: 9538
{
	// Fields
	public Vector3[] tetrahedron; // 0x10
	public float volume; // 0x18
	public Vector3 S; // 0x1C
	public Vector3 B; // 0x28

	// Properties
	public Vector3 o { get; }
	public Vector3 a { get; }
	public Vector3 b { get; }
	public Vector3 c { get; }
	public bool isValid { get; }

	// Methods

	// RVA: 0x2923920 Offset: 0x2923A21 VA: 0x2923920
	public Vector3 get_o() { }

	// RVA: 0x2923960 Offset: 0x2923A61 VA: 0x2923960
	public Vector3 get_a() { }

	// RVA: 0x29239A0 Offset: 0x2923AA1 VA: 0x29239A0
	public Vector3 get_b() { }

	// RVA: 0x29239E0 Offset: 0x2923AE1 VA: 0x29239E0
	public Vector3 get_c() { }

	// RVA: 0x2923020 Offset: 0x2923121 VA: 0x2923020
	public void .ctor(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c) { }

	// RVA: 0x29229C0 Offset: 0x2922AC1 VA: 0x29229C0
	public bool get_isValid() { }

	// RVA: 0x29231A0 Offset: 0x29232A1 VA: 0x29231A0
	public void Calculate() { }
}

