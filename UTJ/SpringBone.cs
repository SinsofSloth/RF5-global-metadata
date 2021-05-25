public class SpringBone : MonoBehaviour // TypeDefIndex: 9166
{
	// Fields
	[RangeAttribute] // RVA: 0x177360 Offset: 0x177461 VA: 0x177360
	public float stiffnessForce; // 0x18
	[RangeAttribute] // RVA: 0x177380 Offset: 0x177481 VA: 0x177380
	public float dragForce; // 0x1C
	public Vector3 springForce; // 0x20
	[RangeAttribute] // RVA: 0x1773A0 Offset: 0x1774A1 VA: 0x1773A0
	public float windInfluence; // 0x2C
	public Transform pivotNode; // 0x30
	public float angularStiffness; // 0x38
	public AngleLimits yAngleLimits; // 0x40
	public AngleLimits zAngleLimits; // 0x48
	public Transform[] lengthLimitTargets; // 0x50
	[RangeAttribute] // RVA: 0x1773C0 Offset: 0x1774C1 VA: 0x1773C0
	public float radius; // 0x58
	public SpringSphereCollider[] sphereColliders; // 0x60
	public SpringCapsuleCollider[] capsuleColliders; // 0x68
	public SpringPanelCollider[] panelColliders; // 0x70
	private SpringManager manager; // 0x78
	private Vector3 boneAxis; // 0x80
	private float springLength; // 0x8C
	private Quaternion skinAnimationLocalRotation; // 0x90
	private Quaternion initialLocalRotation; // 0xA0
	private Quaternion actualLocalRotation; // 0xB0
	private Vector3 currTipPos; // 0xC0
	private Vector3 prevTipPos; // 0xCC
	private float[] lengthsToLimitTargets; // 0xD8

	// Properties
	public Vector3 CurrentTipPosition { get; }

	// Methods

	// RVA: 0x20010D0 Offset: 0x20011D1 VA: 0x20010D0
	public Vector3 get_CurrentTipPosition() { }

	// RVA: 0x20010E0 Offset: 0x20011E1 VA: 0x20010E0
	public void Initialize(SpringManager owner) { }

	// RVA: 0x2001590 Offset: 0x2001691 VA: 0x2001590
	public Vector3 ComputeChildPosition() { }

	// RVA: 0x2001E00 Offset: 0x2001F01 VA: 0x2001E00
	public void RemoveAllColliders() { }

	// RVA: 0x2001EB0 Offset: 0x2001FB1 VA: 0x2001EB0
	public void UpdateSpring(float deltaTime, Vector3 externalForce) { }

	// RVA: 0x2002310 Offset: 0x2002411 VA: 0x2002310
	public void SatisfyConstraintsAndComputeRotation(float deltaTime, float dynamicRatio) { }

	// RVA: 0x2003550 Offset: 0x2003651 VA: 0x2003550
	public void ComputeRotation(float dynamicRatio) { }

	// RVA: 0x20037F0 Offset: 0x20038F1 VA: 0x20037F0
	public Transform GetPivotTransform() { }

	// RVA: 0x2001C50 Offset: 0x2001D51 VA: 0x2001C50
	private static IList<Transform> GetValidChildren(Transform parent) { }

	// RVA: 0x2003020 Offset: 0x2003121 VA: 0x2003020
	private void ApplyAngleLimits(float deltaTime) { }

	// RVA: 0x2002AE0 Offset: 0x2002BE1 VA: 0x2002AE0
	private bool CheckForCollision() { }

	// RVA: 0x20028F0 Offset: 0x20029F1 VA: 0x20028F0
	private bool CheckForGroundCollision() { }

	// RVA: 0x20038C0 Offset: 0x20039C1 VA: 0x20038C0
	private Vector3 FixBoneLength(Vector3 headPosition, Vector3 tailPosition, float minLength, float maxLength) { }

	// RVA: 0x2001A50 Offset: 0x2001B51 VA: 0x2001A50
	public void InitializeSpringLengthAndTipPosition() { }

	// RVA: 0x2003340 Offset: 0x2003441 VA: 0x2003340
	private Quaternion ComputeRotation(Vector3 tipPosition) { }

	// RVA: 0x2002640 Offset: 0x2002741 VA: 0x2002640
	private Vector3 ApplyLengthLimits(float deltaTime) { }

	// RVA: 0x2003A90 Offset: 0x2003B91 VA: 0x2003A90
	public void .ctor() { }
}

