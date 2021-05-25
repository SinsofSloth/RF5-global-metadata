public sealed class NullableDateTimeFormatter : IMessagePackFormatter<Nullable<DateTime>>, IMessagePackFormatter // TypeDefIndex: 5499
{
	// Fields
	public static readonly NullableDateTimeFormatter Instance; // 0x0

	// Methods

	// RVA: 0x165D7E0 Offset: 0x165D8E1 VA: 0x165D7E0
	private void .ctor() { }

	// RVA: 0x165D7F0 Offset: 0x165D8F1 VA: 0x165D7F0 Slot: 4
	public void Serialize(ref MessagePackWriter writer, Nullable<DateTime> value, MessagePackSerializerOptions options) { }

	// RVA: 0x165D890 Offset: 0x165D991 VA: 0x165D890 Slot: 5
	public Nullable<DateTime> Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x165D970 Offset: 0x165DA71 VA: 0x165D970
	private static void .cctor() { }
}

