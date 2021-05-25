[AddComponentMenu] // RVA: 0x11A310 Offset: 0x11A411 VA: 0x11A310
[ExecuteAlways] // RVA: 0x11A310 Offset: 0x11A411 VA: 0x11A310
[RequireComponent] // RVA: 0x11A310 Offset: 0x11A411 VA: 0x11A310
[DisallowMultipleComponent] // RVA: 0x11A310 Offset: 0x11A411 VA: 0x11A310
public class Mask : UIBehaviour, ICanvasRaycastFilter, IMaterialModifier // TypeDefIndex: 3982
{
	// Fields
	private RectTransform m_RectTransform; // 0x18
	[SerializeField] // RVA: 0x11C170 Offset: 0x11C271 VA: 0x11C170
	private bool m_ShowMaskGraphic; // 0x20
	private Graphic m_Graphic; // 0x28
	private Material m_MaskMaterial; // 0x30
	private Material m_UnmaskMaterial; // 0x38

	// Properties
	public RectTransform rectTransform { get; }
	public bool showMaskGraphic { get; set; }
	public Graphic graphic { get; }

	// Methods

	// RVA: 0x18BF430 Offset: 0x18BF531 VA: 0x18BF430
	public RectTransform get_rectTransform() { }

	// RVA: 0x18BF4B0 Offset: 0x18BF5B1 VA: 0x18BF4B0
	public bool get_showMaskGraphic() { }

	// RVA: 0x18BF4C0 Offset: 0x18BF5C1 VA: 0x18BF4C0
	public void set_showMaskGraphic(bool value) { }

	// RVA: 0x18BF630 Offset: 0x18BF731 VA: 0x18BF630
	public Graphic get_graphic() { }

	// RVA: 0x18BF6B0 Offset: 0x18BF7B1 VA: 0x18BF6B0
	protected void .ctor() { }

	// RVA: 0x18BF6C0 Offset: 0x18BF7C1 VA: 0x18BF6C0 Slot: 19
	public virtual bool MaskEnabled() { }

	[ObsoleteAttribute] // RVA: 0x11D100 Offset: 0x11D201 VA: 0x11D100
	// RVA: 0x18BF7C0 Offset: 0x18BF8C1 VA: 0x18BF7C0 Slot: 20
	public virtual void OnSiblingGraphicEnabledDisabled() { }

	// RVA: 0x18BF7D0 Offset: 0x18BF8D1 VA: 0x18BF7D0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x18BFD20 Offset: 0x18BFE21 VA: 0x18BFD20 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x18C00D0 Offset: 0x18C01D1 VA: 0x18C00D0 Slot: 21
	public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x18C01E0 Offset: 0x18C02E1 VA: 0x18C01E0 Slot: 22
	public virtual Material GetModifiedMaterial(Material baseMaterial) { }
}

