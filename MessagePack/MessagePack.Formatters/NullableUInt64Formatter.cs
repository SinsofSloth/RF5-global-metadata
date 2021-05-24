public sealed class NullableUInt64Formatter : IMessagePackFormatter<Nullable<ulong>>, IMessagePackFormatter // TypeDefIndex: 5479
{
	// Fields
	public static readonly NullableUInt64Formatter Instance; // 0x0

	// Methods

	// RVA: 0x165FF40 Offset: 0x1660041 VA: 0x165FF40
	private void .ctor() { }

	// RVA: 0x165FF50 Offset: 0x1660051 VA: 0x165FF50 Slot: 4
	public void Serialize(ref MessagePackWriter writer, Nullable<ulong> value, MessagePackSerializerOptions options) { }

	// RVA: 0x165FFF0 Offset: 0x16600F1 VA: 0x165FFF0 Slot: 5
	public Nullable<ulong> Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x16600D0 Offset: 0x16601D1 VA: 0x16600D0
	private static void .cctor() { }
}

