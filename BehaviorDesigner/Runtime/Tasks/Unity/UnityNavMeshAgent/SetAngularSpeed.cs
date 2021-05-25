[TaskCategoryAttribute] // RVA: 0x1523E0 Offset: 0x1524E1 VA: 0x1523E0
[TaskDescriptionAttribute] // RVA: 0x1523E0 Offset: 0x1524E1 VA: 0x1523E0
public class SetAngularSpeed : Action // TypeDefIndex: 11226
{
	// Fields
	[TooltipAttribute] // RVA: 0x18DB40 Offset: 0x18DC41 VA: 0x18DB40
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18DB80 Offset: 0x18DC81 VA: 0x18DB80
	public SharedFloat angularSpeed; // 0x58
	private NavMeshAgent navMeshAgent; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2878720 Offset: 0x2878821 VA: 0x2878720 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2878820 Offset: 0x2878921 VA: 0x2878820 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2878910 Offset: 0x2878A11 VA: 0x2878910 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2878960 Offset: 0x2878A61 VA: 0x2878960
	public void .ctor() { }
}

