[Serializable]
public struct Edge : IEquatable<Edge> // TypeDefIndex: 5948
{
	// Fields
	public int a; // 0x0
	public int b; // 0x4
	public static readonly Edge Empty; // 0x0

	// Methods

	// RVA: 0x190A0 Offset: 0x191A1 VA: 0x190A0
	public void .ctor(int a, int b) { }

	// RVA: 0x190B0 Offset: 0x191B1 VA: 0x190B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x190C0 Offset: 0x191C1 VA: 0x190C0 Slot: 4
	public bool Equals(Edge other) { }

	// RVA: 0x19110 Offset: 0x19211 VA: 0x19110 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x19210 Offset: 0x19311 VA: 0x19210 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1A91AD0 Offset: 0x1A91BD1 VA: 0x1A91AD0
	private static void .cctor() { }
}

