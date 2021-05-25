[TaskCategoryAttribute] // RVA: 0x156A60 Offset: 0x156B61 VA: 0x156A60
[TaskDescriptionAttribute] // RVA: 0x156A60 Offset: 0x156B61 VA: 0x156A60
public class Play : Action // TypeDefIndex: 11422
{
	// Fields
	[TooltipAttribute] // RVA: 0x194690 Offset: 0x194791 VA: 0x194690
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x1946D0 Offset: 0x1947D1 VA: 0x1946D0
	public SharedString animationName; // 0x58
	[TooltipAttribute] // RVA: 0x194710 Offset: 0x194811 VA: 0x194710
	public PlayMode playMode; // 0x60
	private Animation animation; // 0x68
	private GameObject prevGameObject; // 0x70

	// Methods

	// RVA: 0x278F370 Offset: 0x278F471 VA: 0x278F370 Slot: 5
	public override void OnStart() { }

	// RVA: 0x278F470 Offset: 0x278F571 VA: 0x278F470 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x278F5B0 Offset: 0x278F6B1 VA: 0x278F5B0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x278F630 Offset: 0x278F731 VA: 0x278F630
	public void .ctor() { }
}

