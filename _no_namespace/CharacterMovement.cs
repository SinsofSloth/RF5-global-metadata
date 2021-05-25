public class CharacterMovement : MonoBehaviour // TypeDefIndex: 6615
{
	// Fields
	[SerializeField] // RVA: 0x15DF30 Offset: 0x15E031 VA: 0x15DF30
	public CharacterMovement.MoveType moveType; // 0x18
	protected const float kBackstepDistance = 0.05;
	protected const float kMinCastDistance = 0.01;
	protected const float kMinLedgeDistance = 0.05;
	protected const float kMinStepOffset = 0.1;
	protected const float kHorizontalOffset = 0.001;
	private static readonly Collider[] OverlappedColliders; // 0x0
	[SerializeField] // RVA: 0x15DF40 Offset: 0x15E041 VA: 0x15DF40
	protected MoveParamID m_MoveParamID; // 0x1C
	[SerializeField] // RVA: 0x15DF50 Offset: 0x15E051 VA: 0x15DF50
	protected AnimationCurve m_LocomotionCurve; // 0x20
	[SerializeField] // RVA: 0x15DF60 Offset: 0x15E061 VA: 0x15DF60
	private bool m_useGravity; // 0x28
	[SerializeField] // RVA: 0x15DF70 Offset: 0x15E071 VA: 0x15DF70
	protected float m_CastDistance; // 0x2C
	[SerializeField] // RVA: 0x15DF80 Offset: 0x15E081 VA: 0x15DF80
	protected float m_AirCastDistance; // 0x30
	[SerializeField] // RVA: 0x15DF90 Offset: 0x15E091 VA: 0x15DF90
	protected bool m_EnableDetectGround; // 0x34
	[SerializeField] // RVA: 0x15DFA0 Offset: 0x15E0A1 VA: 0x15DFA0
	private UnityEvent m_onLanding; // 0x38
	[SerializeField] // RVA: 0x15DFB0 Offset: 0x15E0B1 VA: 0x15DFB0
	private UnityEvent m_onFalling; // 0x40
	[SerializeField] // RVA: 0x15DFC0 Offset: 0x15E0C1 VA: 0x15DFC0
	private UnityEvent m_onSliding; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x15DFD0 Offset: 0x15E0D1 VA: 0x15DFD0
	private CharacterMoveParam <MoveParam>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x15DFE0 Offset: 0x15E0E1 VA: 0x15DFE0
	private CharacterMoveSetting <MoveSetting>k__BackingField; // 0x58
	private float m_SlopeElapsed; // 0x60
	private const int kVelocityTypeLength = 3;
	private MovementVelocity[] m_Velocity; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x15DFF0 Offset: 0x15E0F1 VA: 0x15DFF0
	private Character <Chara>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x15E000 Offset: 0x15E101 VA: 0x15E000
	private NavMeshAgent <NavMeshAgent>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x15E010 Offset: 0x15E111 VA: 0x15E010
	private CharacterController <CharacterController>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x15E020 Offset: 0x15E121 VA: 0x15E020
	private Rigidbody <Rigidbody>k__BackingField; // 0x88
	private float m_LocomotionMinValue; // 0x90
	private bool m_isMove; // 0x94
	private bool m_isRotate; // 0x95
	private RaycastHit[] m_HitInfo; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x15E030 Offset: 0x15E131 VA: 0x15E030
	private bool <isValidGround>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x15E040 Offset: 0x15E141 VA: 0x15E040
	private bool <isOnGround>k__BackingField; // 0xA1
	[CompilerGeneratedAttribute] // RVA: 0x15E050 Offset: 0x15E151 VA: 0x15E050
	private bool <isOnStep>k__BackingField; // 0xA2
	[CompilerGeneratedAttribute] // RVA: 0x15E060 Offset: 0x15E161 VA: 0x15E060
	private bool <isOnSlope>k__BackingField; // 0xA3
	[CompilerGeneratedAttribute] // RVA: 0x15E070 Offset: 0x15E171 VA: 0x15E070
	private bool <wasOnGround>k__BackingField; // 0xA4
	[CompilerGeneratedAttribute] // RVA: 0x15E080 Offset: 0x15E181 VA: 0x15E080
	private bool <wasOnStep>k__BackingField; // 0xA5
	[CompilerGeneratedAttribute] // RVA: 0x15E090 Offset: 0x15E191 VA: 0x15E090
	private bool <wasOnSlope>k__BackingField; // 0xA6
	[CompilerGeneratedAttribute] // RVA: 0x15E0A0 Offset: 0x15E1A1 VA: 0x15E0A0
	private bool <isFalling>k__BackingField; // 0xA7
	[CompilerGeneratedAttribute] // RVA: 0x15E0B0 Offset: 0x15E1B1 VA: 0x15E0B0
	private Vector3 <GroundNormal>k__BackingField; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x15E0C0 Offset: 0x15E1C1 VA: 0x15E0C0
	private Vector3 <MoveDirection>k__BackingField; // 0xB4
	[CompilerGeneratedAttribute] // RVA: 0x15E0D0 Offset: 0x15E1D1 VA: 0x15E0D0
	private Vector3 <RotateDirection>k__BackingField; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x15E0E0 Offset: 0x15E1E1 VA: 0x15E0E0
	private Vector3 <VelocityAtLanding>k__BackingField; // 0xCC
	[CompilerGeneratedAttribute] // RVA: 0x15E0F0 Offset: 0x15E1F1 VA: 0x15E0F0
	private Collider <CapsuleCollider>k__BackingField; // 0xD8
	[CompilerGeneratedAttribute] // RVA: 0x15E100 Offset: 0x15E201 VA: 0x15E100
	private float <capsuleRadius>k__BackingField; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x15E110 Offset: 0x15E211 VA: 0x15E110
	private float <capsuleHeight>k__BackingField; // 0xE4
	[CompilerGeneratedAttribute] // RVA: 0x15E120 Offset: 0x15E221 VA: 0x15E120
	private Vector3 <capsuleCenter>k__BackingField; // 0xE8
	[CompilerGeneratedAttribute] // RVA: 0x15E130 Offset: 0x15E231 VA: 0x15E130
	private float <capsuleSkinWidth>k__BackingField; // 0xF4
	[CompilerGeneratedAttribute] // RVA: 0x15E140 Offset: 0x15E241 VA: 0x15E140
	private float <stepOffset>k__BackingField; // 0xF8
	[CompilerGeneratedAttribute] // RVA: 0x15E150 Offset: 0x15E251 VA: 0x15E150
	private LayerMask <overlapMask>k__BackingField; // 0xFC
	[CompilerGeneratedAttribute] // RVA: 0x15E160 Offset: 0x15E261 VA: 0x15E160
	private bool <enableEnemyCollision>k__BackingField; // 0x100
	public static float WalkMoveSpeed; // 0x8
	public static float CrystalMoveSpeed; // 0xC
	public static float InDoorMoveSpeed; // 0x10
	public static float InFarmMoveSpeed; // 0x14
	public static float ParalysisMoveSpeed; // 0x18
	public static float OnSpiderFlatWebMoveSpeed; // 0x1C

	// Properties
	public CharacterMoveParam MoveParam { get; set; }
	public CharacterMoveSetting MoveSetting { get; set; }
	public Character Chara { get; set; }
	private NavMeshAgent NavMeshAgent { get; set; }
	private CharacterController CharacterController { get; set; }
	private Rigidbody Rigidbody { get; set; }
	public AnimationCurve LocomotionCurve { get; }
	public bool useGravity { get; set; }
	public bool IsMove { get; }
	public bool isGrounded { get; }
	public bool isValidGround { get; set; }
	public bool isOnGround { get; set; }
	public bool isOnStep { get; set; }
	public bool isOnSlope { get; set; }
	public bool wasOnGround { get; set; }
	public bool wasOnStep { get; set; }
	public bool wasOnSlope { get; set; }
	public bool isFalling { get; set; }
	public Vector3 GroundNormal { get; set; }
	public Vector3 MoveDirection { get; set; }
	public Vector3 RotateDirection { get; set; }
	public Vector3 Velocity { get; set; }
	public Vector3 VelocityHorizon { get; }
	public Vector3 VelocityAtLanding { get; set; }
	public Collider CapsuleCollider { get; set; }
	private float capsuleRadius { get; set; }
	private float capsuleHeight { get; set; }
	private Vector3 capsuleCenter { get; set; }
	private float capsuleSkinWidth { get; set; }
	private float stepOffset { get; set; }
	private LayerMask overlapMask { get; set; }
	public bool enableEnemyCollision { get; set; }
	public static CharacterMoveSetting CharacterMoveSetting { get; }
	public static CharacterMoveParamArray CharacterMoveParamArray { get; }

	// Methods

	// RVA: 0x1E4FD20 Offset: 0x1E4FE21 VA: 0x1E4FD20
	public void SetMoveParamID(MoveParamID id) { }

	[CompilerGeneratedAttribute] // RVA: 0x19BDD0 Offset: 0x19BED1 VA: 0x19BDD0
	// RVA: 0x1E4FEF0 Offset: 0x1E4FFF1 VA: 0x1E4FEF0
	public CharacterMoveParam get_MoveParam() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BDE0 Offset: 0x19BEE1 VA: 0x19BDE0
	// RVA: 0x1E4FF00 Offset: 0x1E50001 VA: 0x1E4FF00
	protected void set_MoveParam(CharacterMoveParam value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19BDF0 Offset: 0x19BEF1 VA: 0x19BDF0
	// RVA: 0x1E4FF10 Offset: 0x1E50011 VA: 0x1E4FF10
	public CharacterMoveSetting get_MoveSetting() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BE00 Offset: 0x19BF01 VA: 0x19BE00
	// RVA: 0x1E4FF20 Offset: 0x1E50021 VA: 0x1E4FF20
	protected void set_MoveSetting(CharacterMoveSetting value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19BE10 Offset: 0x19BF11 VA: 0x19BE10
	// RVA: 0x1E4FF30 Offset: 0x1E50031 VA: 0x1E4FF30
	public Character get_Chara() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BE20 Offset: 0x19BF21 VA: 0x19BE20
	// RVA: 0x1E4FF40 Offset: 0x1E50041 VA: 0x1E4FF40
	private void set_Chara(Character value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19BE30 Offset: 0x19BF31 VA: 0x19BE30
	// RVA: 0x1E4FF50 Offset: 0x1E50051 VA: 0x1E4FF50
	private NavMeshAgent get_NavMeshAgent() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BE40 Offset: 0x19BF41 VA: 0x19BE40
	// RVA: 0x1E4FF60 Offset: 0x1E50061 VA: 0x1E4FF60
	private void set_NavMeshAgent(NavMeshAgent value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19BE50 Offset: 0x19BF51 VA: 0x19BE50
	// RVA: 0x1E4FF70 Offset: 0x1E50071 VA: 0x1E4FF70
	private CharacterController get_CharacterController() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BE60 Offset: 0x19BF61 VA: 0x19BE60
	// RVA: 0x1E4FF80 Offset: 0x1E50081 VA: 0x1E4FF80
	private void set_CharacterController(CharacterController value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19BE70 Offset: 0x19BF71 VA: 0x19BE70
	// RVA: 0x1E4FF90 Offset: 0x1E50091 VA: 0x1E4FF90
	private Rigidbody get_Rigidbody() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BE80 Offset: 0x19BF81 VA: 0x19BE80
	// RVA: 0x1E4FFA0 Offset: 0x1E500A1 VA: 0x1E4FFA0
	private void set_Rigidbody(Rigidbody value) { }

	// RVA: 0x1E4FFB0 Offset: 0x1E500B1 VA: 0x1E4FFB0
	public AnimationCurve get_LocomotionCurve() { }

	// RVA: 0x1E4FFC0 Offset: 0x1E500C1 VA: 0x1E4FFC0
	public bool get_useGravity() { }

	// RVA: 0x1E4FFD0 Offset: 0x1E500D1 VA: 0x1E4FFD0
	public void set_useGravity(bool value) { }

	// RVA: 0x1E4FFE0 Offset: 0x1E500E1 VA: 0x1E4FFE0
	public bool get_IsMove() { }

	// RVA: 0x1E50000 Offset: 0x1E50101 VA: 0x1E50000
	public bool get_isGrounded() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BE90 Offset: 0x19BF91 VA: 0x19BE90
	// RVA: 0x1E50020 Offset: 0x1E50121 VA: 0x1E50020
	public bool get_isValidGround() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BEA0 Offset: 0x19BFA1 VA: 0x19BEA0
	// RVA: 0x1E50030 Offset: 0x1E50131 VA: 0x1E50030
	private void set_isValidGround(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19BEB0 Offset: 0x19BFB1 VA: 0x19BEB0
	// RVA: 0x1E50040 Offset: 0x1E50141 VA: 0x1E50040
	public bool get_isOnGround() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BEC0 Offset: 0x19BFC1 VA: 0x19BEC0
	// RVA: 0x1E50050 Offset: 0x1E50151 VA: 0x1E50050
	protected void set_isOnGround(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19BED0 Offset: 0x19BFD1 VA: 0x19BED0
	// RVA: 0x1E50060 Offset: 0x1E50161 VA: 0x1E50060
	public bool get_isOnStep() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BEE0 Offset: 0x19BFE1 VA: 0x19BEE0
	// RVA: 0x1E50070 Offset: 0x1E50171 VA: 0x1E50070
	protected void set_isOnStep(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19BEF0 Offset: 0x19BFF1 VA: 0x19BEF0
	// RVA: 0x1E50080 Offset: 0x1E50181 VA: 0x1E50080
	public bool get_isOnSlope() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BF00 Offset: 0x19C001 VA: 0x19BF00
	// RVA: 0x1E50090 Offset: 0x1E50191 VA: 0x1E50090
	protected void set_isOnSlope(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19BF10 Offset: 0x19C011 VA: 0x19BF10
	// RVA: 0x1E500A0 Offset: 0x1E501A1 VA: 0x1E500A0
	public bool get_wasOnGround() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BF20 Offset: 0x19C021 VA: 0x19BF20
	// RVA: 0x1E500B0 Offset: 0x1E501B1 VA: 0x1E500B0
	protected void set_wasOnGround(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19BF30 Offset: 0x19C031 VA: 0x19BF30
	// RVA: 0x1E500C0 Offset: 0x1E501C1 VA: 0x1E500C0
	public bool get_wasOnStep() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BF40 Offset: 0x19C041 VA: 0x19BF40
	// RVA: 0x1E500D0 Offset: 0x1E501D1 VA: 0x1E500D0
	protected void set_wasOnStep(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19BF50 Offset: 0x19C051 VA: 0x19BF50
	// RVA: 0x1E500E0 Offset: 0x1E501E1 VA: 0x1E500E0
	public bool get_wasOnSlope() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BF60 Offset: 0x19C061 VA: 0x19BF60
	// RVA: 0x1E500F0 Offset: 0x1E501F1 VA: 0x1E500F0
	protected void set_wasOnSlope(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19BF70 Offset: 0x19C071 VA: 0x19BF70
	// RVA: 0x1E50100 Offset: 0x1E50201 VA: 0x1E50100
	public bool get_isFalling() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BF80 Offset: 0x19C081 VA: 0x19BF80
	// RVA: 0x1E50110 Offset: 0x1E50211 VA: 0x1E50110
	protected void set_isFalling(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19BF90 Offset: 0x19C091 VA: 0x19BF90
	// RVA: 0x1E50120 Offset: 0x1E50221 VA: 0x1E50120
	public Vector3 get_GroundNormal() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BFA0 Offset: 0x19C0A1 VA: 0x19BFA0
	// RVA: 0x1E50130 Offset: 0x1E50231 VA: 0x1E50130
	private void set_GroundNormal(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19BFB0 Offset: 0x19C0B1 VA: 0x19BFB0
	// RVA: 0x1E50140 Offset: 0x1E50241 VA: 0x1E50140
	public Vector3 get_MoveDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BFC0 Offset: 0x19C0C1 VA: 0x19BFC0
	// RVA: 0x1E50150 Offset: 0x1E50251 VA: 0x1E50150
	public void set_MoveDirection(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19BFD0 Offset: 0x19C0D1 VA: 0x19BFD0
	// RVA: 0x1E50160 Offset: 0x1E50261 VA: 0x1E50160
	public Vector3 get_RotateDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BFE0 Offset: 0x19C0E1 VA: 0x19BFE0
	// RVA: 0x1E50170 Offset: 0x1E50271 VA: 0x1E50170
	public void set_RotateDirection(Vector3 value) { }

	// RVA: 0x1E50180 Offset: 0x1E50281 VA: 0x1E50180
	public Vector3 get_Velocity() { }

	// RVA: 0x1E501C0 Offset: 0x1E502C1 VA: 0x1E501C0
	public void set_Velocity(Vector3 value) { }

	// RVA: 0x1E50200 Offset: 0x1E50301 VA: 0x1E50200
	public Vector3 get_VelocityHorizon() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BFF0 Offset: 0x19C0F1 VA: 0x19BFF0
	// RVA: 0x1E502D0 Offset: 0x1E503D1 VA: 0x1E502D0
	public Vector3 get_VelocityAtLanding() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C000 Offset: 0x19C101 VA: 0x19C000
	// RVA: 0x1E502E0 Offset: 0x1E503E1 VA: 0x1E502E0
	private void set_VelocityAtLanding(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C010 Offset: 0x19C111 VA: 0x19C010
	// RVA: 0x1E502F0 Offset: 0x1E503F1 VA: 0x1E502F0
	public Collider get_CapsuleCollider() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C020 Offset: 0x19C121 VA: 0x19C020
	// RVA: 0x1E50300 Offset: 0x1E50401 VA: 0x1E50300
	public void set_CapsuleCollider(Collider value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C030 Offset: 0x19C131 VA: 0x19C030
	// RVA: 0x1E50310 Offset: 0x1E50411 VA: 0x1E50310
	private float get_capsuleRadius() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C040 Offset: 0x19C141 VA: 0x19C040
	// RVA: 0x1E50320 Offset: 0x1E50421 VA: 0x1E50320
	private void set_capsuleRadius(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C050 Offset: 0x19C151 VA: 0x19C050
	// RVA: 0x1E50330 Offset: 0x1E50431 VA: 0x1E50330
	private float get_capsuleHeight() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C060 Offset: 0x19C161 VA: 0x19C060
	// RVA: 0x1E50340 Offset: 0x1E50441 VA: 0x1E50340
	private void set_capsuleHeight(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C070 Offset: 0x19C171 VA: 0x19C070
	// RVA: 0x1E50350 Offset: 0x1E50451 VA: 0x1E50350
	private Vector3 get_capsuleCenter() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C080 Offset: 0x19C181 VA: 0x19C080
	// RVA: 0x1E50360 Offset: 0x1E50461 VA: 0x1E50360
	private void set_capsuleCenter(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C090 Offset: 0x19C191 VA: 0x19C090
	// RVA: 0x1E50370 Offset: 0x1E50471 VA: 0x1E50370
	private float get_capsuleSkinWidth() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C0A0 Offset: 0x19C1A1 VA: 0x19C0A0
	// RVA: 0x1E50380 Offset: 0x1E50481 VA: 0x1E50380
	private void set_capsuleSkinWidth(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C0B0 Offset: 0x19C1B1 VA: 0x19C0B0
	// RVA: 0x1E50390 Offset: 0x1E50491 VA: 0x1E50390
	private float get_stepOffset() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C0C0 Offset: 0x19C1C1 VA: 0x19C0C0
	// RVA: 0x1E503A0 Offset: 0x1E504A1 VA: 0x1E503A0
	private void set_stepOffset(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C0D0 Offset: 0x19C1D1 VA: 0x19C0D0
	// RVA: 0x1E503B0 Offset: 0x1E504B1 VA: 0x1E503B0
	private LayerMask get_overlapMask() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C0E0 Offset: 0x19C1E1 VA: 0x19C0E0
	// RVA: 0x1E503C0 Offset: 0x1E504C1 VA: 0x1E503C0
	private void set_overlapMask(LayerMask value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C0F0 Offset: 0x19C1F1 VA: 0x19C0F0
	// RVA: 0x1E503D0 Offset: 0x1E504D1 VA: 0x1E503D0
	public bool get_enableEnemyCollision() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C100 Offset: 0x19C201 VA: 0x19C100
	// RVA: 0x1E503E0 Offset: 0x1E504E1 VA: 0x1E503E0
	public void set_enableEnemyCollision(bool value) { }

	// RVA: 0x1E503F0 Offset: 0x1E504F1 VA: 0x1E503F0
	public static CharacterMoveSetting get_CharacterMoveSetting() { }

	// RVA: 0x1E4FE40 Offset: 0x1E4FF41 VA: 0x1E4FE40
	public static CharacterMoveParamArray get_CharacterMoveParamArray() { }

	// RVA: 0x1E504A0 Offset: 0x1E505A1 VA: 0x1E504A0
	public void Init(CharacterController controller) { }

	// RVA: 0x1E505F0 Offset: 0x1E506F1 VA: 0x1E505F0
	public void Init(Collider collider, Rigidbody rigidbody) { }

	// RVA: 0x1E50770 Offset: 0x1E50871 VA: 0x1E50770
	public void Init(Collider collider, NavMeshAgent agent) { }

	// RVA: 0x1E50920 Offset: 0x1E50A21 VA: 0x1E50920
	private void Awake() { }

	// RVA: 0x1E50DB0 Offset: 0x1E50EB1 VA: 0x1E50DB0
	protected void Start() { }

	// RVA: 0x1E50E50 Offset: 0x1E50F51 VA: 0x1E50E50
	public void OnEnable() { }

	// RVA: 0x1E50E60 Offset: 0x1E50F61 VA: 0x1E50E60
	public void OnDisable() { }

	// RVA: 0x1E50E70 Offset: 0x1E50F71 VA: 0x1E50E70 Slot: 4
	public virtual void Rotate(float angularSpeed, float deltaTime, bool onlyLateral = True) { }

	// RVA: 0x1E51000 Offset: 0x1E51101 VA: 0x1E51000
	public void ResetOnGround() { }

	// RVA: 0x1E51010 Offset: 0x1E51111 VA: 0x1E51010 Slot: 5
	public virtual void Move(float maxSpeed, float acceleration, float deceleration, float deltaTime, bool onlyLateral = True) { }

	// RVA: 0x1E528A0 Offset: 0x1E529A1 VA: 0x1E528A0
	private void LimitLateralVelocity(float maxSpeed) { }

	// RVA: 0x1E51790 Offset: 0x1E51891 VA: 0x1E51790
	public void DetectGround(float deltaTime) { }

	// RVA: 0x1E52670 Offset: 0x1E52771 VA: 0x1E52670
	private void ApplyMovement(MovementVelocity velocity, Vector3 desiredVelocity, float maxSpeed, float acceleration, float deceleration, float deltaTime) { }

	// RVA: 0x1E52F20 Offset: 0x1E53021 VA: 0x1E52F20
	public Vector3 MoveDeltaPosition(Vector3 deltaPosition, float deltaTime) { }

	// RVA: 0x1E52E50 Offset: 0x1E52F51 VA: 0x1E52E50
	public void ClearVelocityAll() { }

	// RVA: 0x1E54140 Offset: 0x1E54241 VA: 0x1E54140
	public void ClearVelocity(CharacterMovement.VelocityType type) { }

	// RVA: 0x1E541F0 Offset: 0x1E542F1 VA: 0x1E541F0
	public Vector3 GetVelocity(CharacterMovement.VelocityType type = 0) { }

	// RVA: 0x1E54240 Offset: 0x1E54341 VA: 0x1E54240
	public void SetVelocity(Vector3 velocity, CharacterMovement.VelocityType type = 0) { }

	// RVA: 0x1E54290 Offset: 0x1E54391 VA: 0x1E54290
	public void ClearForceAll() { }

	// RVA: 0x1E52E00 Offset: 0x1E52F01 VA: 0x1E52E00
	public void ClearForce(CharacterMovement.VelocityType type = 0) { }

	// RVA: 0x1E516B0 Offset: 0x1E517B1 VA: 0x1E516B0
	public void AddForce(Vector3 force, ForceMode mode = 0, CharacterMovement.VelocityType type = 0) { }

	// RVA: 0x1E51700 Offset: 0x1E51801 VA: 0x1E51700
	private void ApplyForceAll(float deltaTime) { }

	// RVA: 0x1E52CA0 Offset: 0x1E52DA1 VA: 0x1E52CA0
	protected bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float distance, LayerMask layerMask, float backstepDistance = 0.05) { }

	// RVA: 0x1E52A70 Offset: 0x1E52B71 VA: 0x1E52A70
	protected bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float distance, LayerMask layerMask, float backstepDistance = 0.05) { }

	// RVA: 0x1E53CE0 Offset: 0x1E53DE1 VA: 0x1E53CE0
	protected bool CapsuleCast(Vector3 bottom, Vector3 top, float radius, Vector3 direction, out RaycastHit hitInfo, float distance, LayerMask layerMask, float backstepDistance = 0.05) { }

	// RVA: 0x1E54300 Offset: 0x1E54401 VA: 0x1E54300
	public Collider[] OverlapCapsule(Vector3 position, Quaternion rotation, out int overlapCount) { }

	[IteratorStateMachineAttribute] // RVA: 0x19C110 Offset: 0x19C211 VA: 0x19C110
	// RVA: 0x1E54750 Offset: 0x1E54851 VA: 0x1E54750
	private IEnumerator LateFixedUpdate() { }

	// RVA: 0x1E54800 Offset: 0x1E54901 VA: 0x1E54800
	private void OverlapRecovery(ref Vector3 probingPosition, Quaternion probingRotation) { }

	// RVA: 0x1E54BC0 Offset: 0x1E54CC1 VA: 0x1E54BC0
	public bool IsReverseMove(Vector3 vector) { }

	// RVA: 0x1E54D90 Offset: 0x1E54E91 VA: 0x1E54D90
	public float GetAcceleration() { }

	// RVA: 0x1E54F60 Offset: 0x1E55061 VA: 0x1E54F60
	public float GetRotateSpeed() { }

	// RVA: 0x1E54E80 Offset: 0x1E54F81 VA: 0x1E54E80
	public float GetAcceleration(float min, float max, float rate) { }

	// RVA: 0x1E55060 Offset: 0x1E55161 VA: 0x1E55060
	public float GetRotateSpeed(float min, float max, float rate) { }

	// RVA: 0x1E52590 Offset: 0x1E52691 VA: 0x1E52590
	public float CalcSlopRate(float min, float max, float slope) { }

	// RVA: 0x1E52BD0 Offset: 0x1E52CD1 VA: 0x1E52BD0
	public float GetSlopeDef() { }

	// RVA: 0x1E52BF0 Offset: 0x1E52CF1 VA: 0x1E52BF0
	public float GetSlopeLimit(float elapsed) { }

	// RVA: 0x1E55140 Offset: 0x1E55241 VA: 0x1E55140
	public static void SwapMoveParam(MoveParamID id, CharacterMoveParam param) { }

	// RVA: 0x1E55380 Offset: 0x1E55481 VA: 0x1E55380
	public float GetLocomotionValue(float value) { }

	// RVA: 0x1E55420 Offset: 0x1E55521 VA: 0x1E55420
	public void .ctor() { }

	// RVA: 0x1E55510 Offset: 0x1E55611 VA: 0x1E55510
	private static void .cctor() { }
}

