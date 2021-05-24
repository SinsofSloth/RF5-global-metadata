internal static class StringBuilderCache // TypeDefIndex: 474
{
	// Fields
	[ThreadStaticAttribute] // RVA: 0xB45E0 Offset: 0xB46E1 VA: 0xB45E0
	private static StringBuilder CachedInstance; // 0x80000000

	// Methods

	// RVA: 0x19FC450 Offset: 0x19FC551 VA: 0x19FC450
	public static StringBuilder Acquire(int capacity = 16) { }

	// RVA: 0x19FC520 Offset: 0x19FC621 VA: 0x19FC520
	public static void Release(StringBuilder sb) { }

	// RVA: 0x19FC5A0 Offset: 0x19FC6A1 VA: 0x19FC5A0
	public static string GetStringAndRelease(StringBuilder sb) { }
}

