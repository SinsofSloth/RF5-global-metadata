internal sealed class SharedStatics // TypeDefIndex: 307
{
	// Fields
	private static readonly SharedStatics _sharedStatics; // 0x0
	private Tokenizer.StringMaker _maker; // 0x10

	// Methods

	// RVA: 0x2645F70 Offset: 0x2646071 VA: 0x2645F70
	private void .ctor() { }

	// RVA: 0x263F540 Offset: 0x263F641 VA: 0x263F540
	public static Tokenizer.StringMaker GetSharedStringMaker() { }

	// RVA: 0x263FAB0 Offset: 0x263FBB1 VA: 0x263FAB0
	public static void ReleaseSharedStringMaker(ref Tokenizer.StringMaker maker) { }

	// RVA: 0x2645F80 Offset: 0x2646081 VA: 0x2645F80
	private static void .cctor() { }
}

