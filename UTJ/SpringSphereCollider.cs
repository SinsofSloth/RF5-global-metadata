public class SpringSphereCollider : MonoBehaviour // TypeDefIndex: 9116
{
	// Fields
	public float radius; // 0x18
	public Renderer linkedRenderer; // 0x20

	// Methods

	// RVA: 0x23A3610 Offset: 0x23A3711 VA: 0x23A3610
	public SpringBone.CollisionStatus CheckForCollisionAndReact(Vector3 headPosition, ref Vector3 tailPosition, float tailRadius, ref Vector3 hitNormal) { }

	// RVA: 0x23A37E0 Offset: 0x23A38E1 VA: 0x23A37E0
	public static SpringBone.CollisionStatus CheckForCollisionAndReact(Vector3 localHeadPosition, ref Vector3 localTailPosition, float localTailRadius, Vector3 sphereLocalOrigin, float sphereRadius) { }

	// RVA: 0x23993B0 Offset: 0x23994B1 VA: 0x23993B0
	public static bool ComputeIntersection(Vector3 originA, float radiusA, Vector3 originB, float radiusB, ref Circle3 intersection) { }

	// RVA: 0x2399600 Offset: 0x2399701 VA: 0x2399600
	public static Vector3 ComputeNewTailPosition(Circle3 intersection, Vector3 tailPosition) { }

	// RVA: 0x23A3AA0 Offset: 0x23A3BA1 VA: 0x23A3AA0
	public void .ctor() { }
}

