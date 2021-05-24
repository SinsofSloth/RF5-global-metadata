[TaskCategoryAttribute] // RVA: 0x156580 Offset: 0x156681 VA: 0x156580
[TaskDescriptionAttribute] // RVA: 0x156580 Offset: 0x156681 VA: 0x156580
public class SetLookAtWeight : Action // TypeDefIndex: 11409
{
	// Fields
	[TooltipAttribute] // RVA: 0x193DC0 Offset: 0x193EC1 VA: 0x193DC0
	public SharedFloat weight; // 0x50
	[TooltipAttribute] // RVA: 0x193E00 Offset: 0x193F01 VA: 0x193E00
	public float bodyWeight; // 0x58
	[TooltipAttribute] // RVA: 0x193E40 Offset: 0x193F41 VA: 0x193E40
	public float headWeight; // 0x5C
	[TooltipAttribute] // RVA: 0x193E80 Offset: 0x193F81 VA: 0x193E80
	public float eyesWeight; // 0x60
	[TooltipAttribute] // RVA: 0x193EC0 Offset: 0x193FC1 VA: 0x193EC0
	public float clampWeight; // 0x64
	private Animator animator; // 0x68
	private bool weightSet; // 0x70

	// Methods

	// RVA: 0x2794700 Offset: 0x2794801 VA: 0x2794700 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2794770 Offset: 0x2794871 VA: 0x2794770 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2794840 Offset: 0x2794941 VA: 0x2794840 Slot: 27
	public override void OnAnimatorIK() { }

	// RVA: 0x2794900 Offset: 0x2794A01 VA: 0x2794900 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2794950 Offset: 0x2794A51 VA: 0x2794950
	public void .ctor() { }
}

