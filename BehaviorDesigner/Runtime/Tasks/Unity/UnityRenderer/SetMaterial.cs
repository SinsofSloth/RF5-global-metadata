[TaskCategoryAttribute] // RVA: 0x150A60 Offset: 0x150B61 VA: 0x150A60
[TaskDescriptionAttribute] // RVA: 0x150A60 Offset: 0x150B61 VA: 0x150A60
public class SetMaterial : Action // TypeDefIndex: 11158
{
	// Fields
	[TooltipAttribute] // RVA: 0x18AE80 Offset: 0x18AF81 VA: 0x18AE80
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18AEC0 Offset: 0x18AFC1 VA: 0x18AEC0
	public SharedMaterial material; // 0x58
	private Renderer renderer; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2880ED0 Offset: 0x2880FD1 VA: 0x2880ED0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2880FD0 Offset: 0x28810D1 VA: 0x2880FD0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x28810D0 Offset: 0x28811D1 VA: 0x28810D0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2881110 Offset: 0x2881211 VA: 0x2881110
	public void .ctor() { }
}

