[TaskCategoryAttribute] // RVA: 0x153F40 Offset: 0x154041 VA: 0x153F40
[TaskDescriptionAttribute] // RVA: 0x153F40 Offset: 0x154041 VA: 0x153F40
public class SetActive : Action // TypeDefIndex: 11304
{
	// Fields
	[TooltipAttribute] // RVA: 0x190310 Offset: 0x190411 VA: 0x190310
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x190350 Offset: 0x190451 VA: 0x190350
	public SharedBool active; // 0x58

	// Methods

	// RVA: 0x27A1CD0 Offset: 0x27A1DD1 VA: 0x27A1CD0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x27A1D70 Offset: 0x27A1E71 VA: 0x27A1D70 Slot: 16
	public override void OnReset() { }

	// RVA: 0x27A1DC0 Offset: 0x27A1EC1 VA: 0x27A1DC0
	public void .ctor() { }
}

