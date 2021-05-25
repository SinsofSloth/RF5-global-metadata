public struct CapEdge // TypeDefIndex: 9238
{
	// Fields
	public Vector3 v1; // 0x0
	public Vector3 v2; // 0xC
	public int nHash1; // 0x18
	public int nHash2; // 0x1C
	public float fLength; // 0x20

	// Methods

	// RVA: 0x3023A0 Offset: 0x3024A1 VA: 0x3023A0
	public void .ctor(int nHash1, int nHash2, Vector3 v1, Vector3 v2, float fLength) { }

	// RVA: 0x3023D0 Offset: 0x3024D1 VA: 0x3023D0
	public int SharesVertex1Of(CapEdge edge) { }

	// RVA: 0x302400 Offset: 0x302501 VA: 0x302400
	public int SharesVertex2Of(CapEdge edge) { }
}

