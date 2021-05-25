public class RagdollUtility.Rigidbone // TypeDefIndex: 9531
{
	// Fields
	public Rigidbody r; // 0x10
	public Transform t; // 0x18
	public Collider collider; // 0x20
	public Joint joint; // 0x28
	public Rigidbody c; // 0x30
	public bool updateAnchor; // 0x38
	public Vector3 deltaPosition; // 0x3C
	public Quaternion deltaRotation; // 0x48
	public float deltaTime; // 0x58
	public Vector3 lastPosition; // 0x5C
	public Quaternion lastRotation; // 0x68

	// Methods

	// RVA: 0x291D450 Offset: 0x291D551 VA: 0x291D450
	public void .ctor(Rigidbody r) { }

	// RVA: 0x291E250 Offset: 0x291E351 VA: 0x291E250
	public void RecordVelocity() { }

	// RVA: 0x291E020 Offset: 0x291E121 VA: 0x291E020
	public void WakeUp(float velocityWeight, float angularVelocityWeight) { }
}

