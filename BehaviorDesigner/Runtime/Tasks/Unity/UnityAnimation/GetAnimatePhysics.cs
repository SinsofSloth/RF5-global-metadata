[TaskCategoryAttribute] // RVA: 0x1569A0 Offset: 0x156AA1 VA: 0x1569A0
[TaskDescriptionAttribute] // RVA: 0x1569A0 Offset: 0x156AA1 VA: 0x1569A0
public class GetAnimatePhysics : Action // TypeDefIndex: 11420
{
	// Fields
	[TooltipAttribute] // RVA: 0x194580 Offset: 0x194681 VA: 0x194580
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x1945C0 Offset: 0x1946C1 VA: 0x1945C0
	[RequiredFieldAttribute] // RVA: 0x1945C0 Offset: 0x1946C1 VA: 0x1945C0
	public SharedBool storeValue; // 0x58
	private Animation animation; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x278EE20 Offset: 0x278EF21 VA: 0x278EE20 Slot: 5
	public override void OnStart() { }

	// RVA: 0x278EF20 Offset: 0x278F021 VA: 0x278EF20 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x278F020 Offset: 0x278F121 VA: 0x278F020 Slot: 16
	public override void OnReset() { }

	// RVA: 0x278F090 Offset: 0x278F191 VA: 0x278F090
	public void .ctor() { }
}

