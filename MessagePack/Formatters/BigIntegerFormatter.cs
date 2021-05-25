public sealed class BigIntegerFormatter : IMessagePackFormatter<BigInteger>, IMessagePackFormatter // TypeDefIndex: 5433
{
	// Fields
	public static readonly IMessagePackFormatter<BigInteger> Instance; // 0x0

	// Methods

	// RVA: 0x1653400 Offset: 0x1653501 VA: 0x1653400
	private void .ctor() { }

	// RVA: 0x1653410 Offset: 0x1653511 VA: 0x1653410 Slot: 4
	public void Serialize(ref MessagePackWriter writer, BigInteger value, MessagePackSerializerOptions options) { }

	// RVA: 0x1653460 Offset: 0x1653561 VA: 0x1653460 Slot: 5
	public BigInteger Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x1653540 Offset: 0x1653641 VA: 0x1653540
	private static void .cctor() { }
}

