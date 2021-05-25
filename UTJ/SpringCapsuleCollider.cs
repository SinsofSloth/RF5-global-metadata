public class SpringCapsuleCollider : MonoBehaviour // TypeDefIndex: 9113
{
	// Fields
	public float radius; // 0x18
	public float height; // 0x1C
	public Renderer linkedRenderer; // 0x20

	// Methods

	// RVA: 0x2398DB0 Offset: 0x2398EB1 VA: 0x2398DB0
	public SpringBone.CollisionStatus CheckForCollisionAndReact(Vector3 moverHeadPosition, ref Vector3 moverPosition, float moverRadius, ref Vector3 hitNormal) { }

	// RVA: 0x23997A0 Offset: 0x23998A1 VA: 0x23997A0
	private SpringBone.CollisionStatus CheckForCylinderCollisionAndReact(Vector3 localHeadPosition, ref Vector3 worldMoverPosition, float localMoverRadius, Vector3 localSpherePosition, ref Vector3 hitNormal) { }

	// RVA: 0x23999A0 Offset: 0x2399AA1 VA: 0x23999A0
	public void .ctor() { }
}

