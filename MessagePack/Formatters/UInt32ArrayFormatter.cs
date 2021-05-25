public sealed class UInt32ArrayFormatter : IMessagePackFormatter<uint[]>, IMessagePackFormatter // TypeDefIndex: 5477
{
	// Fields
	public static readonly UInt32ArrayFormatter Instance; // 0x0

	// Methods

	// RVA: 0x1662730 Offset: 0x1662831 VA: 0x1662730
	private void .ctor() { }

	// RVA: 0x1662740 Offset: 0x1662841 VA: 0x1662740 Slot: 4
	public void Serialize(ref MessagePackWriter writer, uint[] value, MessagePackSerializerOptions options) { }

	// RVA: 0x16627E0 Offset: 0x16628E1 VA: 0x16627E0 Slot: 5
	public uint[] Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x16629A0 Offset: 0x1662AA1 VA: 0x16629A0
	private static void .cctor() { }
}

