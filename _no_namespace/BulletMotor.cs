public class BulletMotor : MonoBehaviour, IBulletModule // TypeDefIndex: 6480
{
	// Fields
	private static float kGrounderMaxHeight; // 0x0
	private static float kGrounderStepOffset; // 0x4
	private static float kGrounderKickback; // 0x8
	[SerializeField] // RVA: 0x15CD30 Offset: 0x15CE31 VA: 0x15CD30
	public BulletMotorType type; // 0x18
	[SerializeField] // RVA: 0x15CD40 Offset: 0x15CE41 VA: 0x15CD40
	public float maxSpeed; // 0x1C
	[SerializeField] // RVA: 0x15CD50 Offset: 0x15CE51 VA: 0x15CD50
	public float minSpeed; // 0x20
	[SerializeField] // RVA: 0x15CD60 Offset: 0x15CE61 VA: 0x15CD60
	public float acceleration; // 0x24
	private MovementVelocity m_Velocity; // 0x28

	// Properties
	public Vector3 velocity { get; set; }

	// Methods

	// RVA: 0x20664D0 Offset: 0x20665D1 VA: 0x20664D0
	public Vector3 get_velocity() { }

	// RVA: 0x20664F0 Offset: 0x20665F1 VA: 0x20664F0
	public void set_velocity(Vector3 value) { }

	// RVA: 0x2064790 Offset: 0x2064891 VA: 0x2064790
	public void Stop() { }

	// RVA: 0x2062190 Offset: 0x2062291 VA: 0x2062190 Slot: 4
	public void OnSetup(BulletBase bullet) { }

	// RVA: 0x2062B00 Offset: 0x2062C01 VA: 0x2062B00 Slot: 5
	public void OnUpdate(BulletBase bullet) { }

	// RVA: 0x2062330 Offset: 0x2062431 VA: 0x2062330 Slot: 6
	public void OnFixedUpdate(BulletBase bullet) { }

	// RVA: 0x2064830 Offset: 0x2064931 VA: 0x2064830
	public void AddForce(Vector3 force, ForceMode mode = 0) { }

	// RVA: 0x206B7E0 Offset: 0x206B8E1 VA: 0x206B7E0
	private void ApplyMovement(BulletBase bullet, MovementVelocity velocity, Vector3 desiredVelocity, float acceleration, float deltaTime) { }

	// RVA: 0x206BA10 Offset: 0x206BB11 VA: 0x206BA10
	public Vector3 MoveDeltaPosition(BulletBase bullet, Vector3 deltaPosition, float deltaTime) { }

	// RVA: 0x206BB60 Offset: 0x206BC61 VA: 0x206BB60
	private void UpdateGrounder(BulletBase bullet, Vector3 deltaPosition) { }

	// RVA: 0x206C160 Offset: 0x206C261 VA: 0x206C160
	public void .ctor() { }

	// RVA: 0x206C180 Offset: 0x206C281 VA: 0x206C180
	private static void .cctor() { }
}

