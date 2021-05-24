public sealed class CharFormatter : IMessagePackFormatter<char>, IMessagePackFormatter // TypeDefIndex: 5495
{
	// Fields
	public static readonly CharFormatter Instance; // 0x0

	// Methods

	// RVA: 0x16548E0 Offset: 0x16549E1 VA: 0x16548E0
	private void .ctor() { }

	// RVA: 0x16548F0 Offset: 0x16549F1 VA: 0x16548F0 Slot: 4
	public void Serialize(ref MessagePackWriter writer, char value, MessagePackSerializerOptions options) { }

	// RVA: 0x1654900 Offset: 0x1654A01 VA: 0x1654900 Slot: 5
	public char Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x1654910 Offset: 0x1654A11 VA: 0x1654910
	private static void .cctor() { }
}

