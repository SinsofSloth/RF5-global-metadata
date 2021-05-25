[AddComponentMenu] // RVA: 0x147800 Offset: 0x147901 VA: 0x147800
public class DynamicBoneCollider : DynamicBoneColliderBase // TypeDefIndex: 8973
{
	// Fields
	public float m_Radius; // 0x2C
	public float m_Height; // 0x30

	// Methods

	// RVA: 0x2012DA0 Offset: 0x2012EA1 VA: 0x2012DA0
	private void OnValidate() { }

	// RVA: 0x2012E40 Offset: 0x2012F41 VA: 0x2012E40 Slot: 4
	public override void Collide(ref Vector3 particlePosition, float particleRadius) { }

	// RVA: 0x20130A0 Offset: 0x20131A1 VA: 0x20130A0
	private static void OutsideSphere(ref Vector3 particlePosition, float particleRadius, Vector3 sphereCenter, float sphereRadius) { }

	// RVA: 0x2013250 Offset: 0x2013351 VA: 0x2013250
	private static void InsideSphere(ref Vector3 particlePosition, float particleRadius, Vector3 sphereCenter, float sphereRadius) { }

	// RVA: 0x20133F0 Offset: 0x20134F1 VA: 0x20133F0
	private static void OutsideCapsule(ref Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius) { }

	// RVA: 0x2013830 Offset: 0x2013931 VA: 0x2013830
	private static void InsideCapsule(ref Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius) { }

	// RVA: 0x2013C50 Offset: 0x2013D51 VA: 0x2013C50
	private void OnDrawGizmosSelected() { }

	// RVA: 0x2013E50 Offset: 0x2013F51 VA: 0x2013E50
	public void .ctor() { }
}

