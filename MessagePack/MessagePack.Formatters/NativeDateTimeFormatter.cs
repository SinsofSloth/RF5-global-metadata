public sealed class NativeDateTimeFormatter : IMessagePackFormatter<DateTime>, IMessagePackFormatter // TypeDefIndex: 5389
{
	// Fields
	public static readonly NativeDateTimeFormatter Instance; // 0x0

	// Methods

	// RVA: 0x165A520 Offset: 0x165A621 VA: 0x165A520 Slot: 4
	public void Serialize(ref MessagePackWriter writer, DateTime value, MessagePackSerializerOptions options) { }

	// RVA: 0x165A560 Offset: 0x165A661 VA: 0x165A560 Slot: 5
	public DateTime Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x165A5E0 Offset: 0x165A6E1 VA: 0x165A5E0
	public void .ctor() { }

	// RVA: 0x165A5F0 Offset: 0x165A6F1 VA: 0x165A5F0
	private static void .cctor() { }
}

