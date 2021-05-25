[TaskCategoryAttribute] // RVA: 0x1517E0 Offset: 0x1518E1 VA: 0x1517E0
[TaskDescriptionAttribute] // RVA: 0x1517E0 Offset: 0x1518E1 VA: 0x1517E0
public class GetTime : Action // TypeDefIndex: 11194
{
	// Fields
	[TooltipAttribute] // RVA: 0x18CD50 Offset: 0x18CE51 VA: 0x18CD50
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18CD90 Offset: 0x18CE91 VA: 0x18CD90
	[RequiredFieldAttribute] // RVA: 0x18CD90 Offset: 0x18CE91 VA: 0x18CD90
	public SharedFloat storeResult; // 0x58
	private ParticleSystem particleSystem; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x287A820 Offset: 0x287A921 VA: 0x287A820 Slot: 5
	public override void OnStart() { }

	// RVA: 0x287A920 Offset: 0x287AA21 VA: 0x287A920 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x287AA10 Offset: 0x287AB11 VA: 0x287AA10 Slot: 16
	public override void OnReset() { }

	// RVA: 0x287AA60 Offset: 0x287AB61 VA: 0x287AA60
	public void .ctor() { }
}

