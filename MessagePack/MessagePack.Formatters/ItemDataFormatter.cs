public sealed class ItemDataFormatter : IMessagePackFormatter<ItemData>, IMessagePackFormatter // TypeDefIndex: 10127
{
	// Fields
	private readonly Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>> typeToKeyAndJumpMap; // 0x10
	private readonly Dictionary<int, int> keyToJumpMap; // 0x18

	// Methods

	// RVA: 0x2345270 Offset: 0x2345371 VA: 0x2345270
	public void .ctor() { }

	// RVA: 0x23456B0 Offset: 0x23457B1 VA: 0x23456B0 Slot: 4
	public void Serialize(ref MessagePackWriter writer, ItemData value, MessagePackSerializerOptions options) { }

	// RVA: 0x2345D10 Offset: 0x2345E11 VA: 0x2345D10 Slot: 5
	public ItemData Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }
}

