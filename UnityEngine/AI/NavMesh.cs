[MovedFromAttribute] // RVA: 0x109310 Offset: 0x109411 VA: 0x109310
[NativeHeaderAttribute] // RVA: 0x109310 Offset: 0x109411 VA: 0x109310
[StaticAccessorAttribute] // RVA: 0x109310 Offset: 0x109411 VA: 0x109310
[NativeHeaderAttribute] // RVA: 0x109310 Offset: 0x109411 VA: 0x109310
public static class NavMesh // TypeDefIndex: 3781
{
	// Fields
	public static NavMesh.OnNavMeshPreUpdate onPreUpdate; // 0x0

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x109E50 Offset: 0x109F51 VA: 0x109E50
	// RVA: 0x1BAB060 Offset: 0x1BAB161 VA: 0x1BAB060
	private static void Internal_CallOnNavMeshPreUpdate() { }

	// RVA: 0x1BAB300 Offset: 0x1BAB401 VA: 0x1BAB300
	public static bool Raycast(Vector3 sourcePosition, Vector3 targetPosition, out NavMeshHit hit, int areaMask) { }

	// RVA: 0x1BAB3F0 Offset: 0x1BAB4F1 VA: 0x1BAB3F0
	public static bool CalculatePath(Vector3 sourcePosition, Vector3 targetPosition, int areaMask, NavMeshPath path) { }

	// RVA: 0x1BAB530 Offset: 0x1BAB631 VA: 0x1BAB530
	private static bool CalculatePathInternal(Vector3 sourcePosition, Vector3 targetPosition, int areaMask, NavMeshPath path) { }

	// RVA: 0x1BAB620 Offset: 0x1BAB721 VA: 0x1BAB620
	public static bool FindClosestEdge(Vector3 sourcePosition, out NavMeshHit hit, int areaMask) { }

	// RVA: 0x1BAB6F0 Offset: 0x1BAB7F1 VA: 0x1BAB6F0
	public static bool SamplePosition(Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, int areaMask) { }

	[StaticAccessorAttribute] // RVA: 0x109E60 Offset: 0x109F61 VA: 0x109E60
	[NativeNameAttribute] // RVA: 0x109E60 Offset: 0x109F61 VA: 0x109E60
	// RVA: 0x1BAB7E0 Offset: 0x1BAB8E1 VA: 0x1BAB7E0
	public static int GetAreaFromName(string areaName) { }

	// RVA: 0x1BAB830 Offset: 0x1BAB931 VA: 0x1BAB830
	public static NavMeshDataInstance AddNavMeshData(NavMeshData navMeshData, Vector3 position, Quaternion rotation) { }

	[NativeNameAttribute] // RVA: 0x109EC0 Offset: 0x109FC1 VA: 0x109EC0
	[StaticAccessorAttribute] // RVA: 0x109EC0 Offset: 0x109FC1 VA: 0x109EC0
	// RVA: 0x1BAB9E0 Offset: 0x1BABAE1 VA: 0x1BAB9E0
	internal static bool IsValidNavMeshDataHandle(int handle) { }

	[StaticAccessorAttribute] // RVA: 0x109F20 Offset: 0x10A021 VA: 0x109F20
	// RVA: 0x1BABA30 Offset: 0x1BABB31 VA: 0x1BABA30
	internal static bool IsValidLinkHandle(int handle) { }

	[NativeNameAttribute] // RVA: 0x109F60 Offset: 0x10A061 VA: 0x109F60
	[StaticAccessorAttribute] // RVA: 0x109F60 Offset: 0x10A061 VA: 0x109F60
	// RVA: 0x1BABA80 Offset: 0x1BABB81 VA: 0x1BABA80
	internal static bool InternalSetOwner(int dataID, int ownerID) { }

	[NativeNameAttribute] // RVA: 0x109FC0 Offset: 0x10A0C1 VA: 0x109FC0
	[StaticAccessorAttribute] // RVA: 0x109FC0 Offset: 0x10A0C1 VA: 0x109FC0
	// RVA: 0x1BABAD0 Offset: 0x1BABBD1 VA: 0x1BABAD0
	internal static bool InternalSetLinkOwner(int linkID, int ownerID) { }

	[NativeNameAttribute] // RVA: 0x10A020 Offset: 0x10A121 VA: 0x10A020
	[StaticAccessorAttribute] // RVA: 0x10A020 Offset: 0x10A121 VA: 0x10A020
	// RVA: 0x1BAB970 Offset: 0x1BABA71 VA: 0x1BAB970
	internal static int AddNavMeshDataTransformedInternal(NavMeshData navMeshData, Vector3 position, Quaternion rotation) { }

	[StaticAccessorAttribute] // RVA: 0x10A080 Offset: 0x10A181 VA: 0x10A080
	[NativeNameAttribute] // RVA: 0x10A080 Offset: 0x10A181 VA: 0x10A080
	// RVA: 0x1BABB80 Offset: 0x1BABC81 VA: 0x1BABB80
	internal static void RemoveNavMeshDataInternal(int handle) { }

	// RVA: 0x1BABBD0 Offset: 0x1BABCD1 VA: 0x1BABBD0
	public static NavMeshLinkInstance AddLink(NavMeshLinkData link, Vector3 position, Quaternion rotation) { }

	[NativeNameAttribute] // RVA: 0x10A0E0 Offset: 0x10A1E1 VA: 0x10A0E0
	[StaticAccessorAttribute] // RVA: 0x10A0E0 Offset: 0x10A1E1 VA: 0x10A0E0
	// RVA: 0x1BABC60 Offset: 0x1BABD61 VA: 0x1BABC60
	internal static int AddLinkInternal(NavMeshLinkData link, Vector3 position, Quaternion rotation) { }

	[NativeNameAttribute] // RVA: 0x10A140 Offset: 0x10A241 VA: 0x10A140
	[StaticAccessorAttribute] // RVA: 0x10A140 Offset: 0x10A241 VA: 0x10A140
	// RVA: 0x1BABD30 Offset: 0x1BABE31 VA: 0x1BABD30
	internal static void RemoveLinkInternal(int handle) { }

	// RVA: 0x1BABD80 Offset: 0x1BABE81 VA: 0x1BABD80
	public static bool SamplePosition(Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, NavMeshQueryFilter filter) { }

	// RVA: 0x1BABE10 Offset: 0x1BABF11 VA: 0x1BABE10
	private static bool SamplePositionFilter(Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, int type, int mask) { }

	// RVA: 0x1BABF20 Offset: 0x1BAC021 VA: 0x1BABF20
	public static NavMeshBuildSettings GetSettingsByID(int agentTypeID) { }

	[StaticAccessorAttribute] // RVA: 0x10A1A0 Offset: 0x10A2A1 VA: 0x10A1A0
	// RVA: 0x1BAC000 Offset: 0x1BAC101 VA: 0x1BAC000
	public static int GetSettingsCount() { }

	// RVA: 0x1BAC040 Offset: 0x1BAC141 VA: 0x1BAC040
	public static NavMeshBuildSettings GetSettingsByIndex(int index) { }

	// RVA: 0x1BAC120 Offset: 0x1BAC221 VA: 0x1BAC120
	public static string GetSettingsNameFromID(int agentTypeID) { }

	// RVA: 0x1BAB380 Offset: 0x1BAB481 VA: 0x1BAB380
	private static bool Raycast_Injected(ref Vector3 sourcePosition, ref Vector3 targetPosition, out NavMeshHit hit, int areaMask) { }

	// RVA: 0x1BAB5B0 Offset: 0x1BAB6B1 VA: 0x1BAB5B0
	private static bool CalculatePathInternal_Injected(ref Vector3 sourcePosition, ref Vector3 targetPosition, int areaMask, NavMeshPath path) { }

	// RVA: 0x1BAB690 Offset: 0x1BAB791 VA: 0x1BAB690
	private static bool FindClosestEdge_Injected(ref Vector3 sourcePosition, out NavMeshHit hit, int areaMask) { }

	// RVA: 0x1BAB770 Offset: 0x1BAB871 VA: 0x1BAB770
	private static bool SamplePosition_Injected(ref Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, int areaMask) { }

	// RVA: 0x1BABB20 Offset: 0x1BABC21 VA: 0x1BABB20
	private static int AddNavMeshDataTransformedInternal_Injected(NavMeshData navMeshData, ref Vector3 position, ref Quaternion rotation) { }

	// RVA: 0x1BABCD0 Offset: 0x1BABDD1 VA: 0x1BABCD0
	private static int AddLinkInternal_Injected(ref NavMeshLinkData link, ref Vector3 position, ref Quaternion rotation) { }

	// RVA: 0x1BABEA0 Offset: 0x1BABFA1 VA: 0x1BABEA0
	private static bool SamplePositionFilter_Injected(ref Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, int type, int mask) { }

	// RVA: 0x1BABFB0 Offset: 0x1BAC0B1 VA: 0x1BABFB0
	private static void GetSettingsByID_Injected(int agentTypeID, out NavMeshBuildSettings ret) { }

	// RVA: 0x1BAC0D0 Offset: 0x1BAC1D1 VA: 0x1BAC0D0
	private static void GetSettingsByIndex_Injected(int index, out NavMeshBuildSettings ret) { }
}

