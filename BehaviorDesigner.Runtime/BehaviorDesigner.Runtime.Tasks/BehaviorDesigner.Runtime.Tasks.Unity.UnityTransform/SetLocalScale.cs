[TaskCategoryAttribute] // RVA: 0x14D9B0 Offset: 0x14DAB1 VA: 0x14D9B0
[TaskDescriptionAttribute] // RVA: 0x14D9B0 Offset: 0x14DAB1 VA: 0x14D9B0
public class SetLocalScale : Action // TypeDefIndex: 11029
{
	// Fields
	[TooltipAttribute] // RVA: 0x186AE0 Offset: 0x186BE1 VA: 0x186AE0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x186B20 Offset: 0x186C21 VA: 0x186B20
	public SharedVector3 localScale; // 0x58
	private Transform targetTransform; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x288FF10 Offset: 0x2890011 VA: 0x288FF10 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2890010 Offset: 0x2890111 VA: 0x2890010 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2890100 Offset: 0x2890201 VA: 0x2890100 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2890190 Offset: 0x2890291 VA: 0x2890190
	public void .ctor() { }
}

