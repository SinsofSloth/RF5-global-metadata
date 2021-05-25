public abstract class FootSteps : MonoBehaviour // TypeDefIndex: 6334
{
	// Fields
	protected const float kBackstepDistance = 0.05;
	[SerializeField] // RVA: 0x15C310 Offset: 0x15C411 VA: 0x15C310
	private float m_RaycastHeight; // 0x18
	[SerializeField] // RVA: 0x15C320 Offset: 0x15C421 VA: 0x15C320
	private float m_RaycastDistance; // 0x1C
	[SerializeField] // RVA: 0x15C330 Offset: 0x15C431 VA: 0x15C330
	protected float m_SoundPitchValue; // 0x20
	[SerializeField] // RVA: 0x15C340 Offset: 0x15C441 VA: 0x15C340
	protected float m_FootEffectScaleValue; // 0x24
	[SerializeField] // RVA: 0x15C350 Offset: 0x15C451 VA: 0x15C350
	protected float m_LandingEffectScaleValue; // 0x28
	[SerializeField] // RVA: 0x15C360 Offset: 0x15C461 VA: 0x15C360
	public FootSteps.OnFootStepEvent m_StepEvent; // 0x30
	[SerializeField] // RVA: 0x15C370 Offset: 0x15C471 VA: 0x15C370
	public FootSteps.OnFootStepEvent m_LandingEvent; // 0x38
	protected List<Transform> m_TransformList; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x15C380 Offset: 0x15C481 VA: 0x15C380
	private AudioSource <AudioSource>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x15C390 Offset: 0x15C491 VA: 0x15C390
	private FootStepDataTable <FootStepDataTable>k__BackingField; // 0x50

	// Properties
	public AudioSource AudioSource { get; set; }
	protected abstract FootStepType FootStepType { get; }
	public float RaycastHeight { get; set; }
	public float RaycastDistance { get; }
	public float SoundPitch { get; set; }
	public virtual float FootEffectScale { get; }
	public float FootWaterEffectScale { get; }
	public virtual float LandingEffectScale { get; }
	public float LandingWaterEffectScale { get; }
	public FootStepDataTable FootStepDataTable { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19AC60 Offset: 0x19AD61 VA: 0x19AC60
	// RVA: 0x1D553F0 Offset: 0x1D554F1 VA: 0x1D553F0
	public AudioSource get_AudioSource() { }

	[CompilerGeneratedAttribute] // RVA: 0x19AC70 Offset: 0x19AD71 VA: 0x19AC70
	// RVA: 0x1D55400 Offset: 0x1D55501 VA: 0x1D55400
	private void set_AudioSource(AudioSource value) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract FootStepType get_FootStepType() { }

	// RVA: 0x1D55410 Offset: 0x1D55511 VA: 0x1D55410
	public float get_RaycastHeight() { }

	// RVA: 0x1D55420 Offset: 0x1D55521 VA: 0x1D55420
	protected void set_RaycastHeight(float value) { }

	// RVA: 0x1D55430 Offset: 0x1D55531 VA: 0x1D55430
	public float get_RaycastDistance() { }

	// RVA: 0x1D55440 Offset: 0x1D55541 VA: 0x1D55440
	public float get_SoundPitch() { }

	// RVA: 0x1D55450 Offset: 0x1D55551 VA: 0x1D55450
	protected void set_SoundPitch(float value) { }

	// RVA: 0x1D55460 Offset: 0x1D55561 VA: 0x1D55460 Slot: 5
	public virtual float get_FootEffectScale() { }

	// RVA: 0x1D55470 Offset: 0x1D55571 VA: 0x1D55470
	public float get_FootWaterEffectScale() { }

	// RVA: 0x1D55480 Offset: 0x1D55581 VA: 0x1D55480 Slot: 6
	public virtual float get_LandingEffectScale() { }

	// RVA: 0x1D55490 Offset: 0x1D55591 VA: 0x1D55490
	public float get_LandingWaterEffectScale() { }

	[CompilerGeneratedAttribute] // RVA: 0x19AC80 Offset: 0x19AD81 VA: 0x19AC80
	// RVA: 0x1D554A0 Offset: 0x1D555A1 VA: 0x1D554A0
	public FootStepDataTable get_FootStepDataTable() { }

	[CompilerGeneratedAttribute] // RVA: 0x19AC90 Offset: 0x19AD91 VA: 0x19AC90
	// RVA: 0x1D554B0 Offset: 0x1D555B1 VA: 0x1D554B0
	protected void set_FootStepDataTable(FootStepDataTable value) { }

	// RVA: 0x1D554C0 Offset: 0x1D555C1 VA: 0x1D554C0 Slot: 7
	protected virtual void Awake() { }

	// RVA: 0x1D55540 Offset: 0x1D55641 VA: 0x1D55540
	protected void InitAudioSource() { }

	// RVA: 0x1D55630 Offset: 0x1D55731 VA: 0x1D55630
	public float GetSoundDistanceMax() { }

	// RVA: 0x1D556E0 Offset: 0x1D557E1 VA: 0x1D556E0
	public float GetSoundDistanceMin() { }

	// RVA: 0x1D55790 Offset: 0x1D55891 VA: 0x1D55790
	public float GetEffectDistance() { }

	// RVA: 0x1D55840 Offset: 0x1D55941 VA: 0x1D55840
	public float GetDistanceMax() { }

	// RVA: 0x1D558D0 Offset: 0x1D559D1 VA: 0x1D558D0
	public Vector3 GetPosition(int index = -1) { }

	// RVA: 0x1D559E0 Offset: 0x1D55AE1 VA: 0x1D559E0 Slot: 8
	protected virtual Vector3 GetRootPosition() { }

	// RVA: 0x1D55A10 Offset: 0x1D55B11 VA: 0x1D55A10 Slot: 9
	public virtual SoundID GetStepSoundID(GroundType groundType) { }

	// RVA: 0x1D55B20 Offset: 0x1D55C21 VA: 0x1D55B20 Slot: 10
	public virtual SoundID GetLandingSoundID(GroundType groundType) { }

	// RVA: 0x1D55BD0 Offset: 0x1D55CD1 VA: 0x1D55BD0
	public EffectID GetStepEffectID(GroundType groundType) { }

	// RVA: 0x1D55C80 Offset: 0x1D55D81 VA: 0x1D55C80
	public EffectID GetLandingEffectID(GroundType groundType) { }

	// RVA: 0x1D55D30 Offset: 0x1D55E31 VA: 0x1D55D30 Slot: 11
	public virtual void OnFootSteps(GroundType groundType, Collider hitCollider) { }

	// RVA: 0x1D55DB0 Offset: 0x1D55EB1 VA: 0x1D55DB0 Slot: 12
	public virtual void OnLanding(GroundType groundType, Collider hitCollider) { }

	// RVA: 0x1D55E30 Offset: 0x1D55F31 VA: 0x1D55E30
	protected void .ctor() { }
}

