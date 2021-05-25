public class SpringManager : MonoBehaviour // TypeDefIndex: 9170
{
	// Fields
	[HeaderAttribute] // RVA: 0x1773E0 Offset: 0x1774E1 VA: 0x1773E0
	public bool automaticUpdates; // 0x18
	public bool isPaused; // 0x19
	public bool isStarted; // 0x1A
	public int simulationFrameRate; // 0x1C
	[RangeAttribute] // RVA: 0x177420 Offset: 0x177521 VA: 0x177420
	public float dynamicRatio; // 0x20
	public Vector3 gravity; // 0x24
	[RangeAttribute] // RVA: 0x177440 Offset: 0x177541 VA: 0x177440
	public float bounce; // 0x30
	[RangeAttribute] // RVA: 0x177460 Offset: 0x177561 VA: 0x177460
	public float friction; // 0x34
	[HeaderAttribute] // RVA: 0x177480 Offset: 0x177581 VA: 0x177480
	public bool enableAngleLimits; // 0x38
	public bool enableCollision; // 0x39
	public bool enableLengthLimits; // 0x3A
	[HeaderAttribute] // RVA: 0x1774C0 Offset: 0x1775C1 VA: 0x1774C0
	public bool collideWithGround; // 0x3B
	public float groundHeight; // 0x3C
	[HeaderAttribute] // RVA: 0x177500 Offset: 0x177601 VA: 0x177500
	public SpringBone[] springBones; // 0x40
	private const float ResetSeconds = 1;
	private bool isResetPosition; // 0x48
	private bool[] boneIsAnimatedStates; // 0x50
	private ForceProvider[] forceProviders; // 0x58

	// Methods

	// RVA: 0x23A12B0 Offset: 0x23A13B1 VA: 0x23A12B0
	public void CleanUpBoneColliders() { }

	// RVA: 0x23A1600 Offset: 0x23A1701 VA: 0x23A1600
	public void FindSpringBones(bool includeInactive = False) { }

	// RVA: 0x23A18E0 Offset: 0x23A19E1 VA: 0x23A18E0
	public void UpdateBoneIsAnimatedStates(IList<string> animatedBoneNames) { }

	// RVA: 0x23A1AB0 Offset: 0x23A1BB1 VA: 0x23A1AB0
	public void ResetPosition() { }

	// RVA: 0x23A1AC0 Offset: 0x23A1BC1 VA: 0x23A1AC0
	public void UpdateDynamics() { }

	// RVA: 0x23A1DF0 Offset: 0x23A1EF1 VA: 0x23A1DF0
	public void InitializeDynamics() { }

	// RVA: 0x23A2040 Offset: 0x23A2141 VA: 0x23A2040
	private static int GetObjectDepth(Transform inObject) { }

	// RVA: 0x23A1EF0 Offset: 0x23A1FF1 VA: 0x23A1EF0
	private Vector3 GetSumOfForcesOnBone(SpringBone springBone) { }

	// RVA: 0x23A20F0 Offset: 0x23A21F1 VA: 0x23A20F0
	private void Awake() { }

	// RVA: 0x23A21F0 Offset: 0x23A22F1 VA: 0x23A21F0
	private void Start() { }

	// RVA: 0x23A2270 Offset: 0x23A2371 VA: 0x23A2270
	private void LateUpdate() { }

	// RVA: 0x23A2280 Offset: 0x23A2381 VA: 0x23A2280
	public void .ctor() { }
}

