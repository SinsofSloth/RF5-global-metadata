[RequireComponent] // RVA: 0x148220 Offset: 0x148321 VA: 0x148220
public class CharacterAnimationThirdPerson : CharacterAnimationBase // TypeDefIndex: 9397
{
	// Fields
	public CharacterThirdPerson characterController; // 0x60
	[SerializeField] // RVA: 0x1788F0 Offset: 0x1789F1 VA: 0x1788F0
	private float turnSensitivity; // 0x68
	[SerializeField] // RVA: 0x178900 Offset: 0x178A01 VA: 0x178900
	private float turnSpeed; // 0x6C
	[SerializeField] // RVA: 0x178910 Offset: 0x178A11 VA: 0x178910
	private float runCycleLegOffset; // 0x70
	[RangeAttribute] // RVA: 0x178920 Offset: 0x178A21 VA: 0x178920
	[SerializeField] // RVA: 0x178920 Offset: 0x178A21 VA: 0x178920
	private float animSpeedMultiplier; // 0x74
	protected Animator animator; // 0x78
	private Vector3 lastForward; // 0x80
	private const string groundedDirectional = "Grounded Directional";
	private const string groundedStrafe = "Grounded Strafe";
	private float deltaAngle; // 0x8C

	// Properties
	public override bool animationGrounded { get; }

	// Methods

	// RVA: 0x26C1590 Offset: 0x26C1691 VA: 0x26C1590 Slot: 6
	protected override void Start() { }

	// RVA: 0x26C1620 Offset: 0x26C1721 VA: 0x26C1620 Slot: 4
	public override Vector3 GetPivotPoint() { }

	// RVA: 0x26C1640 Offset: 0x26C1741 VA: 0x26C1640 Slot: 5
	public override bool get_animationGrounded() { }

	// RVA: 0x26C1740 Offset: 0x26C1841 VA: 0x26C1740 Slot: 9
	protected virtual void Update() { }

	// RVA: 0x26C1B00 Offset: 0x26C1C01 VA: 0x26C1B00
	private void OnAnimatorMove() { }

	// RVA: 0x26C1CC0 Offset: 0x26C1DC1 VA: 0x26C1CC0
	public void .ctor() { }
}

