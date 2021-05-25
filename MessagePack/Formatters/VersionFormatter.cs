public sealed class VersionFormatter : IMessagePackFormatter<Version>, IMessagePackFormatter // TypeDefIndex: 5429
{
	// Fields
	public static readonly IMessagePackFormatter<Version> Instance; // 0x0

	// Methods

	// RVA: 0x1663060 Offset: 0x1663161 VA: 0x1663060
	private void .ctor() { }

	// RVA: 0x1663070 Offset: 0x1663171 VA: 0x1663070 Slot: 4
	public void Serialize(ref MessagePackWriter writer, Version value, MessagePackSerializerOptions options) { }

	// RVA: 0x1663130 Offset: 0x1663231 VA: 0x1663130 Slot: 5
	public Version Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x1663210 Offset: 0x1663311 VA: 0x1663210
	private static void .cctor() { }
}

