[TaskCategoryAttribute] // RVA: 0x1562E0 Offset: 0x1563E1 VA: 0x1562E0
[TaskDescriptionAttribute] // RVA: 0x1562E0 Offset: 0x1563E1 VA: 0x1562E0
public class Play : Action // TypeDefIndex: 11399
{
	// Fields
	[TooltipAttribute] // RVA: 0x193840 Offset: 0x193941 VA: 0x193840
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x193880 Offset: 0x193981 VA: 0x193880
	public SharedString stateName; // 0x58
	[TooltipAttribute] // RVA: 0x1938C0 Offset: 0x1939C1 VA: 0x1938C0
	public int layer; // 0x60
	[TooltipAttribute] // RVA: 0x193900 Offset: 0x193A01 VA: 0x193900
	public float normalizedTime; // 0x64
	private Animator animator; // 0x68
	private GameObject prevGameObject; // 0x70

	// Methods

	// RVA: 0x2792D50 Offset: 0x2792E51 VA: 0x2792D50 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2792E50 Offset: 0x2792F51 VA: 0x2792E50 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2792F50 Offset: 0x2793051 VA: 0x2792F50 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2792FD0 Offset: 0x27930D1 VA: 0x2792FD0
	public void .ctor() { }
}

