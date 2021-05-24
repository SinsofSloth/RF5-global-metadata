public class CinemachineDebug // TypeDefIndex: 4895
{
	// Fields
	private static HashSet<Object> mClients; // 0x0
	public static CinemachineDebug.OnGUIDelegate OnGUIHandlers; // 0x8
	private static List<StringBuilder> mAvailableStringBuilders; // 0x10

	// Methods

	// RVA: 0x1A21F80 Offset: 0x1A22081 VA: 0x1A21F80
	public static void ReleaseScreenPos(Object client) { }

	// RVA: 0x1A22020 Offset: 0x1A22121 VA: 0x1A22020
	public static Rect GetScreenPos(Object client, string text, GUIStyle style) { }

	// RVA: 0x1A222A0 Offset: 0x1A223A1 VA: 0x1A222A0
	public static StringBuilder SBFromPool() { }

	// RVA: 0x1A22370 Offset: 0x1A22471 VA: 0x1A22370
	public static void ReturnToPool(StringBuilder sb) { }

	// RVA: 0x1A22430 Offset: 0x1A22531 VA: 0x1A22430
	public void .ctor() { }
}

