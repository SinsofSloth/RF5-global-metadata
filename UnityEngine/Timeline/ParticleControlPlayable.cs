public class ParticleControlPlayable : PlayableBehaviour // TypeDefIndex: 4607
{
	// Fields
	private const float kUnsetTime = 3.4028235E+38;
	private float m_LastPlayableTime; // 0x10
	private float m_LastParticleTime; // 0x14
	private uint m_RandomSeed; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x12BCA0 Offset: 0x12BDA1 VA: 0x12BCA0
	private ParticleSystem <particleSystem>k__BackingField; // 0x20

	// Properties
	public ParticleSystem particleSystem { get; set; }

	// Methods

	// RVA: 0x17DCF40 Offset: 0x17DD041 VA: 0x17DCF40
	public static ScriptPlayable<ParticleControlPlayable> Create(PlayableGraph graph, ParticleSystem component, uint randomSeed) { }

	[CompilerGeneratedAttribute] // RVA: 0x12C3B0 Offset: 0x12C4B1 VA: 0x12C3B0
	// RVA: 0x17E3B70 Offset: 0x17E3C71 VA: 0x17E3B70
	public ParticleSystem get_particleSystem() { }

	[CompilerGeneratedAttribute] // RVA: 0x12C3C0 Offset: 0x12C4C1 VA: 0x12C3C0
	// RVA: 0x17E3B80 Offset: 0x17E3C81 VA: 0x17E3B80
	private void set_particleSystem(ParticleSystem value) { }

	// RVA: 0x17E3AD0 Offset: 0x17E3BD1 VA: 0x17E3AD0
	public void Initialize(ParticleSystem ps, uint randomSeed) { }

	// RVA: 0x17E3B90 Offset: 0x17E3C91 VA: 0x17E3B90
	private static void SetRandomSeed(ParticleSystem particleSystem, uint randomSeed) { }

	// RVA: 0x17E3CE0 Offset: 0x17E3DE1 VA: 0x17E3CE0 Slot: 19
	public override void PrepareFrame(Playable playable, FrameData data) { }

	// RVA: 0x17E3FA0 Offset: 0x17E40A1 VA: 0x17E3FA0 Slot: 17
	public override void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: 0x17E3FB0 Offset: 0x17E40B1 VA: 0x17E3FB0 Slot: 18
	public override void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0x17E3ED0 Offset: 0x17E3FD1 VA: 0x17E3ED0
	private void Simulate(float time, bool restart) { }

	// RVA: 0x17E3FC0 Offset: 0x17E40C1 VA: 0x17E3FC0
	public void .ctor() { }
}

