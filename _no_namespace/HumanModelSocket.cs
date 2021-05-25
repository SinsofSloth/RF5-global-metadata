[Serializable]
public class HumanModelSocket // TypeDefIndex: 6663
{
	// Fields
	[SerializeField] // RVA: 0x15E9A0 Offset: 0x15EAA1 VA: 0x15E9A0
	public HumanAttachIDEnum AttachId; // 0x10
	[SerializeField] // RVA: 0x15E9B0 Offset: 0x15EAB1 VA: 0x15E9B0
	public bool IsVisible; // 0x14
	[SerializeField] // RVA: 0x15E9C0 Offset: 0x15EAC1 VA: 0x15E9C0
	public Transform AttachTarget; // 0x18
	[SerializeField] // RVA: 0x15E9D0 Offset: 0x15EAD1 VA: 0x15E9D0
	[RangeAttribute] // RVA: 0x15E9D0 Offset: 0x15EAD1 VA: 0x15E9D0
	public float Weight; // 0x20
	[SerializeField] // RVA: 0x15EA10 Offset: 0x15EB11 VA: 0x15EA10
	public Vector3 AttachPosition; // 0x24
	[SerializeField] // RVA: 0x15EA20 Offset: 0x15EB21 VA: 0x15EA20
	public Vector3 AttachRotation; // 0x30
	[SerializeField] // RVA: 0x15EA30 Offset: 0x15EB31 VA: 0x15EA30
	public Vector3 AttachScale; // 0x3C
	[SerializeField] // RVA: 0x15EA40 Offset: 0x15EB41 VA: 0x15EA40
	private Transform AttachedObject; // 0x48
	[SerializeField] // RVA: 0x15EA50 Offset: 0x15EB51 VA: 0x15EA50
	public List<EraseObject> EraseList; // 0x50
	public static readonly string[] AttachPointName; // 0x0
	private readonly string[] EraseName; // 0x58

	// Properties
	public Transform AttachSocket { get; }
	public Transform EquipItem { get; }

	// Methods

	// RVA: 0x20C0440 Offset: 0x20C0541 VA: 0x20C0440
	public Transform get_AttachSocket() { }

	// RVA: 0x20C0450 Offset: 0x20C0551 VA: 0x20C0450
	public Transform get_EquipItem() { }

	// RVA: 0x20C0460 Offset: 0x20C0561 VA: 0x20C0460
	public bool Reset(HumanAttachIDEnum id, Transform target, HumanJoint[] joints) { }

	// RVA: 0x20BFAD0 Offset: 0x20BFBD1 VA: 0x20BFAD0
	public Transform Attach(Transform item, HumanJoint[] joints) { }

	// RVA: 0x20BFCB0 Offset: 0x20BFDB1 VA: 0x20BFCB0
	public Transform Detach(HumanJoint[] joints) { }

	// RVA: 0x20BFDD0 Offset: 0x20BFED1 VA: 0x20BFDD0
	public void EraseOn(HumanJoint[] joints) { }

	// RVA: 0x20BFFC0 Offset: 0x20C00C1 VA: 0x20BFFC0
	public void EraseOff(HumanJoint[] joints) { }

	// RVA: 0x20C0B50 Offset: 0x20C0C51 VA: 0x20C0B50
	public void SetAlpha(float alpha) { }

	// RVA: 0x20C0B60 Offset: 0x20C0C61 VA: 0x20C0B60
	public void .ctor() { }

	// RVA: 0x20C1010 Offset: 0x20C1111 VA: 0x20C1010
	private static void .cctor() { }
}

