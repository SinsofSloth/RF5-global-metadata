[Serializable]
public class HandCuffsEffect // TypeDefIndex: 6775
{
	// Fields
	[SerializeField] // RVA: 0x15F680 Offset: 0x15F781 VA: 0x15F680
	private EffectID effectID; // 0x10
	[SerializeField] // RVA: 0x15F690 Offset: 0x15F791 VA: 0x15F690
	private HumanJointIDEnum jointID; // 0x14
	[SerializeField] // RVA: 0x15F6A0 Offset: 0x15F7A1 VA: 0x15F6A0
	private AnimationCurve stopScaleCurve; // 0x18
	private HandCuffsEffect.State currentState; // 0x20
	private float elapsed; // 0x24
	private List<ParticleSystem> ParticleSystems; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x15F6B0 Offset: 0x15F7B1 VA: 0x15F6B0
	private ParticleSystem <Particle>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x15F6C0 Offset: 0x15F7C1 VA: 0x15F6C0
	private HumanModel <HumanModel>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x15F6D0 Offset: 0x15F7D1 VA: 0x15F6D0
	private float <Scale>k__BackingField; // 0x40

	// Properties
	public ParticleSystem Particle { get; set; }
	public HumanModel HumanModel { get; set; }
	public EffectID EffectID { get; }
	public HumanJointIDEnum JointID { get; }
	public bool IsActive { get; }
	public float Scale { get; set; }
	public bool IsPlaying { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19CEA0 Offset: 0x19CFA1 VA: 0x19CEA0
	// RVA: 0x22F3430 Offset: 0x22F3531 VA: 0x22F3430
	public ParticleSystem get_Particle() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CEB0 Offset: 0x19CFB1 VA: 0x19CEB0
	// RVA: 0x22F3440 Offset: 0x22F3541 VA: 0x22F3440
	private void set_Particle(ParticleSystem value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19CEC0 Offset: 0x19CFC1 VA: 0x19CEC0
	// RVA: 0x22F3450 Offset: 0x22F3551 VA: 0x22F3450
	public HumanModel get_HumanModel() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CED0 Offset: 0x19CFD1 VA: 0x19CED0
	// RVA: 0x22F3460 Offset: 0x22F3561 VA: 0x22F3460
	private void set_HumanModel(HumanModel value) { }

	// RVA: 0x22F3470 Offset: 0x22F3571 VA: 0x22F3470
	public EffectID get_EffectID() { }

	// RVA: 0x22F3480 Offset: 0x22F3581 VA: 0x22F3480
	public HumanJointIDEnum get_JointID() { }

	// RVA: 0x22F2BC0 Offset: 0x22F2CC1 VA: 0x22F2BC0
	public bool get_IsActive() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CEE0 Offset: 0x19CFE1 VA: 0x19CEE0
	// RVA: 0x22F3490 Offset: 0x22F3591 VA: 0x22F3490
	public void set_Scale(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19CEF0 Offset: 0x19CFF1 VA: 0x19CEF0
	// RVA: 0x22F34A0 Offset: 0x22F35A1 VA: 0x22F34A0
	public float get_Scale() { }

	// RVA: 0x22F34B0 Offset: 0x22F35B1 VA: 0x22F34B0
	public bool get_IsPlaying() { }

	// RVA: 0x22F34C0 Offset: 0x22F35C1 VA: 0x22F34C0
	public void .ctor(EffectID effect) { }

	// RVA: 0x22F3580 Offset: 0x22F3681 VA: 0x22F3580
	public void Copy(HandCuffsEffect effect) { }

	// RVA: 0x22F0800 Offset: 0x22F0901 VA: 0x22F0800
	public void EffectLoad(HumanModel humanModel) { }

	// RVA: 0x22F35C0 Offset: 0x22F36C1 VA: 0x22F35C0
	private void AttachEffect(HumanModel humanModel) { }

	// RVA: 0x22F0B30 Offset: 0x22F0C31 VA: 0x22F0B30
	public void OnEnable() { }

	// RVA: 0x22F1770 Offset: 0x22F1871 VA: 0x22F1770
	public void OnDisable() { }

	// RVA: 0x22F3770 Offset: 0x22F3871 VA: 0x22F3770
	public void Play() { }

	// RVA: 0x22F0FC0 Offset: 0x22F10C1 VA: 0x22F0FC0
	public void Stop() { }

	// RVA: 0x22F1340 Offset: 0x22F1441 VA: 0x22F1340
	public void Cancel(bool immediate = False) { }

	// RVA: 0x22F1D20 Offset: 0x22F1E21 VA: 0x22F1D20
	public void OnUpdate() { }

	// RVA: 0x22F3820 Offset: 0x22F3921 VA: 0x22F3820
	private bool UpdateParticleScale(AnimationCurve scaleCurve) { }
}

