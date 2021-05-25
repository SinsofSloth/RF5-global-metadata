private class Simplifier.VertexDataHash // TypeDefIndex: 9216
{
	// Fields
	private Vector3 _v3Vertex; // 0x10
	private Vector3 _v3Normal; // 0x1C
	private Vector2 _v2Mapping1; // 0x28
	private Vector2 _v2Mapping2; // 0x30
	private Color32 _color; // 0x38
	private MeshUniqueVertices.UniqueVertex _uniqueVertex; // 0x40

	// Properties
	public Vector3 Vertex { get; }
	public Vector3 Normal { get; }
	public Vector2 UV1 { get; }
	public Vector2 UV2 { get; }
	public Color32 Color { get; }

	// Methods

	// RVA: 0x1F5F040 Offset: 0x1F5F141 VA: 0x1F5F040
	public Vector3 get_Vertex() { }

	// RVA: 0x1F5F050 Offset: 0x1F5F151 VA: 0x1F5F050
	public Vector3 get_Normal() { }

	// RVA: 0x1F5F060 Offset: 0x1F5F161 VA: 0x1F5F060
	public Vector2 get_UV1() { }

	// RVA: 0x1F5F070 Offset: 0x1F5F171 VA: 0x1F5F070
	public Vector2 get_UV2() { }

	// RVA: 0x1F5F080 Offset: 0x1F5F181 VA: 0x1F5F080
	public Color32 get_Color() { }

	// RVA: 0x1F5DE60 Offset: 0x1F5DF61 VA: 0x1F5DE60
	public void .ctor(Vector3 v3Vertex, Vector3 v3Normal, Vector2 v2Mapping1, Vector2 v2Mapping2, Color32 color) { }

	// RVA: 0x1F5F090 Offset: 0x1F5F191 VA: 0x1F5F090 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1F5F250 Offset: 0x1F5F351 VA: 0x1F5F250 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1F5F270 Offset: 0x1F5F371 VA: 0x1F5F270
	public static bool op_Equality(Simplifier.VertexDataHash a, Simplifier.VertexDataHash b) { }

	// RVA: 0x1F5F290 Offset: 0x1F5F391 VA: 0x1F5F290
	public static bool op_Inequality(Simplifier.VertexDataHash a, Simplifier.VertexDataHash b) { }
}

