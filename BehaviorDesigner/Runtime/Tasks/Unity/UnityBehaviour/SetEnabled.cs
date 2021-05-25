[TaskCategoryAttribute] // RVA: 0x154F60 Offset: 0x155061 VA: 0x154F60
[TaskDescriptionAttribute] // RVA: 0x154F60 Offset: 0x155061 VA: 0x154F60
public class SetEnabled : Action // TypeDefIndex: 11347
{
	// Fields
	[TooltipAttribute] // RVA: 0x191A20 Offset: 0x191B21 VA: 0x191A20
	public SharedBehaviour specifiedObject; // 0x50
	[TooltipAttribute] // RVA: 0x191A60 Offset: 0x191B61 VA: 0x191A60
	public SharedBool enabled; // 0x58

	// Methods

	// RVA: 0x279AFB0 Offset: 0x279B0B1 VA: 0x279AFB0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x279B090 Offset: 0x279B191 VA: 0x279B090 Slot: 16
	public override void OnReset() { }

	// RVA: 0x279B110 Offset: 0x279B211 VA: 0x279B110
	public void .ctor() { }
}

