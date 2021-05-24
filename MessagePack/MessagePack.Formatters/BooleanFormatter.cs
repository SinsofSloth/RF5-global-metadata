public sealed class BooleanFormatter : IMessagePackFormatter<bool>, IMessagePackFormatter // TypeDefIndex: 5487
{
	// Fields
	public static readonly BooleanFormatter Instance; // 0x0

	// Methods

	// RVA: 0x1653AD0 Offset: 0x1653BD1 VA: 0x1653AD0
	private void .ctor() { }

	// RVA: 0x1653AE0 Offset: 0x1653BE1 VA: 0x1653AE0 Slot: 4
	public void Serialize(ref MessagePackWriter writer, bool value, MessagePackSerializerOptions options) { }

	// RVA: 0x1653AF0 Offset: 0x1653BF1 VA: 0x1653AF0 Slot: 5
	public bool Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x1653B00 Offset: 0x1653C01 VA: 0x1653B00
	private static void .cctor() { }
}

