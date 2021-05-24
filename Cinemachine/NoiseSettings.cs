[DocumentationSortingAttribute] // RVA: 0x12EE60 Offset: 0x12EF61 VA: 0x12EE60
[HelpURLAttribute] // RVA: 0x12EE60 Offset: 0x12EF61 VA: 0x12EE60
public sealed class NoiseSettings : SignalSourceAsset // TypeDefIndex: 4854
{
	// Fields
	[TooltipAttribute] // RVA: 0x134C70 Offset: 0x134D71 VA: 0x134C70
	[FormerlySerializedAsAttribute] // RVA: 0x134C70 Offset: 0x134D71 VA: 0x134C70
	public NoiseSettings.TransformNoiseParams[] PositionNoise; // 0x18
	[TooltipAttribute] // RVA: 0x134CD0 Offset: 0x134DD1 VA: 0x134CD0
	[FormerlySerializedAsAttribute] // RVA: 0x134CD0 Offset: 0x134DD1 VA: 0x134CD0
	public NoiseSettings.TransformNoiseParams[] OrientationNoise; // 0x20

	// Properties
	public override float SignalDuration { get; }

	// Methods

	// RVA: 0x1A1EB90 Offset: 0x1A1EC91 VA: 0x1A1EB90
	public static Vector3 GetCombinedFilterResults(NoiseSettings.TransformNoiseParams[] noiseParams, float time, Vector3 timeOffsets) { }

	// RVA: 0x1A1EDE0 Offset: 0x1A1EEE1 VA: 0x1A1EDE0 Slot: 6
	public override float get_SignalDuration() { }

	// RVA: 0x1A1EDF0 Offset: 0x1A1EEF1 VA: 0x1A1EDF0 Slot: 7
	public override void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot) { }

	// RVA: 0x1A1EF30 Offset: 0x1A1F031 VA: 0x1A1EF30
	public void .ctor() { }
}

