[NativeHeaderAttribute] // RVA: 0xC62A0 Offset: 0xC63A1 VA: 0xC62A0
public class PlayerPrefs // TypeDefIndex: 2975
{
	// Methods

	[NativeMethodAttribute] // RVA: 0xD5710 Offset: 0xD5811 VA: 0xD5710
	// RVA: 0x2B72AA0 Offset: 0x2B72BA1 VA: 0x2B72AA0
	private static bool TrySetInt(string key, int value) { }

	[NativeMethodAttribute] // RVA: 0xD5750 Offset: 0xD5851 VA: 0xD5750
	// RVA: 0x2B72AF0 Offset: 0x2B72BF1 VA: 0x2B72AF0
	private static bool TrySetFloat(string key, float value) { }

	[NativeMethodAttribute] // RVA: 0xD5790 Offset: 0xD5891 VA: 0xD5790
	// RVA: 0x2B72B40 Offset: 0x2B72C41 VA: 0x2B72B40
	private static bool TrySetSetString(string key, string value) { }

	// RVA: 0x2B72B90 Offset: 0x2B72C91 VA: 0x2B72B90
	public static void SetInt(string key, int value) { }

	// RVA: 0x2B72CE0 Offset: 0x2B72DE1 VA: 0x2B72CE0
	public static int GetInt(string key, int defaultValue) { }

	// RVA: 0x2B72D30 Offset: 0x2B72E31 VA: 0x2B72D30
	public static void SetFloat(string key, float value) { }

	// RVA: 0x2B72E00 Offset: 0x2B72F01 VA: 0x2B72E00
	public static float GetFloat(string key, float defaultValue) { }

	// RVA: 0x2B72E50 Offset: 0x2B72F51 VA: 0x2B72E50
	public static void SetString(string key, string value) { }

	// RVA: 0x2B72F20 Offset: 0x2B73021 VA: 0x2B72F20
	public static string GetString(string key, string defaultValue) { }

	// RVA: 0x2B72F70 Offset: 0x2B73071 VA: 0x2B72F70
	public static string GetString(string key) { }

	// RVA: 0x2B72FF0 Offset: 0x2B730F1 VA: 0x2B72FF0
	public static bool HasKey(string key) { }

	// RVA: 0x2B73040 Offset: 0x2B73141 VA: 0x2B73040
	public static void DeleteKey(string key) { }

	[NativeMethodAttribute] // RVA: 0xD57D0 Offset: 0xD58D1 VA: 0xD57D0
	// RVA: 0x2B73090 Offset: 0x2B73191 VA: 0x2B73090
	public static void DeleteAll() { }

	[NativeMethodAttribute] // RVA: 0xD5810 Offset: 0xD5911 VA: 0xD5810
	// RVA: 0x2B730D0 Offset: 0x2B731D1 VA: 0x2B730D0
	public static void Save() { }
}

