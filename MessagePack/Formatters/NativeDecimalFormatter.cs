public sealed class NativeDecimalFormatter : IMessagePackFormatter<Decimal>, IMessagePackFormatter // TypeDefIndex: 5439
{
	// Fields
	public static readonly IMessagePackFormatter<Decimal> Instance; // 0x0

	// Methods

	// RVA: 0x165A660 Offset: 0x165A761 VA: 0x165A660
	private void .ctor() { }

	// RVA: 0x165A670 Offset: 0x165A771 VA: 0x165A670 Slot: 4
	public void Serialize(ref MessagePackWriter writer, Decimal value, MessagePackSerializerOptions options) { }

	// RVA: 0x165A770 Offset: 0x165A871 VA: 0x165A770 Slot: 5
	public Decimal Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x165A930 Offset: 0x165AA31 VA: 0x165A930
	private static void .cctor() { }
}

