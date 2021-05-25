[Serializable]
public class GrounderIKBehavior : PlayableBehaviour // TypeDefIndex: 8348
{
	// Fields
	[RangeAttribute] // RVA: 0x16F040 Offset: 0x16F141 VA: 0x16F040
	public float Weight; // 0x10
	public bool ResetPosition; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x16F060 Offset: 0x16F161 VA: 0x16F060
	private GameObject <BindTarget>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x16F070 Offset: 0x16F171 VA: 0x16F070
	private HumanModel <HumanModel>k__BackingField; // 0x20

	// Properties
	public GameObject BindTarget { get; set; }
	public HumanModel HumanModel { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A7080 Offset: 0x1A7181 VA: 0x1A7080
	// RVA: 0x1EB59E0 Offset: 0x1EB5AE1 VA: 0x1EB59E0
	public GameObject get_BindTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7090 Offset: 0x1A7191 VA: 0x1A7090
	// RVA: 0x1EB59F0 Offset: 0x1EB5AF1 VA: 0x1EB59F0
	public void set_BindTarget(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A70A0 Offset: 0x1A71A1 VA: 0x1A70A0
	// RVA: 0x1EB5A00 Offset: 0x1EB5B01 VA: 0x1EB5A00
	public HumanModel get_HumanModel() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A70B0 Offset: 0x1A71B1 VA: 0x1A70B0
	// RVA: 0x1EB5A10 Offset: 0x1EB5B11 VA: 0x1EB5A10
	public void set_HumanModel(HumanModel value) { }

	// RVA: 0x1EB5A20 Offset: 0x1EB5B21 VA: 0x1EB5A20 Slot: 13
	public override void OnGraphStart(Playable playable) { }

	// RVA: 0x1EB5B20 Offset: 0x1EB5C21 VA: 0x1EB5B20 Slot: 17
	public override void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: 0x1EB5BE0 Offset: 0x1EB5CE1 VA: 0x1EB5BE0 Slot: 20
	public override void ProcessFrame(Playable playable, FrameData info, object playerData) { }

	// RVA: 0x1EB5D00 Offset: 0x1EB5E01 VA: 0x1EB5D00 Slot: 18
	public override void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0x1EB5D10 Offset: 0x1EB5E11 VA: 0x1EB5D10
	public void .ctor() { }
}

