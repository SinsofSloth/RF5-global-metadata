public static class RegionDefine // TypeDefIndex: 10230
{
	// Fields
	public static readonly RegionDefine.Region CurrentRegion; // 0x0
	public static readonly SystemLanguage[] RegionLanguages; // 0x8
	public const SystemLanguage DefaultLanguage = 22;
	private const string RegionFreeKey = "All/";
	private static readonly Dictionary<SystemLanguage, string> RegionKey; // 0x10

	// Methods

	// RVA: 0x1E04960 Offset: 0x1E04A61 VA: 0x1E04960
	public static string RootKey(bool region, SystemLanguage lang) { }

	// RVA: 0x1E04AA0 Offset: 0x1E04BA1 VA: 0x1E04AA0
	private static void .cctor() { }
}

