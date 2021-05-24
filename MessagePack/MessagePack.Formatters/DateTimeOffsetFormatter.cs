public sealed class DateTimeOffsetFormatter : IMessagePackFormatter<DateTimeOffset>, IMessagePackFormatter // TypeDefIndex: 5426
{
	// Fields
	public static readonly IMessagePackFormatter<DateTimeOffset> Instance; // 0x0

	// Methods

	// RVA: 0x1654EC0 Offset: 0x1654FC1 VA: 0x1654EC0
	private void .ctor() { }

	// RVA: 0x1654ED0 Offset: 0x1654FD1 VA: 0x1654ED0 Slot: 4
	public void Serialize(ref MessagePackWriter writer, DateTimeOffset value, MessagePackSerializerOptions options) { }

	// RVA: 0x1654F70 Offset: 0x1655071 VA: 0x1654F70 Slot: 5
	public DateTimeOffset Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x1655090 Offset: 0x1655191 VA: 0x1655090
	private static void .cctor() { }
}

