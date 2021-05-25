[TaskCategoryAttribute] // RVA: 0x151840 Offset: 0x151941 VA: 0x151840
[TaskDescriptionAttribute] // RVA: 0x151840 Offset: 0x151941 VA: 0x151840
public class IsAlive : Conditional // TypeDefIndex: 11195
{
	// Fields
	[TooltipAttribute] // RVA: 0x18CDE0 Offset: 0x18CEE1 VA: 0x18CDE0
	public SharedGameObject targetGameObject; // 0x50
	private ParticleSystem particleSystem; // 0x58
	private GameObject prevGameObject; // 0x60

	// Methods

	// RVA: 0x287AA70 Offset: 0x287AB71 VA: 0x287AA70 Slot: 5
	public override void OnStart() { }

	// RVA: 0x287AB70 Offset: 0x287AC71 VA: 0x287AB70 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x287AC50 Offset: 0x287AD51 VA: 0x287AC50 Slot: 16
	public override void OnReset() { }

	// RVA: 0x287AC60 Offset: 0x287AD61 VA: 0x287AC60
	public void .ctor() { }
}

