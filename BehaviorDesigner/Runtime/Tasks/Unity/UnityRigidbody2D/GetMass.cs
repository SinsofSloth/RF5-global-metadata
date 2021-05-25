[TaskCategoryAttribute] // RVA: 0x14F5D0 Offset: 0x14F6D1 VA: 0x14F5D0
[TaskDescriptionAttribute] // RVA: 0x14F5D0 Offset: 0x14F6D1 VA: 0x14F5D0
public class GetMass : Action // TypeDefIndex: 11104
{
	// Fields
	[TooltipAttribute] // RVA: 0x189290 Offset: 0x189391 VA: 0x189290
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x1892D0 Offset: 0x1893D1 VA: 0x1892D0
	[RequiredFieldAttribute] // RVA: 0x1892D0 Offset: 0x1893D1 VA: 0x1892D0
	public SharedFloat storeValue; // 0x58
	private Rigidbody2D rigidbody2D; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2887C10 Offset: 0x2887D11 VA: 0x2887C10 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2887D10 Offset: 0x2887E11 VA: 0x2887D10 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2887E00 Offset: 0x2887F01 VA: 0x2887E00 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2887E50 Offset: 0x2887F51 VA: 0x2887E50
	public void .ctor() { }
}

