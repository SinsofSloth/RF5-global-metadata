public sealed class ByteFormatter : IMessagePackFormatter<byte>, IMessagePackFormatter // TypeDefIndex: 5490
{
	// Fields
	public static readonly ByteFormatter Instance; // 0x0

	// Methods

	// RVA: 0x1653ED0 Offset: 0x1653FD1 VA: 0x1653ED0
	private void .ctor() { }

	// RVA: 0x1653EE0 Offset: 0x1653FE1 VA: 0x1653EE0 Slot: 4
	public void Serialize(ref MessagePackWriter writer, byte value, MessagePackSerializerOptions options) { }

	// RVA: 0x1653EF0 Offset: 0x1653FF1 VA: 0x1653EF0 Slot: 5
	public byte Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x1653F00 Offset: 0x1654001 VA: 0x1653F00
	private static void .cctor() { }
}

