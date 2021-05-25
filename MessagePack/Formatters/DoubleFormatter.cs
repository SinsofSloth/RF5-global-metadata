public sealed class DoubleFormatter : IMessagePackFormatter<double>, IMessagePackFormatter // TypeDefIndex: 5484
{
	// Fields
	public static readonly DoubleFormatter Instance; // 0x0

	// Methods

	// RVA: 0x1655DF0 Offset: 0x1655EF1 VA: 0x1655DF0
	private void .ctor() { }

	// RVA: 0x1655E00 Offset: 0x1655F01 VA: 0x1655E00 Slot: 4
	public void Serialize(ref MessagePackWriter writer, double value, MessagePackSerializerOptions options) { }

	// RVA: 0x1655E10 Offset: 0x1655F11 VA: 0x1655E10 Slot: 5
	public double Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x1655E20 Offset: 0x1655F21 VA: 0x1655E20
	private static void .cctor() { }
}

