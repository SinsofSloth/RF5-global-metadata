[Serializable]
internal class AudioMixerProperties : PlayableBehaviour // TypeDefIndex: 4566
{
	// Fields
	[RangeAttribute] // RVA: 0x12B9E0 Offset: 0x12BAE1 VA: 0x12B9E0
	public float volume; // 0x10
	[RangeAttribute] // RVA: 0x12BA00 Offset: 0x12BB01 VA: 0x12BA00
	public float stereoPan; // 0x14
	[RangeAttribute] // RVA: 0x12BA20 Offset: 0x12BB21 VA: 0x12BA20
	public float spatialBlend; // 0x18

	// Methods

	// RVA: 0x17D8FC0 Offset: 0x17D90C1 VA: 0x17D8FC0 Slot: 19
	public override void PrepareFrame(Playable playable, FrameData info) { }

	// RVA: 0x17D91D0 Offset: 0x17D92D1 VA: 0x17D91D0
	public void .ctor() { }
}

