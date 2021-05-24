[Serializable]
public class ConstraintPositionOffset : Constraint // TypeDefIndex: 9416
{
	// Fields
	public Vector3 offset; // 0x1C
	private Vector3 defaultLocalPosition; // 0x28
	private Vector3 lastLocalPosition; // 0x34
	private bool initiated; // 0x40

	// Properties
	private bool positionChanged { get; }

	// Methods

	// RVA: 0x2739990 Offset: 0x2739A91 VA: 0x2739990 Slot: 4
	public override void UpdateConstraint() { }

	// RVA: 0x2739C60 Offset: 0x2739D61 VA: 0x2739C60
	public void .ctor() { }

	// RVA: 0x2739C70 Offset: 0x2739D71 VA: 0x2739C70
	public void .ctor(Transform transform) { }

	// RVA: 0x2739BA0 Offset: 0x2739CA1 VA: 0x2739BA0
	private bool get_positionChanged() { }
}

