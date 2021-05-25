public sealed class BooleanArrayFormatter : IMessagePackFormatter<bool[]>, IMessagePackFormatter // TypeDefIndex: 5489
{
	// Fields
	public static readonly BooleanArrayFormatter Instance; // 0x0

	// Methods

	// RVA: 0x16537F0 Offset: 0x16538F1 VA: 0x16537F0
	private void .ctor() { }

	// RVA: 0x1653800 Offset: 0x1653901 VA: 0x1653800 Slot: 4
	public void Serialize(ref MessagePackWriter writer, bool[] value, MessagePackSerializerOptions options) { }

	// RVA: 0x16538A0 Offset: 0x16539A1 VA: 0x16538A0 Slot: 5
	public bool[] Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x1653A60 Offset: 0x1653B61 VA: 0x1653A60
	private static void .cctor() { }
}

