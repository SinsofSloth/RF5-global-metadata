public class CharacterThirdPerson : CharacterBase // TypeDefIndex: 9399
{
	// Fields
	[HeaderAttribute] // RVA: 0x178A10 Offset: 0x178B11 VA: 0x178A10
	public CharacterAnimationBase characterAnimation; // 0x68
	public UserControlThirdPerson userControl; // 0x70
	public CameraController cam; // 0x78
	[HeaderAttribute] // RVA: 0x178A50 Offset: 0x178B51 VA: 0x178A50
	public CharacterThirdPerson.MoveMode moveMode; // 0x80
	public bool smoothPhysics; // 0x84
	public float smoothAccelerationTime; // 0x88
	public float linearAccelerationSpeed; // 0x8C
	public float platformFriction; // 0x90
	public float groundStickyEffect; // 0x94
	public float maxVerticalVelocityOnGround; // 0x98
	public float velocityToGroundTangentWeight; // 0x9C
	[HeaderAttribute] // RVA: 0x178A90 Offset: 0x178B91 VA: 0x178A90
	public bool lookInCameraDirection; // 0xA0
	public float turnSpeed; // 0xA4
	public float stationaryTurnSpeedMlp; // 0xA8
	[HeaderAttribute] // RVA: 0x178AD0 Offset: 0x178BD1 VA: 0x178AD0
	public bool smoothJump; // 0xAC
	public float airSpeed; // 0xB0
	public float airControl; // 0xB4
	public float jumpPower; // 0xB8
	public float jumpRepeatDelayTime; // 0xBC
	public bool doubleJumpEnabled; // 0xC0
	public float doubleJumpPowerMlp; // 0xC4
	[HeaderAttribute] // RVA: 0x178B10 Offset: 0x178C11 VA: 0x178B10
	public LayerMask wallRunLayers; // 0xC8
	public float wallRunMaxLength; // 0xCC
	public float wallRunMinMoveMag; // 0xD0
	public float wallRunMinVelocityY; // 0xD4
	public float wallRunRotationSpeed; // 0xD8
	public float wallRunMaxRotationAngle; // 0xDC
	public float wallRunWeightSpeed; // 0xE0
	[HeaderAttribute] // RVA: 0x178B50 Offset: 0x178C51 VA: 0x178B50
	public float crouchCapsuleScaleMlp; // 0xE4
	[CompilerGeneratedAttribute] // RVA: 0x178B90 Offset: 0x178C91 VA: 0x178B90
	private bool <onGround>k__BackingField; // 0xE8
	public CharacterThirdPerson.AnimState animState; // 0xEC
	protected Vector3 moveDirection; // 0x104
	private Animator animator; // 0x110
	private Vector3 normal; // 0x118
	private Vector3 platformVelocity; // 0x124
	private Vector3 platformAngularVelocity; // 0x130
	private RaycastHit hit; // 0x13C
	private float jumpLeg; // 0x168
	private float jumpEndTime; // 0x16C
	private float forwardMlp; // 0x170
	private float groundDistance; // 0x174
	private float lastAirTime; // 0x178
	private float stickyForce; // 0x17C
	private Vector3 wallNormal; // 0x180
	private Vector3 moveDirectionVelocity; // 0x18C
	private float wallRunWeight; // 0x198
	private float lastWallRunWeight; // 0x19C
	private Vector3 fixedDeltaPosition; // 0x1A0
	private Quaternion fixedDeltaRotation; // 0x1AC
	private bool fixedFrame; // 0x1BC
	private float wallRunEndTime; // 0x1C0
	private Vector3 gravity; // 0x1C4
	private Vector3 verticalVelocity; // 0x1D0
	private float velocityY; // 0x1DC
	private bool doubleJumped; // 0x1E0
	private bool jumpReleased; // 0x1E1

	// Properties
	public bool onGround { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AA140 Offset: 0x1AA241 VA: 0x1AA140
	// RVA: 0x26C3380 Offset: 0x26C3481 VA: 0x26C3380
	public bool get_onGround() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AA150 Offset: 0x1AA251 VA: 0x1AA150
	// RVA: 0x26C3390 Offset: 0x26C3491 VA: 0x26C3390
	private void set_onGround(bool value) { }

	// RVA: 0x26C33A0 Offset: 0x26C34A1 VA: 0x26C33A0 Slot: 5
	protected override void Start() { }

	// RVA: 0x26C3550 Offset: 0x26C3651 VA: 0x26C3550
	private void OnAnimatorMove() { }

	// RVA: 0x26C35F0 Offset: 0x26C36F1 VA: 0x26C35F0 Slot: 4
	public override void Move(Vector3 deltaPosition, Quaternion deltaRotation) { }

	// RVA: 0x26C3730 Offset: 0x26C3831 VA: 0x26C3730
	private void FixedUpdate() { }

	// RVA: 0x26C46C0 Offset: 0x26C47C1 VA: 0x26C46C0 Slot: 7
	protected virtual void Update() { }

	// RVA: 0x26C4A60 Offset: 0x26C4B61 VA: 0x26C4A60 Slot: 8
	protected virtual void LateUpdate() { }

	// RVA: 0x26C3D70 Offset: 0x26C3E71 VA: 0x26C3D70
	private void MoveFixed(Vector3 deltaPosition) { }

	// RVA: 0x26C4B40 Offset: 0x26C4C41 VA: 0x26C4B40
	private void WallRun() { }

	// RVA: 0x26C51A0 Offset: 0x26C52A1 VA: 0x26C51A0
	private bool CanWallRun() { }

	// RVA: 0x26C47A0 Offset: 0x26C48A1 VA: 0x26C47A0
	private Vector3 GetMoveDirection() { }

	// RVA: 0x26C5250 Offset: 0x26C5351 VA: 0x26C5250 Slot: 9
	protected virtual void Rotate() { }

	// RVA: 0x26C56C0 Offset: 0x26C57C1 VA: 0x26C56C0
	private Vector3 GetForwardDirection() { }

	// RVA: 0x26C5850 Offset: 0x26C5951 VA: 0x26C5850 Slot: 10
	protected virtual bool Jump() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AA160 Offset: 0x1AA261 VA: 0x1AA160
	// RVA: 0x26C5AD0 Offset: 0x26C5BD1 VA: 0x26C5AD0
	private IEnumerator JumpSmooth(Vector3 jumpVelocity) { }

	// RVA: 0x26C4280 Offset: 0x26C4381 VA: 0x26C4280
	private void GroundCheck() { }

	// RVA: 0x26C5BA0 Offset: 0x26C5CA1 VA: 0x26C5BA0
	public void .ctor() { }
}

public class CharacterThirdPerson : CharacterBase // TypeDefIndex: 9399
{
	// Fields
	[HeaderAttribute] // RVA: 0x178A10 Offset: 0x178B11 VA: 0x178A10
	public CharacterAnimationBase characterAnimation; // 0x68
	public UserControlThirdPerson userControl; // 0x70
	public CameraController cam; // 0x78
	[HeaderAttribute] // RVA: 0x178A50 Offset: 0x178B51 VA: 0x178A50
	public CharacterThirdPerson.MoveMode moveMode; // 0x80
	public bool smoothPhysics; // 0x84
	public float smoothAccelerationTime; // 0x88
	public float linearAccelerationSpeed; // 0x8C
	public float platformFriction; // 0x90
	public float groundStickyEffect; // 0x94
	public float maxVerticalVelocityOnGround; // 0x98
	public float velocityToGroundTangentWeight; // 0x9C
	[HeaderAttribute] // RVA: 0x178A90 Offset: 0x178B91 VA: 0x178A90
	public bool lookInCameraDirection; // 0xA0
	public float turnSpeed; // 0xA4
	public float stationaryTurnSpeedMlp; // 0xA8
	[HeaderAttribute] // RVA: 0x178AD0 Offset: 0x178BD1 VA: 0x178AD0
	public bool smoothJump; // 0xAC
	public float airSpeed; // 0xB0
	public float airControl; // 0xB4
	public float jumpPower; // 0xB8
	public float jumpRepeatDelayTime; // 0xBC
	public bool doubleJumpEnabled; // 0xC0
	public float doubleJumpPowerMlp; // 0xC4
	[HeaderAttribute] // RVA: 0x178B10 Offset: 0x178C11 VA: 0x178B10
	public LayerMask wallRunLayers; // 0xC8
	public float wallRunMaxLength; // 0xCC
	public float wallRunMinMoveMag; // 0xD0
	public float wallRunMinVelocityY; // 0xD4
	public float wallRunRotationSpeed; // 0xD8
	public float wallRunMaxRotationAngle; // 0xDC
	public float wallRunWeightSpeed; // 0xE0
	[HeaderAttribute] // RVA: 0x178B50 Offset: 0x178C51 VA: 0x178B50
	public float crouchCapsuleScaleMlp; // 0xE4
	[CompilerGeneratedAttribute] // RVA: 0x178B90 Offset: 0x178C91 VA: 0x178B90
	private bool <onGround>k__BackingField; // 0xE8
	public CharacterThirdPerson.AnimState animState; // 0xEC
	protected Vector3 moveDirection; // 0x104
	private Animator animator; // 0x110
	private Vector3 normal; // 0x118
	private Vector3 platformVelocity; // 0x124
	private Vector3 platformAngularVelocity; // 0x130
	private RaycastHit hit; // 0x13C
	private float jumpLeg; // 0x168
	private float jumpEndTime; // 0x16C
	private float forwardMlp; // 0x170
	private float groundDistance; // 0x174
	private float lastAirTime; // 0x178
	private float stickyForce; // 0x17C
	private Vector3 wallNormal; // 0x180
	private Vector3 moveDirectionVelocity; // 0x18C
	private float wallRunWeight; // 0x198
	private float lastWallRunWeight; // 0x19C
	private Vector3 fixedDeltaPosition; // 0x1A0
	private Quaternion fixedDeltaRotation; // 0x1AC
	private bool fixedFrame; // 0x1BC
	private float wallRunEndTime; // 0x1C0
	private Vector3 gravity; // 0x1C4
	private Vector3 verticalVelocity; // 0x1D0
	private float velocityY; // 0x1DC
	private bool doubleJumped; // 0x1E0
	private bool jumpReleased; // 0x1E1

	// Properties
	public bool onGround { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AA140 Offset: 0x1AA241 VA: 0x1AA140
	// RVA: 0x26C3380 Offset: 0x26C3481 VA: 0x26C3380
	public bool get_onGround() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AA150 Offset: 0x1AA251 VA: 0x1AA150
	// RVA: 0x26C3390 Offset: 0x26C3491 VA: 0x26C3390
	private void set_onGround(bool value) { }

	// RVA: 0x26C33A0 Offset: 0x26C34A1 VA: 0x26C33A0 Slot: 5
	protected override void Start() { }

	// RVA: 0x26C3550 Offset: 0x26C3651 VA: 0x26C3550
	private void OnAnimatorMove() { }

	// RVA: 0x26C35F0 Offset: 0x26C36F1 VA: 0x26C35F0 Slot: 4
	public override void Move(Vector3 deltaPosition, Quaternion deltaRotation) { }

	// RVA: 0x26C3730 Offset: 0x26C3831 VA: 0x26C3730
	private void FixedUpdate() { }

	// RVA: 0x26C46C0 Offset: 0x26C47C1 VA: 0x26C46C0 Slot: 7
	protected virtual void Update() { }

	// RVA: 0x26C4A60 Offset: 0x26C4B61 VA: 0x26C4A60 Slot: 8
	protected virtual void LateUpdate() { }

	// RVA: 0x26C3D70 Offset: 0x26C3E71 VA: 0x26C3D70
	private void MoveFixed(Vector3 deltaPosition) { }

	// RVA: 0x26C4B40 Offset: 0x26C4C41 VA: 0x26C4B40
	private void WallRun() { }

	// RVA: 0x26C51A0 Offset: 0x26C52A1 VA: 0x26C51A0
	private bool CanWallRun() { }

	// RVA: 0x26C47A0 Offset: 0x26C48A1 VA: 0x26C47A0
	private Vector3 GetMoveDirection() { }

	// RVA: 0x26C5250 Offset: 0x26C5351 VA: 0x26C5250 Slot: 9
	protected virtual void Rotate() { }

	// RVA: 0x26C56C0 Offset: 0x26C57C1 VA: 0x26C56C0
	private Vector3 GetForwardDirection() { }

	// RVA: 0x26C5850 Offset: 0x26C5951 VA: 0x26C5850 Slot: 10
	protected virtual bool Jump() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AA160 Offset: 0x1AA261 VA: 0x1AA160
	// RVA: 0x26C5AD0 Offset: 0x26C5BD1 VA: 0x26C5AD0
	private IEnumerator JumpSmooth(Vector3 jumpVelocity) { }

	// RVA: 0x26C4280 Offset: 0x26C4381 VA: 0x26C4280
	private void GroundCheck() { }

	// RVA: 0x26C5BA0 Offset: 0x26C5CA1 VA: 0x26C5BA0
	public void .ctor() { }
}

public class CharacterThirdPerson : CharacterBase // TypeDefIndex: 9399
{
	// Fields
	[HeaderAttribute] // RVA: 0x178A10 Offset: 0x178B11 VA: 0x178A10
	public CharacterAnimationBase characterAnimation; // 0x68
	public UserControlThirdPerson userControl; // 0x70
	public CameraController cam; // 0x78
	[HeaderAttribute] // RVA: 0x178A50 Offset: 0x178B51 VA: 0x178A50
	public CharacterThirdPerson.MoveMode moveMode; // 0x80
	public bool smoothPhysics; // 0x84
	public float smoothAccelerationTime; // 0x88
	public float linearAccelerationSpeed; // 0x8C
	public float platformFriction; // 0x90
	public float groundStickyEffect; // 0x94
	public float maxVerticalVelocityOnGround; // 0x98
	public float velocityToGroundTangentWeight; // 0x9C
	[HeaderAttribute] // RVA: 0x178A90 Offset: 0x178B91 VA: 0x178A90
	public bool lookInCameraDirection; // 0xA0
	public float turnSpeed; // 0xA4
	public float stationaryTurnSpeedMlp; // 0xA8
	[HeaderAttribute] // RVA: 0x178AD0 Offset: 0x178BD1 VA: 0x178AD0
	public bool smoothJump; // 0xAC
	public float airSpeed; // 0xB0
	public float airControl; // 0xB4
	public float jumpPower; // 0xB8
	public float jumpRepeatDelayTime; // 0xBC
	public bool doubleJumpEnabled; // 0xC0
	public float doubleJumpPowerMlp; // 0xC4
	[HeaderAttribute] // RVA: 0x178B10 Offset: 0x178C11 VA: 0x178B10
	public LayerMask wallRunLayers; // 0xC8
	public float wallRunMaxLength; // 0xCC
	public float wallRunMinMoveMag; // 0xD0
	public float wallRunMinVelocityY; // 0xD4
	public float wallRunRotationSpeed; // 0xD8
	public float wallRunMaxRotationAngle; // 0xDC
	public float wallRunWeightSpeed; // 0xE0
	[HeaderAttribute] // RVA: 0x178B50 Offset: 0x178C51 VA: 0x178B50
	public float crouchCapsuleScaleMlp; // 0xE4
	[CompilerGeneratedAttribute] // RVA: 0x178B90 Offset: 0x178C91 VA: 0x178B90
	private bool <onGround>k__BackingField; // 0xE8
	public CharacterThirdPerson.AnimState animState; // 0xEC
	protected Vector3 moveDirection; // 0x104
	private Animator animator; // 0x110
	private Vector3 normal; // 0x118
	private Vector3 platformVelocity; // 0x124
	private Vector3 platformAngularVelocity; // 0x130
	private RaycastHit hit; // 0x13C
	private float jumpLeg; // 0x168
	private float jumpEndTime; // 0x16C
	private float forwardMlp; // 0x170
	private float groundDistance; // 0x174
	private float lastAirTime; // 0x178
	private float stickyForce; // 0x17C
	private Vector3 wallNormal; // 0x180
	private Vector3 moveDirectionVelocity; // 0x18C
	private float wallRunWeight; // 0x198
	private float lastWallRunWeight; // 0x19C
	private Vector3 fixedDeltaPosition; // 0x1A0
	private Quaternion fixedDeltaRotation; // 0x1AC
	private bool fixedFrame; // 0x1BC
	private float wallRunEndTime; // 0x1C0
	private Vector3 gravity; // 0x1C4
	private Vector3 verticalVelocity; // 0x1D0
	private float velocityY; // 0x1DC
	private bool doubleJumped; // 0x1E0
	private bool jumpReleased; // 0x1E1

	// Properties
	public bool onGround { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AA140 Offset: 0x1AA241 VA: 0x1AA140
	// RVA: 0x26C3380 Offset: 0x26C3481 VA: 0x26C3380
	public bool get_onGround() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AA150 Offset: 0x1AA251 VA: 0x1AA150
	// RVA: 0x26C3390 Offset: 0x26C3491 VA: 0x26C3390
	private void set_onGround(bool value) { }

	// RVA: 0x26C33A0 Offset: 0x26C34A1 VA: 0x26C33A0 Slot: 5
	protected override void Start() { }

	// RVA: 0x26C3550 Offset: 0x26C3651 VA: 0x26C3550
	private void OnAnimatorMove() { }

	// RVA: 0x26C35F0 Offset: 0x26C36F1 VA: 0x26C35F0 Slot: 4
	public override void Move(Vector3 deltaPosition, Quaternion deltaRotation) { }

	// RVA: 0x26C3730 Offset: 0x26C3831 VA: 0x26C3730
	private void FixedUpdate() { }

	// RVA: 0x26C46C0 Offset: 0x26C47C1 VA: 0x26C46C0 Slot: 7
	protected virtual void Update() { }

	// RVA: 0x26C4A60 Offset: 0x26C4B61 VA: 0x26C4A60 Slot: 8
	protected virtual void LateUpdate() { }

	// RVA: 0x26C3D70 Offset: 0x26C3E71 VA: 0x26C3D70
	private void MoveFixed(Vector3 deltaPosition) { }

	// RVA: 0x26C4B40 Offset: 0x26C4C41 VA: 0x26C4B40
	private void WallRun() { }

	// RVA: 0x26C51A0 Offset: 0x26C52A1 VA: 0x26C51A0
	private bool CanWallRun() { }

	// RVA: 0x26C47A0 Offset: 0x26C48A1 VA: 0x26C47A0
	private Vector3 GetMoveDirection() { }

	// RVA: 0x26C5250 Offset: 0x26C5351 VA: 0x26C5250 Slot: 9
	protected virtual void Rotate() { }

	// RVA: 0x26C56C0 Offset: 0x26C57C1 VA: 0x26C56C0
	private Vector3 GetForwardDirection() { }

	// RVA: 0x26C5850 Offset: 0x26C5951 VA: 0x26C5850 Slot: 10
	protected virtual bool Jump() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AA160 Offset: 0x1AA261 VA: 0x1AA160
	// RVA: 0x26C5AD0 Offset: 0x26C5BD1 VA: 0x26C5AD0
	private IEnumerator JumpSmooth(Vector3 jumpVelocity) { }

	// RVA: 0x26C4280 Offset: 0x26C4381 VA: 0x26C4280
	private void GroundCheck() { }

	// RVA: 0x26C5BA0 Offset: 0x26C5CA1 VA: 0x26C5BA0
	public void .ctor() { }
}

public class CharacterThirdPerson : CharacterBase // TypeDefIndex: 9399
{
	// Fields
	[HeaderAttribute] // RVA: 0x178A10 Offset: 0x178B11 VA: 0x178A10
	public CharacterAnimationBase characterAnimation; // 0x68
	public UserControlThirdPerson userControl; // 0x70
	public CameraController cam; // 0x78
	[HeaderAttribute] // RVA: 0x178A50 Offset: 0x178B51 VA: 0x178A50
	public CharacterThirdPerson.MoveMode moveMode; // 0x80
	public bool smoothPhysics; // 0x84
	public float smoothAccelerationTime; // 0x88
	public float linearAccelerationSpeed; // 0x8C
	public float platformFriction; // 0x90
	public float groundStickyEffect; // 0x94
	public float maxVerticalVelocityOnGround; // 0x98
	public float velocityToGroundTangentWeight; // 0x9C
	[HeaderAttribute] // RVA: 0x178A90 Offset: 0x178B91 VA: 0x178A90
	public bool lookInCameraDirection; // 0xA0
	public float turnSpeed; // 0xA4
	public float stationaryTurnSpeedMlp; // 0xA8
	[HeaderAttribute] // RVA: 0x178AD0 Offset: 0x178BD1 VA: 0x178AD0
	public bool smoothJump; // 0xAC
	public float airSpeed; // 0xB0
	public float airControl; // 0xB4
	public float jumpPower; // 0xB8
	public float jumpRepeatDelayTime; // 0xBC
	public bool doubleJumpEnabled; // 0xC0
	public float doubleJumpPowerMlp; // 0xC4
	[HeaderAttribute] // RVA: 0x178B10 Offset: 0x178C11 VA: 0x178B10
	public LayerMask wallRunLayers; // 0xC8
	public float wallRunMaxLength; // 0xCC
	public float wallRunMinMoveMag; // 0xD0
	public float wallRunMinVelocityY; // 0xD4
	public float wallRunRotationSpeed; // 0xD8
	public float wallRunMaxRotationAngle; // 0xDC
	public float wallRunWeightSpeed; // 0xE0
	[HeaderAttribute] // RVA: 0x178B50 Offset: 0x178C51 VA: 0x178B50
	public float crouchCapsuleScaleMlp; // 0xE4
	[CompilerGeneratedAttribute] // RVA: 0x178B90 Offset: 0x178C91 VA: 0x178B90
	private bool <onGround>k__BackingField; // 0xE8
	public CharacterThirdPerson.AnimState animState; // 0xEC
	protected Vector3 moveDirection; // 0x104
	private Animator animator; // 0x110
	private Vector3 normal; // 0x118
	private Vector3 platformVelocity; // 0x124
	private Vector3 platformAngularVelocity; // 0x130
	private RaycastHit hit; // 0x13C
	private float jumpLeg; // 0x168
	private float jumpEndTime; // 0x16C
	private float forwardMlp; // 0x170
	private float groundDistance; // 0x174
	private float lastAirTime; // 0x178
	private float stickyForce; // 0x17C
	private Vector3 wallNormal; // 0x180
	private Vector3 moveDirectionVelocity; // 0x18C
	private float wallRunWeight; // 0x198
	private float lastWallRunWeight; // 0x19C
	private Vector3 fixedDeltaPosition; // 0x1A0
	private Quaternion fixedDeltaRotation; // 0x1AC
	private bool fixedFrame; // 0x1BC
	private float wallRunEndTime; // 0x1C0
	private Vector3 gravity; // 0x1C4
	private Vector3 verticalVelocity; // 0x1D0
	private float velocityY; // 0x1DC
	private bool doubleJumped; // 0x1E0
	private bool jumpReleased; // 0x1E1

	// Properties
	public bool onGround { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AA140 Offset: 0x1AA241 VA: 0x1AA140
	// RVA: 0x26C3380 Offset: 0x26C3481 VA: 0x26C3380
	public bool get_onGround() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AA150 Offset: 0x1AA251 VA: 0x1AA150
	// RVA: 0x26C3390 Offset: 0x26C3491 VA: 0x26C3390
	private void set_onGround(bool value) { }

	// RVA: 0x26C33A0 Offset: 0x26C34A1 VA: 0x26C33A0 Slot: 5
	protected override void Start() { }

	// RVA: 0x26C3550 Offset: 0x26C3651 VA: 0x26C3550
	private void OnAnimatorMove() { }

	// RVA: 0x26C35F0 Offset: 0x26C36F1 VA: 0x26C35F0 Slot: 4
	public override void Move(Vector3 deltaPosition, Quaternion deltaRotation) { }

	// RVA: 0x26C3730 Offset: 0x26C3831 VA: 0x26C3730
	private void FixedUpdate() { }

	// RVA: 0x26C46C0 Offset: 0x26C47C1 VA: 0x26C46C0 Slot: 7
	protected virtual void Update() { }

	// RVA: 0x26C4A60 Offset: 0x26C4B61 VA: 0x26C4A60 Slot: 8
	protected virtual void LateUpdate() { }

	// RVA: 0x26C3D70 Offset: 0x26C3E71 VA: 0x26C3D70
	private void MoveFixed(Vector3 deltaPosition) { }

	// RVA: 0x26C4B40 Offset: 0x26C4C41 VA: 0x26C4B40
	private void WallRun() { }

	// RVA: 0x26C51A0 Offset: 0x26C52A1 VA: 0x26C51A0
	private bool CanWallRun() { }

	// RVA: 0x26C47A0 Offset: 0x26C48A1 VA: 0x26C47A0
	private Vector3 GetMoveDirection() { }

	// RVA: 0x26C5250 Offset: 0x26C5351 VA: 0x26C5250 Slot: 9
	protected virtual void Rotate() { }

	// RVA: 0x26C56C0 Offset: 0x26C57C1 VA: 0x26C56C0
	private Vector3 GetForwardDirection() { }

	// RVA: 0x26C5850 Offset: 0x26C5951 VA: 0x26C5850 Slot: 10
	protected virtual bool Jump() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AA160 Offset: 0x1AA261 VA: 0x1AA160
	// RVA: 0x26C5AD0 Offset: 0x26C5BD1 VA: 0x26C5AD0
	private IEnumerator JumpSmooth(Vector3 jumpVelocity) { }

	// RVA: 0x26C4280 Offset: 0x26C4381 VA: 0x26C4280
	private void GroundCheck() { }

	// RVA: 0x26C5BA0 Offset: 0x26C5CA1 VA: 0x26C5BA0
	public void .ctor() { }
}

public class CharacterThirdPerson : CharacterBase // TypeDefIndex: 9399
{
	// Fields
	[HeaderAttribute] // RVA: 0x178A10 Offset: 0x178B11 VA: 0x178A10
	public CharacterAnimationBase characterAnimation; // 0x68
	public UserControlThirdPerson userControl; // 0x70
	public CameraController cam; // 0x78
	[HeaderAttribute] // RVA: 0x178A50 Offset: 0x178B51 VA: 0x178A50
	public CharacterThirdPerson.MoveMode moveMode; // 0x80
	public bool smoothPhysics; // 0x84
	public float smoothAccelerationTime; // 0x88
	public float linearAccelerationSpeed; // 0x8C
	public float platformFriction; // 0x90
	public float groundStickyEffect; // 0x94
	public float maxVerticalVelocityOnGround; // 0x98
	public float velocityToGroundTangentWeight; // 0x9C
	[HeaderAttribute] // RVA: 0x178A90 Offset: 0x178B91 VA: 0x178A90
	public bool lookInCameraDirection; // 0xA0
	public float turnSpeed; // 0xA4
	public float stationaryTurnSpeedMlp; // 0xA8
	[HeaderAttribute] // RVA: 0x178AD0 Offset: 0x178BD1 VA: 0x178AD0
	public bool smoothJump; // 0xAC
	public float airSpeed; // 0xB0
	public float airControl; // 0xB4
	public float jumpPower; // 0xB8
	public float jumpRepeatDelayTime; // 0xBC
	public bool doubleJumpEnabled; // 0xC0
	public float doubleJumpPowerMlp; // 0xC4
	[HeaderAttribute] // RVA: 0x178B10 Offset: 0x178C11 VA: 0x178B10
	public LayerMask wallRunLayers; // 0xC8
	public float wallRunMaxLength; // 0xCC
	public float wallRunMinMoveMag; // 0xD0
	public float wallRunMinVelocityY; // 0xD4
	public float wallRunRotationSpeed; // 0xD8
	public float wallRunMaxRotationAngle; // 0xDC
	public float wallRunWeightSpeed; // 0xE0
	[HeaderAttribute] // RVA: 0x178B50 Offset: 0x178C51 VA: 0x178B50
	public float crouchCapsuleScaleMlp; // 0xE4
	[CompilerGeneratedAttribute] // RVA: 0x178B90 Offset: 0x178C91 VA: 0x178B90
	private bool <onGround>k__BackingField; // 0xE8
	public CharacterThirdPerson.AnimState animState; // 0xEC
	protected Vector3 moveDirection; // 0x104
	private Animator animator; // 0x110
	private Vector3 normal; // 0x118
	private Vector3 platformVelocity; // 0x124
	private Vector3 platformAngularVelocity; // 0x130
	private RaycastHit hit; // 0x13C
	private float jumpLeg; // 0x168
	private float jumpEndTime; // 0x16C
	private float forwardMlp; // 0x170
	private float groundDistance; // 0x174
	private float lastAirTime; // 0x178
	private float stickyForce; // 0x17C
	private Vector3 wallNormal; // 0x180
	private Vector3 moveDirectionVelocity; // 0x18C
	private float wallRunWeight; // 0x198
	private float lastWallRunWeight; // 0x19C
	private Vector3 fixedDeltaPosition; // 0x1A0
	private Quaternion fixedDeltaRotation; // 0x1AC
	private bool fixedFrame; // 0x1BC
	private float wallRunEndTime; // 0x1C0
	private Vector3 gravity; // 0x1C4
	private Vector3 verticalVelocity; // 0x1D0
	private float velocityY; // 0x1DC
	private bool doubleJumped; // 0x1E0
	private bool jumpReleased; // 0x1E1

	// Properties
	public bool onGround { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AA140 Offset: 0x1AA241 VA: 0x1AA140
	// RVA: 0x26C3380 Offset: 0x26C3481 VA: 0x26C3380
	public bool get_onGround() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AA150 Offset: 0x1AA251 VA: 0x1AA150
	// RVA: 0x26C3390 Offset: 0x26C3491 VA: 0x26C3390
	private void set_onGround(bool value) { }

	// RVA: 0x26C33A0 Offset: 0x26C34A1 VA: 0x26C33A0 Slot: 5
	protected override void Start() { }

	// RVA: 0x26C3550 Offset: 0x26C3651 VA: 0x26C3550
	private void OnAnimatorMove() { }

	// RVA: 0x26C35F0 Offset: 0x26C36F1 VA: 0x26C35F0 Slot: 4
	public override void Move(Vector3 deltaPosition, Quaternion deltaRotation) { }

	// RVA: 0x26C3730 Offset: 0x26C3831 VA: 0x26C3730
	private void FixedUpdate() { }

	// RVA: 0x26C46C0 Offset: 0x26C47C1 VA: 0x26C46C0 Slot: 7
	protected virtual void Update() { }

	// RVA: 0x26C4A60 Offset: 0x26C4B61 VA: 0x26C4A60 Slot: 8
	protected virtual void LateUpdate() { }

	// RVA: 0x26C3D70 Offset: 0x26C3E71 VA: 0x26C3D70
	private void MoveFixed(Vector3 deltaPosition) { }

	// RVA: 0x26C4B40 Offset: 0x26C4C41 VA: 0x26C4B40
	private void WallRun() { }

	// RVA: 0x26C51A0 Offset: 0x26C52A1 VA: 0x26C51A0
	private bool CanWallRun() { }

	// RVA: 0x26C47A0 Offset: 0x26C48A1 VA: 0x26C47A0
	private Vector3 GetMoveDirection() { }

	// RVA: 0x26C5250 Offset: 0x26C5351 VA: 0x26C5250 Slot: 9
	protected virtual void Rotate() { }

	// RVA: 0x26C56C0 Offset: 0x26C57C1 VA: 0x26C56C0
	private Vector3 GetForwardDirection() { }

	// RVA: 0x26C5850 Offset: 0x26C5951 VA: 0x26C5850 Slot: 10
	protected virtual bool Jump() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AA160 Offset: 0x1AA261 VA: 0x1AA160
	// RVA: 0x26C5AD0 Offset: 0x26C5BD1 VA: 0x26C5AD0
	private IEnumerator JumpSmooth(Vector3 jumpVelocity) { }

	// RVA: 0x26C4280 Offset: 0x26C4381 VA: 0x26C4280
	private void GroundCheck() { }

	// RVA: 0x26C5BA0 Offset: 0x26C5CA1 VA: 0x26C5BA0
	public void .ctor() { }
}

