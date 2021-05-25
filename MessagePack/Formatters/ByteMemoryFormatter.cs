public sealed class ByteMemoryFormatter : IMessagePackFormatter<Memory<byte>>, IMessagePackFormatter // TypeDefIndex: 5347
{
	// Fields
	public static readonly ByteMemoryFormatter Instance; // 0x0

	// Methods

	// RVA: 0x1653F70 Offset: 0x1654071 VA: 0x1653F70
	private void .ctor() { }

	// RVA: 0x1653F80 Offset: 0x1654081 VA: 0x1653F80 Slot: 4
	public void Serialize(ref MessagePackWriter writer, Memory<byte> value, MessagePackSerializerOptions options) { }

	// RVA: 0x1654030 Offset: 0x1654131 VA: 0x1654030 Slot: 5
	public Memory<byte> Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x1654120 Offset: 0x1654221 VA: 0x1654120
	private static void .cctor() { }
}

