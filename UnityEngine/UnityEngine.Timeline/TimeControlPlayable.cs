public class TimeControlPlayable : PlayableBehaviour // TypeDefIndex: 4609
{
	// Fields
	private ITimeControl m_timeControl; // 0x10
	private bool m_started; // 0x18

	// Methods

	// RVA: 0x17DD210 Offset: 0x17DD311 VA: 0x17DD210
	public static ScriptPlayable<TimeControlPlayable> Create(PlayableGraph graph, ITimeControl timeControl) { }

	// RVA: 0x17E68B0 Offset: 0x17E69B1 VA: 0x17E68B0
	public void Initialize(ITimeControl timeControl) { }

	// RVA: 0x17E68C0 Offset: 0x17E69C1 VA: 0x17E68C0 Slot: 19
	public override void PrepareFrame(Playable playable, FrameData info) { }

	// RVA: 0x17E69C0 Offset: 0x17E6AC1 VA: 0x17E69C0 Slot: 17
	public override void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: 0x17E6A90 Offset: 0x17E6B91 VA: 0x17E6A90 Slot: 18
	public override void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0x17E6B50 Offset: 0x17E6C51 VA: 0x17E6B50
	public void .ctor() { }
}

