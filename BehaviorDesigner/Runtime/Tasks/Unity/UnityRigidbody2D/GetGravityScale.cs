[TaskCategoryAttribute] // RVA: 0x14F510 Offset: 0x14F611 VA: 0x14F510
[TaskDescriptionAttribute] // RVA: 0x14F510 Offset: 0x14F611 VA: 0x14F510
public class GetGravityScale : Action // TypeDefIndex: 11102
{
	// Fields
	[TooltipAttribute] // RVA: 0x189170 Offset: 0x189271 VA: 0x189170
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x1891B0 Offset: 0x1892B1 VA: 0x1891B0
	[RequiredFieldAttribute] // RVA: 0x1891B0 Offset: 0x1892B1 VA: 0x1891B0
	public SharedFloat storeValue; // 0x58
	private Rigidbody2D rigidbody2D; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2887760 Offset: 0x2887861 VA: 0x2887760 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2887860 Offset: 0x2887961 VA: 0x2887860 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2887950 Offset: 0x2887A51 VA: 0x2887950 Slot: 16
	public override void OnReset() { }

	// RVA: 0x28879A0 Offset: 0x2887AA1 VA: 0x28879A0
	public void .ctor() { }
}

