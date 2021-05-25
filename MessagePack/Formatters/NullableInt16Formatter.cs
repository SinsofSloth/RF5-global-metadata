public sealed class NullableInt16Formatter : IMessagePackFormatter<Nullable<short>>, IMessagePackFormatter // TypeDefIndex: 5464
{
	// Fields
	public static readonly NullableInt16Formatter Instance; // 0x0

	// Methods

	// RVA: 0x165EC30 Offset: 0x165ED31 VA: 0x165EC30
	private void .ctor() { }

	// RVA: 0x165EC40 Offset: 0x165ED41 VA: 0x165EC40 Slot: 4
	public void Serialize(ref MessagePackWriter writer, Nullable<short> value, MessagePackSerializerOptions options) { }

	// RVA: 0x165ECE0 Offset: 0x165EDE1 VA: 0x165ECE0 Slot: 5
	public Nullable<short> Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x165EDD0 Offset: 0x165EED1 VA: 0x165EDD0
	private static void .cctor() { }
}

