public sealed class SubEventSaveParameterFormatter : IMessagePackFormatter<SubEventSaveParameter>, IMessagePackFormatter // TypeDefIndex: 10167
{
	// Methods

	// RVA: 0x2356610 Offset: 0x2356711 VA: 0x2356610
	private static ReadOnlySpan<byte> GetSpan_Step() { }

	// RVA: 0x2356680 Offset: 0x2356781 VA: 0x2356680
	private static ReadOnlySpan<byte> GetSpan_NextStep() { }

	// RVA: 0x23566F0 Offset: 0x23567F1 VA: 0x23566F0
	private static ReadOnlySpan<byte> GetSpan_NextStepDaysLeft() { }

	// RVA: 0x2356760 Offset: 0x2356861 VA: 0x2356760
	private static ReadOnlySpan<byte> GetSpan_NextStepTime() { }

	// RVA: 0x23567D0 Offset: 0x23568D1 VA: 0x23567D0
	private static ReadOnlySpan<byte> GetSpan_NextStepConfig() { }

	// RVA: 0x2356840 Offset: 0x2356941 VA: 0x2356840
	private static ReadOnlySpan<byte> GetSpan_Completed() { }

	// RVA: 0x23568B0 Offset: 0x23569B1 VA: 0x23568B0
	private static ReadOnlySpan<byte> GetSpan_CompletedDate() { }

	// RVA: 0x2356920 Offset: 0x2356A21 VA: 0x2356920 Slot: 4
	public void Serialize(ref MessagePackWriter writer, SubEventSaveParameter value, MessagePackSerializerOptions options) { }

	// RVA: 0x2356D20 Offset: 0x2356E21 VA: 0x2356D20 Slot: 5
	public SubEventSaveParameter Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options) { }

	// RVA: 0x2357880 Offset: 0x2357981 VA: 0x2357880
	public void .ctor() { }
}

