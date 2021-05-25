[NativeHeaderAttribute] // RVA: 0x109410 Offset: 0x109511 VA: 0x109410
public struct NavMeshBuildMarkup // TypeDefIndex: 3786
{
	// Fields
	private int m_OverrideArea; // 0x0
	private int m_Area; // 0x4
	private int m_IgnoreFromBuild; // 0x8
	private int m_InstanceID; // 0xC

	// Properties
	public bool overrideArea { set; }
	public int area { set; }
	public bool ignoreFromBuild { set; }
	public Transform root { set; }

	// Methods

	// RVA: 0x22C90 Offset: 0x22D91 VA: 0x22C90
	public void set_overrideArea(bool value) { }

	// RVA: 0x22CA0 Offset: 0x22DA1 VA: 0x22CA0
	public void set_area(int value) { }

	// RVA: 0x22CB0 Offset: 0x22DB1 VA: 0x22CB0
	public void set_ignoreFromBuild(bool value) { }

	// RVA: 0x22CC0 Offset: 0x22DC1 VA: 0x22CC0
	public void set_root(Transform value) { }
}

