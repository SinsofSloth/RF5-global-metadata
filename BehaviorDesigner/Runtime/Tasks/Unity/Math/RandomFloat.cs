[TaskCategoryAttribute] // RVA: 0x152C20 Offset: 0x152D21 VA: 0x152C20
[TaskDescriptionAttribute] // RVA: 0x152C20 Offset: 0x152D21 VA: 0x152C20
public class RandomFloat : Action // TypeDefIndex: 11253
{
	// Fields
	[TooltipAttribute] // RVA: 0x18E840 Offset: 0x18E941 VA: 0x18E840
	public SharedFloat min; // 0x50
	[TooltipAttribute] // RVA: 0x18E880 Offset: 0x18E981 VA: 0x18E880
	public SharedFloat max; // 0x58
	[TooltipAttribute] // RVA: 0x18E8C0 Offset: 0x18E9C1 VA: 0x18E8C0
	public bool inclusive; // 0x60
	[TooltipAttribute] // RVA: 0x18E900 Offset: 0x18EA01 VA: 0x18E900
	public SharedFloat storeResult; // 0x68

	// Methods

	// RVA: 0x20EC3F0 Offset: 0x20EC4F1 VA: 0x20EC3F0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20EC4C0 Offset: 0x20EC5C1 VA: 0x20EC4C0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x20EC5D0 Offset: 0x20EC6D1 VA: 0x20EC5D0
	public void .ctor() { }
}

