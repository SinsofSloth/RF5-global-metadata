[TaskCategoryAttribute] // RVA: 0x156BE0 Offset: 0x156CE1 VA: 0x156BE0
[TaskDescriptionAttribute] // RVA: 0x156BE0 Offset: 0x156CE1 VA: 0x156BE0
public class SetAnimatePhysics : Action // TypeDefIndex: 11426
{
	// Fields
	[TooltipAttribute] // RVA: 0x194910 Offset: 0x194A11 VA: 0x194910
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x194950 Offset: 0x194A51 VA: 0x194950
	public SharedBool animatePhysics; // 0x58
	private Animation animation; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x278FD90 Offset: 0x278FE91 VA: 0x278FD90 Slot: 5
	public override void OnStart() { }

	// RVA: 0x278FE90 Offset: 0x278FF91 VA: 0x278FE90 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x278FF90 Offset: 0x2790091 VA: 0x278FF90 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2790000 Offset: 0x2790101 VA: 0x2790000
	public void .ctor() { }
}

