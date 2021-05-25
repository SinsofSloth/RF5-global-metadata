public sealed class StringBuilderFormatter : IMessagePackFormatter<StringBuilder>, IMessagePackFormatter // TypeDefIndex: 5431
{
	// Fields
	public static readonly IMessagePackFormatter<StringBuilder> Instance; // 0x0

	// Methods

	// RVA: 0x1662160 Offset: 0x1662261 VA: 0x1662160
	private void .ctor() { }

	// RVA: 0x1662170 Offset: 0x1662271 VA: 0x1662170 Slot: 4
	public void Serialize(ref MessagePackWriter writer, StringBuilder value, MessagePackSerializerOptions options) { }

	// RVA: 0x16621C0 Offset: 0x16622C1 VA: 0x16621C0 Slot: 5
	public StringBuilder Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x16622A0 Offset: 0x16623A1 VA: 0x16622A0
	private static void .cctor() { }
}

