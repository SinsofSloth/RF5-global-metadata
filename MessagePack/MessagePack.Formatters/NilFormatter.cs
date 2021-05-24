public class NilFormatter : IMessagePackFormatter<Nil>, IMessagePackFormatter // TypeDefIndex: 5416
{
	// Fields
	public static readonly IMessagePackFormatter<Nil> Instance; // 0x0

	// Methods

	// RVA: 0x165ACE0 Offset: 0x165ADE1 VA: 0x165ACE0
	private void .ctor() { }

	// RVA: 0x165ACF0 Offset: 0x165ADF1 VA: 0x165ACF0 Slot: 4
	public void Serialize(ref MessagePackWriter writer, Nil value, MessagePackSerializerOptions options) { }

	// RVA: 0x165AD00 Offset: 0x165AE01 VA: 0x165AD00 Slot: 5
	public Nil Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x165AD20 Offset: 0x165AE21 VA: 0x165AD20
	private static void .cctor() { }
}

