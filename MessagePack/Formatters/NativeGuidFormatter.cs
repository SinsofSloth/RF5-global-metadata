public sealed class NativeGuidFormatter : IMessagePackFormatter<Guid>, IMessagePackFormatter // TypeDefIndex: 5438
{
	// Fields
	public static readonly IMessagePackFormatter<Guid> Instance; // 0x0

	// Methods

	// RVA: 0x165A9A0 Offset: 0x165AAA1 VA: 0x165A9A0
	private void .ctor() { }

	// RVA: 0x165A9B0 Offset: 0x165AAB1 VA: 0x165A9B0 Slot: 4
	public void Serialize(ref MessagePackWriter writer, Guid value, MessagePackSerializerOptions options) { }

	// RVA: 0x165AAB0 Offset: 0x165ABB1 VA: 0x165AAB0 Slot: 5
	public Guid Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x165AC70 Offset: 0x165AD71 VA: 0x165AC70
	private static void .cctor() { }
}

