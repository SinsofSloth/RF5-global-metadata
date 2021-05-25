[TaskCategoryAttribute] // RVA: 0x156220 Offset: 0x156321 VA: 0x156220
[TaskDescriptionAttribute] // RVA: 0x156220 Offset: 0x156321 VA: 0x156220
public class IsParameterControlledByCurve : Conditional // TypeDefIndex: 11397
{
	// Fields
	[TooltipAttribute] // RVA: 0x1935C0 Offset: 0x1936C1 VA: 0x1935C0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x193600 Offset: 0x193701 VA: 0x193600
	public SharedString paramaterName; // 0x58
	private Animator animator; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2792720 Offset: 0x2792821 VA: 0x2792720 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2792820 Offset: 0x2792921 VA: 0x2792820 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2792920 Offset: 0x2792A21 VA: 0x2792920 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2792990 Offset: 0x2792A91 VA: 0x2792990
	public void .ctor() { }
}

