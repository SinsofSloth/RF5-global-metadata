[TaskCategoryAttribute] // RVA: 0x156280 Offset: 0x156381 VA: 0x156280
[TaskDescriptionAttribute] // RVA: 0x156280 Offset: 0x156381 VA: 0x156280
public class MatchTarget : Action // TypeDefIndex: 11398
{
	// Fields
	[TooltipAttribute] // RVA: 0x193640 Offset: 0x193741 VA: 0x193640
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x193680 Offset: 0x193781 VA: 0x193680
	public SharedVector3 matchPosition; // 0x58
	[TooltipAttribute] // RVA: 0x1936C0 Offset: 0x1937C1 VA: 0x1936C0
	public SharedQuaternion matchRotation; // 0x60
	[TooltipAttribute] // RVA: 0x193700 Offset: 0x193801 VA: 0x193700
	public AvatarTarget targetBodyPart; // 0x68
	[TooltipAttribute] // RVA: 0x193740 Offset: 0x193841 VA: 0x193740
	public Vector3 weightMaskPosition; // 0x6C
	[TooltipAttribute] // RVA: 0x193780 Offset: 0x193881 VA: 0x193780
	public float weightMaskRotation; // 0x78
	[TooltipAttribute] // RVA: 0x1937C0 Offset: 0x1938C1 VA: 0x1937C0
	public float startNormalizedTime; // 0x7C
	[TooltipAttribute] // RVA: 0x193800 Offset: 0x193901 VA: 0x193800
	public float targetNormalizedTime; // 0x80
	private Animator animator; // 0x88
	private GameObject prevGameObject; // 0x90

	// Methods

	// RVA: 0x27929A0 Offset: 0x2792AA1 VA: 0x27929A0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2792AA0 Offset: 0x2792BA1 VA: 0x2792AA0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2792C50 Offset: 0x2792D51 VA: 0x2792C50 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2792D40 Offset: 0x2792E41 VA: 0x2792D40
	public void .ctor() { }
}

