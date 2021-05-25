public sealed class Int32ArrayFormatter : IMessagePackFormatter<int[]>, IMessagePackFormatter // TypeDefIndex: 5468
{
	// Fields
	public static readonly Int32ArrayFormatter Instance; // 0x0

	// Methods

	// RVA: 0x1659B00 Offset: 0x1659C01 VA: 0x1659B00
	private void .ctor() { }

	// RVA: 0x1659B10 Offset: 0x1659C11 VA: 0x1659B10 Slot: 4
	public void Serialize(ref MessagePackWriter writer, int[] value, MessagePackSerializerOptions options) { }

	// RVA: 0x1659BB0 Offset: 0x1659CB1 VA: 0x1659BB0 Slot: 5
	public int[] Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x1659D70 Offset: 0x1659E71 VA: 0x1659D70
	private static void .cctor() { }
}

