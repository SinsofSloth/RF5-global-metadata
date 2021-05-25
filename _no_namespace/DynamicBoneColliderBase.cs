public class DynamicBoneColliderBase : MonoBehaviour // TypeDefIndex: 8974
{
	// Fields
	public DynamicBoneColliderBase.Direction m_Direction; // 0x18
	public Vector3 m_Center; // 0x1C
	public DynamicBoneColliderBase.Bound m_Bound; // 0x28

	// Methods

	// RVA: 0x2013F60 Offset: 0x2014061 VA: 0x2013F60 Slot: 4
	public virtual void Collide(ref Vector3 particlePosition, float particleRadius) { }

	// RVA: 0x2013EE0 Offset: 0x2013FE1 VA: 0x2013EE0
	public void .ctor() { }
}

