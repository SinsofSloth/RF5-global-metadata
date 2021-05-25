[TaskDescriptionAttribute] // RVA: 0x14AA90 Offset: 0x14AB91 VA: 0x14AA90
[TaskCategoryAttribute] // RVA: 0x14AA90 Offset: 0x14AB91 VA: 0x14AA90
[TaskIconAttribute] // RVA: 0x14AA90 Offset: 0x14AB91 VA: 0x14AA90
public class CalcLongAttackPosition : Action // TypeDefIndex: 10906
{
	// Fields
	[TooltipAttribute] // RVA: 0x1821D0 Offset: 0x1822D1 VA: 0x1821D0
	public SharedFloat LeaveRange; // 0x50
	[TooltipAttribute] // RVA: 0x182210 Offset: 0x182311 VA: 0x182210
	public SharedGameObject Target; // 0x58
	[TooltipAttribute] // RVA: 0x182250 Offset: 0x182351 VA: 0x182250
	public SharedVector3 ReturnCanLongAttackPosition; // 0x60
	public static readonly string LeaveRangeKeyName; // 0x0
	private AIInput AIInput; // 0x68

	// Methods

	// RVA: 0x20DD0C0 Offset: 0x20DD1C1 VA: 0x20DD0C0 Slot: 4
	public override void OnAwake() { }

	// RVA: 0x20DD190 Offset: 0x20DD291 VA: 0x20DD190 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20DD3E0 Offset: 0x20DD4E1 VA: 0x20DD3E0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x20DD430 Offset: 0x20DD531 VA: 0x20DD430
	public void .ctor() { }

	// RVA: 0x20DD440 Offset: 0x20DD541 VA: 0x20DD440
	private static void .cctor() { }
}

