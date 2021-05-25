public class AimController : MonoBehaviour // TypeDefIndex: 9541
{
	// Fields
	[TooltipAttribute] // RVA: 0x17C200 Offset: 0x17C301 VA: 0x17C200
	public AimIK ik; // 0x18
	[TooltipAttribute] // RVA: 0x17C240 Offset: 0x17C341 VA: 0x17C240
	[RangeAttribute] // RVA: 0x17C240 Offset: 0x17C341 VA: 0x17C240
	public float weight; // 0x20
	[HeaderAttribute] // RVA: 0x17C2A0 Offset: 0x17C3A1 VA: 0x17C2A0
	[TooltipAttribute] // RVA: 0x17C2A0 Offset: 0x17C3A1 VA: 0x17C2A0
	public Transform target; // 0x28
	[TooltipAttribute] // RVA: 0x17C300 Offset: 0x17C401 VA: 0x17C300
	public float targetSwitchSmoothTime; // 0x30
	[TooltipAttribute] // RVA: 0x17C340 Offset: 0x17C441 VA: 0x17C340
	public float weightSmoothTime; // 0x34
	[HeaderAttribute] // RVA: 0x17C380 Offset: 0x17C481 VA: 0x17C380
	[TooltipAttribute] // RVA: 0x17C380 Offset: 0x17C481 VA: 0x17C380
	public bool smoothTurnTowardsTarget; // 0x38
	[TooltipAttribute] // RVA: 0x17C3E0 Offset: 0x17C4E1 VA: 0x17C3E0
	public float maxRadiansDelta; // 0x3C
	[TooltipAttribute] // RVA: 0x17C420 Offset: 0x17C521 VA: 0x17C420
	public float maxMagnitudeDelta; // 0x40
	[TooltipAttribute] // RVA: 0x17C460 Offset: 0x17C561 VA: 0x17C460
	public float slerpSpeed; // 0x44
	[TooltipAttribute] // RVA: 0x17C4A0 Offset: 0x17C5A1 VA: 0x17C4A0
	public Vector3 pivotOffsetFromRoot; // 0x48
	[TooltipAttribute] // RVA: 0x17C4E0 Offset: 0x17C5E1 VA: 0x17C4E0
	public float minDistance; // 0x54
	[TooltipAttribute] // RVA: 0x17C520 Offset: 0x17C621 VA: 0x17C520
	public Vector3 offset; // 0x58
	[HeaderAttribute] // RVA: 0x17C560 Offset: 0x17C661 VA: 0x17C560
	[TooltipAttribute] // RVA: 0x17C560 Offset: 0x17C661 VA: 0x17C560
	[RangeAttribute] // RVA: 0x17C560 Offset: 0x17C661 VA: 0x17C560
	public float maxRootAngle; // 0x64
	[TooltipAttribute] // RVA: 0x17C5E0 Offset: 0x17C6E1 VA: 0x17C5E0
	public bool turnToTarget; // 0x68
	[TooltipAttribute] // RVA: 0x17C620 Offset: 0x17C721 VA: 0x17C620
	public float turnToTargetTime; // 0x6C
	[HeaderAttribute] // RVA: 0x17C660 Offset: 0x17C761 VA: 0x17C660
	[TooltipAttribute] // RVA: 0x17C660 Offset: 0x17C761 VA: 0x17C660
	public bool useAnimatedAimDirection; // 0x70
	[TooltipAttribute] // RVA: 0x17C6C0 Offset: 0x17C7C1 VA: 0x17C6C0
	public Vector3 animatedAimDirection; // 0x74
	private Transform lastTarget; // 0x80
	private float switchWeight; // 0x88
	private float switchWeightV; // 0x8C
	private float weightV; // 0x90
	private Vector3 lastPosition; // 0x94
	private Vector3 dir; // 0xA0
	private bool lastSmoothTowardsTarget; // 0xAC
	private bool turningToTarget; // 0xAD
	private float turnToTargetMlp; // 0xB0
	private float turnToTargetMlpV; // 0xB4

	// Properties
	private Vector3 pivot { get; }

	// Methods

	// RVA: 0x272E9C0 Offset: 0x272EAC1 VA: 0x272E9C0
	private void Start() { }

	// RVA: 0x272EC10 Offset: 0x272ED11 VA: 0x272EC10
	private void LateUpdate() { }

	// RVA: 0x272EAC0 Offset: 0x272EBC1 VA: 0x272EAC0
	private Vector3 get_pivot() { }

	// RVA: 0x272F360 Offset: 0x272F461 VA: 0x272F360
	private void ApplyMinDistance() { }

	// RVA: 0x272F500 Offset: 0x272F601 VA: 0x272F500
	private void RootRotation() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AC1A0 Offset: 0x1AC2A1 VA: 0x1AC1A0
	// RVA: 0x272F930 Offset: 0x272FA31 VA: 0x272F930
	private IEnumerator TurnToTarget() { }

	// RVA: 0x272F9E0 Offset: 0x272FAE1 VA: 0x272F9E0
	public void .ctor() { }
}

