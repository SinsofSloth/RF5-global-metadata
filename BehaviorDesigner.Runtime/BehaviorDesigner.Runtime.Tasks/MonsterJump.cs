[TaskDescriptionAttribute] // RVA: 0x14A960 Offset: 0x14AA61 VA: 0x14A960
[TaskCategoryAttribute] // RVA: 0x14A960 Offset: 0x14AA61 VA: 0x14A960
public class MonsterJump : Action // TypeDefIndex: 10903
{
	// Fields
	private const float GravityAccel = 9.8;
	[TooltipAttribute] // RVA: 0x181FD0 Offset: 0x1820D1 VA: 0x181FD0
	public SharedVector3 SharedVelocity; // 0x50
	private Vector3 CurrentVelocity; // 0x58
	private Vector3 GroundPosition; // 0x64
	private AIInput AIInput; // 0x70

	// Methods

	// RVA: 0x20E1F70 Offset: 0x20E2071 VA: 0x20E1F70 Slot: 4
	public override void OnAwake() { }

	// RVA: 0x20E2040 Offset: 0x20E2141 VA: 0x20E2040 Slot: 5
	public override void OnStart() { }

	// RVA: 0x20E20E0 Offset: 0x20E21E1 VA: 0x20E20E0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20E2670 Offset: 0x20E2771 VA: 0x20E2670 Slot: 16
	public override void OnReset() { }

	// RVA: 0x20E24D0 Offset: 0x20E25D1 VA: 0x20E24D0
	private void UpdateGroundHeight() { }

	// RVA: 0x20E2680 Offset: 0x20E2781 VA: 0x20E2680
	public void .ctor() { }
}

