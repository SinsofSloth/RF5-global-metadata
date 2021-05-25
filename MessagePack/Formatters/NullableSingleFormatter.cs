public sealed class NullableSingleFormatter : IMessagePackFormatter<Nullable<float>>, IMessagePackFormatter // TypeDefIndex: 5482
{
	// Fields
	public static readonly NullableSingleFormatter Instance; // 0x0

	// Methods

	// RVA: 0x165F570 Offset: 0x165F671 VA: 0x165F570
	private void .ctor() { }

	// RVA: 0x165F580 Offset: 0x165F681 VA: 0x165F580 Slot: 4
	public void Serialize(ref MessagePackWriter writer, Nullable<float> value, MessagePackSerializerOptions options) { }

	// RVA: 0x165F610 Offset: 0x165F711 VA: 0x165F610 Slot: 5
	public Nullable<float> Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x165F6F0 Offset: 0x165F7F1 VA: 0x165F6F0
	private static void .cctor() { }
}

