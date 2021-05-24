[TaskCategoryAttribute] // RVA: 0x155500 Offset: 0x155601 VA: 0x155500
[TaskDescriptionAttribute] // RVA: 0x155500 Offset: 0x155601 VA: 0x155500
public class Play : Action // TypeDefIndex: 11362
{
	// Fields
	[TooltipAttribute] // RVA: 0x1921E0 Offset: 0x1922E1 VA: 0x1921E0
	public SharedGameObject targetGameObject; // 0x50
	private AudioSource audioSource; // 0x58
	private GameObject prevGameObject; // 0x60

	// Methods

	// RVA: 0x2797BF0 Offset: 0x2797CF1 VA: 0x2797BF0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2797CF0 Offset: 0x2797DF1 VA: 0x2797CF0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2797DD0 Offset: 0x2797ED1 VA: 0x2797DD0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2797DE0 Offset: 0x2797EE1 VA: 0x2797DE0
	public void .ctor() { }
}

