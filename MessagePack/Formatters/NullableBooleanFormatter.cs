public sealed class NullableBooleanFormatter : IMessagePackFormatter<Nullable<bool>>, IMessagePackFormatter // TypeDefIndex: 5488
{
	// Fields
	public static readonly NullableBooleanFormatter Instance; // 0x0

	// Methods

	// RVA: 0x165D1B0 Offset: 0x165D2B1 VA: 0x165D1B0
	private void .ctor() { }

	// RVA: 0x165D1C0 Offset: 0x165D2C1 VA: 0x165D1C0 Slot: 4
	public void Serialize(ref MessagePackWriter writer, Nullable<bool> value, MessagePackSerializerOptions options) { }

	// RVA: 0x165D260 Offset: 0x165D361 VA: 0x165D260 Slot: 5
	public Nullable<bool> Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x165D350 Offset: 0x165D451 VA: 0x165D350
	private static void .cctor() { }
}

