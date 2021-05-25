[TaskCategoryAttribute] // RVA: 0x14F390 Offset: 0x14F491 VA: 0x14F390
[TaskDescriptionAttribute] // RVA: 0x14F390 Offset: 0x14F491 VA: 0x14F390
public class AddTorque : Action // TypeDefIndex: 11098
{
	// Fields
	[TooltipAttribute] // RVA: 0x188F40 Offset: 0x189041 VA: 0x188F40
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x188F80 Offset: 0x189081 VA: 0x188F80
	public SharedFloat torque; // 0x58
	private Rigidbody2D rigidbody2D; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2886E20 Offset: 0x2886F21 VA: 0x2886E20 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2886F20 Offset: 0x2887021 VA: 0x2886F20 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2887010 Offset: 0x2887111 VA: 0x2887010 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2887060 Offset: 0x2887161 VA: 0x2887060
	public void .ctor() { }
}

