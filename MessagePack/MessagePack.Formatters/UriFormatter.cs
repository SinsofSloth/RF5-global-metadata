public sealed class UriFormatter : IMessagePackFormatter<Uri>, IMessagePackFormatter // TypeDefIndex: 5428
{
	// Fields
	public static readonly IMessagePackFormatter<Uri> Instance; // 0x0

	// Methods

	// RVA: 0x1662E30 Offset: 0x1662F31 VA: 0x1662E30
	private void .ctor() { }

	// RVA: 0x1662E40 Offset: 0x1662F41 VA: 0x1662E40 Slot: 4
	public void Serialize(ref MessagePackWriter writer, Uri value, MessagePackSerializerOptions options) { }

	// RVA: 0x1662F00 Offset: 0x1663001 VA: 0x1662F00 Slot: 5
	public Uri Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x1662FF0 Offset: 0x16630F1 VA: 0x1662FF0
	private static void .cctor() { }
}

