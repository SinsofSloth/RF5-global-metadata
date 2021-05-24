internal class RuntimeClip : RuntimeClipBase // TypeDefIndex: 4582
{
	// Fields
	private TimelineClip m_Clip; // 0x18
	private Playable m_Playable; // 0x20
	private Playable m_ParentMixer; // 0x30

	// Properties
	public override double start { get; }
	public override double duration { get; }
	public TimelineClip clip { get; }
	public Playable mixer { get; }
	public Playable playable { get; }
	public override bool enable { set; }

	// Methods

	// RVA: 0x17E4910 Offset: 0x17E4A11 VA: 0x17E4910 Slot: 11
	public override double get_start() { }

	// RVA: 0x17E4930 Offset: 0x17E4A31 VA: 0x17E4930 Slot: 12
	public override double get_duration() { }

	// RVA: 0x17D5E40 Offset: 0x17D5F41 VA: 0x17D5E40
	public void .ctor(TimelineClip clip, Playable clipPlayable, Playable parentMixer) { }

	// RVA: 0x17E4960 Offset: 0x17E4A61 VA: 0x17E4960
	private void Create(TimelineClip clip, Playable clipPlayable, Playable parentMixer) { }

	// RVA: 0x17E4A00 Offset: 0x17E4B01 VA: 0x17E4A00
	public TimelineClip get_clip() { }

	// RVA: 0x17E4A10 Offset: 0x17E4B11 VA: 0x17E4A10
	public Playable get_mixer() { }

	// RVA: 0x17E4A20 Offset: 0x17E4B21 VA: 0x17E4A20
	public Playable get_playable() { }

	// RVA: 0x17E4A30 Offset: 0x17E4B31 VA: 0x17E4A30 Slot: 8
	public override void set_enable(bool value) { }

	// RVA: 0x17E4B80 Offset: 0x17E4C81 VA: 0x17E4B80
	public void SetTime(double time) { }

	// RVA: 0x17E4BE0 Offset: 0x17E4CE1 VA: 0x17E4BE0
	public void SetDuration(double duration) { }

	// RVA: 0x17E4C40 Offset: 0x17E4D41 VA: 0x17E4C40 Slot: 9
	public override void EvaluateAt(double localTime, FrameData frameData) { }

	// RVA: 0x17E4E70 Offset: 0x17E4F71 VA: 0x17E4E70 Slot: 10
	public override void Reset() { }
}

