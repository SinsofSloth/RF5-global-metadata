public sealed class NullableUInt32Formatter : IMessagePackFormatter<Nullable<uint>>, IMessagePackFormatter // TypeDefIndex: 5476
{
	// Fields
	public static readonly NullableUInt32Formatter Instance; // 0x0

	// Methods

	// RVA: 0x165FD30 Offset: 0x165FE31 VA: 0x165FD30
	private void .ctor() { }

	// RVA: 0x165FD40 Offset: 0x165FE41 VA: 0x165FD40 Slot: 4
	public void Serialize(ref MessagePackWriter writer, Nullable<uint> value, MessagePackSerializerOptions options) { }

	// RVA: 0x165FDE0 Offset: 0x165FEE1 VA: 0x165FDE0 Slot: 5
	public Nullable<uint> Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x165FED0 Offset: 0x165FFD1 VA: 0x165FED0
	private static void .cctor() { }
}

