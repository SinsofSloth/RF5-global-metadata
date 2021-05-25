public class HumanEquipBehavior : PlayableBehaviour // TypeDefIndex: 8352
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x16F090 Offset: 0x16F191 VA: 0x16F090
	private HumanModel <HumanModel>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x16F0A0 Offset: 0x16F1A1 VA: 0x16F0A0
	private Transform <EquipItem>k__BackingField; // 0x18
	public HumanAttachIDEnum attachIDEnum; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x16F0B0 Offset: 0x16F1B1 VA: 0x16F0B0
	private Transform <ReturnItem>k__BackingField; // 0x28
	private Transform oldItem; // 0x30

	// Properties
	public HumanModel HumanModel { get; set; }
	public Transform EquipItem { get; set; }
	public Transform ReturnItem { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A70E0 Offset: 0x1A71E1 VA: 0x1A70E0
	// RVA: 0x1E92440 Offset: 0x1E92541 VA: 0x1E92440
	public HumanModel get_HumanModel() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A70F0 Offset: 0x1A71F1 VA: 0x1A70F0
	// RVA: 0x1E92450 Offset: 0x1E92551 VA: 0x1E92450
	public void set_HumanModel(HumanModel value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7100 Offset: 0x1A7201 VA: 0x1A7100
	// RVA: 0x1E92460 Offset: 0x1E92561 VA: 0x1E92460
	public Transform get_EquipItem() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7110 Offset: 0x1A7211 VA: 0x1A7110
	// RVA: 0x1E92470 Offset: 0x1E92571 VA: 0x1E92470
	public void set_EquipItem(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7120 Offset: 0x1A7221 VA: 0x1A7120
	// RVA: 0x1E92480 Offset: 0x1E92581 VA: 0x1E92480
	public Transform get_ReturnItem() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7130 Offset: 0x1A7231 VA: 0x1A7130
	// RVA: 0x1E92490 Offset: 0x1E92591 VA: 0x1E92490
	public void set_ReturnItem(Transform value) { }

	// RVA: 0x1E924A0 Offset: 0x1E925A1 VA: 0x1E924A0
	public void EquipOn() { }

	// RVA: 0x1E92640 Offset: 0x1E92741 VA: 0x1E92640
	public void EquipOff() { }

	// RVA: 0x1E927D0 Offset: 0x1E928D1 VA: 0x1E927D0 Slot: 17
	public override void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: 0x1E92810 Offset: 0x1E92911 VA: 0x1E92810 Slot: 18
	public override void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0x1E92850 Offset: 0x1E92951 VA: 0x1E92850
	public void .ctor() { }
}

