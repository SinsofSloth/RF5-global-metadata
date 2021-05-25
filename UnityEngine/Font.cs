[NativeHeaderAttribute] // RVA: 0xE6ED0 Offset: 0xE6FD1 VA: 0xE6ED0
[StaticAccessorAttribute] // RVA: 0xE6ED0 Offset: 0xE6FD1 VA: 0xE6ED0
[NativeHeaderAttribute] // RVA: 0xE6ED0 Offset: 0xE6FD1 VA: 0xE6ED0
[NativeClassAttribute] // RVA: 0xE6ED0 Offset: 0xE6FD1 VA: 0xE6ED0
public sealed class Font : Object // TypeDefIndex: 3466
{
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0xE70A0 Offset: 0xE71A1 VA: 0xE70A0
	[CompilerGeneratedAttribute] // RVA: 0xE70A0 Offset: 0xE71A1 VA: 0xE70A0
	private static Action<Font> textureRebuilt; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0xE70E0 Offset: 0xE71E1 VA: 0xE70E0
	[DebuggerBrowsableAttribute] // RVA: 0xE70E0 Offset: 0xE71E1 VA: 0xE70E0
	private Font.FontTextureRebuildCallback m_FontTextureRebuildCallback; // 0x18

	// Properties
	public Material material { get; set; }
	public string[] fontNames { get; set; }
	public bool dynamic { get; }
	public int ascent { get; }
	public int fontSize { get; }
	public CharacterInfo[] characterInfo { get; set; }
	[NativePropertyAttribute] // RVA: 0xE7480 Offset: 0xE7581 VA: 0xE7480
	public int lineHeight { get; }
	[ObsoleteAttribute] // RVA: 0xE74C0 Offset: 0xE75C1 VA: 0xE74C0
	public Font.FontTextureRebuildCallback textureRebuildCallback { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0xE71D0 Offset: 0xE72D1 VA: 0xE71D0
	// RVA: 0x1BCD4E0 Offset: 0x1BCD5E1 VA: 0x1BCD4E0
	public static void add_textureRebuilt(Action<Font> value) { }

	[CompilerGeneratedAttribute] // RVA: 0xE71E0 Offset: 0xE72E1 VA: 0xE71E0
	// RVA: 0x1BCD5A0 Offset: 0x1BCD6A1 VA: 0x1BCD5A0
	public static void remove_textureRebuilt(Action<Font> value) { }

	[CompilerGeneratedAttribute] // RVA: 0xE71F0 Offset: 0xE72F1 VA: 0xE71F0
	// RVA: 0x1BCD660 Offset: 0x1BCD761 VA: 0x1BCD660
	private void add_m_FontTextureRebuildCallback(Font.FontTextureRebuildCallback value) { }

	[CompilerGeneratedAttribute] // RVA: 0xE7200 Offset: 0xE7301 VA: 0xE7200
	// RVA: 0x1BCD710 Offset: 0x1BCD811 VA: 0x1BCD710
	private void remove_m_FontTextureRebuildCallback(Font.FontTextureRebuildCallback value) { }

	// RVA: 0x1BCD7C0 Offset: 0x1BCD8C1 VA: 0x1BCD7C0
	public Material get_material() { }

	// RVA: 0x1BCD810 Offset: 0x1BCD911 VA: 0x1BCD810
	public void set_material(Material value) { }

	// RVA: 0x1BCD860 Offset: 0x1BCD961 VA: 0x1BCD860
	public string[] get_fontNames() { }

	// RVA: 0x1BCD8B0 Offset: 0x1BCD9B1 VA: 0x1BCD8B0
	public void set_fontNames(string[] value) { }

	// RVA: 0x1BCD900 Offset: 0x1BCDA01 VA: 0x1BCD900
	public bool get_dynamic() { }

	// RVA: 0x1BCD950 Offset: 0x1BCDA51 VA: 0x1BCD950
	public int get_ascent() { }

	// RVA: 0x1BCD9A0 Offset: 0x1BCDAA1 VA: 0x1BCD9A0
	public int get_fontSize() { }

	[FreeFunctionAttribute] // RVA: 0xE7210 Offset: 0xE7311 VA: 0xE7210
	// RVA: 0x1BCD9F0 Offset: 0x1BCDAF1 VA: 0x1BCD9F0
	public CharacterInfo[] get_characterInfo() { }

	[FreeFunctionAttribute] // RVA: 0xE7260 Offset: 0xE7361 VA: 0xE7260
	// RVA: 0x1BCDA40 Offset: 0x1BCDB41 VA: 0x1BCDA40
	public void set_characterInfo(CharacterInfo[] value) { }

	// RVA: 0x1BCDA90 Offset: 0x1BCDB91 VA: 0x1BCDA90
	public int get_lineHeight() { }

	// RVA: 0x1BCDAE0 Offset: 0x1BCDBE1 VA: 0x1BCDAE0
	public Font.FontTextureRebuildCallback get_textureRebuildCallback() { }

	// RVA: 0x1BCDAF0 Offset: 0x1BCDBF1 VA: 0x1BCDAF0
	public void set_textureRebuildCallback(Font.FontTextureRebuildCallback value) { }

	// RVA: 0x1BCDB00 Offset: 0x1BCDC01 VA: 0x1BCDB00
	public void .ctor() { }

	// RVA: 0x1BCDBF0 Offset: 0x1BCDCF1 VA: 0x1BCDBF0
	public void .ctor(string name) { }

	// RVA: 0x1BCDD50 Offset: 0x1BCDE51 VA: 0x1BCDD50
	private void .ctor(string[] names, int size) { }

	// RVA: 0x1BCDE60 Offset: 0x1BCDF61 VA: 0x1BCDE60
	public static Font CreateDynamicFontFromOSFont(string fontname, int size) { }

	// RVA: 0x1BCDFB0 Offset: 0x1BCE0B1 VA: 0x1BCDFB0
	public static Font CreateDynamicFontFromOSFont(string[] fontnames, int size) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xE72B0 Offset: 0xE73B1 VA: 0xE72B0
	// RVA: 0x1BCE0A0 Offset: 0x1BCE1A1 VA: 0x1BCE0A0
	internal static void InvokeTextureRebuilt_Internal(Font font) { }

	// RVA: 0x1BCE370 Offset: 0x1BCE471 VA: 0x1BCE370
	public static int GetMaxVertsForString(string str) { }

	// RVA: 0x1BCE390 Offset: 0x1BCE491 VA: 0x1BCE390
	internal static Font GetDefault() { }

	// RVA: 0x1BCE3D0 Offset: 0x1BCE4D1 VA: 0x1BCE3D0
	public bool HasCharacter(char c) { }

	// RVA: 0x1BCE420 Offset: 0x1BCE521 VA: 0x1BCE420
	private bool HasCharacter(int c) { }

	// RVA: 0x1BCE470 Offset: 0x1BCE571 VA: 0x1BCE470
	public static string[] GetOSInstalledFontNames() { }

	// RVA: 0x1BCE4B0 Offset: 0x1BCE5B1 VA: 0x1BCE4B0
	public static string[] GetPathsToOSFonts() { }

	// RVA: 0x1BCDBA0 Offset: 0x1BCDCA1 VA: 0x1BCDBA0
	private static void Internal_CreateFont(Font self, string name) { }

	// RVA: 0x1BCDD00 Offset: 0x1BCDE01 VA: 0x1BCDD00
	private static void Internal_CreateFontFromPath(Font self, string fontPath) { }

	// RVA: 0x1BCDE00 Offset: 0x1BCDF01 VA: 0x1BCDE00
	private static void Internal_CreateDynamicFont(Font self, string[] _names, int size) { }

	[FreeFunctionAttribute] // RVA: 0xE72C0 Offset: 0xE73C1 VA: 0xE72C0
	// RVA: 0x1BCE4F0 Offset: 0x1BCE5F1 VA: 0x1BCE4F0
	public bool GetCharacterInfo(char ch, out CharacterInfo info, int size, FontStyle style) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE7310 Offset: 0xE7411 VA: 0xE7310
	// RVA: 0x1BCE560 Offset: 0x1BCE661 VA: 0x1BCE560
	public bool GetCharacterInfo(char ch, out CharacterInfo info, int size) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE7320 Offset: 0xE7421 VA: 0xE7320
	// RVA: 0x1BCE5D0 Offset: 0x1BCE6D1 VA: 0x1BCE5D0
	public bool GetCharacterInfo(char ch, out CharacterInfo info) { }

	// RVA: 0x1BCE630 Offset: 0x1BCE731 VA: 0x1BCE630
	public void RequestCharactersInTexture(string characters, int size, FontStyle style) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE7330 Offset: 0xE7431 VA: 0xE7330
	// RVA: 0x1BCE6A0 Offset: 0x1BCE7A1 VA: 0x1BCE6A0
	public void RequestCharactersInTexture(string characters, int size) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE7340 Offset: 0xE7441 VA: 0xE7340
	// RVA: 0x1BCE700 Offset: 0x1BCE801 VA: 0x1BCE700
	public void RequestCharactersInTexture(string characters) { }
}

