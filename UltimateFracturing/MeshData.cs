public class MeshData // TypeDefIndex: 9246
{
	// Fields
	public int nSubMeshCount; // 0x10
	public int[][] aaIndices; // 0x18
	public int nSplitCloseSubMesh; // 0x20
	public VertexData[] aVertexData; // 0x28
	public Vector3 v3Position; // 0x30
	public Quaternion qRotation; // 0x3C
	public Vector3 v3Scale; // 0x4C
	public Vector3 v3Min; // 0x58
	public Vector3 v3Max; // 0x64
	public int nCurrentVertexHash; // 0x70
	public Material[] aMaterials; // 0x78
	public MeshDataConnectivity meshDataConnectivity; // 0x80

	// Methods

	// RVA: 0x1F4B5F0 Offset: 0x1F4B6F1 VA: 0x1F4B5F0
	private void .ctor() { }

	// RVA: 0x1F4B7E0 Offset: 0x1F4B8E1 VA: 0x1F4B7E0
	public void .ctor(Material[] aMaterials, List<int>[] alistIndices, List<VertexData> listVertexData, int nSplitCloseSubMesh, Vector3 v3Position, Quaternion qRotation, Vector3 v3Scale, Matrix4x4 mtxTransformVertices, bool bUseTransform, bool bBuildVertexHashData) { }

	// RVA: 0x1F4C680 Offset: 0x1F4C781 VA: 0x1F4C680
	public void .ctor(Transform transform, Mesh mesh, Material[] aMaterials, Matrix4x4 mtxLocalToWorld, bool bTransformVerticesToWorld, int nSplitCloseSubMesh, bool bBuildVertexHashData) { }

	// RVA: 0x1F4C7B0 Offset: 0x1F4C8B1 VA: 0x1F4C7B0
	public void .ctor(Vector3 v3Position, Quaternion qRotation, Vector3 v3Scale, Mesh mesh, Material[] aMaterials, Matrix4x4 mtxLocalToWorld, bool bTransformVerticesToWorld, int nSplitCloseSubMesh, bool bBuildVertexHashData) { }

	// RVA: 0x1F4D180 Offset: 0x1F4D281 VA: 0x1F4D180
	public static MeshData CreateBoxMeshData(Vector3 v3Pos, Quaternion qRot, Vector3 v3Scale, Vector3 v3Min, Vector3 v3Max) { }

	// RVA: 0x1F4D770 Offset: 0x1F4D871 VA: 0x1F4D770
	public MeshData GetDeepCopy() { }

	// RVA: 0x1F4E2A0 Offset: 0x1F4E3A1 VA: 0x1F4E2A0
	public bool FillMeshFilter(MeshFilter meshFilter, bool bTransformVerticesToLocal) { }

	// RVA: 0x1F4BB10 Offset: 0x1F4BC11 VA: 0x1F4BB10
	public static void ComputeMinMax(IEnumerable<VertexData> VertexData, ref Vector3 v3Min, ref Vector3 v3Max) { }

	// RVA: 0x1F4BEF0 Offset: 0x1F4BFF1 VA: 0x1F4BEF0
	private void BuildVertexHashData() { }

	// RVA: 0x1F4E9B0 Offset: 0x1F4EAB1 VA: 0x1F4E9B0
	public bool GetSharedFacesArea(FracturedObject fracturedComponent, MeshData meshData2, out float fSharedArea) { }

	// RVA: 0x1F4F4E0 Offset: 0x1F4F5E1 VA: 0x1F4F4E0
	private static bool Face2InsideFace1(FracturedObject fracturedComponent, MeshData meshData1, MeshData meshData2, MeshDataConnectivity.Face face1, MeshDataConnectivity.Face face2) { }

	// RVA: 0x1F4FE90 Offset: 0x1F4FF91 VA: 0x1F4FE90
	public static List<MeshData> PostProcessConnectivity(MeshData meshDataSource, MeshFaceConnectivity connectivity, MeshDataConnectivity meshConnectivity, List<int>[] alistIndices, List<VertexData> listVertexData, int nSplitCloseSubMesh, int nCurrentVertexHash, bool bTransformToLocal) { }

	// RVA: 0x1F50D00 Offset: 0x1F50E01 VA: 0x1F50D00
	private static bool StillHasFacesToProcess(List<int>[] alistFacesRemaining) { }

	// RVA: 0x1F50550 Offset: 0x1F50651 VA: 0x1F50550
	private static void LookForClosedObjectRecursive(MeshFaceConnectivity connectivity, MeshDataConnectivity meshConnectivity, int nSubMeshStart, int nFaceSubMeshStart, List<int>[] alistIndicesIn, List<VertexData> listVertexDataIn, List<int>[] alistFacesRemainingInOut, int[] aLinearFaceIndexStart, List<int>[] alistIndicesOut, List<VertexData> listVertexDataOut, Dictionary<int, int> dicVertexRemap, MeshDataConnectivity meshConnectivityOut) { }
}

public class MeshData // TypeDefIndex: 9246
{
	// Fields
	public int nSubMeshCount; // 0x10
	public int[][] aaIndices; // 0x18
	public int nSplitCloseSubMesh; // 0x20
	public VertexData[] aVertexData; // 0x28
	public Vector3 v3Position; // 0x30
	public Quaternion qRotation; // 0x3C
	public Vector3 v3Scale; // 0x4C
	public Vector3 v3Min; // 0x58
	public Vector3 v3Max; // 0x64
	public int nCurrentVertexHash; // 0x70
	public Material[] aMaterials; // 0x78
	public MeshDataConnectivity meshDataConnectivity; // 0x80

	// Methods

	// RVA: 0x1F4B5F0 Offset: 0x1F4B6F1 VA: 0x1F4B5F0
	private void .ctor() { }

	// RVA: 0x1F4B7E0 Offset: 0x1F4B8E1 VA: 0x1F4B7E0
	public void .ctor(Material[] aMaterials, List<int>[] alistIndices, List<VertexData> listVertexData, int nSplitCloseSubMesh, Vector3 v3Position, Quaternion qRotation, Vector3 v3Scale, Matrix4x4 mtxTransformVertices, bool bUseTransform, bool bBuildVertexHashData) { }

	// RVA: 0x1F4C680 Offset: 0x1F4C781 VA: 0x1F4C680
	public void .ctor(Transform transform, Mesh mesh, Material[] aMaterials, Matrix4x4 mtxLocalToWorld, bool bTransformVerticesToWorld, int nSplitCloseSubMesh, bool bBuildVertexHashData) { }

	// RVA: 0x1F4C7B0 Offset: 0x1F4C8B1 VA: 0x1F4C7B0
	public void .ctor(Vector3 v3Position, Quaternion qRotation, Vector3 v3Scale, Mesh mesh, Material[] aMaterials, Matrix4x4 mtxLocalToWorld, bool bTransformVerticesToWorld, int nSplitCloseSubMesh, bool bBuildVertexHashData) { }

	// RVA: 0x1F4D180 Offset: 0x1F4D281 VA: 0x1F4D180
	public static MeshData CreateBoxMeshData(Vector3 v3Pos, Quaternion qRot, Vector3 v3Scale, Vector3 v3Min, Vector3 v3Max) { }

	// RVA: 0x1F4D770 Offset: 0x1F4D871 VA: 0x1F4D770
	public MeshData GetDeepCopy() { }

	// RVA: 0x1F4E2A0 Offset: 0x1F4E3A1 VA: 0x1F4E2A0
	public bool FillMeshFilter(MeshFilter meshFilter, bool bTransformVerticesToLocal) { }

	// RVA: 0x1F4BB10 Offset: 0x1F4BC11 VA: 0x1F4BB10
	public static void ComputeMinMax(IEnumerable<VertexData> VertexData, ref Vector3 v3Min, ref Vector3 v3Max) { }

	// RVA: 0x1F4BEF0 Offset: 0x1F4BFF1 VA: 0x1F4BEF0
	private void BuildVertexHashData() { }

	// RVA: 0x1F4E9B0 Offset: 0x1F4EAB1 VA: 0x1F4E9B0
	public bool GetSharedFacesArea(FracturedObject fracturedComponent, MeshData meshData2, out float fSharedArea) { }

	// RVA: 0x1F4F4E0 Offset: 0x1F4F5E1 VA: 0x1F4F4E0
	private static bool Face2InsideFace1(FracturedObject fracturedComponent, MeshData meshData1, MeshData meshData2, MeshDataConnectivity.Face face1, MeshDataConnectivity.Face face2) { }

	// RVA: 0x1F4FE90 Offset: 0x1F4FF91 VA: 0x1F4FE90
	public static List<MeshData> PostProcessConnectivity(MeshData meshDataSource, MeshFaceConnectivity connectivity, MeshDataConnectivity meshConnectivity, List<int>[] alistIndices, List<VertexData> listVertexData, int nSplitCloseSubMesh, int nCurrentVertexHash, bool bTransformToLocal) { }

	// RVA: 0x1F50D00 Offset: 0x1F50E01 VA: 0x1F50D00
	private static bool StillHasFacesToProcess(List<int>[] alistFacesRemaining) { }

	// RVA: 0x1F50550 Offset: 0x1F50651 VA: 0x1F50550
	private static void LookForClosedObjectRecursive(MeshFaceConnectivity connectivity, MeshDataConnectivity meshConnectivity, int nSubMeshStart, int nFaceSubMeshStart, List<int>[] alistIndicesIn, List<VertexData> listVertexDataIn, List<int>[] alistFacesRemainingInOut, int[] aLinearFaceIndexStart, List<int>[] alistIndicesOut, List<VertexData> listVertexDataOut, Dictionary<int, int> dicVertexRemap, MeshDataConnectivity meshConnectivityOut) { }
}

public class MeshData // TypeDefIndex: 9246
{
	// Fields
	public int nSubMeshCount; // 0x10
	public int[][] aaIndices; // 0x18
	public int nSplitCloseSubMesh; // 0x20
	public VertexData[] aVertexData; // 0x28
	public Vector3 v3Position; // 0x30
	public Quaternion qRotation; // 0x3C
	public Vector3 v3Scale; // 0x4C
	public Vector3 v3Min; // 0x58
	public Vector3 v3Max; // 0x64
	public int nCurrentVertexHash; // 0x70
	public Material[] aMaterials; // 0x78
	public MeshDataConnectivity meshDataConnectivity; // 0x80

	// Methods

	// RVA: 0x1F4B5F0 Offset: 0x1F4B6F1 VA: 0x1F4B5F0
	private void .ctor() { }

	// RVA: 0x1F4B7E0 Offset: 0x1F4B8E1 VA: 0x1F4B7E0
	public void .ctor(Material[] aMaterials, List<int>[] alistIndices, List<VertexData> listVertexData, int nSplitCloseSubMesh, Vector3 v3Position, Quaternion qRotation, Vector3 v3Scale, Matrix4x4 mtxTransformVertices, bool bUseTransform, bool bBuildVertexHashData) { }

	// RVA: 0x1F4C680 Offset: 0x1F4C781 VA: 0x1F4C680
	public void .ctor(Transform transform, Mesh mesh, Material[] aMaterials, Matrix4x4 mtxLocalToWorld, bool bTransformVerticesToWorld, int nSplitCloseSubMesh, bool bBuildVertexHashData) { }

	// RVA: 0x1F4C7B0 Offset: 0x1F4C8B1 VA: 0x1F4C7B0
	public void .ctor(Vector3 v3Position, Quaternion qRotation, Vector3 v3Scale, Mesh mesh, Material[] aMaterials, Matrix4x4 mtxLocalToWorld, bool bTransformVerticesToWorld, int nSplitCloseSubMesh, bool bBuildVertexHashData) { }

	// RVA: 0x1F4D180 Offset: 0x1F4D281 VA: 0x1F4D180
	public static MeshData CreateBoxMeshData(Vector3 v3Pos, Quaternion qRot, Vector3 v3Scale, Vector3 v3Min, Vector3 v3Max) { }

	// RVA: 0x1F4D770 Offset: 0x1F4D871 VA: 0x1F4D770
	public MeshData GetDeepCopy() { }

	// RVA: 0x1F4E2A0 Offset: 0x1F4E3A1 VA: 0x1F4E2A0
	public bool FillMeshFilter(MeshFilter meshFilter, bool bTransformVerticesToLocal) { }

	// RVA: 0x1F4BB10 Offset: 0x1F4BC11 VA: 0x1F4BB10
	public static void ComputeMinMax(IEnumerable<VertexData> VertexData, ref Vector3 v3Min, ref Vector3 v3Max) { }

	// RVA: 0x1F4BEF0 Offset: 0x1F4BFF1 VA: 0x1F4BEF0
	private void BuildVertexHashData() { }

	// RVA: 0x1F4E9B0 Offset: 0x1F4EAB1 VA: 0x1F4E9B0
	public bool GetSharedFacesArea(FracturedObject fracturedComponent, MeshData meshData2, out float fSharedArea) { }

	// RVA: 0x1F4F4E0 Offset: 0x1F4F5E1 VA: 0x1F4F4E0
	private static bool Face2InsideFace1(FracturedObject fracturedComponent, MeshData meshData1, MeshData meshData2, MeshDataConnectivity.Face face1, MeshDataConnectivity.Face face2) { }

	// RVA: 0x1F4FE90 Offset: 0x1F4FF91 VA: 0x1F4FE90
	public static List<MeshData> PostProcessConnectivity(MeshData meshDataSource, MeshFaceConnectivity connectivity, MeshDataConnectivity meshConnectivity, List<int>[] alistIndices, List<VertexData> listVertexData, int nSplitCloseSubMesh, int nCurrentVertexHash, bool bTransformToLocal) { }

	// RVA: 0x1F50D00 Offset: 0x1F50E01 VA: 0x1F50D00
	private static bool StillHasFacesToProcess(List<int>[] alistFacesRemaining) { }

	// RVA: 0x1F50550 Offset: 0x1F50651 VA: 0x1F50550
	private static void LookForClosedObjectRecursive(MeshFaceConnectivity connectivity, MeshDataConnectivity meshConnectivity, int nSubMeshStart, int nFaceSubMeshStart, List<int>[] alistIndicesIn, List<VertexData> listVertexDataIn, List<int>[] alistFacesRemainingInOut, int[] aLinearFaceIndexStart, List<int>[] alistIndicesOut, List<VertexData> listVertexDataOut, Dictionary<int, int> dicVertexRemap, MeshDataConnectivity meshConnectivityOut) { }
}

public class MeshData // TypeDefIndex: 9246
{
	// Fields
	public int nSubMeshCount; // 0x10
	public int[][] aaIndices; // 0x18
	public int nSplitCloseSubMesh; // 0x20
	public VertexData[] aVertexData; // 0x28
	public Vector3 v3Position; // 0x30
	public Quaternion qRotation; // 0x3C
	public Vector3 v3Scale; // 0x4C
	public Vector3 v3Min; // 0x58
	public Vector3 v3Max; // 0x64
	public int nCurrentVertexHash; // 0x70
	public Material[] aMaterials; // 0x78
	public MeshDataConnectivity meshDataConnectivity; // 0x80

	// Methods

	// RVA: 0x1F4B5F0 Offset: 0x1F4B6F1 VA: 0x1F4B5F0
	private void .ctor() { }

	// RVA: 0x1F4B7E0 Offset: 0x1F4B8E1 VA: 0x1F4B7E0
	public void .ctor(Material[] aMaterials, List<int>[] alistIndices, List<VertexData> listVertexData, int nSplitCloseSubMesh, Vector3 v3Position, Quaternion qRotation, Vector3 v3Scale, Matrix4x4 mtxTransformVertices, bool bUseTransform, bool bBuildVertexHashData) { }

	// RVA: 0x1F4C680 Offset: 0x1F4C781 VA: 0x1F4C680
	public void .ctor(Transform transform, Mesh mesh, Material[] aMaterials, Matrix4x4 mtxLocalToWorld, bool bTransformVerticesToWorld, int nSplitCloseSubMesh, bool bBuildVertexHashData) { }

	// RVA: 0x1F4C7B0 Offset: 0x1F4C8B1 VA: 0x1F4C7B0
	public void .ctor(Vector3 v3Position, Quaternion qRotation, Vector3 v3Scale, Mesh mesh, Material[] aMaterials, Matrix4x4 mtxLocalToWorld, bool bTransformVerticesToWorld, int nSplitCloseSubMesh, bool bBuildVertexHashData) { }

	// RVA: 0x1F4D180 Offset: 0x1F4D281 VA: 0x1F4D180
	public static MeshData CreateBoxMeshData(Vector3 v3Pos, Quaternion qRot, Vector3 v3Scale, Vector3 v3Min, Vector3 v3Max) { }

	// RVA: 0x1F4D770 Offset: 0x1F4D871 VA: 0x1F4D770
	public MeshData GetDeepCopy() { }

	// RVA: 0x1F4E2A0 Offset: 0x1F4E3A1 VA: 0x1F4E2A0
	public bool FillMeshFilter(MeshFilter meshFilter, bool bTransformVerticesToLocal) { }

	// RVA: 0x1F4BB10 Offset: 0x1F4BC11 VA: 0x1F4BB10
	public static void ComputeMinMax(IEnumerable<VertexData> VertexData, ref Vector3 v3Min, ref Vector3 v3Max) { }

	// RVA: 0x1F4BEF0 Offset: 0x1F4BFF1 VA: 0x1F4BEF0
	private void BuildVertexHashData() { }

	// RVA: 0x1F4E9B0 Offset: 0x1F4EAB1 VA: 0x1F4E9B0
	public bool GetSharedFacesArea(FracturedObject fracturedComponent, MeshData meshData2, out float fSharedArea) { }

	// RVA: 0x1F4F4E0 Offset: 0x1F4F5E1 VA: 0x1F4F4E0
	private static bool Face2InsideFace1(FracturedObject fracturedComponent, MeshData meshData1, MeshData meshData2, MeshDataConnectivity.Face face1, MeshDataConnectivity.Face face2) { }

	// RVA: 0x1F4FE90 Offset: 0x1F4FF91 VA: 0x1F4FE90
	public static List<MeshData> PostProcessConnectivity(MeshData meshDataSource, MeshFaceConnectivity connectivity, MeshDataConnectivity meshConnectivity, List<int>[] alistIndices, List<VertexData> listVertexData, int nSplitCloseSubMesh, int nCurrentVertexHash, bool bTransformToLocal) { }

	// RVA: 0x1F50D00 Offset: 0x1F50E01 VA: 0x1F50D00
	private static bool StillHasFacesToProcess(List<int>[] alistFacesRemaining) { }

	// RVA: 0x1F50550 Offset: 0x1F50651 VA: 0x1F50550
	private static void LookForClosedObjectRecursive(MeshFaceConnectivity connectivity, MeshDataConnectivity meshConnectivity, int nSubMeshStart, int nFaceSubMeshStart, List<int>[] alistIndicesIn, List<VertexData> listVertexDataIn, List<int>[] alistFacesRemainingInOut, int[] aLinearFaceIndexStart, List<int>[] alistIndicesOut, List<VertexData> listVertexDataOut, Dictionary<int, int> dicVertexRemap, MeshDataConnectivity meshConnectivityOut) { }
}

public class MeshData // TypeDefIndex: 9246
{
	// Fields
	public int nSubMeshCount; // 0x10
	public int[][] aaIndices; // 0x18
	public int nSplitCloseSubMesh; // 0x20
	public VertexData[] aVertexData; // 0x28
	public Vector3 v3Position; // 0x30
	public Quaternion qRotation; // 0x3C
	public Vector3 v3Scale; // 0x4C
	public Vector3 v3Min; // 0x58
	public Vector3 v3Max; // 0x64
	public int nCurrentVertexHash; // 0x70
	public Material[] aMaterials; // 0x78
	public MeshDataConnectivity meshDataConnectivity; // 0x80

	// Methods

	// RVA: 0x1F4B5F0 Offset: 0x1F4B6F1 VA: 0x1F4B5F0
	private void .ctor() { }

	// RVA: 0x1F4B7E0 Offset: 0x1F4B8E1 VA: 0x1F4B7E0
	public void .ctor(Material[] aMaterials, List<int>[] alistIndices, List<VertexData> listVertexData, int nSplitCloseSubMesh, Vector3 v3Position, Quaternion qRotation, Vector3 v3Scale, Matrix4x4 mtxTransformVertices, bool bUseTransform, bool bBuildVertexHashData) { }

	// RVA: 0x1F4C680 Offset: 0x1F4C781 VA: 0x1F4C680
	public void .ctor(Transform transform, Mesh mesh, Material[] aMaterials, Matrix4x4 mtxLocalToWorld, bool bTransformVerticesToWorld, int nSplitCloseSubMesh, bool bBuildVertexHashData) { }

	// RVA: 0x1F4C7B0 Offset: 0x1F4C8B1 VA: 0x1F4C7B0
	public void .ctor(Vector3 v3Position, Quaternion qRotation, Vector3 v3Scale, Mesh mesh, Material[] aMaterials, Matrix4x4 mtxLocalToWorld, bool bTransformVerticesToWorld, int nSplitCloseSubMesh, bool bBuildVertexHashData) { }

	// RVA: 0x1F4D180 Offset: 0x1F4D281 VA: 0x1F4D180
	public static MeshData CreateBoxMeshData(Vector3 v3Pos, Quaternion qRot, Vector3 v3Scale, Vector3 v3Min, Vector3 v3Max) { }

	// RVA: 0x1F4D770 Offset: 0x1F4D871 VA: 0x1F4D770
	public MeshData GetDeepCopy() { }

	// RVA: 0x1F4E2A0 Offset: 0x1F4E3A1 VA: 0x1F4E2A0
	public bool FillMeshFilter(MeshFilter meshFilter, bool bTransformVerticesToLocal) { }

	// RVA: 0x1F4BB10 Offset: 0x1F4BC11 VA: 0x1F4BB10
	public static void ComputeMinMax(IEnumerable<VertexData> VertexData, ref Vector3 v3Min, ref Vector3 v3Max) { }

	// RVA: 0x1F4BEF0 Offset: 0x1F4BFF1 VA: 0x1F4BEF0
	private void BuildVertexHashData() { }

	// RVA: 0x1F4E9B0 Offset: 0x1F4EAB1 VA: 0x1F4E9B0
	public bool GetSharedFacesArea(FracturedObject fracturedComponent, MeshData meshData2, out float fSharedArea) { }

	// RVA: 0x1F4F4E0 Offset: 0x1F4F5E1 VA: 0x1F4F4E0
	private static bool Face2InsideFace1(FracturedObject fracturedComponent, MeshData meshData1, MeshData meshData2, MeshDataConnectivity.Face face1, MeshDataConnectivity.Face face2) { }

	// RVA: 0x1F4FE90 Offset: 0x1F4FF91 VA: 0x1F4FE90
	public static List<MeshData> PostProcessConnectivity(MeshData meshDataSource, MeshFaceConnectivity connectivity, MeshDataConnectivity meshConnectivity, List<int>[] alistIndices, List<VertexData> listVertexData, int nSplitCloseSubMesh, int nCurrentVertexHash, bool bTransformToLocal) { }

	// RVA: 0x1F50D00 Offset: 0x1F50E01 VA: 0x1F50D00
	private static bool StillHasFacesToProcess(List<int>[] alistFacesRemaining) { }

	// RVA: 0x1F50550 Offset: 0x1F50651 VA: 0x1F50550
	private static void LookForClosedObjectRecursive(MeshFaceConnectivity connectivity, MeshDataConnectivity meshConnectivity, int nSubMeshStart, int nFaceSubMeshStart, List<int>[] alistIndicesIn, List<VertexData> listVertexDataIn, List<int>[] alistFacesRemainingInOut, int[] aLinearFaceIndexStart, List<int>[] alistIndicesOut, List<VertexData> listVertexDataOut, Dictionary<int, int> dicVertexRemap, MeshDataConnectivity meshConnectivityOut) { }
}

