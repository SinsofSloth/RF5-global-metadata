[TaskCategoryAttribute] // RVA: 0x151AE0 Offset: 0x151BE1 VA: 0x151AE0
[TaskDescriptionAttribute] // RVA: 0x151AE0 Offset: 0x151BE1 VA: 0x151AE0
public class SetEnableEmission : Action // TypeDefIndex: 11202
{
	// Fields
	[TooltipAttribute] // RVA: 0x18CFE0 Offset: 0x18D0E1 VA: 0x18CFE0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18D020 Offset: 0x18D121 VA: 0x18D020
	public SharedBool enable; // 0x58
	private ParticleSystem particleSystem; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x287B8C0 Offset: 0x287B9C1 VA: 0x287B8C0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x287B9C0 Offset: 0x287BAC1 VA: 0x287B9C0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x287BAD0 Offset: 0x287BBD1 VA: 0x287BAD0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x287BB20 Offset: 0x287BC21 VA: 0x287BB20
	public void .ctor() { }
}

