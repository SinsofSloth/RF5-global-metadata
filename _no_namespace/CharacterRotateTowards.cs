[TaskCategoryAttribute] // RVA: 0x145790 Offset: 0x145891 VA: 0x145790
public class CharacterRotateTowards : Action // TypeDefIndex: 6399
{
	// Fields
	private AIInput AIInput; // 0x50
	public SharedFloat rotationEpsilon; // 0x58
	public SharedFloat maxLookAtRotationDelta; // 0x60
	public SharedBool onlyY; // 0x68
	public SharedGameObject target; // 0x70
	public SharedVector3 targetRotation; // 0x78

	// Methods

	// RVA: 0x1E56BB0 Offset: 0x1E56CB1 VA: 0x1E56BB0 Slot: 4
	public override void OnAwake() { }

	// RVA: 0x1E56C80 Offset: 0x1E56D81 VA: 0x1E56C80 Slot: 5
	public override void OnStart() { }

	// RVA: 0x1E56C90 Offset: 0x1E56D91 VA: 0x1E56C90 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x1E56E70 Offset: 0x1E56F71 VA: 0x1E56E70
	private Quaternion Target() { }

	// RVA: 0x1E570A0 Offset: 0x1E571A1 VA: 0x1E570A0
	public void .ctor() { }
}

