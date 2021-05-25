public sealed class CharArrayFormatter : IMessagePackFormatter<char[]>, IMessagePackFormatter // TypeDefIndex: 5497
{
	// Fields
	public static readonly CharArrayFormatter Instance; // 0x0

	// Methods

	// RVA: 0x1654600 Offset: 0x1654701 VA: 0x1654600
	private void .ctor() { }

	// RVA: 0x1654610 Offset: 0x1654711 VA: 0x1654610 Slot: 4
	public void Serialize(ref MessagePackWriter writer, char[] value, MessagePackSerializerOptions options) { }

	// RVA: 0x16546B0 Offset: 0x16547B1 VA: 0x16546B0 Slot: 5
	public char[] Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x1654870 Offset: 0x1654971 VA: 0x1654870
	private static void .cctor() { }
}

