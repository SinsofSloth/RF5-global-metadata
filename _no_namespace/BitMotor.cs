public class BitMotor : MonoBehaviour // TypeDefIndex: 6573
{
	// Fields
	[SerializeField] // RVA: 0x15D770 Offset: 0x15D871 VA: 0x15D770
	public float maxSpeed; // 0x18
	[SerializeField] // RVA: 0x15D780 Offset: 0x15D881 VA: 0x15D780
	public float minSpeed; // 0x1C
	[SerializeField] // RVA: 0x15D790 Offset: 0x15D891 VA: 0x15D790
	public float acceleration; // 0x20
	[SerializeField] // RVA: 0x15D7A0 Offset: 0x15D8A1 VA: 0x15D7A0
	public float deceleration; // 0x24
	[SerializeField] // RVA: 0x15D7B0 Offset: 0x15D8B1 VA: 0x15D7B0
	public float rotateSpeed; // 0x28
	protected MovementVelocity m_Velocity; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x15D7C0 Offset: 0x15D8C1 VA: 0x15D7C0
	private float <LocomotionValue>k__BackingField; // 0x38

	// Properties
	public float LocomotionValue { get; set; }
	public Vector3 velocity { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19B7E0 Offset: 0x19B8E1 VA: 0x19B7E0
	// RVA: 0x22E5220 Offset: 0x22E5321 VA: 0x22E5220
	public float get_LocomotionValue() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B7F0 Offset: 0x19B8F1 VA: 0x19B7F0
	// RVA: 0x22E5230 Offset: 0x22E5331 VA: 0x22E5230
	protected void set_LocomotionValue(float value) { }

	// RVA: 0x22E5240 Offset: 0x22E5341 VA: 0x22E5240
	public Vector3 get_velocity() { }

	// RVA: 0x22E5260 Offset: 0x22E5361 VA: 0x22E5260
	public void set_velocity(Vector3 value) { }

	// RVA: 0x22E5290 Offset: 0x22E5391 VA: 0x22E5290
	public void Awake() { }

	// RVA: 0x22E3530 Offset: 0x22E3631 VA: 0x22E3530
	public void Stop() { }

	// RVA: 0x22E2280 Offset: 0x22E2381 VA: 0x22E2280
	public void Move(Vector3 direction, float speedRate, bool rotateToward = True) { }

	// RVA: 0x22E24C0 Offset: 0x22E25C1 VA: 0x22E24C0
	public void Rotate(Vector3 direction) { }

	// RVA: 0x22E55A0 Offset: 0x22E56A1 VA: 0x22E55A0
	public void AddForce(Vector3 force, ForceMode mode = 0) { }

	// RVA: 0x22E5320 Offset: 0x22E5421 VA: 0x22E5320
	private void ApplyMovement(MovementVelocity velocity, Vector3 desiredVelocity, float deltaTime) { }

	// RVA: 0x22E55C0 Offset: 0x22E56C1 VA: 0x22E55C0
	public Vector3 MoveDeltaPosition(Vector3 deltaPosition, float deltaTime) { }

	// RVA: 0x22E5760 Offset: 0x22E5861 VA: 0x22E5760
	public void .ctor() { }
}

