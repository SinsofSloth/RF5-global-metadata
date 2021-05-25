[Serializable]
public class ConstraintBehavior : PlayableBehaviour // TypeDefIndex: 8322
{
	// Fields
	public ConstraintPresetID PresetID; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x16EDA0 Offset: 0x16EEA1 VA: 0x16EDA0
	private GameObject <BindTarget>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x16EDB0 Offset: 0x16EEB1 VA: 0x16EDB0
	private HumanModel <HumanModel>k__BackingField; // 0x20

	// Properties
	public GameObject BindTarget { get; set; }
	public HumanModel HumanModel { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A6DB0 Offset: 0x1A6EB1 VA: 0x1A6DB0
	// RVA: 0x1FCA6D0 Offset: 0x1FCA7D1 VA: 0x1FCA6D0
	public GameObject get_BindTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6DC0 Offset: 0x1A6EC1 VA: 0x1A6DC0
	// RVA: 0x1FCA6E0 Offset: 0x1FCA7E1 VA: 0x1FCA6E0
	public void set_BindTarget(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6DD0 Offset: 0x1A6ED1 VA: 0x1A6DD0
	// RVA: 0x1FCA6F0 Offset: 0x1FCA7F1 VA: 0x1FCA6F0
	public HumanModel get_HumanModel() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6DE0 Offset: 0x1A6EE1 VA: 0x1A6DE0
	// RVA: 0x1FCA700 Offset: 0x1FCA801 VA: 0x1FCA700
	public void set_HumanModel(HumanModel value) { }

	// RVA: 0x1FCA710 Offset: 0x1FCA811 VA: 0x1FCA710 Slot: 13
	public override void OnGraphStart(Playable playable) { }

	// RVA: 0x1FCA810 Offset: 0x1FCA911 VA: 0x1FCA810 Slot: 17
	public override void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: 0x1FCA8B0 Offset: 0x1FCA9B1 VA: 0x1FCA8B0 Slot: 18
	public override void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0x1FCA8C0 Offset: 0x1FCA9C1 VA: 0x1FCA8C0
	public void .ctor() { }
}

