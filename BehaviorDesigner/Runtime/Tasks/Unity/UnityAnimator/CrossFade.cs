[TaskCategoryAttribute] // RVA: 0x155CE0 Offset: 0x155DE1 VA: 0x155CE0
[TaskDescriptionAttribute] // RVA: 0x155CE0 Offset: 0x155DE1 VA: 0x155CE0
public class CrossFade : Action // TypeDefIndex: 11383
{
	// Fields
	[TooltipAttribute] // RVA: 0x192C20 Offset: 0x192D21 VA: 0x192C20
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x192C60 Offset: 0x192D61 VA: 0x192C60
	public SharedString stateName; // 0x58
	[TooltipAttribute] // RVA: 0x192CA0 Offset: 0x192DA1 VA: 0x192CA0
	public SharedFloat transitionDuration; // 0x60
	[TooltipAttribute] // RVA: 0x192CE0 Offset: 0x192DE1 VA: 0x192CE0
	public int layer; // 0x68
	[TooltipAttribute] // RVA: 0x192D20 Offset: 0x192E21 VA: 0x192D20
	public float normalizedTime; // 0x6C
	private Animator animator; // 0x70
	private GameObject prevGameObject; // 0x78

	// Methods

	// RVA: 0x27904E0 Offset: 0x27905E1 VA: 0x27904E0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x27905E0 Offset: 0x27906E1 VA: 0x27905E0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2790710 Offset: 0x2790811 VA: 0x2790710 Slot: 16
	public override void OnReset() { }

	// RVA: 0x27907B0 Offset: 0x27908B1 VA: 0x27907B0
	public void .ctor() { }
}

