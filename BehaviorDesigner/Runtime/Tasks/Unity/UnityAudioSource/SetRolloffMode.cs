[TaskCategoryAttribute] // RVA: 0x1559E0 Offset: 0x155AE1 VA: 0x1559E0
[TaskDescriptionAttribute] // RVA: 0x1559E0 Offset: 0x155AE1 VA: 0x1559E0
public class SetRolloffMode : Action // TypeDefIndex: 11375
{
	// Fields
	[TooltipAttribute] // RVA: 0x192860 Offset: 0x192961 VA: 0x192860
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x1928A0 Offset: 0x1929A1 VA: 0x1928A0
	public AudioRolloffMode rolloffMode; // 0x58
	private AudioSource audioSource; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2799AD0 Offset: 0x2799BD1 VA: 0x2799AD0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2799BD0 Offset: 0x2799CD1 VA: 0x2799BD0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2799CB0 Offset: 0x2799DB1 VA: 0x2799CB0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2799CE0 Offset: 0x2799DE1 VA: 0x2799CE0
	public void .ctor() { }
}

