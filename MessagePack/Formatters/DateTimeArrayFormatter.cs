public sealed class DateTimeArrayFormatter : IMessagePackFormatter<DateTime[]>, IMessagePackFormatter // TypeDefIndex: 5500
{
	// Fields
	public static readonly DateTimeArrayFormatter Instance; // 0x0

	// Methods

	// RVA: 0x1654B40 Offset: 0x1654C41 VA: 0x1654B40
	private void .ctor() { }

	// RVA: 0x1654B50 Offset: 0x1654C51 VA: 0x1654B50 Slot: 4
	public void Serialize(ref MessagePackWriter writer, DateTime[] value, MessagePackSerializerOptions options) { }

	// RVA: 0x1654BF0 Offset: 0x1654CF1 VA: 0x1654BF0 Slot: 5
	public DateTime[] Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x1654DB0 Offset: 0x1654EB1 VA: 0x1654DB0
	private static void .cctor() { }
}

