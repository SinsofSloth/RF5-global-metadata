[TaskCategoryAttribute] // RVA: 0x14C870 Offset: 0x14C971 VA: 0x14C870
[TaskDescriptionAttribute] // RVA: 0x14C870 Offset: 0x14C971 VA: 0x14C870
public class Multiply : Action // TypeDefIndex: 10981
{
	// Fields
	[TooltipAttribute] // RVA: 0x184AE0 Offset: 0x184BE1 VA: 0x184AE0
	public SharedVector3 vector3Variable; // 0x50
	[TooltipAttribute] // RVA: 0x184B20 Offset: 0x184C21 VA: 0x184B20
	public SharedFloat multiplyBy; // 0x58
	[TooltipAttribute] // RVA: 0x184B60 Offset: 0x184C61 VA: 0x184B60
	[RequiredFieldAttribute] // RVA: 0x184B60 Offset: 0x184C61 VA: 0x184B60
	public SharedVector3 storeResult; // 0x60

	// Methods

	// RVA: 0x22D9830 Offset: 0x22D9931 VA: 0x22D9830 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x22D9920 Offset: 0x22D9A21 VA: 0x22D9920 Slot: 16
	public override void OnReset() { }

	// RVA: 0x22D99E0 Offset: 0x22D9AE1 VA: 0x22D99E0
	public void .ctor() { }
}

