public class VertexPool // TypeDefIndex: 9105
{
	// Fields
	public Vector3[] Vertices; // 0x10
	public int[] Indices; // 0x18
	public Vector2[] UVs; // 0x20
	public Color[] Colors; // 0x28
	public bool IndiceChanged; // 0x30
	public bool ColorChanged; // 0x31
	public bool UVChanged; // 0x32
	public bool VertChanged; // 0x33
	public bool UV2Changed; // 0x34
	protected int VertexTotal; // 0x38
	protected int VertexUsed; // 0x3C
	protected int IndexTotal; // 0x40
	protected int IndexUsed; // 0x44
	public bool FirstUpdate; // 0x48
	protected bool VertCountChanged; // 0x49
	public const int BlockSize = 108;
	public float BoundsScheduleTime; // 0x4C
	public float ElapsedTime; // 0x50
	protected XWeaponTrail _owner; // 0x58
	protected MeshFilter _meshFilter; // 0x60
	protected Mesh _mesh2d; // 0x68
	protected Material _material; // 0x70

	// Properties
	public Mesh MyMesh { get; }

	// Methods

	// RVA: 0x1D0FCC0 Offset: 0x1D0FDC1 VA: 0x1D0FCC0
	public Mesh get_MyMesh() { }

	// RVA: 0x1D0FDD0 Offset: 0x1D0FED1 VA: 0x1D0FDD0
	public void RecalculateBounds() { }

	// RVA: 0x1D0FDF0 Offset: 0x1D0FEF1 VA: 0x1D0FDF0
	public void SetMeshObjectActive(bool flag) { }

	// RVA: 0x1D0FEB0 Offset: 0x1D0FFB1 VA: 0x1D0FEB0
	private void CreateMeshObj(XWeaponTrail owner, Material material) { }

	// RVA: 0x1D101D0 Offset: 0x1D102D1 VA: 0x1D101D0
	public void Destroy() { }

	// RVA: 0x1D102F0 Offset: 0x1D103F1 VA: 0x1D102F0
	public void .ctor(Material material, XWeaponTrail owner) { }

	// RVA: 0x1D104E0 Offset: 0x1D105E1 VA: 0x1D104E0
	public VertexPool.VertexSegment GetVertices(int vcount, int icount) { }

	// RVA: 0x1D103F0 Offset: 0x1D104F1 VA: 0x1D103F0
	protected void InitArrays() { }

	// RVA: 0x1D10650 Offset: 0x1D10751 VA: 0x1D10650
	public void EnlargeArrays(int count, int icount) { }

	// RVA: 0x1D10840 Offset: 0x1D10941 VA: 0x1D10840
	public void LateUpdate() { }
}

