public sealed class NpcDateSaveParameterFormatter : IMessagePackFormatter<NpcDateSaveParameter>, IMessagePackFormatter // TypeDefIndex: 10162
{
	// Methods

	// RVA: 0x2347670 Offset: 0x2347771 VA: 0x2347670
	private static ReadOnlySpan<byte> GetSpan_ProgressType() { }

	// RVA: 0x23476E0 Offset: 0x23477E1 VA: 0x23476E0
	private static ReadOnlySpan<byte> GetSpan_dateType() { }

	// RVA: 0x2347750 Offset: 0x2347851 VA: 0x2347750
	private static ReadOnlySpan<byte> GetSpan_dateSpotID() { }

	// RVA: 0x23477C0 Offset: 0x23478C1 VA: 0x23477C0
	private static ReadOnlySpan<byte> GetSpan_NpcId() { }

	// RVA: 0x2347830 Offset: 0x2347931 VA: 0x2347830
	private static ReadOnlySpan<byte> GetSpan_dateStartTime() { }

	// RVA: 0x23478A0 Offset: 0x23479A1 VA: 0x23478A0
	private static ReadOnlySpan<byte> GetSpan_meetingLimitTime() { }

	// RVA: 0x2347910 Offset: 0x2347A11 VA: 0x2347910
	private static ReadOnlySpan<byte> GetSpan_meetingEventPointOnFlag() { }

	// RVA: 0x2347980 Offset: 0x2347A81 VA: 0x2347980
	private static ReadOnlySpan<byte> GetSpan_doSuppo() { }

	// RVA: 0x23479F0 Offset: 0x2347AF1 VA: 0x23479F0 Slot: 4
	public void Serialize(ref MessagePackWriter writer, NpcDateSaveParameter value, MessagePackSerializerOptions options) { }

	// RVA: 0x2348050 Offset: 0x2348151 VA: 0x2348050 Slot: 5
	public NpcDateSaveParameter Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x2348E50 Offset: 0x2348F51 VA: 0x2348E50
	public void .ctor() { }
}

