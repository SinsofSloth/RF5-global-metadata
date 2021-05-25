[TaskCategoryAttribute] // RVA: 0x1555C0 Offset: 0x1556C1 VA: 0x1555C0
[TaskDescriptionAttribute] // RVA: 0x1555C0 Offset: 0x1556C1 VA: 0x1555C0
public class PlayOneShot : Action // TypeDefIndex: 11364
{
	// Fields
	[TooltipAttribute] // RVA: 0x1922A0 Offset: 0x1923A1 VA: 0x1922A0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x1922E0 Offset: 0x1923E1 VA: 0x1922E0
	public SharedObject clip; // 0x58
	[TooltipAttribute] // RVA: 0x192320 Offset: 0x192421 VA: 0x192320
	public SharedFloat volumeScale; // 0x60
	private AudioSource audioSource; // 0x68
	private GameObject prevGameObject; // 0x70

	// Methods

	// RVA: 0x2798070 Offset: 0x2798171 VA: 0x2798070 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2798170 Offset: 0x2798271 VA: 0x2798170 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x27982B0 Offset: 0x27983B1 VA: 0x27982B0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2798300 Offset: 0x2798401 VA: 0x2798300
	public void .ctor() { }
}

