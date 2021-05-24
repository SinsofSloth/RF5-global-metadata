public static class ConcaveColliderInterface // TypeDefIndex: 9221
{
	// Methods

	// RVA: 0x23A8D00 Offset: 0x23A8E01 VA: 0x23A8D00
	private static extern void DllInit(bool bUseMultithreading) { }

	// RVA: 0x23A8D80 Offset: 0x23A8E81 VA: 0x23A8D80
	private static extern void DllClose() { }

	// RVA: 0x23A8DF0 Offset: 0x23A8EF1 VA: 0x23A8DF0
	private static extern void SetLogFunctionPointer(IntPtr pfnUnity3DLog) { }

	// RVA: 0x23A8E70 Offset: 0x23A8F71 VA: 0x23A8E70
	private static extern void SetProgressFunctionPointer(IntPtr pfnUnity3DProgress) { }

	// RVA: 0x23A8EF0 Offset: 0x23A8FF1 VA: 0x23A8EF0
	private static extern void CancelConvexDecomposition() { }

	// RVA: 0x23A8F60 Offset: 0x23A9061 VA: 0x23A8F60
	private static extern bool DoConvexDecomposition(ref ConcaveColliderInterface.SConvexDecompositionInfoInOut infoInOut, Vector3[] pfVertices, int[] puIndices) { }

	// RVA: 0x23A9010 Offset: 0x23A9111 VA: 0x23A9010
	private static extern bool GetHullInfo(uint uHullIndex, ref ConcaveColliderInterface.SConvexDecompositionHullInfo infoOut) { }

	// RVA: 0x23A90B0 Offset: 0x23A91B1 VA: 0x23A90B0
	private static extern bool FillHullMeshData(uint uHullIndex, ref float pfVolumeOut, int[] pnIndicesOut, Vector3[] pfVerticesOut) { }

	// RVA: 0x23A9170 Offset: 0x23A9271 VA: 0x23A9170
	public static int ComputeHull(GameObject gameObject, FracturedObject fracturedObject) { }

	// RVA: 0x23A9310 Offset: 0x23A9411 VA: 0x23A9310
	private static bool ComputeHull(GameObject gameObject, bool isTrigger, FracturedObject.ECCAlgorithm eAlgorithm, int nMaxHulls, int nMaxHullVertices, int nLegacySteps, bool bVerbose, out int nTotalTrianglesOut) { }

	// RVA: 0x23A9BD0 Offset: 0x23A9CD1 VA: 0x23A9BD0
	private static void Log(string message) { }
}

