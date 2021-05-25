[TaskCategoryAttribute] // RVA: 0x14F870 Offset: 0x14F971 VA: 0x14F870
[TaskDescriptionAttribute] // RVA: 0x14F870 Offset: 0x14F971 VA: 0x14F870
public class MoveRotation : Action // TypeDefIndex: 11111
{
	// Fields
	[TooltipAttribute] // RVA: 0x1895D0 Offset: 0x1896D1 VA: 0x1895D0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x189610 Offset: 0x189711 VA: 0x189610
	public SharedFloat rotation; // 0x58
	private Rigidbody2D rigidbody2D; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2888C60 Offset: 0x2888D61 VA: 0x2888C60 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2888D60 Offset: 0x2888E61 VA: 0x2888D60 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2888E50 Offset: 0x2888F51 VA: 0x2888E50 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2888EA0 Offset: 0x2888FA1 VA: 0x2888EA0
	public void .ctor() { }
}

