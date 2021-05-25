public sealed class Int64Formatter : IMessagePackFormatter<long>, IMessagePackFormatter // TypeDefIndex: 5469
{
	// Fields
	public static readonly Int64Formatter Instance; // 0x0

	// Methods

	// RVA: 0x165A160 Offset: 0x165A261 VA: 0x165A160
	private void .ctor() { }

	// RVA: 0x165A170 Offset: 0x165A271 VA: 0x165A170 Slot: 4
	public void Serialize(ref MessagePackWriter writer, long value, MessagePackSerializerOptions options) { }

	// RVA: 0x165A180 Offset: 0x165A281 VA: 0x165A180 Slot: 5
	public long Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x165A190 Offset: 0x165A291 VA: 0x165A190
	private static void .cctor() { }
}

