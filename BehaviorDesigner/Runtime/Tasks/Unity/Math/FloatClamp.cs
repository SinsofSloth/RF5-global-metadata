[TaskCategoryAttribute] // RVA: 0x1527A0 Offset: 0x1528A1 VA: 0x1527A0
[TaskDescriptionAttribute] // RVA: 0x1527A0 Offset: 0x1528A1 VA: 0x1527A0
public class FloatClamp : Action // TypeDefIndex: 11237
{
	// Fields
	[TooltipAttribute] // RVA: 0x18E010 Offset: 0x18E111 VA: 0x18E010
	public SharedFloat floatVariable; // 0x50
	[TooltipAttribute] // RVA: 0x18E050 Offset: 0x18E151 VA: 0x18E050
	public SharedFloat minValue; // 0x58
	[TooltipAttribute] // RVA: 0x18E090 Offset: 0x18E191 VA: 0x18E090
	public SharedFloat maxValue; // 0x60

	// Methods

	// RVA: 0x20EA490 Offset: 0x20EA591 VA: 0x20EA490 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20EA580 Offset: 0x20EA681 VA: 0x20EA580 Slot: 16
	public override void OnReset() { }

	// RVA: 0x20EA750 Offset: 0x20EA851 VA: 0x20EA750
	public void .ctor() { }
}

