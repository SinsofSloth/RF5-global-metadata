public sealed class NullableCharFormatter : IMessagePackFormatter<Nullable<char>>, IMessagePackFormatter // TypeDefIndex: 5496
{
	// Fields
	public static readonly NullableCharFormatter Instance; // 0x0

	// Methods

	// RVA: 0x165D5D0 Offset: 0x165D6D1 VA: 0x165D5D0
	private void .ctor() { }

	// RVA: 0x165D5E0 Offset: 0x165D6E1 VA: 0x165D5E0 Slot: 4
	public void Serialize(ref MessagePackWriter writer, Nullable<char> value, MessagePackSerializerOptions options) { }

	// RVA: 0x165D680 Offset: 0x165D781 VA: 0x165D680 Slot: 5
	public Nullable<char> Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x165D770 Offset: 0x165D871 VA: 0x165D770
	private static void .cctor() { }
}

