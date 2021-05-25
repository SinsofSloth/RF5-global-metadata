public sealed class GuidFormatter : IMessagePackFormatter<Guid>, IMessagePackFormatter // TypeDefIndex: 5427
{
	// Fields
	public static readonly IMessagePackFormatter<Guid> Instance; // 0x0

	// Methods

	// RVA: 0x16593B0 Offset: 0x16594B1 VA: 0x16593B0
	private void .ctor() { }

	// RVA: 0x16593C0 Offset: 0x16594C1 VA: 0x16593C0 Slot: 4
	public void Serialize(ref MessagePackWriter writer, Guid value, MessagePackSerializerOptions options) { }

	// RVA: 0x16594D0 Offset: 0x16595D1 VA: 0x16594D0 Slot: 5
	public Guid Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x1659710 Offset: 0x1659811 VA: 0x1659710
	private static void .cctor() { }
}

