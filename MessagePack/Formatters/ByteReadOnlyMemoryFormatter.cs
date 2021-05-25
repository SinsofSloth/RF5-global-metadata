public sealed class ByteReadOnlyMemoryFormatter : IMessagePackFormatter<ReadOnlyMemory<byte>>, IMessagePackFormatter // TypeDefIndex: 5348
{
	// Fields
	public static readonly ByteReadOnlyMemoryFormatter Instance; // 0x0

	// Methods

	// RVA: 0x1654190 Offset: 0x1654291 VA: 0x1654190
	private void .ctor() { }

	// RVA: 0x16541A0 Offset: 0x16542A1 VA: 0x16541A0 Slot: 4
	public void Serialize(ref MessagePackWriter writer, ReadOnlyMemory<byte> value, MessagePackSerializerOptions options) { }

	// RVA: 0x1654230 Offset: 0x1654331 VA: 0x1654230 Slot: 5
	public ReadOnlyMemory<byte> Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x16542F0 Offset: 0x16543F1 VA: 0x16542F0
	private static void .cctor() { }
}

