public sealed class ByteArrayFormatter : IMessagePackFormatter<byte[]>, IMessagePackFormatter // TypeDefIndex: 5421
{
	// Fields
	public static readonly ByteArrayFormatter Instance; // 0x0

	// Methods

	// RVA: 0x1653B70 Offset: 0x1653C71 VA: 0x1653B70
	private void .ctor() { }

	// RVA: 0x1653B80 Offset: 0x1653C81 VA: 0x1653B80 Slot: 4
	public void Serialize(ref MessagePackWriter writer, byte[] value, MessagePackSerializerOptions options) { }

	// RVA: 0x1653B90 Offset: 0x1653C91 VA: 0x1653B90 Slot: 5
	public byte[] Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x1653C60 Offset: 0x1653D61 VA: 0x1653C60
	private static void .cctor() { }
}

