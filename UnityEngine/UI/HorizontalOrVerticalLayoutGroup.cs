[ExecuteAlways] // RVA: 0x11A190 Offset: 0x11A291 VA: 0x11A190
public abstract class HorizontalOrVerticalLayoutGroup : LayoutGroup // TypeDefIndex: 3968
{
	// Fields
	[SerializeField] // RVA: 0x11C060 Offset: 0x11C161 VA: 0x11C060
	protected float m_Spacing; // 0x58
	[SerializeField] // RVA: 0x11C070 Offset: 0x11C171 VA: 0x11C070
	protected bool m_ChildForceExpandWidth; // 0x5C
	[SerializeField] // RVA: 0x11C080 Offset: 0x11C181 VA: 0x11C080
	protected bool m_ChildForceExpandHeight; // 0x5D
	[SerializeField] // RVA: 0x11C090 Offset: 0x11C191 VA: 0x11C090
	protected bool m_ChildControlWidth; // 0x5E
	[SerializeField] // RVA: 0x11C0A0 Offset: 0x11C1A1 VA: 0x11C0A0
	protected bool m_ChildControlHeight; // 0x5F
	[SerializeField] // RVA: 0x11C0B0 Offset: 0x11C1B1 VA: 0x11C0B0
	protected bool m_ChildScaleWidth; // 0x60
	[SerializeField] // RVA: 0x11C0C0 Offset: 0x11C1C1 VA: 0x11C0C0
	protected bool m_ChildScaleHeight; // 0x61

	// Properties
	public float spacing { get; set; }
	public bool childForceExpandWidth { get; set; }
	public bool childForceExpandHeight { get; set; }
	public bool childControlWidth { get; set; }
	public bool childControlHeight { get; set; }
	public bool childScaleWidth { get; set; }
	public bool childScaleHeight { get; set; }

	// Methods

	// RVA: 0x186C880 Offset: 0x186C981 VA: 0x186C880
	public float get_spacing() { }

	// RVA: 0x186C890 Offset: 0x186C991 VA: 0x186C890
	public void set_spacing(float value) { }

	// RVA: 0x186C900 Offset: 0x186CA01 VA: 0x186C900
	public bool get_childForceExpandWidth() { }

	// RVA: 0x186C910 Offset: 0x186CA11 VA: 0x186C910
	public void set_childForceExpandWidth(bool value) { }

	// RVA: 0x186C980 Offset: 0x186CA81 VA: 0x186C980
	public bool get_childForceExpandHeight() { }

	// RVA: 0x186C990 Offset: 0x186CA91 VA: 0x186C990
	public void set_childForceExpandHeight(bool value) { }

	// RVA: 0x186CA00 Offset: 0x186CB01 VA: 0x186CA00
	public bool get_childControlWidth() { }

	// RVA: 0x186CA10 Offset: 0x186CB11 VA: 0x186CA10
	public void set_childControlWidth(bool value) { }

	// RVA: 0x186CA80 Offset: 0x186CB81 VA: 0x186CA80
	public bool get_childControlHeight() { }

	// RVA: 0x186CA90 Offset: 0x186CB91 VA: 0x186CA90
	public void set_childControlHeight(bool value) { }

	// RVA: 0x186CB00 Offset: 0x186CC01 VA: 0x186CB00
	public bool get_childScaleWidth() { }

	// RVA: 0x186CB10 Offset: 0x186CC11 VA: 0x186CB10
	public void set_childScaleWidth(bool value) { }

	// RVA: 0x186CB80 Offset: 0x186CC81 VA: 0x186CB80
	public bool get_childScaleHeight() { }

	// RVA: 0x186CB90 Offset: 0x186CC91 VA: 0x186CB90
	public void set_childScaleHeight(bool value) { }

	// RVA: 0x186BEC0 Offset: 0x186BFC1 VA: 0x186BEC0
	protected void CalcAlongAxis(int axis, bool isVertical) { }

	// RVA: 0x186C290 Offset: 0x186C391 VA: 0x186C290
	protected void SetChildrenAlongAxis(int axis, bool isVertical) { }

	// RVA: 0x186CC00 Offset: 0x186CD01 VA: 0x186CC00
	private void GetChildSizes(RectTransform child, int axis, bool controlSize, bool childForceExpand, out float min, out float preferred, out float flexible) { }

	// RVA: 0x186BE80 Offset: 0x186BF81 VA: 0x186BE80
	protected void .ctor() { }
}

