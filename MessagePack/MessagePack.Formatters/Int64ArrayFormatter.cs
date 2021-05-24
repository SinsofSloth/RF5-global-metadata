public sealed class Int64ArrayFormatter : IMessagePackFormatter<long[]>, IMessagePackFormatter // TypeDefIndex: 5471
{
	// Fields
	public static readonly Int64ArrayFormatter Instance; // 0x0

	// Methods

	// RVA: 0x1659E80 Offset: 0x1659F81 VA: 0x1659E80
	private void .ctor() { }

	// RVA: 0x1659E90 Offset: 0x1659F91 VA: 0x1659E90 Slot: 4
	public void Serialize(ref MessagePackWriter writer, long[] value, MessagePackSerializerOptions options) { }

	// RVA: 0x1659F30 Offset: 0x165A031 VA: 0x1659F30 Slot: 5
	public long[] Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x165A0F0 Offset: 0x165A1F1 VA: 0x165A0F0
	private static void .cctor() { }
}

