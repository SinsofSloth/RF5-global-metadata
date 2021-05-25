[TaskCategoryAttribute] // RVA: 0x156400 Offset: 0x156501 VA: 0x156400
[TaskDescriptionAttribute] // RVA: 0x156400 Offset: 0x156501 VA: 0x156400
public class SetFloatParameter : Action // TypeDefIndex: 11403
{
	// Fields
	[TooltipAttribute] // RVA: 0x193AC0 Offset: 0x193BC1 VA: 0x193AC0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x193B00 Offset: 0x193C01 VA: 0x193B00
	public SharedString paramaterName; // 0x58
	[TooltipAttribute] // RVA: 0x193B40 Offset: 0x193C41 VA: 0x193B40
	public SharedFloat floatValue; // 0x60
	[TooltipAttribute] // RVA: 0x193B80 Offset: 0x193C81 VA: 0x193B80
	public bool setOnce; // 0x68
	private int hashID; // 0x6C
	private Animator animator; // 0x70
	private GameObject prevGameObject; // 0x78

	// Methods

	// RVA: 0x2793780 Offset: 0x2793881 VA: 0x2793780 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2793880 Offset: 0x2793981 VA: 0x2793880 Slot: 6
	public override TaskStatus OnUpdate() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AFE70 Offset: 0x1AFF71 VA: 0x1AFE70
	// RVA: 0x2793A30 Offset: 0x2793B31 VA: 0x2793A30
	public IEnumerator ResetValue(float origVale) { }

	// RVA: 0x2793AF0 Offset: 0x2793BF1 VA: 0x2793AF0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2793B80 Offset: 0x2793C81 VA: 0x2793B80
	public void .ctor() { }
}

