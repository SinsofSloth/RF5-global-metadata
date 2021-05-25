private class Simplifier.Vertex // TypeDefIndex: 9214
{
	// Fields
	public Vector3 m_v3Position; // 0x10
	public Vector3 m_v3PositionWorld; // 0x1C
	public bool m_bHasBoneWeight; // 0x28
	public BoneWeight m_boneWeight; // 0x2C
	public int m_nID; // 0x4C
	public List<Simplifier.Vertex> m_listNeighbors; // 0x50
	public List<Simplifier.Triangle> m_listFaces; // 0x58
	public float m_fObjDist; // 0x60
	public Simplifier.Vertex m_collapse; // 0x68
	public int m_nHeapSpot; // 0x70

	// Methods

	// RVA: 0x1F5A8E0 Offset: 0x1F5A9E1 VA: 0x1F5A8E0
	public void .ctor(Simplifier simplifier, Vector3 v, Vector3 v3World, bool bHasBoneWeight, BoneWeight boneWeight, int nID) { }

	// RVA: 0x1F59A90 Offset: 0x1F59B91 VA: 0x1F59A90
	public void Destructor(Simplifier simplifier) { }

	// RVA: 0x1F5EED0 Offset: 0x1F5EFD1 VA: 0x1F5EED0
	public void RemoveIfNonNeighbor(Simplifier.Vertex n) { }

	// RVA: 0x1F58E20 Offset: 0x1F58F21 VA: 0x1F58E20
	public bool IsBorder() { }
}

