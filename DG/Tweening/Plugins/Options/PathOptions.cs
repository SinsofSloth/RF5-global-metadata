public struct PathOptions : IPlugOptions // TypeDefIndex: 5038
{
	// Fields
	public PathMode mode; // 0x0
	public OrientType orientType; // 0x4
	public AxisConstraint lockPositionAxis; // 0x8
	public AxisConstraint lockRotationAxis; // 0xC
	public bool isClosedPath; // 0x10
	public Vector3 lookAtPosition; // 0x14
	public Transform lookAtTransform; // 0x20
	public float lookAhead; // 0x28
	public bool hasCustomForwardDirection; // 0x2C
	public Quaternion forward; // 0x30
	public bool useLocalPosition; // 0x40
	public Transform parent; // 0x48
	public bool isRigidbody; // 0x50
	internal Quaternion startupRot; // 0x54
	internal float startupZRot; // 0x64
	internal bool addedExtraStartWp; // 0x68
	internal bool addedExtraEndWp; // 0x69

	// Methods

	// RVA: 0x134D0 Offset: 0x135D1 VA: 0x134D0 Slot: 4
	public void Reset() { }
}

