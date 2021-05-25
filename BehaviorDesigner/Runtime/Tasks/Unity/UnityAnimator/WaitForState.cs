[TaskCategoryAttribute] // RVA: 0x156820 Offset: 0x156921 VA: 0x156820
[TaskDescriptionAttribute] // RVA: 0x156820 Offset: 0x156921 VA: 0x156820
public class WaitForState : Action // TypeDefIndex: 11416
{
	// Fields
	[TooltipAttribute] // RVA: 0x194140 Offset: 0x194241 VA: 0x194140
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x194180 Offset: 0x194281 VA: 0x194180
	public SharedString stateName; // 0x58
	[TooltipAttribute] // RVA: 0x1941C0 Offset: 0x1942C1 VA: 0x1941C0
	public SharedInt layer; // 0x60
	private Animator animator; // 0x68
	private GameObject prevGameObject; // 0x70
	private int stateHash; // 0x78

	// Methods

	// RVA: 0x2795660 Offset: 0x2795761 VA: 0x2795660 Slot: 4
	public override void OnAwake() { }

	// RVA: 0x27956D0 Offset: 0x27957D1 VA: 0x27956D0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x27959C0 Offset: 0x2795AC1 VA: 0x27959C0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2795B00 Offset: 0x2795C01 VA: 0x2795B00 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2795B90 Offset: 0x2795C91 VA: 0x2795B90
	public void .ctor() { }
}

