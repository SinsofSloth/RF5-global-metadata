public sealed class ChildDataFormatter : IMessagePackFormatter<ChildData>, IMessagePackFormatter // TypeDefIndex: 10150
{
	// Methods

	// RVA: 0x242FB30 Offset: 0x242FC31 VA: 0x242FB30
	private static ReadOnlySpan<byte> GetSpan_Name() { }

	// RVA: 0x242FBA0 Offset: 0x242FCA1 VA: 0x242FBA0
	private static ReadOnlySpan<byte> GetSpan_IsMale() { }

	// RVA: 0x242FC10 Offset: 0x242FD11 VA: 0x242FC10
	private static ReadOnlySpan<byte> GetSpan_Personality() { }

	// RVA: 0x242FC80 Offset: 0x242FD81 VA: 0x242FC80
	private static ReadOnlySpan<byte> GetSpan_BirthDay() { }

	// RVA: 0x242FCF0 Offset: 0x242FDF1 VA: 0x242FCF0 Slot: 4
	public void Serialize(ref MessagePackWriter writer, ChildData value, MessagePackSerializerOptions options) { }

	// RVA: 0x2430040 Offset: 0x2430141 VA: 0x2430040 Slot: 5
	public ChildData Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x24305F0 Offset: 0x24306F1 VA: 0x24305F0
	public void .ctor() { }
}

