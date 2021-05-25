[StaticAccessorAttribute] // RVA: 0x109010 Offset: 0x109111 VA: 0x109010
[NativeHeaderAttribute] // RVA: 0x109010 Offset: 0x109111 VA: 0x109010
public static class NavMeshBuilder // TypeDefIndex: 3768
{
	// Methods

	// RVA: 0x1BAE750 Offset: 0x1BAE851 VA: 0x1BAE750
	public static void CollectSources(Bounds includedWorldBounds, int includedLayerMask, NavMeshCollectGeometry geometry, int defaultArea, List<NavMeshBuildMarkup> markups, List<NavMeshBuildSource> results) { }

	// RVA: 0x1BAE9F0 Offset: 0x1BAEAF1 VA: 0x1BAE9F0
	public static void CollectSources(Transform root, int includedLayerMask, NavMeshCollectGeometry geometry, int defaultArea, List<NavMeshBuildMarkup> markups, List<NavMeshBuildSource> results) { }

	// RVA: 0x1BAE960 Offset: 0x1BAEA61 VA: 0x1BAE960
	private static NavMeshBuildSource[] CollectSourcesInternal(int includedLayerMask, Bounds includedWorldBounds, Transform root, bool useBounds, NavMeshCollectGeometry geometry, int defaultArea, NavMeshBuildMarkup[] markups) { }

	// RVA: 0x1BAEBF0 Offset: 0x1BAECF1 VA: 0x1BAEBF0
	public static NavMeshData BuildNavMeshData(NavMeshBuildSettings buildSettings, List<NavMeshBuildSource> sources, Bounds localBounds, Vector3 position, Quaternion rotation) { }

	// RVA: 0x1BAEFA0 Offset: 0x1BAF0A1 VA: 0x1BAEFA0
	private static bool UpdateNavMeshDataListInternal(NavMeshData data, NavMeshBuildSettings buildSettings, object sources, Bounds localBounds) { }

	// RVA: 0x1BAF080 Offset: 0x1BAF181 VA: 0x1BAF080
	public static AsyncOperation UpdateNavMeshDataAsync(NavMeshData data, NavMeshBuildSettings buildSettings, List<NavMeshBuildSource> sources, Bounds localBounds) { }

	// RVA: 0x1BAF1E0 Offset: 0x1BAF2E1 VA: 0x1BAF1E0
	private static AsyncOperation UpdateNavMeshDataAsyncListInternal(NavMeshData data, NavMeshBuildSettings buildSettings, object sources, Bounds localBounds) { }

	// RVA: 0x1BAEB60 Offset: 0x1BAEC61 VA: 0x1BAEB60
	private static NavMeshBuildSource[] CollectSourcesInternal_Injected(int includedLayerMask, ref Bounds includedWorldBounds, Transform root, bool useBounds, NavMeshCollectGeometry geometry, int defaultArea, NavMeshBuildMarkup[] markups) { }

	// RVA: 0x1BAF010 Offset: 0x1BAF111 VA: 0x1BAF010
	private static bool UpdateNavMeshDataListInternal_Injected(NavMeshData data, ref NavMeshBuildSettings buildSettings, object sources, ref Bounds localBounds) { }

	// RVA: 0x1BAF250 Offset: 0x1BAF351 VA: 0x1BAF250
	private static AsyncOperation UpdateNavMeshDataAsyncListInternal_Injected(NavMeshData data, ref NavMeshBuildSettings buildSettings, object sources, ref Bounds localBounds) { }
}

