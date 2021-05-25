[NativeHeaderAttribute] // RVA: 0xFAD20 Offset: 0xFAE21 VA: 0xFAD20
public struct PhysicsScene2D : IEquatable<PhysicsScene2D> // TypeDefIndex: 3637
{
	// Fields
	private int m_Handle; // 0x0

	// Methods

	// RVA: 0x23FC0 Offset: 0x240C1 VA: 0x23FC0 Slot: 3
	public override string ToString() { }

	// RVA: 0x23FD0 Offset: 0x240D1 VA: 0x23FD0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x23FE0 Offset: 0x240E1 VA: 0x23FE0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x24090 Offset: 0x24191 VA: 0x24090 Slot: 4
	public bool Equals(PhysicsScene2D other) { }

	// RVA: 0x240A0 Offset: 0x241A1 VA: 0x240A0
	public RaycastHit2D Linecast(Vector2 start, Vector2 end, ContactFilter2D contactFilter) { }

	[StaticAccessorAttribute] // RVA: 0xFB980 Offset: 0xFBA81 VA: 0xFB980
	[NativeMethodAttribute] // RVA: 0xFB980 Offset: 0xFBA81 VA: 0xFB980
	// RVA: 0x1BC5C40 Offset: 0x1BC5D41 VA: 0x1BC5C40
	private static RaycastHit2D Linecast_Internal(PhysicsScene2D physicsScene, Vector2 start, Vector2 end, ContactFilter2D contactFilter) { }

	// RVA: 0x24180 Offset: 0x24281 VA: 0x24180
	public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask = -5) { }

	// RVA: 0x242B0 Offset: 0x243B1 VA: 0x242B0
	public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter) { }

	[NativeMethodAttribute] // RVA: 0xFB9F0 Offset: 0xFBAF1 VA: 0xFB9F0
	[StaticAccessorAttribute] // RVA: 0xFB9F0 Offset: 0xFBAF1 VA: 0xFB9F0
	// RVA: 0x1BC5D50 Offset: 0x1BC5E51 VA: 0x1BC5D50
	private static RaycastHit2D Raycast_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter) { }

	// RVA: 0x243A0 Offset: 0x244A1 VA: 0x243A0
	public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	[NativeMethodAttribute] // RVA: 0xFBA60 Offset: 0xFBB61 VA: 0xFBA60
	[StaticAccessorAttribute] // RVA: 0xFBA60 Offset: 0xFBB61 VA: 0xFBA60
	// RVA: 0x1BC5E80 Offset: 0x1BC5F81 VA: 0x1BC5E80
	private static int RaycastArray_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0x24450 Offset: 0x24551 VA: 0x24450
	public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	[NativeMethodAttribute] // RVA: 0xFBAD0 Offset: 0xFBBD1 VA: 0xFBAD0
	[StaticAccessorAttribute] // RVA: 0xFBAD0 Offset: 0xFBBD1 VA: 0xFBAD0
	// RVA: 0x1BC5F90 Offset: 0x1BC6091 VA: 0x1BC5F90
	private static int RaycastList_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	// RVA: 0x24500 Offset: 0x24601 VA: 0x24500
	public RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, ContactFilter2D contactFilter) { }

	[StaticAccessorAttribute] // RVA: 0xFBB40 Offset: 0xFBC41 VA: 0xFBB40
	[NativeMethodAttribute] // RVA: 0xFBB40 Offset: 0xFBC41 VA: 0xFBB40
	// RVA: 0x1BC60A0 Offset: 0x1BC61A1 VA: 0x1BC60A0
	private static RaycastHit2D CircleCast_Internal(PhysicsScene2D physicsScene, Vector2 origin, float radius, Vector2 direction, float distance, ContactFilter2D contactFilter) { }

	// RVA: 0x24600 Offset: 0x24701 VA: 0x24600
	public int GetRayIntersection(Ray ray, float distance, RaycastHit2D[] results, int layerMask = -5) { }

	[NativeMethodAttribute] // RVA: 0xFBBB0 Offset: 0xFBCB1 VA: 0xFBBB0
	[StaticAccessorAttribute] // RVA: 0xFBBB0 Offset: 0xFBCB1 VA: 0xFBBB0
	// RVA: 0x1BC61E0 Offset: 0x1BC62E1 VA: 0x1BC61E0
	private static int GetRayIntersectionArray_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask, RaycastHit2D[] results) { }

	// RVA: 0x1BC5CE0 Offset: 0x1BC5DE1 VA: 0x1BC5CE0
	private static void Linecast_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 start, ref Vector2 end, ref ContactFilter2D contactFilter, out RaycastHit2D ret) { }

	// RVA: 0x1BC5E00 Offset: 0x1BC5F01 VA: 0x1BC5E00
	private static void Raycast_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, out RaycastHit2D ret) { }

	// RVA: 0x1BC5F10 Offset: 0x1BC6011 VA: 0x1BC5F10
	private static int RaycastArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0x1BC6020 Offset: 0x1BC6121 VA: 0x1BC6020
	private static int RaycastList_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	// RVA: 0x1BC6150 Offset: 0x1BC6251 VA: 0x1BC6150
	private static void CircleCast_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, float radius, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, out RaycastHit2D ret) { }

	// RVA: 0x1BC6270 Offset: 0x1BC6371 VA: 0x1BC6270
	private static int GetRayIntersectionArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask, RaycastHit2D[] results) { }
}

