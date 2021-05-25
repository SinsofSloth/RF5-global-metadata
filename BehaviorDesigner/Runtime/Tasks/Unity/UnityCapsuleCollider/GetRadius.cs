[TaskCategoryAttribute] // RVA: 0x154A80 Offset: 0x154B81 VA: 0x154A80
[TaskDescriptionAttribute] // RVA: 0x154A80 Offset: 0x154B81 VA: 0x154A80
public class GetRadius : Action // TypeDefIndex: 11334
{
	// Fields
	[TooltipAttribute] // RVA: 0x191390 Offset: 0x191491 VA: 0x191390
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x1913D0 Offset: 0x1914D1 VA: 0x1913D0
	[RequiredFieldAttribute] // RVA: 0x1913D0 Offset: 0x1914D1 VA: 0x1913D0
	public SharedFloat storeValue; // 0x58
	private CapsuleCollider capsuleCollider; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x279C7C0 Offset: 0x279C8C1 VA: 0x279C7C0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x279C8C0 Offset: 0x279C9C1 VA: 0x279C8C0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x279C9B0 Offset: 0x279CAB1 VA: 0x279C9B0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x279CA00 Offset: 0x279CB01 VA: 0x279CA00
	public void .ctor() { }
}

