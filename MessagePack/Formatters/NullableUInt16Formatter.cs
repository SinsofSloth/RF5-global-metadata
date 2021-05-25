public sealed class NullableUInt16Formatter : IMessagePackFormatter<Nullable<ushort>>, IMessagePackFormatter // TypeDefIndex: 5473
{
	// Fields
	public static readonly NullableUInt16Formatter Instance; // 0x0

	// Methods

	// RVA: 0x165FB20 Offset: 0x165FC21 VA: 0x165FB20
	private void .ctor() { }

	// RVA: 0x165FB30 Offset: 0x165FC31 VA: 0x165FB30 Slot: 4
	public void Serialize(ref MessagePackWriter writer, Nullable<ushort> value, MessagePackSerializerOptions options) { }

	// RVA: 0x165FBD0 Offset: 0x165FCD1 VA: 0x165FBD0 Slot: 5
	public Nullable<ushort> Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x165FCC0 Offset: 0x165FDC1 VA: 0x165FCC0
	private static void .cctor() { }
}

