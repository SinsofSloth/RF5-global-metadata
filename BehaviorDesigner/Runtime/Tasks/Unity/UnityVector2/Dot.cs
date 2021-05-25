[TaskCategoryAttribute] // RVA: 0x14CB70 Offset: 0x14CC71 VA: 0x14CB70
[TaskDescriptionAttribute] // RVA: 0x14CB70 Offset: 0x14CC71 VA: 0x14CB70
public class Dot : Action // TypeDefIndex: 10990
{
	// Fields
	[TooltipAttribute] // RVA: 0x1851B0 Offset: 0x1852B1 VA: 0x1851B0
	public SharedVector2 leftHandSide; // 0x50
	[TooltipAttribute] // RVA: 0x1851F0 Offset: 0x1852F1 VA: 0x1851F0
	public SharedVector2 rightHandSide; // 0x58
	[TooltipAttribute] // RVA: 0x185230 Offset: 0x185331 VA: 0x185230
	[RequiredFieldAttribute] // RVA: 0x185230 Offset: 0x185331 VA: 0x185230
	public SharedFloat storeResult; // 0x60

	// Methods

	// RVA: 0x2891460 Offset: 0x2891561 VA: 0x2891460 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2891550 Offset: 0x2891651 VA: 0x2891550 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2891610 Offset: 0x2891711 VA: 0x2891610
	public void .ctor() { }
}

