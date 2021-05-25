[TaskCategoryAttribute] // RVA: 0x145290 Offset: 0x145391 VA: 0x145290
public class CharacterRotate : Action // TypeDefIndex: 6348
{
	// Fields
	public SharedFloat rotationEpsilon; // 0x50
	public SharedGameObject target; // 0x58
	public SharedVector3 targetPosition; // 0x60
	public bool UseRotateAnimation; // 0x68
	private AIInput AIInput; // 0x70
	private bool IsHoldRotateAnimation; // 0x78

	// Methods

	// RVA: 0x1E563A0 Offset: 0x1E564A1 VA: 0x1E563A0 Slot: 4
	public override void OnAwake() { }

	// RVA: 0x1E56470 Offset: 0x1E56571 VA: 0x1E56470 Slot: 5
	public override void OnStart() { }

	// RVA: 0x1E56840 Offset: 0x1E56941 VA: 0x1E56840 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x1E56A00 Offset: 0x1E56B01 VA: 0x1E56A00 Slot: 9
	public override void OnEnd() { }

	// RVA: 0x1E56690 Offset: 0x1E56791 VA: 0x1E56690
	private Quaternion Target() { }

	// RVA: 0x1E56B60 Offset: 0x1E56C61 VA: 0x1E56B60
	public void .ctor() { }
}

