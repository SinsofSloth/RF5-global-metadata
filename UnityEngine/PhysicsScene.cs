[NativeHeaderAttribute] // RVA: 0xE14C0 Offset: 0xE15C1 VA: 0xE14C0
public struct PhysicsScene : IEquatable<PhysicsScene> // TypeDefIndex: 3440
{
	// Fields
	private int m_Handle; // 0x0

	// Methods

	// RVA: 0x3A2BB0 Offset: 0x3A2CB1 VA: 0x3A2BB0 Slot: 3
	public override string ToString() { }

	// RVA: 0x3A2BC0 Offset: 0x3A2CC1 VA: 0x3A2BC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3A2BD0 Offset: 0x3A2CD1 VA: 0x3A2BD0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x3A2C80 Offset: 0x3A2D81 VA: 0x3A2C80 Slot: 4
	public bool Equals(PhysicsScene other) { }

	// RVA: 0x3A2C90 Offset: 0x3A2D91 VA: 0x3A2C90
	public bool Raycast(Vector3 origin, Vector3 direction, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[StaticAccessorAttribute] // RVA: 0xE1A20 Offset: 0xE1B21 VA: 0xE1A20
	[NativeNameAttribute] // RVA: 0xE1A20 Offset: 0xE1B21 VA: 0xE1A20
	// RVA: 0x3511990 Offset: 0x3511A91 VA: 0x3511990
	private static bool Internal_RaycastTest(PhysicsScene physicsScene, Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3A2CA0 Offset: 0x3A2DA1 VA: 0x3A2CA0
	public bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[StaticAccessorAttribute] // RVA: 0xE1A90 Offset: 0xE1B91 VA: 0xE1A90
	[NativeNameAttribute] // RVA: 0xE1A90 Offset: 0xE1B91 VA: 0xE1A90
	// RVA: 0x3511A90 Offset: 0x3511B91 VA: 0x3511A90
	private static bool Internal_Raycast(PhysicsScene physicsScene, Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3A2CB0 Offset: 0x3A2DB1 VA: 0x3A2CB0
	public int Raycast(Vector3 origin, Vector3 direction, RaycastHit[] raycastHits, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[StaticAccessorAttribute] // RVA: 0xE1B00 Offset: 0xE1C01 VA: 0xE1B00
	[NativeNameAttribute] // RVA: 0xE1B00 Offset: 0xE1C01 VA: 0xE1B00
	// RVA: 0x3511BA0 Offset: 0x3511CA1 VA: 0x3511BA0
	private static int Internal_RaycastNonAlloc(PhysicsScene physicsScene, Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	[StaticAccessorAttribute] // RVA: 0xE1B60 Offset: 0xE1C61 VA: 0xE1B60
	[NativeNameAttribute] // RVA: 0xE1B60 Offset: 0xE1C61 VA: 0xE1B60
	// RVA: 0x3511CB0 Offset: 0x3511DB1 VA: 0x3511CB0
	private static bool Query_CapsuleCast(PhysicsScene physicsScene, Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3511E10 Offset: 0x3511F11 VA: 0x3511E10
	private static bool Internal_CapsuleCast(PhysicsScene physicsScene, Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3A2CC0 Offset: 0x3A2DC1 VA: 0x3A2CC0
	public bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[NativeNameAttribute] // RVA: 0xE1BD0 Offset: 0xE1CD1 VA: 0xE1BD0
	[StaticAccessorAttribute] // RVA: 0xE1BD0 Offset: 0xE1CD1 VA: 0xE1BD0
	// RVA: 0x3511FC0 Offset: 0x35120C1 VA: 0x3511FC0
	private static int Internal_CapsuleCastNonAlloc(PhysicsScene physicsScene, Vector3 p0, Vector3 p1, float radius, Vector3 direction, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3A2CE0 Offset: 0x3A2DE1 VA: 0x3A2CE0
	public int CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[NativeNameAttribute] // RVA: 0xE1C30 Offset: 0xE1D31 VA: 0xE1C30
	[StaticAccessorAttribute] // RVA: 0xE1C30 Offset: 0xE1D31 VA: 0xE1C30
	// RVA: 0x3512110 Offset: 0x3512211 VA: 0x3512110
	private static int OverlapCapsuleNonAlloc_Internal(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3A2E00 Offset: 0x3A2F01 VA: 0x3A2E00
	public int OverlapCapsule(Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask = -1, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[StaticAccessorAttribute] // RVA: 0xE1C90 Offset: 0xE1D91 VA: 0xE1C90
	[NativeNameAttribute] // RVA: 0xE1C90 Offset: 0xE1D91 VA: 0xE1C90
	// RVA: 0x3512240 Offset: 0x3512341 VA: 0x3512240
	private static bool Query_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3512380 Offset: 0x3512481 VA: 0x3512380
	private static bool Internal_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3A2EA0 Offset: 0x3A2FA1 VA: 0x3A2EA0
	public bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[NativeNameAttribute] // RVA: 0xE1D00 Offset: 0xE1E01 VA: 0xE1D00
	[StaticAccessorAttribute] // RVA: 0xE1D00 Offset: 0xE1E01 VA: 0xE1D00
	// RVA: 0x3512500 Offset: 0x3512601 VA: 0x3512500
	private static int Internal_SphereCastNonAlloc(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3A2EB0 Offset: 0x3A2FB1 VA: 0x3A2EB0
	public int SphereCast(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[NativeNameAttribute] // RVA: 0xE1D60 Offset: 0xE1E61 VA: 0xE1D60
	[StaticAccessorAttribute] // RVA: 0xE1D60 Offset: 0xE1E61 VA: 0xE1D60
	// RVA: 0x3512640 Offset: 0x3512741 VA: 0x3512640
	private static int OverlapSphereNonAlloc_Internal(PhysicsScene physicsScene, Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3A2FB0 Offset: 0x3A30B1 VA: 0x3A2FB0
	public int OverlapSphere(Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[NativeNameAttribute] // RVA: 0xE1DC0 Offset: 0xE1EC1 VA: 0xE1DC0
	[StaticAccessorAttribute] // RVA: 0xE1DC0 Offset: 0xE1EC1 VA: 0xE1DC0
	// RVA: 0x3512750 Offset: 0x3512851 VA: 0x3512750
	private static bool Query_BoxCast(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, ref RaycastHit outHit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x35128C0 Offset: 0x35129C1 VA: 0x35128C0
	private static bool Internal_BoxCast(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3A3040 Offset: 0x3A3141 VA: 0x3A3040
	public bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[StaticAccessorAttribute] // RVA: 0xE1E30 Offset: 0xE1F31 VA: 0xE1E30
	[NativeNameAttribute] // RVA: 0xE1E30 Offset: 0xE1F31 VA: 0xE1E30
	// RVA: 0x3512AA0 Offset: 0x3512BA1 VA: 0x3512AA0
	private static int OverlapBoxNonAlloc_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3A3070 Offset: 0x3A3171 VA: 0x3A3070
	public int OverlapBox(Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[StaticAccessorAttribute] // RVA: 0xE1E90 Offset: 0xE1F91 VA: 0xE1E90
	[NativeNameAttribute] // RVA: 0xE1E90 Offset: 0xE1F91 VA: 0xE1E90
	// RVA: 0x3512BD0 Offset: 0x3512CD1 VA: 0x3512BD0
	private static int Internal_BoxCastNonAlloc(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] raycastHits, Quaternion orientation, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3A3110 Offset: 0x3A3211 VA: 0x3A3110
	public int BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, Quaternion orientation, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	// RVA: 0x3511A10 Offset: 0x3511B11 VA: 0x3511A10
	private static bool Internal_RaycastTest_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3511B20 Offset: 0x3511C21 VA: 0x3511B20
	private static bool Internal_Raycast_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3511C30 Offset: 0x3511D31 VA: 0x3511C30
	private static int Internal_RaycastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3511D70 Offset: 0x3511E71 VA: 0x3511D70
	private static bool Query_CapsuleCast_Injected(ref PhysicsScene physicsScene, ref Vector3 point1, ref Vector3 point2, float radius, ref Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3512070 Offset: 0x3512171 VA: 0x3512070
	private static int Internal_CapsuleCastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Vector3 p0, ref Vector3 p1, float radius, ref Vector3 direction, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x35121B0 Offset: 0x35122B1 VA: 0x35121B0
	private static int OverlapCapsuleNonAlloc_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 point0, ref Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x35122E0 Offset: 0x35123E1 VA: 0x35122E0
	private static bool Query_SphereCast_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x35125A0 Offset: 0x35126A1 VA: 0x35125A0
	private static int Internal_SphereCastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x35126D0 Offset: 0x35127D1 VA: 0x35126D0
	private static int OverlapSphereNonAlloc_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3512810 Offset: 0x3512911 VA: 0x3512810
	private static bool Query_BoxCast_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Vector3 direction, ref Quaternion orientation, float maxDistance, ref RaycastHit outHit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3512B40 Offset: 0x3512C41 VA: 0x3512B40
	private static int OverlapBoxNonAlloc_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, Collider[] results, ref Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3512C90 Offset: 0x3512D91 VA: 0x3512C90
	private static int Internal_BoxCastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Vector3 direction, RaycastHit[] raycastHits, ref Quaternion orientation, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }
}

