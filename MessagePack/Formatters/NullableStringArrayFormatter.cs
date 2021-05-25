public sealed class NullableStringArrayFormatter : IMessagePackFormatter<string[]>, IMessagePackFormatter // TypeDefIndex: 5423
{
	// Fields
	public static readonly NullableStringArrayFormatter Instance; // 0x0

	// Methods

	// RVA: 0x165F760 Offset: 0x165F861 VA: 0x165F760
	private void .ctor() { }

	// RVA: 0x165F770 Offset: 0x165F871 VA: 0x165F770 Slot: 4
	public void Serialize(ref MessagePackWriter writer, string[] value, MessagePackSerializerOptions options) { }

	// RVA: 0x165F810 Offset: 0x165F911 VA: 0x165F810 Slot: 5
	public string[] Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x165FA10 Offset: 0x165FB11 VA: 0x165FA10
	private static void .cctor() { }
}

