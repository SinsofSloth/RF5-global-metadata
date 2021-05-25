public sealed class StatusDataBaseFormatter : IMessagePackFormatter<StatusDataBase>, IMessagePackFormatter // TypeDefIndex: 10128
{
	// Fields
	private readonly Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>> typeToKeyAndJumpMap; // 0x10
	private readonly Dictionary<int, int> keyToJumpMap; // 0x18

	// Methods

	// RVA: 0x2355800 Offset: 0x2355901 VA: 0x2355800
	public void .ctor() { }

	// RVA: 0x2355A90 Offset: 0x2355B91 VA: 0x2355A90 Slot: 4
	public void Serialize(ref MessagePackWriter writer, StatusDataBase value, MessagePackSerializerOptions options) { }

	// RVA: 0x2355E00 Offset: 0x2355F01 VA: 0x2355E00 Slot: 5
	public StatusDataBase Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }
}

