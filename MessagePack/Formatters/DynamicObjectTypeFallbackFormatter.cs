public sealed class DynamicObjectTypeFallbackFormatter : IMessagePackFormatter<object>, IMessagePackFormatter // TypeDefIndex: 5402
{
	// Fields
	public static readonly IMessagePackFormatter<object> Instance; // 0x0
	private static readonly ThreadsafeTypeKeyHashTable<DynamicObjectTypeFallbackFormatter.SerializeMethod> SerializerDelegates; // 0x8

	// Methods

	// RVA: 0x1655E90 Offset: 0x1655F91 VA: 0x1655E90
	private void .ctor() { }

	// RVA: 0x1655EA0 Offset: 0x1655FA1 VA: 0x1655EA0 Slot: 4
	public void Serialize(ref MessagePackWriter writer, object value, MessagePackSerializerOptions options) { }

	// RVA: 0x1656F50 Offset: 0x1657051 VA: 0x1656F50 Slot: 5
	public object Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x1657040 Offset: 0x1657141 VA: 0x1657040
	private static void .cctor() { }
}

