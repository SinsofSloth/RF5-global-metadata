[TaskCategoryAttribute] // RVA: 0x154060 Offset: 0x154161 VA: 0x154060
[TaskDescriptionAttribute] // RVA: 0x154060 Offset: 0x154161 VA: 0x154060
public class DrawRay : Action // TypeDefIndex: 11307
{
	// Fields
	[TooltipAttribute] // RVA: 0x190550 Offset: 0x190651 VA: 0x190550
	public SharedVector3 start; // 0x50
	[TooltipAttribute] // RVA: 0x190590 Offset: 0x190691 VA: 0x190590
	public SharedVector3 direction; // 0x58
	[TooltipAttribute] // RVA: 0x1905D0 Offset: 0x1906D1 VA: 0x1905D0
	public SharedColor color; // 0x60

	// Methods

	// RVA: 0x27A0430 Offset: 0x27A0531 VA: 0x27A0430 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x27A0550 Offset: 0x27A0651 VA: 0x27A0550 Slot: 16
	public override void OnReset() { }

	// RVA: 0x27A0610 Offset: 0x27A0711 VA: 0x27A0610
	public void .ctor() { }
}

