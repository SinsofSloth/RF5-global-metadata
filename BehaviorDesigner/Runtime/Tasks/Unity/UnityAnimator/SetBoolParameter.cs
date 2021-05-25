[TaskCategoryAttribute] // RVA: 0x1563A0 Offset: 0x1564A1 VA: 0x1563A0
[TaskDescriptionAttribute] // RVA: 0x1563A0 Offset: 0x1564A1 VA: 0x1563A0
public class SetBoolParameter : Action // TypeDefIndex: 11401
{
	// Fields
	[TooltipAttribute] // RVA: 0x1939C0 Offset: 0x193AC1 VA: 0x1939C0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x193A00 Offset: 0x193B01 VA: 0x193A00
	public SharedString paramaterName; // 0x58
	[TooltipAttribute] // RVA: 0x193A40 Offset: 0x193B41 VA: 0x193A40
	public SharedBool boolValue; // 0x60
	[TooltipAttribute] // RVA: 0x193A80 Offset: 0x193B81 VA: 0x193A80
	public bool setOnce; // 0x68
	private int hashID; // 0x6C
	private Animator animator; // 0x70
	private GameObject prevGameObject; // 0x78

	// Methods

	// RVA: 0x2793240 Offset: 0x2793341 VA: 0x2793240 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2793340 Offset: 0x2793441 VA: 0x2793340 Slot: 6
	public override TaskStatus OnUpdate() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AFE00 Offset: 0x1AFF01 VA: 0x1AFE00
	// RVA: 0x2793500 Offset: 0x2793601 VA: 0x2793500
	public IEnumerator ResetValue(bool origVale) { }

	// RVA: 0x27935C0 Offset: 0x27936C1 VA: 0x27935C0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2793650 Offset: 0x2793751 VA: 0x2793650
	public void .ctor() { }
}

