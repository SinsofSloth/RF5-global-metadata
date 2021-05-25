public sealed class UInt64ArrayFormatter : IMessagePackFormatter<ulong[]>, IMessagePackFormatter // TypeDefIndex: 5480
{
	// Fields
	public static readonly UInt64ArrayFormatter Instance; // 0x0

	// Methods

	// RVA: 0x1662AB0 Offset: 0x1662BB1 VA: 0x1662AB0
	private void .ctor() { }

	// RVA: 0x1662AC0 Offset: 0x1662BC1 VA: 0x1662AC0 Slot: 4
	public void Serialize(ref MessagePackWriter writer, ulong[] value, MessagePackSerializerOptions options) { }

	// RVA: 0x1662B60 Offset: 0x1662C61 VA: 0x1662B60 Slot: 5
	public ulong[] Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x1662D20 Offset: 0x1662E21 VA: 0x1662D20
	private static void .cctor() { }
}

