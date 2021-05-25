[NativeHeaderAttribute] // RVA: 0xC7620 Offset: 0xC7721 VA: 0xC7620
[NativeHeaderAttribute] // RVA: 0xC7620 Offset: 0xC7721 VA: 0xC7620
[StaticAccessorAttribute] // RVA: 0xC7620 Offset: 0xC7721 VA: 0xC7620
public class SpriteAtlasManager // TypeDefIndex: 3086
{
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0xCAB00 Offset: 0xCAC01 VA: 0xCAB00
	[CompilerGeneratedAttribute] // RVA: 0xCAB00 Offset: 0xCAC01 VA: 0xCAB00
	private static Action<string, Action<SpriteAtlas>> atlasRequested; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0xCAB40 Offset: 0xCAC41 VA: 0xCAB40
	[CompilerGeneratedAttribute] // RVA: 0xCAB40 Offset: 0xCAC41 VA: 0xCAB40
	private static Action<SpriteAtlas> atlasRegistered; // 0x8

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0xD8F50 Offset: 0xD9051 VA: 0xD8F50
	// RVA: 0x1B78C50 Offset: 0x1B78D51 VA: 0x1B78C50
	private static bool RequestAtlas(string tag) { }

	[CompilerGeneratedAttribute] // RVA: 0xD8F60 Offset: 0xD9061 VA: 0xD8F60
	// RVA: 0x1B78D70 Offset: 0x1B78E71 VA: 0x1B78D70
	public static void add_atlasRegistered(Action<SpriteAtlas> value) { }

	[CompilerGeneratedAttribute] // RVA: 0xD8F70 Offset: 0xD9071 VA: 0xD8F70
	// RVA: 0x1B78E60 Offset: 0x1B78F61 VA: 0x1B78E60
	public static void remove_atlasRegistered(Action<SpriteAtlas> value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xD8F80 Offset: 0xD9081 VA: 0xD8F80
	// RVA: 0x1B78F50 Offset: 0x1B79051 VA: 0x1B78F50
	private static void PostRegisteredAtlas(SpriteAtlas spriteAtlas) { }

	// RVA: 0x1B78FF0 Offset: 0x1B790F1 VA: 0x1B78FF0
	internal static void Register(SpriteAtlas spriteAtlas) { }

	// RVA: 0x1B79040 Offset: 0x1B79141 VA: 0x1B79040
	private static void .cctor() { }
}

