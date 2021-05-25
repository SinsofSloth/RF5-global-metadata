public sealed class SingleFormatter : IMessagePackFormatter<float>, IMessagePackFormatter // TypeDefIndex: 5481
{
	// Fields
	public static readonly SingleFormatter Instance; // 0x0

	// Methods

	// RVA: 0x16620C0 Offset: 0x16621C1 VA: 0x16620C0
	private void .ctor() { }

	// RVA: 0x16620D0 Offset: 0x16621D1 VA: 0x16620D0 Slot: 4
	public void Serialize(ref MessagePackWriter writer, float value, MessagePackSerializerOptions options) { }

	// RVA: 0x16620E0 Offset: 0x16621E1 VA: 0x16620E0 Slot: 5
	public float Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x16620F0 Offset: 0x16621F1 VA: 0x16620F0
	private static void .cctor() { }
}

