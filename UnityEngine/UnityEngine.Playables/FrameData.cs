public struct FrameData // TypeDefIndex: 3336
{
	// Fields
	internal ulong m_FrameID; // 0x0
	internal double m_DeltaTime; // 0x8
	internal float m_Weight; // 0x10
	internal float m_EffectiveWeight; // 0x14
	internal double m_EffectiveParentDelay; // 0x18
	internal float m_EffectiveParentSpeed; // 0x20
	internal float m_EffectiveSpeed; // 0x24
	internal FrameData.Flags m_Flags; // 0x28
	internal PlayableOutput m_Output; // 0x30

	// Properties
	public ulong frameId { get; }
	public float deltaTime { get; }
	public float weight { get; }
	public float effectiveSpeed { get; }
	public FrameData.EvaluationType evaluationType { get; }
	public bool seekOccurred { get; }
	public bool timeLooped { get; }
	public bool timeHeld { get; }
	public PlayableOutput output { get; }
	public PlayState effectivePlayState { get; }

	// Methods

	// RVA: 0x37F1D0 Offset: 0x37F2D1 VA: 0x37F1D0
	private bool HasFlags(FrameData.Flags flag) { }

	// RVA: 0x37F1E0 Offset: 0x37F2E1 VA: 0x37F1E0
	public ulong get_frameId() { }

	// RVA: 0x37F1F0 Offset: 0x37F2F1 VA: 0x37F1F0
	public float get_deltaTime() { }

	// RVA: 0x37F200 Offset: 0x37F301 VA: 0x37F200
	public float get_weight() { }

	// RVA: 0x37F210 Offset: 0x37F311 VA: 0x37F210
	public float get_effectiveSpeed() { }

	// RVA: 0x37F220 Offset: 0x37F321 VA: 0x37F220
	public FrameData.EvaluationType get_evaluationType() { }

	// RVA: 0x37F230 Offset: 0x37F331 VA: 0x37F230
	public bool get_seekOccurred() { }

	// RVA: 0x37F240 Offset: 0x37F341 VA: 0x37F240
	public bool get_timeLooped() { }

	// RVA: 0x37F250 Offset: 0x37F351 VA: 0x37F250
	public bool get_timeHeld() { }

	// RVA: 0x37F260 Offset: 0x37F361 VA: 0x37F260
	public PlayableOutput get_output() { }

	// RVA: 0x37F270 Offset: 0x37F371 VA: 0x37F270
	public PlayState get_effectivePlayState() { }
}

