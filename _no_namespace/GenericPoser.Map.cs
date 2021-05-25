[Serializable]
public class GenericPoser.Map // TypeDefIndex: 9527
{
	// Fields
	public Transform bone; // 0x10
	public Transform target; // 0x18
	private Vector3 defaultLocalPosition; // 0x20
	private Quaternion defaultLocalRotation; // 0x2C

	// Methods

	// RVA: 0x2B2F990 Offset: 0x2B2FA91 VA: 0x2B2F990
	public void .ctor(Transform bone, Transform target) { }

	// RVA: 0x2B2FE90 Offset: 0x2B2FF91 VA: 0x2B2FE90
	public void StoreDefaultState() { }

	// RVA: 0x2B2FE40 Offset: 0x2B2FF41 VA: 0x2B2FE40
	public void FixTransform() { }

	// RVA: 0x2B2FC00 Offset: 0x2B2FD01 VA: 0x2B2FC00
	public void Update(float localRotationWeight, float localPositionWeight) { }
}

