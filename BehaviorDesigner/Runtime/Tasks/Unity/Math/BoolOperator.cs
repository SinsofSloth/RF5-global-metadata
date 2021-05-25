[TaskCategoryAttribute] // RVA: 0x1526E0 Offset: 0x1527E1 VA: 0x1526E0
[TaskDescriptionAttribute] // RVA: 0x1526E0 Offset: 0x1527E1 VA: 0x1526E0
public class BoolOperator : Action // TypeDefIndex: 11234
{
	// Fields
	[TooltipAttribute] // RVA: 0x18DED0 Offset: 0x18DFD1 VA: 0x18DED0
	public BoolOperator.Operation operation; // 0x4C
	[TooltipAttribute] // RVA: 0x18DF10 Offset: 0x18E011 VA: 0x18DF10
	public SharedBool bool1; // 0x50
	[TooltipAttribute] // RVA: 0x18DF50 Offset: 0x18E051 VA: 0x18DF50
	public SharedBool bool2; // 0x58
	[TooltipAttribute] // RVA: 0x18DF90 Offset: 0x18E091 VA: 0x18DF90
	public SharedBool storeResult; // 0x60

	// Methods

	// RVA: 0x20EA030 Offset: 0x20EA131 VA: 0x20EA030 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20EA1D0 Offset: 0x20EA2D1 VA: 0x20EA1D0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x20EA300 Offset: 0x20EA401 VA: 0x20EA300
	public void .ctor() { }
}

