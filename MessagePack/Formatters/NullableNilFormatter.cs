public class NullableNilFormatter : IMessagePackFormatter<Nullable<Nil>>, IMessagePackFormatter // TypeDefIndex: 5417
{
	// Fields
	public static readonly IMessagePackFormatter<Nullable<Nil>> Instance; // 0x0

	// Methods

	// RVA: 0x165F250 Offset: 0x165F351 VA: 0x165F250
	private void .ctor() { }

	// RVA: 0x165F260 Offset: 0x165F361 VA: 0x165F260 Slot: 4
	public void Serialize(ref MessagePackWriter writer, Nullable<Nil> value, MessagePackSerializerOptions options) { }

	// RVA: 0x165F270 Offset: 0x165F371 VA: 0x165F270 Slot: 5
	public Nullable<Nil> Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x165F2F0 Offset: 0x165F3F1 VA: 0x165F2F0
	private static void .cctor() { }
}

