[TaskCategoryAttribute] // RVA: 0x14E4F0 Offset: 0x14E5F1 VA: 0x14E4F0
[TaskDescriptionAttribute] // RVA: 0x14E4F0 Offset: 0x14E5F1 VA: 0x14E4F0
public class SetRadius : Action // TypeDefIndex: 11059
{
	// Fields
	[TooltipAttribute] // RVA: 0x187A00 Offset: 0x187B01 VA: 0x187A00
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x187A40 Offset: 0x187B41 VA: 0x187A40
	public SharedFloat radius; // 0x58
	private SphereCollider sphereCollider; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x288AA90 Offset: 0x288AB91 VA: 0x288AA90 Slot: 5
	public override void OnStart() { }

	// RVA: 0x288AB90 Offset: 0x288AC91 VA: 0x288AB90 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x288AC80 Offset: 0x288AD81 VA: 0x288AC80 Slot: 16
	public override void OnReset() { }

	// RVA: 0x288ACD0 Offset: 0x288ADD1 VA: 0x288ACD0
	public void .ctor() { }
}

