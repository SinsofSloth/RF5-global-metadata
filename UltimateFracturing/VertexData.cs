public class VertexData // TypeDefIndex: 9232
{
	// Fields
	public int nVertexHash; // 0x10
	public Vector3 v3Vertex; // 0x14
	public Vector3 v3Normal; // 0x20
	public Vector4 v4Tangent; // 0x2C
	public Color32 color32; // 0x3C
	public Vector2 v2Mapping1; // 0x40
	public Vector2 v2Mapping2; // 0x48
	public bool bHasNormal; // 0x50
	public bool bHasTangent; // 0x51
	public bool bHasColor32; // 0x52
	public bool bHasMapping1; // 0x53
	public bool bHasMapping2; // 0x54

	// Methods

	// RVA: 0x1F4D640 Offset: 0x1F4D741 VA: 0x1F4D640
	public void .ctor(int nVertexHash) { }

	// RVA: 0x1F553B0 Offset: 0x1F554B1 VA: 0x1F553B0
	public void .ctor(int nVertexHash, Vector3 v3Vertex, Vector3 v3Normal, Vector3 v4Tangent, Color32 color32, Vector2 v2Mapping1, Vector2 v2Mapping2, bool bHasNormal, bool bHasTangent, bool bHasColor32, bool bHasMapping1, bool bHasMapping2) { }

	// RVA: 0x1F51220 Offset: 0x1F51321 VA: 0x1F51220
	public VertexData Copy() { }

	// RVA: 0x1F55550 Offset: 0x1F55651 VA: 0x1F55550
	public static VertexData Lerp(int nVertexHash, VertexData vd1, VertexData vd2, float fT) { }

	// RVA: 0x1F55870 Offset: 0x1F55971 VA: 0x1F55870
	public static bool ClipAgainstPlane(VertexData[] aVertexDataInput, int nIndexA, int nIndexB, Vector3 v3A, Vector3 v3B, Plane planeSplit, ref VertexData clippedVertexDataOut) { }

	// RVA: 0x1F4CAC0 Offset: 0x1F4CBC1 VA: 0x1F4CAC0
	public static VertexData[] BuildVertexDataArray(Mesh mesh, Matrix4x4 mtxLocalToWorld, bool bTransformVerticesToWorld) { }

	// RVA: 0x1F4E420 Offset: 0x1F4E521 VA: 0x1F4E420
	public static void SetMeshDataFromVertexDataArray(MeshFilter meshFilter, MeshData meshData, bool bTransformVertexToLocal) { }
}

public class VertexData // TypeDefIndex: 9232
{
	// Fields
	public int nVertexHash; // 0x10
	public Vector3 v3Vertex; // 0x14
	public Vector3 v3Normal; // 0x20
	public Vector4 v4Tangent; // 0x2C
	public Color32 color32; // 0x3C
	public Vector2 v2Mapping1; // 0x40
	public Vector2 v2Mapping2; // 0x48
	public bool bHasNormal; // 0x50
	public bool bHasTangent; // 0x51
	public bool bHasColor32; // 0x52
	public bool bHasMapping1; // 0x53
	public bool bHasMapping2; // 0x54

	// Methods

	// RVA: 0x1F4D640 Offset: 0x1F4D741 VA: 0x1F4D640
	public void .ctor(int nVertexHash) { }

	// RVA: 0x1F553B0 Offset: 0x1F554B1 VA: 0x1F553B0
	public void .ctor(int nVertexHash, Vector3 v3Vertex, Vector3 v3Normal, Vector3 v4Tangent, Color32 color32, Vector2 v2Mapping1, Vector2 v2Mapping2, bool bHasNormal, bool bHasTangent, bool bHasColor32, bool bHasMapping1, bool bHasMapping2) { }

	// RVA: 0x1F51220 Offset: 0x1F51321 VA: 0x1F51220
	public VertexData Copy() { }

	// RVA: 0x1F55550 Offset: 0x1F55651 VA: 0x1F55550
	public static VertexData Lerp(int nVertexHash, VertexData vd1, VertexData vd2, float fT) { }

	// RVA: 0x1F55870 Offset: 0x1F55971 VA: 0x1F55870
	public static bool ClipAgainstPlane(VertexData[] aVertexDataInput, int nIndexA, int nIndexB, Vector3 v3A, Vector3 v3B, Plane planeSplit, ref VertexData clippedVertexDataOut) { }

	// RVA: 0x1F4CAC0 Offset: 0x1F4CBC1 VA: 0x1F4CAC0
	public static VertexData[] BuildVertexDataArray(Mesh mesh, Matrix4x4 mtxLocalToWorld, bool bTransformVerticesToWorld) { }

	// RVA: 0x1F4E420 Offset: 0x1F4E521 VA: 0x1F4E420
	public static void SetMeshDataFromVertexDataArray(MeshFilter meshFilter, MeshData meshData, bool bTransformVertexToLocal) { }
}

public class VertexData // TypeDefIndex: 9232
{
	// Fields
	public int nVertexHash; // 0x10
	public Vector3 v3Vertex; // 0x14
	public Vector3 v3Normal; // 0x20
	public Vector4 v4Tangent; // 0x2C
	public Color32 color32; // 0x3C
	public Vector2 v2Mapping1; // 0x40
	public Vector2 v2Mapping2; // 0x48
	public bool bHasNormal; // 0x50
	public bool bHasTangent; // 0x51
	public bool bHasColor32; // 0x52
	public bool bHasMapping1; // 0x53
	public bool bHasMapping2; // 0x54

	// Methods

	// RVA: 0x1F4D640 Offset: 0x1F4D741 VA: 0x1F4D640
	public void .ctor(int nVertexHash) { }

	// RVA: 0x1F553B0 Offset: 0x1F554B1 VA: 0x1F553B0
	public void .ctor(int nVertexHash, Vector3 v3Vertex, Vector3 v3Normal, Vector3 v4Tangent, Color32 color32, Vector2 v2Mapping1, Vector2 v2Mapping2, bool bHasNormal, bool bHasTangent, bool bHasColor32, bool bHasMapping1, bool bHasMapping2) { }

	// RVA: 0x1F51220 Offset: 0x1F51321 VA: 0x1F51220
	public VertexData Copy() { }

	// RVA: 0x1F55550 Offset: 0x1F55651 VA: 0x1F55550
	public static VertexData Lerp(int nVertexHash, VertexData vd1, VertexData vd2, float fT) { }

	// RVA: 0x1F55870 Offset: 0x1F55971 VA: 0x1F55870
	public static bool ClipAgainstPlane(VertexData[] aVertexDataInput, int nIndexA, int nIndexB, Vector3 v3A, Vector3 v3B, Plane planeSplit, ref VertexData clippedVertexDataOut) { }

	// RVA: 0x1F4CAC0 Offset: 0x1F4CBC1 VA: 0x1F4CAC0
	public static VertexData[] BuildVertexDataArray(Mesh mesh, Matrix4x4 mtxLocalToWorld, bool bTransformVerticesToWorld) { }

	// RVA: 0x1F4E420 Offset: 0x1F4E521 VA: 0x1F4E420
	public static void SetMeshDataFromVertexDataArray(MeshFilter meshFilter, MeshData meshData, bool bTransformVertexToLocal) { }
}

public class VertexData // TypeDefIndex: 9232
{
	// Fields
	public int nVertexHash; // 0x10
	public Vector3 v3Vertex; // 0x14
	public Vector3 v3Normal; // 0x20
	public Vector4 v4Tangent; // 0x2C
	public Color32 color32; // 0x3C
	public Vector2 v2Mapping1; // 0x40
	public Vector2 v2Mapping2; // 0x48
	public bool bHasNormal; // 0x50
	public bool bHasTangent; // 0x51
	public bool bHasColor32; // 0x52
	public bool bHasMapping1; // 0x53
	public bool bHasMapping2; // 0x54

	// Methods

	// RVA: 0x1F4D640 Offset: 0x1F4D741 VA: 0x1F4D640
	public void .ctor(int nVertexHash) { }

	// RVA: 0x1F553B0 Offset: 0x1F554B1 VA: 0x1F553B0
	public void .ctor(int nVertexHash, Vector3 v3Vertex, Vector3 v3Normal, Vector3 v4Tangent, Color32 color32, Vector2 v2Mapping1, Vector2 v2Mapping2, bool bHasNormal, bool bHasTangent, bool bHasColor32, bool bHasMapping1, bool bHasMapping2) { }

	// RVA: 0x1F51220 Offset: 0x1F51321 VA: 0x1F51220
	public VertexData Copy() { }

	// RVA: 0x1F55550 Offset: 0x1F55651 VA: 0x1F55550
	public static VertexData Lerp(int nVertexHash, VertexData vd1, VertexData vd2, float fT) { }

	// RVA: 0x1F55870 Offset: 0x1F55971 VA: 0x1F55870
	public static bool ClipAgainstPlane(VertexData[] aVertexDataInput, int nIndexA, int nIndexB, Vector3 v3A, Vector3 v3B, Plane planeSplit, ref VertexData clippedVertexDataOut) { }

	// RVA: 0x1F4CAC0 Offset: 0x1F4CBC1 VA: 0x1F4CAC0
	public static VertexData[] BuildVertexDataArray(Mesh mesh, Matrix4x4 mtxLocalToWorld, bool bTransformVerticesToWorld) { }

	// RVA: 0x1F4E420 Offset: 0x1F4E521 VA: 0x1F4E420
	public static void SetMeshDataFromVertexDataArray(MeshFilter meshFilter, MeshData meshData, bool bTransformVertexToLocal) { }
}

public class VertexData // TypeDefIndex: 9232
{
	// Fields
	public int nVertexHash; // 0x10
	public Vector3 v3Vertex; // 0x14
	public Vector3 v3Normal; // 0x20
	public Vector4 v4Tangent; // 0x2C
	public Color32 color32; // 0x3C
	public Vector2 v2Mapping1; // 0x40
	public Vector2 v2Mapping2; // 0x48
	public bool bHasNormal; // 0x50
	public bool bHasTangent; // 0x51
	public bool bHasColor32; // 0x52
	public bool bHasMapping1; // 0x53
	public bool bHasMapping2; // 0x54

	// Methods

	// RVA: 0x1F4D640 Offset: 0x1F4D741 VA: 0x1F4D640
	public void .ctor(int nVertexHash) { }

	// RVA: 0x1F553B0 Offset: 0x1F554B1 VA: 0x1F553B0
	public void .ctor(int nVertexHash, Vector3 v3Vertex, Vector3 v3Normal, Vector3 v4Tangent, Color32 color32, Vector2 v2Mapping1, Vector2 v2Mapping2, bool bHasNormal, bool bHasTangent, bool bHasColor32, bool bHasMapping1, bool bHasMapping2) { }

	// RVA: 0x1F51220 Offset: 0x1F51321 VA: 0x1F51220
	public VertexData Copy() { }

	// RVA: 0x1F55550 Offset: 0x1F55651 VA: 0x1F55550
	public static VertexData Lerp(int nVertexHash, VertexData vd1, VertexData vd2, float fT) { }

	// RVA: 0x1F55870 Offset: 0x1F55971 VA: 0x1F55870
	public static bool ClipAgainstPlane(VertexData[] aVertexDataInput, int nIndexA, int nIndexB, Vector3 v3A, Vector3 v3B, Plane planeSplit, ref VertexData clippedVertexDataOut) { }

	// RVA: 0x1F4CAC0 Offset: 0x1F4CBC1 VA: 0x1F4CAC0
	public static VertexData[] BuildVertexDataArray(Mesh mesh, Matrix4x4 mtxLocalToWorld, bool bTransformVerticesToWorld) { }

	// RVA: 0x1F4E420 Offset: 0x1F4E521 VA: 0x1F4E420
	public static void SetMeshDataFromVertexDataArray(MeshFilter meshFilter, MeshData meshData, bool bTransformVertexToLocal) { }
}

