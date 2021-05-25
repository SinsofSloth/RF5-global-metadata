public class PlayableMixer : MonoBehaviour // TypeDefIndex: 6344
{
	// Fields
	private PlayableGraph m_Graph; // 0x18
	private AnimationMixerPlayable m_Mixer; // 0x28
	private AnimationPlayableOutput m_Output; // 0x38
	private Playable[] m_Playable; // 0x48
	private bool m_IsTransition; // 0x50
	private float m_FadeTime; // 0x54
	private PlayableMixer.STATE m_State; // 0x58
	private double m_Elapsed; // 0x60
	private double m_OutputFadeTime; // 0x68
	private float m_OutputWeightTarget; // 0x70
	private float m_OutputWeightCurrent; // 0x74
	private float m_WeightRate; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x15C3D0 Offset: 0x15C4D1 VA: 0x15C3D0
	private bool <IsAutoStop>k__BackingField; // 0x7C

	// Properties
	public bool IsAutoStop { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19ACA0 Offset: 0x19ADA1 VA: 0x19ACA0
	// RVA: 0x1FE8020 Offset: 0x1FE8121 VA: 0x1FE8020
	public bool get_IsAutoStop() { }

	[CompilerGeneratedAttribute] // RVA: 0x19ACB0 Offset: 0x19ADB1 VA: 0x19ACB0
	// RVA: 0x1FE8030 Offset: 0x1FE8131 VA: 0x1FE8030
	public void set_IsAutoStop(bool value) { }

	// RVA: 0x1FE8040 Offset: 0x1FE8141 VA: 0x1FE8040
	private void Awake() { }

	// RVA: 0x1FE8170 Offset: 0x1FE8271 VA: 0x1FE8170
	private void OnDestroy() { }

	// RVA: 0x1FE8180 Offset: 0x1FE8281 VA: 0x1FE8180
	private void Update() { }

	// RVA: 0x1FE8800 Offset: 0x1FE8901 VA: 0x1FE8800
	public void Play(AnimationClip clip, float fadeTime, float time = 0, float speed = 1) { }

	// RVA: 0x1FE8670 Offset: 0x1FE8771 VA: 0x1FE8670
	public void Stop(double fadeTime) { }

	// RVA: 0x1FE87E0 Offset: 0x1FE88E1 VA: 0x1FE87E0
	public bool IsPlaying() { }

	// RVA: 0x1FE8BB0 Offset: 0x1FE8CB1 VA: 0x1FE8BB0
	public double GetTime() { }

	// RVA: 0x1FE8C30 Offset: 0x1FE8D31 VA: 0x1FE8C30
	public double GetDuration() { }

	// RVA: 0x1FE84D0 Offset: 0x1FE85D1 VA: 0x1FE84D0
	public bool IsFinishedPlay() { }

	// RVA: 0x1FE86D0 Offset: 0x1FE87D1 VA: 0x1FE86D0
	private void Cleanup() { }

	// RVA: 0x1FE8C80 Offset: 0x1FE8D81 VA: 0x1FE8C80
	public void SetWeight(float weight) { }

	// RVA: 0x1FE8C90 Offset: 0x1FE8D91 VA: 0x1FE8C90
	public void .ctor() { }
}

