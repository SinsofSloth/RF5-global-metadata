[TaskCategoryAttribute] // RVA: 0x1558C0 Offset: 0x1559C1 VA: 0x1558C0
[TaskDescriptionAttribute] // RVA: 0x1558C0 Offset: 0x1559C1 VA: 0x1558C0
public class SetMute : Action // TypeDefIndex: 11372
{
	// Fields
	[TooltipAttribute] // RVA: 0x1926E0 Offset: 0x1927E1 VA: 0x1926E0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x192720 Offset: 0x192821 VA: 0x192720
	public SharedBool mute; // 0x58
	private AudioSource audioSource; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x27993C0 Offset: 0x27994C1 VA: 0x27993C0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x27994C0 Offset: 0x27995C1 VA: 0x27994C0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x27995C0 Offset: 0x27996C1 VA: 0x27995C0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2799610 Offset: 0x2799711 VA: 0x2799610
	public void .ctor() { }
}

