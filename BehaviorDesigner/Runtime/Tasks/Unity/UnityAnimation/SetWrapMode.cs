[TaskCategoryAttribute] // RVA: 0x156C40 Offset: 0x156D41 VA: 0x156C40
[TaskDescriptionAttribute] // RVA: 0x156C40 Offset: 0x156D41 VA: 0x156C40
public class SetWrapMode : Action // TypeDefIndex: 11427
{
	// Fields
	[TooltipAttribute] // RVA: 0x194990 Offset: 0x194A91 VA: 0x194990
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x1949D0 Offset: 0x194AD1 VA: 0x1949D0
	public WrapMode wrapMode; // 0x58
	private Animation animation; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2790010 Offset: 0x2790111 VA: 0x2790010 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2790110 Offset: 0x2790211 VA: 0x2790110 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x27901F0 Offset: 0x27902F1 VA: 0x27901F0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2790220 Offset: 0x2790321 VA: 0x2790220
	public void .ctor() { }
}

