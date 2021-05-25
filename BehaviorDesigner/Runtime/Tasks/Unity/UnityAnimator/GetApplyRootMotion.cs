[TaskCategoryAttribute] // RVA: 0x155D40 Offset: 0x155E41 VA: 0x155D40
[TaskDescriptionAttribute] // RVA: 0x155D40 Offset: 0x155E41 VA: 0x155D40
public class GetApplyRootMotion : Action // TypeDefIndex: 11384
{
	// Fields
	[TooltipAttribute] // RVA: 0x192D60 Offset: 0x192E61 VA: 0x192D60
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x192DA0 Offset: 0x192EA1 VA: 0x192DA0
	[RequiredFieldAttribute] // RVA: 0x192DA0 Offset: 0x192EA1 VA: 0x192DA0
	public SharedBool storeValue; // 0x58
	private Animator animator; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x27907C0 Offset: 0x27908C1 VA: 0x27907C0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x27908C0 Offset: 0x27909C1 VA: 0x27908C0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x27909C0 Offset: 0x2790AC1 VA: 0x27909C0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2790A10 Offset: 0x2790B11 VA: 0x2790A10
	public void .ctor() { }
}

