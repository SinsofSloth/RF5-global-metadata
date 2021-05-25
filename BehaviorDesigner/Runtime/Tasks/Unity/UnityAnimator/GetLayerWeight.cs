[TaskCategoryAttribute] // RVA: 0x155FE0 Offset: 0x1560E1 VA: 0x155FE0
[TaskDescriptionAttribute] // RVA: 0x155FE0 Offset: 0x1560E1 VA: 0x155FE0
public class GetLayerWeight : Action // TypeDefIndex: 11391
{
	// Fields
	[TooltipAttribute] // RVA: 0x193210 Offset: 0x193311 VA: 0x193210
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x193250 Offset: 0x193351 VA: 0x193250
	public SharedInt index; // 0x58
	[TooltipAttribute] // RVA: 0x193290 Offset: 0x193391 VA: 0x193290
	[RequiredFieldAttribute] // RVA: 0x193290 Offset: 0x193391 VA: 0x193290
	public SharedFloat storeValue; // 0x60
	private Animator animator; // 0x68
	private GameObject prevGameObject; // 0x70

	// Methods

	// RVA: 0x27919A0 Offset: 0x2791AA1 VA: 0x27919A0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2791AA0 Offset: 0x2791BA1 VA: 0x2791AA0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2791BB0 Offset: 0x2791CB1 VA: 0x2791BB0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2791C10 Offset: 0x2791D11 VA: 0x2791C10
	public void .ctor() { }
}

