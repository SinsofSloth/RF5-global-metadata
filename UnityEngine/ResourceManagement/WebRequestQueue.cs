internal static class WebRequestQueue // TypeDefIndex: 4459
{
	// Fields
	internal static int s_MaxRequest; // 0x0
	internal static Queue<WebRequestQueueOperation> s_QueuedOperations; // 0x8
	internal static List<UnityWebRequestAsyncOperation> s_ActiveRequests; // 0x10

	// Methods

	// RVA: 0x19E5BB0 Offset: 0x19E5CB1 VA: 0x19E5BB0
	public static void SetMaxConcurrentRequests(int maxRequests) { }

	// RVA: 0x19DEA00 Offset: 0x19DEB01 VA: 0x19DEA00
	public static WebRequestQueueOperation QueueRequest(UnityWebRequest request) { }

	// RVA: 0x19E5D40 Offset: 0x19E5E41 VA: 0x19E5D40
	private static void OnWebAsyncOpComplete(AsyncOperation operation) { }

	// RVA: 0x19E5F50 Offset: 0x19E6051 VA: 0x19E5F50
	private static void .cctor() { }
}

