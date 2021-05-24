internal struct MonoProtection // TypeDefIndex: 5166
{
	// Fields
	private static readonly object RefEmitLock; // 0x0

	// Properties
	internal static bool IsRunningOnMono { get; }

	// Methods

	// RVA: 0x14F1DB0 Offset: 0x14F1EB1 VA: 0x14F1DB0
	internal static bool get_IsRunningOnMono() { }

	// RVA: 0x14F1E50 Offset: 0x14F1F51 VA: 0x14F1E50
	internal static MonoProtectionDisposal EnterRefEmitLock() { }

	// RVA: 0x14F1F50 Offset: 0x14F2051 VA: 0x14F1F50
	private static void .cctor() { }
}

