public sealed class NpcPatrolRouteFormatter : IMessagePackFormatter<NpcPatrolRoute>, IMessagePackFormatter // TypeDefIndex: 10163
{
	// Methods

	// RVA: 0x2348E60 Offset: 0x2348F61 VA: 0x2348E60
	private static ReadOnlySpan<byte> GetSpan_TargetSeatName() { }

	// RVA: 0x2348ED0 Offset: 0x2348FD1 VA: 0x2348ED0
	private static ReadOnlySpan<byte> GetSpan_TargetPoint() { }

	// RVA: 0x2348F40 Offset: 0x2349041 VA: 0x2348F40
	private static ReadOnlySpan<byte> GetSpan_Rate() { }

	// RVA: 0x2348FB0 Offset: 0x23490B1 VA: 0x2348FB0
	private static ReadOnlySpan<byte> GetSpan_RotatePatternNumber() { }

	// RVA: 0x2349020 Offset: 0x2349121 VA: 0x2349020 Slot: 4
	public void Serialize(ref MessagePackWriter writer, NpcPatrolRoute value, MessagePackSerializerOptions options) { }

	// RVA: 0x2349400 Offset: 0x2349501 VA: 0x2349400 Slot: 5
	public NpcPatrolRoute Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x2349CF0 Offset: 0x2349DF1 VA: 0x2349CF0
	public void .ctor() { }
}

