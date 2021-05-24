public sealed class NonGenericInterfaceDictionaryFormatter : IMessagePackFormatter<IDictionary>, IMessagePackFormatter // TypeDefIndex: 5379
{
	// Fields
	public static readonly IMessagePackFormatter<IDictionary> Instance; // 0x0

	// Methods

	// RVA: 0x165B680 Offset: 0x165B781 VA: 0x165B680
	private void .ctor() { }

	// RVA: 0x165B690 Offset: 0x165B791 VA: 0x165B690 Slot: 4
	public void Serialize(ref MessagePackWriter writer, IDictionary value, MessagePackSerializerOptions options) { }

	// RVA: 0x165BB50 Offset: 0x165BC51 VA: 0x165BB50 Slot: 5
	public IDictionary Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x165BEB0 Offset: 0x165BFB1 VA: 0x165BEB0
	private static void .cctor() { }
}

