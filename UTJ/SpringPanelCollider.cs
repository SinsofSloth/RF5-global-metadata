public class SpringPanelCollider : MonoBehaviour // TypeDefIndex: 9114
{
	// Fields
	public float width; // 0x18
	public float height; // 0x1C
	public Renderer linkedRenderer; // 0x20

	// Methods

	// RVA: 0x23A26D0 Offset: 0x23A27D1 VA: 0x23A26D0
	public Vector3 GetPlaneNormal() { }

	// RVA: 0x23A2700 Offset: 0x23A2801 VA: 0x23A2700
	public SpringBone.CollisionStatus CheckForCollisionAndReact(Vector3 headPosition, float length, ref Vector3 tailPosition, float tailRadius, ref Vector3 hitNormal) { }

	// RVA: 0x23A2C70 Offset: 0x23A2D71 VA: 0x23A2C70
	public static SpringBone.CollisionStatus CheckForCollisionWithAlignedPlaneAndReact(Vector3 localHeadPosition, float localLength, ref Vector3 localTailPosition, float localTailRadius, SpringPanelCollider.Axis upAxis) { }

	// RVA: 0x23A2F80 Offset: 0x23A3081 VA: 0x23A2F80
	public void .ctor() { }
}

