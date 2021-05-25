[StaticAccessorAttribute] // RVA: 0xE1500 Offset: 0xE1601 VA: 0xE1500
[NativeHeaderAttribute] // RVA: 0xE1500 Offset: 0xE1601 VA: 0xE1500
public class Physics // TypeDefIndex: 3441
{
	// Properties
	public static Vector3 gravity { get; }
	[NativePropertyAttribute] // RVA: 0xE4770 Offset: 0xE4871 VA: 0xE4770
	public static PhysicsScene defaultPhysicsScene { get; }

	// Methods

	[ThreadSafeAttribute] // RVA: 0xE1EF0 Offset: 0xE1FF1 VA: 0xE1EF0
	// RVA: 0x350D660 Offset: 0x350D761 VA: 0x350D660
	public static Vector3 get_gravity() { }

	// RVA: 0x350D710 Offset: 0x350D811 VA: 0x350D710
	public static PhysicsScene get_defaultPhysicsScene() { }

	// RVA: 0x350D7B0 Offset: 0x350D8B1 VA: 0x350D7B0
	public static void IgnoreCollision(Collider collider1, Collider collider2, bool ignore) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE1F00 Offset: 0xE2001 VA: 0xE1F00
	// RVA: 0x350D810 Offset: 0x350D911 VA: 0x350D810
	public static void IgnoreCollision(Collider collider1, Collider collider2) { }

	// RVA: 0x350D870 Offset: 0x350D971 VA: 0x350D870
	public static bool GetIgnoreLayerCollision(int layer1, int layer2) { }

	// RVA: 0x350D8C0 Offset: 0x350D9C1 VA: 0x350D8C0
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE1F10 Offset: 0xE2011 VA: 0xE1F10
	// RVA: 0x350DB20 Offset: 0x350DC21 VA: 0x350DB20
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE1F20 Offset: 0xE2021 VA: 0xE1F20
	// RVA: 0x350DBF0 Offset: 0x350DCF1 VA: 0x350DBF0
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE1F30 Offset: 0xE2031 VA: 0xE1F30
	// RVA: 0x350DCC0 Offset: 0x350DDC1 VA: 0x350DCC0
	public static bool Raycast(Vector3 origin, Vector3 direction) { }

	// RVA: 0x350DD80 Offset: 0x350DE81 VA: 0x350DD80
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE1F40 Offset: 0xE2041 VA: 0xE1F40
	[RequiredByNativeCodeAttribute] // RVA: 0xE1F40 Offset: 0xE2041 VA: 0xE1F40
	// RVA: 0x350E000 Offset: 0x350E101 VA: 0x350E000
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE1F80 Offset: 0xE2081 VA: 0xE1F80
	// RVA: 0x350E0E0 Offset: 0x350E1E1 VA: 0x350E0E0
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE1F90 Offset: 0xE2091 VA: 0xE1F90
	// RVA: 0x350E1B0 Offset: 0x350E2B1 VA: 0x350E1B0
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo) { }

	// RVA: 0x350E280 Offset: 0x350E381 VA: 0x350E280
	public static bool Raycast(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE1FA0 Offset: 0xE20A1 VA: 0xE1FA0
	// RVA: 0x350E360 Offset: 0x350E461 VA: 0x350E360
	public static bool Raycast(Ray ray, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE1FB0 Offset: 0xE20B1 VA: 0xE1FB0
	// RVA: 0x350E430 Offset: 0x350E531 VA: 0x350E430
	public static bool Raycast(Ray ray, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE1FC0 Offset: 0xE20C1 VA: 0xE1FC0
	// RVA: 0x350E500 Offset: 0x350E601 VA: 0x350E500
	public static bool Raycast(Ray ray) { }

	// RVA: 0x350E5D0 Offset: 0x350E6D1 VA: 0x350E5D0
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE1FD0 Offset: 0xE20D1 VA: 0xE1FD0
	// RVA: 0x350E6C0 Offset: 0x350E7C1 VA: 0x350E6C0
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE1FE0 Offset: 0xE20E1 VA: 0xE1FE0
	// RVA: 0x350E7B0 Offset: 0x350E8B1 VA: 0x350E7B0
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE1FF0 Offset: 0xE20F1 VA: 0xE1FF0
	// RVA: 0x350E890 Offset: 0x350E991 VA: 0x350E890
	public static bool Raycast(Ray ray, out RaycastHit hitInfo) { }

	// RVA: 0x350E970 Offset: 0x350EA71 VA: 0x350E970
	public static bool Linecast(Vector3 start, Vector3 end, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE2000 Offset: 0xE2101 VA: 0xE2000
	// RVA: 0x350EAD0 Offset: 0x350EBD1 VA: 0x350EAD0
	public static bool Linecast(Vector3 start, Vector3 end, int layerMask) { }

	// RVA: 0x350EAE0 Offset: 0x350EBE1 VA: 0x350EAE0
	public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x350EC40 Offset: 0x350ED41 VA: 0x350EC40
	public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE2010 Offset: 0xE2111 VA: 0xE2010
	// RVA: 0x350ED50 Offset: 0x350EE51 VA: 0x350ED50
	public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	// RVA: 0x350EE30 Offset: 0x350EF31 VA: 0x350EE30
	public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE2020 Offset: 0xE2121 VA: 0xE2020
	// RVA: 0x350EF20 Offset: 0x350F021 VA: 0x350EF20
	public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	// RVA: 0x350EFF0 Offset: 0x350F0F1 VA: 0x350EFF0
	public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE2030 Offset: 0xE2131 VA: 0xE2030
	// RVA: 0x350F0E0 Offset: 0x350F1E1 VA: 0x350F0E0
	public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	// RVA: 0x350F1E0 Offset: 0x350F2E1 VA: 0x350F1E0
	public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE2040 Offset: 0xE2141 VA: 0xE2040
	// RVA: 0x350F310 Offset: 0x350F411 VA: 0x350F310
	public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask) { }

	[NativeNameAttribute] // RVA: 0xE2050 Offset: 0xE2151 VA: 0xE2050
	[StaticAccessorAttribute] // RVA: 0xE2050 Offset: 0xE2151 VA: 0xE2050
	// RVA: 0x350F400 Offset: 0x350F501 VA: 0x350F400
	private static RaycastHit[] Internal_RaycastAll(PhysicsScene physicsScene, Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x350F500 Offset: 0x350F601 VA: 0x350F500
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE20C0 Offset: 0xE21C1 VA: 0xE20C0
	// RVA: 0x350F6B0 Offset: 0x350F7B1 VA: 0x350F6B0
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE20D0 Offset: 0xE21D1 VA: 0xE20D0
	// RVA: 0x350F6C0 Offset: 0x350F7C1 VA: 0x350F6C0
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE20E0 Offset: 0xE21E1 VA: 0xE20E0
	// RVA: 0x350F6D0 Offset: 0x350F7D1 VA: 0x350F6D0
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction) { }

	// RVA: 0x350F6F0 Offset: 0x350F7F1 VA: 0x350F6F0
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xE20F0 Offset: 0xE21F1 VA: 0xE20F0
	[ExcludeFromDocsAttribute] // RVA: 0xE20F0 Offset: 0xE21F1 VA: 0xE20F0
	// RVA: 0x350F780 Offset: 0x350F881 VA: 0x350F780
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE2130 Offset: 0xE2231 VA: 0xE2130
	// RVA: 0x350F800 Offset: 0x350F901 VA: 0x350F800
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE2140 Offset: 0xE2241 VA: 0xE2140
	// RVA: 0x350F880 Offset: 0x350F981 VA: 0x350F880
	public static RaycastHit[] RaycastAll(Ray ray) { }

	// RVA: 0x350F900 Offset: 0x350FA01 VA: 0x350F900
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE2150 Offset: 0xE2251 VA: 0xE2150
	[RequiredByNativeCodeAttribute] // RVA: 0xE2150 Offset: 0xE2251 VA: 0xE2150
	// RVA: 0x350FAF0 Offset: 0x350FBF1 VA: 0x350FAF0
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE2190 Offset: 0xE2291 VA: 0xE2190
	// RVA: 0x350FBD0 Offset: 0x350FCD1 VA: 0x350FBD0
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE21A0 Offset: 0xE22A1 VA: 0xE21A0
	// RVA: 0x350FCA0 Offset: 0x350FDA1 VA: 0x350FCA0
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results) { }

	// RVA: 0x350FD70 Offset: 0x350FE71 VA: 0x350FD70
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE21B0 Offset: 0xE22B1 VA: 0xE21B0
	// RVA: 0x350FE50 Offset: 0x350FF51 VA: 0x350FE50
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE21C0 Offset: 0xE22C1 VA: 0xE21C0
	// RVA: 0x350FF30 Offset: 0x3510031 VA: 0x350FF30
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE21D0 Offset: 0xE22D1 VA: 0xE21D0
	// RVA: 0x3510000 Offset: 0x3510101 VA: 0x3510000
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results) { }

	[StaticAccessorAttribute] // RVA: 0xE21E0 Offset: 0xE22E1 VA: 0xE21E0
	[NativeNameAttribute] // RVA: 0xE21E0 Offset: 0xE22E1 VA: 0xE21E0
	// RVA: 0x35100C0 Offset: 0x35101C1 VA: 0x35100C0
	private static RaycastHit[] Query_SphereCastAll(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x35101F0 Offset: 0x35102F1 VA: 0x35101F0
	public static RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0xE2250 Offset: 0xE2351 VA: 0xE2250
	// RVA: 0x3510390 Offset: 0x3510491 VA: 0x3510390
	public static RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance, int layerMask) { }

	[StaticAccessorAttribute] // RVA: 0xE2260 Offset: 0xE2361 VA: 0xE2260
	[NativeNameAttribute] // RVA: 0xE2260 Offset: 0xE2361 VA: 0xE2260
	// RVA: 0x35103A0 Offset: 0x35104A1 VA: 0x35103A0
	private static Collider[] OverlapCapsule_Internal(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x35104B0 Offset: 0x35105B1 VA: 0x35104B0
	public static Collider[] OverlapCapsule(Vector3 point0, Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[NativeNameAttribute] // RVA: 0xE22D0 Offset: 0xE23D1 VA: 0xE22D0
	[StaticAccessorAttribute] // RVA: 0xE22D0 Offset: 0xE23D1 VA: 0xE22D0
	// RVA: 0x35105A0 Offset: 0x35106A1 VA: 0x35105A0
	private static Collider[] OverlapSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x35106A0 Offset: 0x35107A1 VA: 0x35106A0
	public static Collider[] OverlapSphere(Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[NativeNameAttribute] // RVA: 0xE2340 Offset: 0xE2441 VA: 0xE2340
	[StaticAccessorAttribute] // RVA: 0xE2340 Offset: 0xE2441 VA: 0xE2340
	// RVA: 0x3510770 Offset: 0x3510871 VA: 0x3510770
	private static bool Query_ComputePenetration(Collider colliderA, Vector3 positionA, Quaternion rotationA, Collider colliderB, Vector3 positionB, Quaternion rotationB, ref Vector3 direction, ref float distance) { }

	// RVA: 0x35108D0 Offset: 0x35109D1 VA: 0x35108D0
	public static bool ComputePenetration(Collider colliderA, Vector3 positionA, Quaternion rotationA, Collider colliderB, Vector3 positionB, Quaternion rotationB, out Vector3 direction, out float distance) { }

	// RVA: 0x3510A40 Offset: 0x3510B41 VA: 0x3510A40
	public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3510BA0 Offset: 0x3510CA1 VA: 0x3510BA0
	public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3510E10 Offset: 0x3510F11 VA: 0x3510E10
	public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[StaticAccessorAttribute] // RVA: 0xE23A0 Offset: 0xE24A1 VA: 0xE23A0
	[NativeNameAttribute] // RVA: 0xE23A0 Offset: 0xE24A1 VA: 0xE23A0
	// RVA: 0x3511040 Offset: 0x3511141 VA: 0x3511040
	private static Collider[] OverlapBox_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3511150 Offset: 0x3511251 VA: 0x3511150
	public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3511260 Offset: 0x3511361 VA: 0x3511260
	public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3511420 Offset: 0x3511521 VA: 0x3511420
	public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3511630 Offset: 0x3511731 VA: 0x3511630
	public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x350D6C0 Offset: 0x350D7C1 VA: 0x350D6C0
	private static void get_gravity_Injected(out Vector3 ret) { }

	// RVA: 0x350D760 Offset: 0x350D861 VA: 0x350D760
	private static void get_defaultPhysicsScene_Injected(out PhysicsScene ret) { }

	// RVA: 0x350F480 Offset: 0x350F581 VA: 0x350F480
	private static RaycastHit[] Internal_RaycastAll_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3510160 Offset: 0x3510261 VA: 0x3510160
	private static RaycastHit[] Query_SphereCastAll_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3510430 Offset: 0x3510531 VA: 0x3510430
	private static Collider[] OverlapCapsule_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 point0, ref Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3510620 Offset: 0x3510721 VA: 0x3510620
	private static Collider[] OverlapSphere_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3510830 Offset: 0x3510931 VA: 0x3510830
	private static bool Query_ComputePenetration_Injected(Collider colliderA, ref Vector3 positionA, ref Quaternion rotationA, Collider colliderB, ref Vector3 positionB, ref Quaternion rotationB, ref Vector3 direction, ref float distance) { }

	// RVA: 0x35110D0 Offset: 0x35111D1 VA: 0x35110D0
	private static Collider[] OverlapBox_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }
}

