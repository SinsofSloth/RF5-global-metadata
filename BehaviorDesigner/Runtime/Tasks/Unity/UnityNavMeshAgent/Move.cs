[TaskCategoryAttribute] // RVA: 0x152260 Offset: 0x152361 VA: 0x152260
[TaskDescriptionAttribute] // RVA: 0x152260 Offset: 0x152361 VA: 0x152260
public class Move : Action // TypeDefIndex: 11222
{
	// Fields
	[TooltipAttribute] // RVA: 0x18D9C0 Offset: 0x18DAC1 VA: 0x18D9C0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18DA00 Offset: 0x18DB01 VA: 0x18DA00
	public SharedVector3 offset; // 0x58
	private NavMeshAgent navMeshAgent; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2877E40 Offset: 0x2877F41 VA: 0x2877E40 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2877F40 Offset: 0x2878041 VA: 0x2877F40 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2878030 Offset: 0x2878131 VA: 0x2878030 Slot: 16
	public override void OnReset() { }

	// RVA: 0x28780C0 Offset: 0x28781C1 VA: 0x28780C0
	public void .ctor() { }
}

