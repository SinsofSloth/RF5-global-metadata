public sealed class NullableByteFormatter : IMessagePackFormatter<Nullable<byte>>, IMessagePackFormatter // TypeDefIndex: 5491
{
	// Fields
	public static readonly NullableByteFormatter Instance; // 0x0

	// Methods

	// RVA: 0x165D3C0 Offset: 0x165D4C1 VA: 0x165D3C0
	private void .ctor() { }

	// RVA: 0x165D3D0 Offset: 0x165D4D1 VA: 0x165D3D0 Slot: 4
	public void Serialize(ref MessagePackWriter writer, Nullable<byte> value, MessagePackSerializerOptions options) { }

	// RVA: 0x165D470 Offset: 0x165D571 VA: 0x165D470 Slot: 5
	public Nullable<byte> Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x165D560 Offset: 0x165D661 VA: 0x165D560
	private static void .cctor() { }
}

