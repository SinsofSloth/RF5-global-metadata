[TaskCategoryAttribute] // RVA: 0x152DA0 Offset: 0x152EA1 VA: 0x152DA0
[TaskDescriptionAttribute] // RVA: 0x152DA0 Offset: 0x152EA1 VA: 0x152DA0
public class SetInt : Action // TypeDefIndex: 11257
{
	// Fields
	[TooltipAttribute] // RVA: 0x18EB40 Offset: 0x18EC41 VA: 0x18EB40
	public SharedInt intValue; // 0x50
	[TooltipAttribute] // RVA: 0x18EB80 Offset: 0x18EC81 VA: 0x18EB80
	public SharedInt storeResult; // 0x58

	// Methods

	// RVA: 0x20ECAE0 Offset: 0x20ECBE1 VA: 0x20ECAE0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20ECB60 Offset: 0x20ECC61 VA: 0x20ECB60 Slot: 16
	public override void OnReset() { }

	// RVA: 0x20ECC90 Offset: 0x20ECD91 VA: 0x20ECC90
	public void .ctor() { }
}

