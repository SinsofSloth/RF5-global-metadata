public struct RaycastResult // TypeDefIndex: 4088
{
	// Fields
	private GameObject m_GameObject; // 0x0
	public BaseRaycaster module; // 0x8
	public float distance; // 0x10
	public float index; // 0x14
	public int depth; // 0x18
	public int sortingLayer; // 0x1C
	public int sortingOrder; // 0x20
	public Vector3 worldPosition; // 0x24
	public Vector3 worldNormal; // 0x30
	public Vector2 screenPosition; // 0x3C
	public int displayIndex; // 0x44

	// Properties
	public GameObject gameObject { get; set; }
	public bool isValid { get; }

	// Methods

	// RVA: 0x5600 Offset: 0x5701 VA: 0x5600
	public GameObject get_gameObject() { }

	// RVA: 0x5610 Offset: 0x5711 VA: 0x5610
	public void set_gameObject(GameObject value) { }

	// RVA: 0x5620 Offset: 0x5721 VA: 0x5620
	public bool get_isValid() { }

	// RVA: 0x5630 Offset: 0x5731 VA: 0x5630
	public void Clear() { }

	// RVA: 0x5640 Offset: 0x5741 VA: 0x5640 Slot: 3
	public override string ToString() { }
}

