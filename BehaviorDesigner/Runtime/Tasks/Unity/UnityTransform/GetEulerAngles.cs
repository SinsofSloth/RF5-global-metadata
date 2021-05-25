[TaskCategoryAttribute] // RVA: 0x14D230 Offset: 0x14D331 VA: 0x14D230
[TaskDescriptionAttribute] // RVA: 0x14D230 Offset: 0x14D331 VA: 0x14D230
public class GetEulerAngles : Action // TypeDefIndex: 11009
{
	// Fields
	[TooltipAttribute] // RVA: 0x185EF0 Offset: 0x185FF1 VA: 0x185EF0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x185F30 Offset: 0x186031 VA: 0x185F30
	[RequiredFieldAttribute] // RVA: 0x185F30 Offset: 0x186031 VA: 0x185F30
	public SharedVector3 storeValue; // 0x58
	private Transform targetTransform; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x288CAC0 Offset: 0x288CBC1 VA: 0x288CAC0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x288CBC0 Offset: 0x288CCC1 VA: 0x288CBC0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x288CCB0 Offset: 0x288CDB1 VA: 0x288CCB0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x288CD40 Offset: 0x288CE41 VA: 0x288CD40
	public void .ctor() { }
}

