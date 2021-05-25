[NativeHeaderAttribute] // RVA: 0x110810 Offset: 0x110911 VA: 0x110810
public static class JsonUtility // TypeDefIndex: 3813
{
	// Methods

	[FreeFunctionAttribute] // RVA: 0x110850 Offset: 0x110951 VA: 0x110850
	[ThreadSafeAttribute] // RVA: 0x110850 Offset: 0x110951 VA: 0x110850
	// RVA: 0x1BE2A30 Offset: 0x1BE2B31 VA: 0x1BE2A30
	private static string ToJsonInternal(object obj, bool prettyPrint) { }

	[ThreadSafeAttribute] // RVA: 0x1108A0 Offset: 0x1109A1 VA: 0x1108A0
	[FreeFunctionAttribute] // RVA: 0x1108A0 Offset: 0x1109A1 VA: 0x1108A0
	// RVA: 0x1BE2A80 Offset: 0x1BE2B81 VA: 0x1BE2A80
	private static object FromJsonInternal(string json, object objectToOverwrite, Type type) { }

	// RVA: 0x1BE2AE0 Offset: 0x1BE2BE1 VA: 0x1BE2AE0
	public static string ToJson(object obj) { }

	// RVA: 0x1BE2AF0 Offset: 0x1BE2BF1 VA: 0x1BE2AF0
	public static string ToJson(object obj, bool prettyPrint) { }

	// RVA: -1 Offset: -1
	public static T FromJson<T>(string json) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22662C0 Offset: 0x22663C1 VA: 0x22662C0
	|-JsonUtility.FromJson<PackedPlayModeBuildLogs>
	|-JsonUtility.FromJson<ContentCatalogData>
	|-JsonUtility.FromJson<object>
	|
	|-RVA: 0x22663A0 Offset: 0x22664A1 VA: 0x22663A0
	|-JsonUtility.FromJson<DiagnosticEvent>
	*/

	// RVA: 0x1BE2C50 Offset: 0x1BE2D51 VA: 0x1BE2C50
	public static object FromJson(string json, Type type) { }
}

