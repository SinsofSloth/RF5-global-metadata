public sealed class SubEventStepFormatter : IMessagePackFormatter<SubEventStep>, IMessagePackFormatter // TypeDefIndex: 10168
{
	// Methods

	// RVA: 0x2357890 Offset: 0x2357991 VA: 0x2357890
	private static ReadOnlySpan<byte> GetSpan_TargetEventStep() { }

	// RVA: 0x2357900 Offset: 0x2357A01 VA: 0x2357900
	private static ReadOnlySpan<byte> GetSpan_KeepEventStep() { }

	// RVA: 0x2357970 Offset: 0x2357A71 VA: 0x2357970
	private static ReadOnlySpan<byte> GetSpan_MainEventSteps() { }

	// RVA: 0x23579E0 Offset: 0x2357AE1 VA: 0x23579E0 Slot: 4
	public void Serialize(ref MessagePackWriter writer, SubEventStep value, MessagePackSerializerOptions options) { }

	// RVA: 0x2357CB0 Offset: 0x2357DB1 VA: 0x2357CB0 Slot: 5
	public SubEventStep Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x2358460 Offset: 0x2358561 VA: 0x2358460
	public void .ctor() { }
}

