[StaticAccessorAttribute] // RVA: 0xFAD60 Offset: 0xFAE61 VA: 0xFAD60
[NativeHeaderAttribute] // RVA: 0xFAD60 Offset: 0xFAE61 VA: 0xFAD60
[NativeHeaderAttribute] // RVA: 0xFAD60 Offset: 0xFAE61 VA: 0xFAD60
[NativeHeaderAttribute] // RVA: 0xFAD60 Offset: 0xFAE61 VA: 0xFAD60
public class Physics2D // TypeDefIndex: 3638
{
	// Fields
	private static List<Rigidbody2D> m_LastDisabledRigidbody2D; // 0x0

	// Properties
	public static PhysicsScene2D defaultPhysicsScene { get; }
	[StaticAccessorAttribute] // RVA: 0xFC400 Offset: 0xFC501 VA: 0xFC400
	public static bool queriesHitTriggers { get; }

	// Methods

	// RVA: 0x1BC3DA0 Offset: 0x1BC3EA1 VA: 0x1BC3DA0
	public static PhysicsScene2D get_defaultPhysicsScene() { }

	// RVA: 0x1BC3D60 Offset: 0x1BC3E61 VA: 0x1BC3D60
	public static bool get_queriesHitTriggers() { }

	[ExcludeFromDocsAttribute] // RVA: 0xFBC20 Offset: 0xFBD21 VA: 0xFBC20
	// RVA: 0x1BC3DB0 Offset: 0x1BC3EB1 VA: 0x1BC3DB0
	public static RaycastHit2D Linecast(Vector2 start, Vector2 end, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0xFBC30 Offset: 0xFBD31 VA: 0xFBC30
	// RVA: 0x1BC4010 Offset: 0x1BC4111 VA: 0x1BC4010
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction) { }

	[ExcludeFromDocsAttribute] // RVA: 0xFBC40 Offset: 0xFBD41 VA: 0xFBC40
	// RVA: 0x1BC42D0 Offset: 0x1BC43D1 VA: 0x1BC42D0
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xFBC50 Offset: 0xFBD51 VA: 0xFBC50
	[ExcludeFromDocsAttribute] // RVA: 0xFBC50 Offset: 0xFBD51 VA: 0xFBC50
	// RVA: 0x1BC4460 Offset: 0x1BC4561 VA: 0x1BC4460
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0xFBC90 Offset: 0xFBD91 VA: 0xFBC90
	// RVA: 0x1BC46E0 Offset: 0x1BC47E1 VA: 0x1BC46E0
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth) { }

	// RVA: 0x1BC4880 Offset: 0x1BC4981 VA: 0x1BC4880
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth) { }

	[ExcludeFromDocsAttribute] // RVA: 0xFBCA0 Offset: 0xFBDA1 VA: 0xFBCA0
	// RVA: 0x1BC4A20 Offset: 0x1BC4B21 VA: 0x1BC4A20
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0x1BC4BC0 Offset: 0x1BC4CC1 VA: 0x1BC4BC0
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, float distance) { }

	// RVA: 0x1BC4CC0 Offset: 0x1BC4DC1 VA: 0x1BC4CC0
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, float distance = ∞) { }

	[ExcludeFromDocsAttribute] // RVA: 0xFBCB0 Offset: 0xFBDB1 VA: 0xFBCB0
	// RVA: 0x1BC4E60 Offset: 0x1BC4F61 VA: 0x1BC4E60
	public static RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0xFBCC0 Offset: 0xFBDC1 VA: 0xFBCC0
	// RVA: 0x1BC50F0 Offset: 0x1BC51F1 VA: 0x1BC50F0
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray) { }

	[ExcludeFromDocsAttribute] // RVA: 0xFBCD0 Offset: 0xFBDD1 VA: 0xFBCD0
	// RVA: 0x1BC5300 Offset: 0x1BC5401 VA: 0x1BC5300
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xFBCE0 Offset: 0xFBDE1 VA: 0xFBCE0
	// RVA: 0x1BC5440 Offset: 0x1BC5541 VA: 0x1BC5440
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance, int layerMask) { }

	[StaticAccessorAttribute] // RVA: 0xFBCF0 Offset: 0xFBDF1 VA: 0xFBCF0
	[NativeMethodAttribute] // RVA: 0xFBCF0 Offset: 0xFBDF1 VA: 0xFBCF0
	// RVA: 0x1BC5230 Offset: 0x1BC5331 VA: 0x1BC5230
	private static RaycastHit2D[] GetRayIntersectionAll_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0xFBD60 Offset: 0xFBE61 VA: 0xFBD60
	// RVA: 0x1BC5610 Offset: 0x1BC5711 VA: 0x1BC5610
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results) { }

	[ExcludeFromDocsAttribute] // RVA: 0xFBD70 Offset: 0xFBE71 VA: 0xFBD70
	// RVA: 0x1BC57E0 Offset: 0x1BC58E1 VA: 0x1BC57E0
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xFBD80 Offset: 0xFBE81 VA: 0xFBD80
	// RVA: 0x1BC58F0 Offset: 0x1BC59F1 VA: 0x1BC58F0
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance, int layerMask) { }

	// RVA: 0x1BC5A00 Offset: 0x1BC5B01 VA: 0x1BC5A00
	private static void .cctor() { }

	// RVA: 0x1BC5590 Offset: 0x1BC5691 VA: 0x1BC5590
	private static RaycastHit2D[] GetRayIntersectionAll_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask) { }
}

