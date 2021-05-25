public static class CompositeResolver // TypeDefIndex: 5229
{
	// Fields
	private static readonly ReadOnlyDictionary<Type, IMessagePackFormatter> EmptyFormattersByType; // 0x0

	// Methods

	// RVA: 0x14F2260 Offset: 0x14F2361 VA: 0x14F2260
	public static IFormatterResolver Create(IReadOnlyList<IMessagePackFormatter> formatters, IReadOnlyList<IFormatterResolver> resolvers) { }

	// RVA: 0x14F2490 Offset: 0x14F2591 VA: 0x14F2490
	public static IFormatterResolver Create(IFormatterResolver[] resolvers) { }

	// RVA: 0x14F25A0 Offset: 0x14F26A1 VA: 0x14F25A0
	public static IFormatterResolver Create(IMessagePackFormatter[] formatters) { }

	// RVA: 0x14F26B0 Offset: 0x14F27B1 VA: 0x14F26B0
	private static void .cctor() { }
}

