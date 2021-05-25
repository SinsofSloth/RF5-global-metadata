public sealed class NonGenericInterfaceEnumerableFormatter : IMessagePackFormatter<IEnumerable>, IMessagePackFormatter // TypeDefIndex: 5376
{
	// Fields
	public static readonly IMessagePackFormatter<IEnumerable> Instance; // 0x0

	// Methods

	// RVA: 0x165BF20 Offset: 0x165C021 VA: 0x165BF20
	private void .ctor() { }

	// RVA: 0x165BF30 Offset: 0x165C031 VA: 0x165BF30 Slot: 4
	public void Serialize(ref MessagePackWriter writer, IEnumerable value, MessagePackSerializerOptions options) { }

	// RVA: 0x165C4E0 Offset: 0x165C5E1 VA: 0x165C4E0 Slot: 5
	public IEnumerable Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x165C850 Offset: 0x165C951 VA: 0x165C850
	private static void .cctor() { }
}

