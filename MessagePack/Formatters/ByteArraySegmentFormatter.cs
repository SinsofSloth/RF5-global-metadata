public sealed class ByteArraySegmentFormatter : IMessagePackFormatter<ArraySegment<byte>>, IMessagePackFormatter // TypeDefIndex: 5350
{
	// Fields
	public static readonly ByteArraySegmentFormatter Instance; // 0x0

	// Methods

	// RVA: 0x1653CD0 Offset: 0x1653DD1 VA: 0x1653CD0
	private void .ctor() { }

	// RVA: 0x1653CE0 Offset: 0x1653DE1 VA: 0x1653CE0 Slot: 4
	public void Serialize(ref MessagePackWriter writer, ArraySegment<byte> value, MessagePackSerializerOptions options) { }

	// RVA: 0x1653DA0 Offset: 0x1653EA1 VA: 0x1653DA0 Slot: 5
	public ArraySegment<byte> Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x1653E60 Offset: 0x1653F61 VA: 0x1653E60
	private static void .cctor() { }
}

