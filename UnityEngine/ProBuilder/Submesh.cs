[Serializable]
public sealed class Submesh // TypeDefIndex: 5974
{
	// Fields
	[SerializeField] // RVA: 0x142200 Offset: 0x142301 VA: 0x142200
	internal int[] m_Indexes; // 0x10
	[SerializeField] // RVA: 0x142210 Offset: 0x142311 VA: 0x142210
	internal MeshTopology m_Topology; // 0x18
	[SerializeField] // RVA: 0x142220 Offset: 0x142321 VA: 0x142220
	internal int m_SubmeshIndex; // 0x1C

	// Methods

	// RVA: 0x1AA4610 Offset: 0x1AA4711 VA: 0x1AA4610
	public void .ctor(int submeshIndex, MeshTopology topology, IEnumerable<int> indexes) { }

	// RVA: 0x1AA46E0 Offset: 0x1AA47E1 VA: 0x1AA46E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1A9D3A0 Offset: 0x1A9D4A1 VA: 0x1A9D3A0
	public static Submesh[] GetSubmeshes(IEnumerable<Face> faces, int submeshCount, MeshTopology preferredTopology = 0) { }

	// RVA: 0x1A9D200 Offset: 0x1A9D301 VA: 0x1A9D200
	internal static void MapFaceMaterialsToSubmeshIndex(ProBuilderMesh mesh) { }
}

