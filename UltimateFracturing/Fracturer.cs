public static class Fracturer // TypeDefIndex: 9225
{
	// Fields
	private static Fracturer.FracturingStats s_FracturingStats; // 0x0

	// Methods

	// RVA: 0x23AA340 Offset: 0x23AA441 VA: 0x23AA340
	public static void CancelFracturing() { }

	// RVA: 0x23AA460 Offset: 0x23AA561 VA: 0x23AA460
	public static bool IsFracturingCancelled() { }

	// RVA: 0x23AA580 Offset: 0x23AA681 VA: 0x23AA580
	public static bool FractureToChunks(FracturedObject fracturedComponent, bool bPositionOnSourceAndHideOriginal, out List<GameObject> listGameObjectsOut, Fracturer.ProgressDelegate progress) { }

	// RVA: 0x23AABA0 Offset: 0x23AACA1 VA: 0x23AABA0
	private static Mesh CopyMesh(MeshFilter meshfIn) { }

	// RVA: 0x23AAFB0 Offset: 0x23AB0B1 VA: 0x23AAFB0
	private static bool FractureToChunksBSP(FracturedObject fracturedComponent, bool bPositionOnSourceAndHideOriginal, out List<GameObject> listGameObjectsOut, Fracturer.ProgressDelegate progress) { }

	// RVA: 0x23ACC70 Offset: 0x23ACD71 VA: 0x23ACC70
	public static List<MeshData> ComputeMeshDataIslands(MeshData meshDataIn, bool bVerticesAreLocal, FracturedObject fracturedComponent, Fracturer.ProgressDelegate progress) { }

	// RVA: 0x23B72E0 Offset: 0x23B73E1 VA: 0x23B72E0
	public static void ComputeChunkColliders(FracturedObject fracturedComponent, Fracturer.ProgressDelegate progress) { }

	// RVA: 0x23B8660 Offset: 0x23B8761 VA: 0x23B8660
	public static void DeleteChunkColliders(FracturedObject fracturedComponent) { }

	// RVA: 0x23AE330 Offset: 0x23AE431 VA: 0x23AE330
	private static Matrix4x4 GetRandomPlaneSplitMatrix(MeshData meshDataIn, FracturedObject fracturedComponent, out int nSplitAxisPerformed) { }

	// RVA: 0x23B6BC0 Offset: 0x23B6CC1 VA: 0x23B6BC0
	private static GameObject CreateNewSplitGameObject(GameObject gameObjectIn, FracturedObject fracturedComponent, string strName, bool bTransformVerticesBackToLocal, MeshData meshData) { }

	// RVA: 0x23B89A0 Offset: 0x23B8AA1 VA: 0x23B89A0
	private static int CreateMeshConnectivityVoronoiHash(int nCell1, int nCell2) { }

	// RVA: 0x23B6FA0 Offset: 0x23B70A1 VA: 0x23B6FA0
	private static void ComputeChunkConnections(FracturedObject fracturedObject, List<GameObject> listGameObjects, List<MeshData> listMeshDatas, Fracturer.ProgressDelegate progress) { }

	// RVA: 0x23B82E0 Offset: 0x23B83E1 VA: 0x23B82E0
	private static void RemoveEmptySubmeshes(FracturedChunk fracturedChunk) { }

	// RVA: 0x23B8A40 Offset: 0x23B8B41 VA: 0x23B8A40
	public static bool SplitMeshUsingPlane(GameObject gameObjectIn, FracturedObject fracturedComponent, Fracturer.SplitOptions splitOptions, Transform transformPlaneSplit, out List<GameObject> listGameObjectsPosOut, out List<GameObject> listGameObjectsNegOut, Fracturer.ProgressDelegate progress) { }

	// RVA: 0x23AEE60 Offset: 0x23AEF61 VA: 0x23AEE60
	private static bool SplitMeshUsingPlane(MeshData meshDataIn, FracturedObject fracturedComponent, Fracturer.SplitOptions splitOptions, Vector3 v3PlaneNormal, Vector3 v3PlaneRight, Vector3 v3PlanePoint, out List<MeshData> listMeshDatasPosOut, out List<MeshData> listMeshDatasNegOut, Fracturer.ProgressDelegate progress) { }

	// RVA: 0x23AD380 Offset: 0x23AD481 VA: 0x23AD380
	private static bool ComputeIslandsMeshDataConnectivity(FracturedObject fracturedComponent, bool bVerticesAreLocal, MeshData meshData1, MeshData meshData2) { }

	// RVA: 0x23BC1C0 Offset: 0x23BC2C1 VA: 0x23BC1C0
	public static bool IntersectEdges2D(float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4) { }

	// RVA: 0x23BC400 Offset: 0x23BC501 VA: 0x23BC400
	private static float CrossProduct2D(Vector2 a, Vector2 b) { }

	// RVA: 0x23B9E80 Offset: 0x23B9F81 VA: 0x23B9E80
	private static void TriangulateConstrainedDelaunay(List<List<Vector3>> listlistPointsConstrainedDelaunay, List<List<int>> listlistHashValuesConstrainedDelaunay, bool bForceVertexSoup, FracturedObject fracturedComponent, bool bConnectivityPostprocess, MeshFaceConnectivity faceConnectivityPos, MeshFaceConnectivity faceConnectivityNeg, MeshDataConnectivity meshConnectivityPos, MeshDataConnectivity meshConnectivityNeg, int nForceMeshConnectivityHash, int nSplitCloseSubMesh, Matrix4x4 mtxPlane, Matrix4x4 mtxToLocalPos, Matrix4x4 mtxToLocalNeg, Vector3 v3CenterPos, Vector3 v3CenterNeg, List<int>[] aListIndicesPosInOut, List<VertexData> listVertexDataPosInOut, List<int>[] aListIndicesNegInOut, List<VertexData> listVertexDataNegInOut) { }

	// RVA: 0x23BC410 Offset: 0x23BC511 VA: 0x23BC410
	private static void CreateIndexedMesh(IList<DelaunayTriangle> listTriangles, List<Vector3> listVerticesOut, List<int> listIndicesOut, Matrix4x4 mtxTransform, bool bTransform) { }

	// RVA: 0x23BCB10 Offset: 0x23BCC11 VA: 0x23BCB10
	private static void Triangulate(List<Vector3> listVertices, List<int> listIndices, FracturedObject fracturedComponent, List<List<Vector3>> listlistPointsConstrainedDelaunay, List<List<int>> listlistHashValuesConstrainedDelaunay, bool bConnectivityPostprocess, MeshFaceConnectivity faceConnectivityPos, MeshFaceConnectivity faceConnectivityNeg, MeshDataConnectivity meshConnectivityPos, MeshDataConnectivity meshConnectivityNeg, int nForceMeshConnectivityHash, int nSplitCloseSubMesh, Matrix4x4 mtxPlane, Matrix4x4 mtxToLocalPos, Matrix4x4 mtxToLocalNeg, Vector3 v3CenterPos, Vector3 v3CenterNeg, List<int>[] aListIndicesPosInOut, List<VertexData> listVertexDataPosInOut, List<int>[] aListIndicesNegInOut, List<VertexData> listVertexDataNegInOut) { }

	// RVA: 0x23BDAC0 Offset: 0x23BDBC1 VA: 0x23BDAC0
	private static int ComputeVertexHash(Vector3 v3Vertex, List<List<Vector3>> listlistPointsConstrainedDelaunay, List<List<int>> listlistHashValuesConstrainedDelaunay) { }

	// RVA: 0x23B9360 Offset: 0x23B9461 VA: 0x23B9360
	private static bool AddCapEdge(Dictionary<EdgeKeyByHash, CapEdge> dicCapEdges, int nVertexHash1, int nVertexHash2, Vector3 v3Vertex1, Vector3 v3Vertex2) { }

	// RVA: 0x23B94A0 Offset: 0x23B95A1 VA: 0x23B94A0
	private static bool ResolveCap(Dictionary<EdgeKeyByHash, CapEdge> dicCapEdges, List<List<Vector3>> listlistResolvedCapVertices, List<List<int>> listlistResolvedCapHashValues, FracturedObject fracturedComponent) { }

	// RVA: 0x23BDDC0 Offset: 0x23BDEC1 VA: 0x23BDDC0
	private static void .cctor() { }
}

