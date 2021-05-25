public sealed class DoubleArrayFormatter : IMessagePackFormatter<double[]>, IMessagePackFormatter // TypeDefIndex: 5486
{
	// Fields
	public static readonly DoubleArrayFormatter Instance; // 0x0

	// Methods

	// RVA: 0x1655B10 Offset: 0x1655C11 VA: 0x1655B10
	private void .ctor() { }

	// RVA: 0x1655B20 Offset: 0x1655C21 VA: 0x1655B20 Slot: 4
	public void Serialize(ref MessagePackWriter writer, double[] value, MessagePackSerializerOptions options) { }

	// RVA: 0x1655BC0 Offset: 0x1655CC1 VA: 0x1655BC0 Slot: 5
	public double[] Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x1655D80 Offset: 0x1655E81 VA: 0x1655D80
	private static void .cctor() { }
}

