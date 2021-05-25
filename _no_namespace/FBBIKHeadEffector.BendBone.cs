[Serializable]
public class FBBIKHeadEffector.BendBone // TypeDefIndex: 9459
{
	// Fields
	[TooltipAttribute] // RVA: 0x1966D0 Offset: 0x1967D1 VA: 0x1966D0
	public Transform transform; // 0x10
	[TooltipAttribute] // RVA: 0x196710 Offset: 0x196811 VA: 0x196710
	[RangeAttribute] // RVA: 0x196710 Offset: 0x196811 VA: 0x196710
	public float weight; // 0x18
	private Quaternion defaultLocalRotation; // 0x1C

	// Methods

	// RVA: 0x2B29310 Offset: 0x2B29411 VA: 0x2B29310
	public void .ctor() { }

	// RVA: 0x2B293A0 Offset: 0x2B294A1 VA: 0x2B293A0
	public void .ctor(Transform transform, float weight) { }

	// RVA: 0x2B29450 Offset: 0x2B29551 VA: 0x2B29450
	public void StoreDefaultLocalState() { }

	// RVA: 0x2B29490 Offset: 0x2B29591 VA: 0x2B29490
	public void FixTransforms() { }
}

