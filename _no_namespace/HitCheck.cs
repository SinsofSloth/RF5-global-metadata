public static class HitCheck // TypeDefIndex: 6819
{
	// Fields
	private const int OverlapResultMax = 256;
	private const int CastResultMax = 256;
	private const int HitResultMax = 512;
	private static ColliderComparer m_ColliderComparer; // 0x0
	private static RaycastHitComparer m_RaycastHitComparer; // 0x8
	private static HitResultComparer m_HitResultComparer; // 0x10
	private static Collider[] m_OverlapResult; // 0x18
	private static RaycastHit[] m_CastResult; // 0x20
	private static HitResult[] m_hitResults; // 0x28
	private static int m_hitResultCount; // 0x30

	// Properties
	public static Collider[] OverlapResult { get; }
	public static RaycastHit[] CastResult { get; }
	public static HitResult[] HitResults { get; }

	// Methods

	// RVA: 0x23016A0 Offset: 0x23017A1 VA: 0x23016A0
	public static Collider[] get_OverlapResult() { }

	// RVA: 0x2301710 Offset: 0x2301811 VA: 0x2301710
	public static RaycastHit[] get_CastResult() { }

	// RVA: 0x2301780 Offset: 0x2301881 VA: 0x2301780
	public static HitResult[] get_HitResults() { }

	// RVA: 0x23017F0 Offset: 0x23018F1 VA: 0x23017F0
	private static void ClearHitResult() { }

	// RVA: 0x2301860 Offset: 0x2301961 VA: 0x2301860
	private static bool AddHitResult(Vector3 point, Vector3 normal, float distance, Collider collider) { }

	// RVA: 0x2301BB0 Offset: 0x2301CB1 VA: 0x2301BB0
	private static void SortHitResults(Vector3 center) { }

	// RVA: 0x2301CB0 Offset: 0x2301DB1 VA: 0x2301CB0
	public static int OverlapSphere(Vector3 center, float radius, LayerMask layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x2301DF0 Offset: 0x2301EF1 VA: 0x2301DF0
	public static int SphereCast(Vector3 origin, float radius, Vector3 direction, float distance, LayerMask layerMask, QueryTriggerInteraction queryTriggerInteraction = 1) { }

	// RVA: 0x2301F60 Offset: 0x2302061 VA: 0x2301F60
	private static void SphereCheckFunc(float radius, Vector3 to, Vector3 from, LayerMask layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x23024B0 Offset: 0x23025B1 VA: 0x23024B0
	public static int SphereCheck(float radius, Vector3 to, Vector3 from, LayerMask layerMask, QueryTriggerInteraction queryTriggerInteraction = 1) { }

	// RVA: 0x2302600 Offset: 0x2302701 VA: 0x2302600
	public static int Check(SphereCollider sphere, Vector3 from, LayerMask layerMask, QueryTriggerInteraction queryTriggerInteraction = 1) { }

	// RVA: 0x2302860 Offset: 0x2302961 VA: 0x2302860
	public static int OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion rotation, LayerMask layerMask, QueryTriggerInteraction queryTriggerInteraction = 1) { }

	// RVA: 0x23029F0 Offset: 0x2302AF1 VA: 0x23029F0
	public static int BoxCast(Vector3 origin, Vector3 halfExtents, Vector3 direction, Quaternion rotation, float distance, LayerMask layerMask, QueryTriggerInteraction queryTriggerInteraction = 1) { }

	// RVA: 0x2302BC0 Offset: 0x2302CC1 VA: 0x2302BC0
	public static void BoxCheckFunc(Vector3 size, Quaternion rotation, Vector3 to, Vector3 from, LayerMask layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x23031F0 Offset: 0x23032F1 VA: 0x23031F0
	public static int BoxCheck(Vector3 size, Quaternion rotation, Vector3 to, Vector3 from, LayerMask layerMask, QueryTriggerInteraction queryTriggerInteraction = 1) { }

	// RVA: 0x2303350 Offset: 0x2303451 VA: 0x2303350
	public static int Check(BoxCollider box, Vector3 from, LayerMask layerMask, QueryTriggerInteraction queryTriggerInteraction = 1) { }

	// RVA: 0x23035F0 Offset: 0x23036F1 VA: 0x23035F0
	public static int Check(Collider collider, Vector3 from, LayerMask layerMask, QueryTriggerInteraction queryTriggerInteraction = 1) { }

	// RVA: 0x23037D0 Offset: 0x23038D1 VA: 0x23037D0
	private static void .cctor() { }
}

