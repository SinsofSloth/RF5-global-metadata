[AddComponentMenu] // RVA: 0x11A1A0 Offset: 0x11A2A1 VA: 0x11A1A0
[RequireComponent] // RVA: 0x11A1A0 Offset: 0x11A2A1 VA: 0x11A1A0
[ExecuteAlways] // RVA: 0x11A1A0 Offset: 0x11A2A1 VA: 0x11A1A0
public class LayoutElement : UIBehaviour, ILayoutElement, ILayoutIgnorer // TypeDefIndex: 3974
{
	// Fields
	[SerializeField] // RVA: 0x11C0D0 Offset: 0x11C1D1 VA: 0x11C0D0
	private bool m_IgnoreLayout; // 0x18
	[SerializeField] // RVA: 0x11C0E0 Offset: 0x11C1E1 VA: 0x11C0E0
	private float m_MinWidth; // 0x1C
	[SerializeField] // RVA: 0x11C0F0 Offset: 0x11C1F1 VA: 0x11C0F0
	private float m_MinHeight; // 0x20
	[SerializeField] // RVA: 0x11C100 Offset: 0x11C201 VA: 0x11C100
	private float m_PreferredWidth; // 0x24
	[SerializeField] // RVA: 0x11C110 Offset: 0x11C211 VA: 0x11C110
	private float m_PreferredHeight; // 0x28
	[SerializeField] // RVA: 0x11C120 Offset: 0x11C221 VA: 0x11C120
	private float m_FlexibleWidth; // 0x2C
	[SerializeField] // RVA: 0x11C130 Offset: 0x11C231 VA: 0x11C130
	private float m_FlexibleHeight; // 0x30
	[SerializeField] // RVA: 0x11C140 Offset: 0x11C241 VA: 0x11C140
	private int m_LayoutPriority; // 0x34

	// Properties
	public virtual bool ignoreLayout { get; set; }
	public virtual float minWidth { get; set; }
	public virtual float minHeight { get; set; }
	public virtual float preferredWidth { get; set; }
	public virtual float preferredHeight { get; set; }
	public virtual float flexibleWidth { get; set; }
	public virtual float flexibleHeight { get; set; }
	public virtual int layoutPriority { get; set; }

	// Methods

	// RVA: 0x18BA1F0 Offset: 0x18BA2F1 VA: 0x18BA1F0 Slot: 27
	public virtual bool get_ignoreLayout() { }

	// RVA: 0x18BA200 Offset: 0x18BA301 VA: 0x18BA200 Slot: 28
	public virtual void set_ignoreLayout(bool value) { }

	// RVA: 0x18BA3E0 Offset: 0x18BA4E1 VA: 0x18BA3E0 Slot: 29
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x18BA3F0 Offset: 0x18BA4F1 VA: 0x18BA3F0 Slot: 30
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x18BA400 Offset: 0x18BA501 VA: 0x18BA400 Slot: 31
	public virtual float get_minWidth() { }

	// RVA: 0x18BA410 Offset: 0x18BA511 VA: 0x18BA410 Slot: 32
	public virtual void set_minWidth(float value) { }

	// RVA: 0x18BA530 Offset: 0x18BA631 VA: 0x18BA530 Slot: 33
	public virtual float get_minHeight() { }

	// RVA: 0x18BA540 Offset: 0x18BA641 VA: 0x18BA540 Slot: 34
	public virtual void set_minHeight(float value) { }

	// RVA: 0x18BA660 Offset: 0x18BA761 VA: 0x18BA660 Slot: 35
	public virtual float get_preferredWidth() { }

	// RVA: 0x18BA670 Offset: 0x18BA771 VA: 0x18BA670 Slot: 36
	public virtual void set_preferredWidth(float value) { }

	// RVA: 0x18BA790 Offset: 0x18BA891 VA: 0x18BA790 Slot: 37
	public virtual float get_preferredHeight() { }

	// RVA: 0x18BA7A0 Offset: 0x18BA8A1 VA: 0x18BA7A0 Slot: 38
	public virtual void set_preferredHeight(float value) { }

	// RVA: 0x18BA8C0 Offset: 0x18BA9C1 VA: 0x18BA8C0 Slot: 39
	public virtual float get_flexibleWidth() { }

	// RVA: 0x18BA8D0 Offset: 0x18BA9D1 VA: 0x18BA8D0 Slot: 40
	public virtual void set_flexibleWidth(float value) { }

	// RVA: 0x18BA9F0 Offset: 0x18BAAF1 VA: 0x18BA9F0 Slot: 41
	public virtual float get_flexibleHeight() { }

	// RVA: 0x18BAA00 Offset: 0x18BAB01 VA: 0x18BAA00 Slot: 42
	public virtual void set_flexibleHeight(float value) { }

	// RVA: 0x18BAB20 Offset: 0x18BAC21 VA: 0x18BAB20 Slot: 43
	public virtual int get_layoutPriority() { }

	// RVA: 0x18BAB30 Offset: 0x18BAC31 VA: 0x18BAB30 Slot: 44
	public virtual void set_layoutPriority(int value) { }

	// RVA: 0x18BAC50 Offset: 0x18BAD51 VA: 0x18BAC50
	protected void .ctor() { }

	// RVA: 0x18BAC80 Offset: 0x18BAD81 VA: 0x18BAC80 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x18BAD50 Offset: 0x18BAE51 VA: 0x18BAD50 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x18BAE10 Offset: 0x18BAF11 VA: 0x18BAE10 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x18BAED0 Offset: 0x18BAFD1 VA: 0x18BAED0 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x18BAF90 Offset: 0x18BB091 VA: 0x18BAF90 Slot: 11
	protected override void OnBeforeTransformParentChanged() { }

	// RVA: 0x18BA320 Offset: 0x18BA421 VA: 0x18BA320
	protected void SetDirty() { }
}

