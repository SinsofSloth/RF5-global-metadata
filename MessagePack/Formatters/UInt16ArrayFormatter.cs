public sealed class UInt16ArrayFormatter : IMessagePackFormatter<ushort[]>, IMessagePackFormatter // TypeDefIndex: 5474
{
	// Fields
	public static readonly UInt16ArrayFormatter Instance; // 0x0

	// Methods

	// RVA: 0x16623B0 Offset: 0x16624B1 VA: 0x16623B0
	private void .ctor() { }

	// RVA: 0x16623C0 Offset: 0x16624C1 VA: 0x16623C0 Slot: 4
	public void Serialize(ref MessagePackWriter writer, ushort[] value, MessagePackSerializerOptions options) { }

	// RVA: 0x1662460 Offset: 0x1662561 VA: 0x1662460 Slot: 5
	public ushort[] Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x1662620 Offset: 0x1662721 VA: 0x1662620
	private static void .cctor() { }
}

