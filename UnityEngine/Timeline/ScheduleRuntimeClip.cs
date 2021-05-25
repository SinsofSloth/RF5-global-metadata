internal class ScheduleRuntimeClip : RuntimeClipBase // TypeDefIndex: 4585
{
	// Fields
	private TimelineClip m_Clip; // 0x18
	private Playable m_Playable; // 0x20
	private Playable m_ParentMixer; // 0x30
	private double m_StartDelay; // 0x40
	private double m_FinishTail; // 0x48
	private bool m_Started; // 0x50

	// Properties
	public override double start { get; }
	public override double duration { get; }
	public TimelineClip clip { get; }
	public Playable mixer { get; }
	public Playable playable { get; }
	public override bool enable { set; }

	// Methods

	// RVA: 0x17E5040 Offset: 0x17E5141 VA: 0x17E5040 Slot: 11
	public override double get_start() { }

	// RVA: 0x17E50D0 Offset: 0x17E51D1 VA: 0x17E50D0 Slot: 12
	public override double get_duration() { }

	// RVA: 0x17E5120 Offset: 0x17E5221 VA: 0x17E5120
	public void SetTime(double time) { }

	// RVA: 0x17E5180 Offset: 0x17E5281 VA: 0x17E5180
	public TimelineClip get_clip() { }

	// RVA: 0x17E5190 Offset: 0x17E5291 VA: 0x17E5190
	public Playable get_mixer() { }

	// RVA: 0x17E51A0 Offset: 0x17E52A1 VA: 0x17E51A0
	public Playable get_playable() { }

	// RVA: 0x17D9FF0 Offset: 0x17DA0F1 VA: 0x17D9FF0
	public void .ctor(TimelineClip clip, Playable clipPlayable, Playable parentMixer, double startDelay = 0.2, double finishTail = 0.1) { }

	// RVA: 0x17E51B0 Offset: 0x17E52B1 VA: 0x17E51B0
	private void Create(TimelineClip clip, Playable clipPlayable, Playable parentMixer, double startDelay, double finishTail) { }

	// RVA: 0x17E5260 Offset: 0x17E5361 VA: 0x17E5260 Slot: 8
	public override void set_enable(bool value) { }

	// RVA: 0x17E5350 Offset: 0x17E5451 VA: 0x17E5350 Slot: 9
	public override void EvaluateAt(double localTime, FrameData frameData) { }
}

