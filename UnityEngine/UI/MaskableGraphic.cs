public abstract class MaskableGraphic : Graphic, IClippable, IMaskable, IMaterialModifier // TypeDefIndex: 3984
{
	// Fields
	protected bool m_ShouldRecalculateStencil; // 0x89
	protected Material m_MaskMaterial; // 0x90
	private RectMask2D m_ParentMask; // 0x98
	[SerializeField] // RVA: 0x11C180 Offset: 0x11C281 VA: 0x11C180
	private bool m_Maskable; // 0xA0
	private bool m_IsMaskingGraphic; // 0xA1
	[EditorBrowsableAttribute] // RVA: 0x11C190 Offset: 0x11C291 VA: 0x11C190
	[ObsoleteAttribute] // RVA: 0x11C190 Offset: 0x11C291 VA: 0x11C190
	protected bool m_IncludeForMasking; // 0xA2
	[SerializeField] // RVA: 0x11C1F0 Offset: 0x11C2F1 VA: 0x11C1F0
	private MaskableGraphic.CullStateChangedEvent m_OnCullStateChanged; // 0xA8
	[EditorBrowsableAttribute] // RVA: 0x11C200 Offset: 0x11C301 VA: 0x11C200
	[ObsoleteAttribute] // RVA: 0x11C200 Offset: 0x11C301 VA: 0x11C200
	protected bool m_ShouldRecalculate; // 0xB0
	protected int m_StencilValue; // 0xB4
	private readonly Vector3[] m_Corners; // 0xB8

	// Properties
	public MaskableGraphic.CullStateChangedEvent onCullStateChanged { get; set; }
	public bool maskable { get; set; }
	public bool isMaskingGraphic { get; set; }
	private Rect rootCanvasRect { get; }

	// Methods

	// RVA: 0x18C1690 Offset: 0x18C1791 VA: 0x18C1690
	public MaskableGraphic.CullStateChangedEvent get_onCullStateChanged() { }

	// RVA: 0x18C16A0 Offset: 0x18C17A1 VA: 0x18C16A0
	public void set_onCullStateChanged(MaskableGraphic.CullStateChangedEvent value) { }

	// RVA: 0x18C16B0 Offset: 0x18C17B1 VA: 0x18C16B0
	public bool get_maskable() { }

	// RVA: 0x18C16C0 Offset: 0x18C17C1 VA: 0x18C16C0
	public void set_maskable(bool value) { }

	// RVA: 0x18C1700 Offset: 0x18C1801 VA: 0x18C1700
	public bool get_isMaskingGraphic() { }

	// RVA: 0x18BFAB0 Offset: 0x18BFBB1 VA: 0x18BFAB0
	public void set_isMaskingGraphic(bool value) { }

	// RVA: 0x18C1710 Offset: 0x18C1811 VA: 0x18C1710 Slot: 58
	public virtual Material GetModifiedMaterial(Material baseMaterial) { }

	// RVA: 0x18C1850 Offset: 0x18C1951 VA: 0x18C1850 Slot: 59
	public virtual void Cull(Rect clipRect, bool validRect) { }

	// RVA: 0x18C1E00 Offset: 0x18C1F01 VA: 0x18C1E00
	private void UpdateCull(bool cull) { }

	// RVA: 0x18C1EF0 Offset: 0x18C1FF1 VA: 0x18C1EF0 Slot: 60
	public virtual void SetClipRect(Rect clipRect, bool validRect) { }

	// RVA: 0x18C1F70 Offset: 0x18C2071 VA: 0x18C1F70 Slot: 61
	public virtual void SetClipSoftness(Vector2 clipSoftness) { }

	// RVA: 0x18C1FB0 Offset: 0x18C20B1 VA: 0x18C1FB0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x18C2190 Offset: 0x18C2291 VA: 0x18C2190 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x18C2270 Offset: 0x18C2371 VA: 0x18C2270 Slot: 12
	protected override void OnTransformParentChanged() { }

	[EditorBrowsableAttribute] // RVA: 0x11D140 Offset: 0x11D241 VA: 0x11D140
	[ObsoleteAttribute] // RVA: 0x11D140 Offset: 0x11D241 VA: 0x11D140
	// RVA: 0x18C22D0 Offset: 0x18C23D1 VA: 0x18C22D0 Slot: 62
	public virtual void ParentMaskStateChanged() { }

	// RVA: 0x18C22E0 Offset: 0x18C23E1 VA: 0x18C22E0 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x18C18B0 Offset: 0x18C19B1 VA: 0x18C18B0
	private Rect get_rootCanvasRect() { }

	// RVA: 0x18C2010 Offset: 0x18C2111 VA: 0x18C2010
	private void UpdateClipParent() { }

	// RVA: 0x18C25E0 Offset: 0x18C26E1 VA: 0x18C25E0 Slot: 63
	public virtual void RecalculateClipping() { }

	// RVA: 0x18C25F0 Offset: 0x18C26F1 VA: 0x18C25F0 Slot: 64
	public virtual void RecalculateMasking() { }

	// RVA: 0x18C26A0 Offset: 0x18C27A1 VA: 0x18C26A0
	protected void .ctor() { }

	// RVA: 0x18C27F0 Offset: 0x18C28F1 VA: 0x18C27F0 Slot: 50
	private GameObject UnityEngine.UI.IClippable.get_gameObject() { }
}

