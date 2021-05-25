public sealed class NonGenericInterfaceCollectionFormatter : IMessagePackFormatter<ICollection>, IMessagePackFormatter // TypeDefIndex: 5375
{
	// Fields
	public static readonly IMessagePackFormatter<ICollection> Instance; // 0x0

	// Methods

	// RVA: 0x165AD90 Offset: 0x165AE91 VA: 0x165AD90
	private void .ctor() { }

	// RVA: 0x165ADA0 Offset: 0x165AEA1 VA: 0x165ADA0 Slot: 4
	public void Serialize(ref MessagePackWriter writer, ICollection value, MessagePackSerializerOptions options) { }

	// RVA: 0x165B2A0 Offset: 0x165B3A1 VA: 0x165B2A0 Slot: 5
	public ICollection Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x165B610 Offset: 0x165B711 VA: 0x165B610
	private static void .cctor() { }
}

