public struct CombineInstance // TypeDefIndex: 2941
{
	// Fields
	private int m_MeshInstanceID; // 0x0
	private int m_SubMeshIndex; // 0x4
	private Matrix4x4 m_Transform; // 0x8
	private Vector4 m_LightmapScaleOffset; // 0x48
	private Vector4 m_RealtimeLightmapScaleOffset; // 0x58

	// Properties
	public Mesh mesh { set; }
	public Matrix4x4 transform { set; }

	// Methods

	// RVA: 0x37C490 Offset: 0x37C591 VA: 0x37C490
	public void set_mesh(Mesh value) { }

	// RVA: 0x37C530 Offset: 0x37C631 VA: 0x37C530
	public void set_transform(Matrix4x4 value) { }
}

