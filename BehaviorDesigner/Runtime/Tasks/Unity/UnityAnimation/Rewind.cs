[TaskCategoryAttribute] // RVA: 0x156B20 Offset: 0x156C21 VA: 0x156B20
[TaskDescriptionAttribute] // RVA: 0x156B20 Offset: 0x156C21 VA: 0x156B20
public class Rewind : Action // TypeDefIndex: 11424
{
	// Fields
	[TooltipAttribute] // RVA: 0x194850 Offset: 0x194951 VA: 0x194850
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x194890 Offset: 0x194991 VA: 0x194890
	public SharedString animationName; // 0x58
	private Animation animation; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x278F8D0 Offset: 0x278F9D1 VA: 0x278F8D0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x278F9D0 Offset: 0x278FAD1 VA: 0x278F9D0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x278FB00 Offset: 0x278FC01 VA: 0x278FB00 Slot: 16
	public override void OnReset() { }

	// RVA: 0x278FB80 Offset: 0x278FC81 VA: 0x278FB80
	public void .ctor() { }
}

