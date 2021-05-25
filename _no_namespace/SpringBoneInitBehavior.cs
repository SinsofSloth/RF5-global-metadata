public class SpringBoneInitBehavior : PlayableBehaviour // TypeDefIndex: 8365
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x16F280 Offset: 0x16F381 VA: 0x16F280
	private GameObject <BindTarget>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x16F290 Offset: 0x16F391 VA: 0x16F290
	private HumanModel <HumanModel>k__BackingField; // 0x18
	private bool IsKeepInit; // 0x20

	// Properties
	public GameObject BindTarget { get; set; }
	public HumanModel HumanModel { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A72C0 Offset: 0x1A73C1 VA: 0x1A72C0
	// RVA: 0x22481E0 Offset: 0x22482E1 VA: 0x22481E0
	public GameObject get_BindTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A72D0 Offset: 0x1A73D1 VA: 0x1A72D0
	// RVA: 0x22481F0 Offset: 0x22482F1 VA: 0x22481F0
	public void set_BindTarget(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A72E0 Offset: 0x1A73E1 VA: 0x1A72E0
	// RVA: 0x2248200 Offset: 0x2248301 VA: 0x2248200
	public HumanModel get_HumanModel() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A72F0 Offset: 0x1A73F1 VA: 0x1A72F0
	// RVA: 0x2248210 Offset: 0x2248311 VA: 0x2248210
	public void set_HumanModel(HumanModel value) { }

	// RVA: 0x2248220 Offset: 0x2248321 VA: 0x2248220
	public void Initialize(GameObject bindTarget, bool isKeep) { }

	// RVA: 0x2248260 Offset: 0x2248361 VA: 0x2248260 Slot: 13
	public override void OnGraphStart(Playable playable) { }

	// RVA: 0x2248360 Offset: 0x2248461 VA: 0x2248360 Slot: 17
	public override void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: 0x2248400 Offset: 0x2248501 VA: 0x2248400 Slot: 20
	public override void ProcessFrame(Playable playable, FrameData info, object playerData) { }

	// RVA: 0x2248450 Offset: 0x2248551 VA: 0x2248450 Slot: 18
	public override void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0x2248460 Offset: 0x2248561 VA: 0x2248460
	public void .ctor() { }
}

