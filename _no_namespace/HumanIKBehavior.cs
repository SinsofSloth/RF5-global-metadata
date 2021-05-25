public class HumanIKBehavior : PlayableBehaviour // TypeDefIndex: 8356
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x16F110 Offset: 0x16F211 VA: 0x16F110
	private GameObject <BindTarget>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x16F120 Offset: 0x16F221 VA: 0x16F120
	private HumanModel <HumanModel>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x16F130 Offset: 0x16F231 VA: 0x16F130
	private bool <StartIK>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x16F140 Offset: 0x16F241 VA: 0x16F140
	private bool <EndIK>k__BackingField; // 0x21

	// Properties
	public GameObject BindTarget { get; set; }
	public HumanModel HumanModel { get; set; }
	public bool StartIK { get; set; }
	public bool EndIK { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A7180 Offset: 0x1A7281 VA: 0x1A7180
	// RVA: 0x1E96D50 Offset: 0x1E96E51 VA: 0x1E96D50
	public GameObject get_BindTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7190 Offset: 0x1A7291 VA: 0x1A7190
	// RVA: 0x1E96D60 Offset: 0x1E96E61 VA: 0x1E96D60
	public void set_BindTarget(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A71A0 Offset: 0x1A72A1 VA: 0x1A71A0
	// RVA: 0x1E96D70 Offset: 0x1E96E71 VA: 0x1E96D70
	public HumanModel get_HumanModel() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A71B0 Offset: 0x1A72B1 VA: 0x1A71B0
	// RVA: 0x1E96D80 Offset: 0x1E96E81 VA: 0x1E96D80
	public void set_HumanModel(HumanModel value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A71C0 Offset: 0x1A72C1 VA: 0x1A71C0
	// RVA: 0x1E96D90 Offset: 0x1E96E91 VA: 0x1E96D90
	public bool get_StartIK() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A71D0 Offset: 0x1A72D1 VA: 0x1A71D0
	// RVA: 0x1E96DA0 Offset: 0x1E96EA1 VA: 0x1E96DA0
	public void set_StartIK(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A71E0 Offset: 0x1A72E1 VA: 0x1A71E0
	// RVA: 0x1E96DB0 Offset: 0x1E96EB1 VA: 0x1E96DB0
	public bool get_EndIK() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A71F0 Offset: 0x1A72F1 VA: 0x1A71F0
	// RVA: 0x1E96DC0 Offset: 0x1E96EC1 VA: 0x1E96DC0
	public void set_EndIK(bool value) { }

	// RVA: 0x1E96DD0 Offset: 0x1E96ED1 VA: 0x1E96DD0 Slot: 13
	public override void OnGraphStart(Playable playable) { }

	// RVA: 0x1E96ED0 Offset: 0x1E96FD1 VA: 0x1E96ED0 Slot: 17
	public override void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: 0x1E96FB0 Offset: 0x1E970B1 VA: 0x1E96FB0 Slot: 18
	public override void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0x1E97090 Offset: 0x1E97191 VA: 0x1E97090
	public void .ctor() { }
}

