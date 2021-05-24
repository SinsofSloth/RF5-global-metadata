[RequireComponent] // RVA: 0x119FC0 Offset: 0x11A0C1 VA: 0x119FC0
[ExecuteAlways] // RVA: 0x119FC0 Offset: 0x11A0C1 VA: 0x119FC0
[AddComponentMenu] // RVA: 0x119FC0 Offset: 0x11A0C1 VA: 0x119FC0
[DisallowMultipleComponent] // RVA: 0x119FC0 Offset: 0x11A0C1 VA: 0x119FC0
public class CanvasScaler : UIBehaviour // TypeDefIndex: 3957
{
	// Fields
	[TooltipAttribute] // RVA: 0x11BCA0 Offset: 0x11BDA1 VA: 0x11BCA0
	[SerializeField] // RVA: 0x11BCA0 Offset: 0x11BDA1 VA: 0x11BCA0
	private CanvasScaler.ScaleMode m_UiScaleMode; // 0x18
	[TooltipAttribute] // RVA: 0x11BCF0 Offset: 0x11BDF1 VA: 0x11BCF0
	[SerializeField] // RVA: 0x11BCF0 Offset: 0x11BDF1 VA: 0x11BCF0
	protected float m_ReferencePixelsPerUnit; // 0x1C
	[TooltipAttribute] // RVA: 0x11BD40 Offset: 0x11BE41 VA: 0x11BD40
	[SerializeField] // RVA: 0x11BD40 Offset: 0x11BE41 VA: 0x11BD40
	protected float m_ScaleFactor; // 0x20
	[TooltipAttribute] // RVA: 0x11BD90 Offset: 0x11BE91 VA: 0x11BD90
	[SerializeField] // RVA: 0x11BD90 Offset: 0x11BE91 VA: 0x11BD90
	protected Vector2 m_ReferenceResolution; // 0x24
	[TooltipAttribute] // RVA: 0x11BDE0 Offset: 0x11BEE1 VA: 0x11BDE0
	[SerializeField] // RVA: 0x11BDE0 Offset: 0x11BEE1 VA: 0x11BDE0
	protected CanvasScaler.ScreenMatchMode m_ScreenMatchMode; // 0x2C
	[TooltipAttribute] // RVA: 0x11BE30 Offset: 0x11BF31 VA: 0x11BE30
	[RangeAttribute] // RVA: 0x11BE30 Offset: 0x11BF31 VA: 0x11BE30
	[SerializeField] // RVA: 0x11BE30 Offset: 0x11BF31 VA: 0x11BE30
	protected float m_MatchWidthOrHeight; // 0x30
	private const float kLogBase = 2;
	[TooltipAttribute] // RVA: 0x11BEA0 Offset: 0x11BFA1 VA: 0x11BEA0
	[SerializeField] // RVA: 0x11BEA0 Offset: 0x11BFA1 VA: 0x11BEA0
	protected CanvasScaler.Unit m_PhysicalUnit; // 0x34
	[TooltipAttribute] // RVA: 0x11BEF0 Offset: 0x11BFF1 VA: 0x11BEF0
	[SerializeField] // RVA: 0x11BEF0 Offset: 0x11BFF1 VA: 0x11BEF0
	protected float m_FallbackScreenDPI; // 0x38
	[TooltipAttribute] // RVA: 0x11BF40 Offset: 0x11C041 VA: 0x11BF40
	[SerializeField] // RVA: 0x11BF40 Offset: 0x11C041 VA: 0x11BF40
	protected float m_DefaultSpriteDPI; // 0x3C
	[TooltipAttribute] // RVA: 0x11BF90 Offset: 0x11C091 VA: 0x11BF90
	[SerializeField] // RVA: 0x11BF90 Offset: 0x11C091 VA: 0x11BF90
	protected float m_DynamicPixelsPerUnit; // 0x40
	private Canvas m_Canvas; // 0x48
	private float m_PrevScaleFactor; // 0x50
	private float m_PrevReferencePixelsPerUnit; // 0x54

	// Properties
	public CanvasScaler.ScaleMode uiScaleMode { get; set; }
	public float referencePixelsPerUnit { get; set; }
	public float scaleFactor { get; set; }
	public Vector2 referenceResolution { get; set; }
	public CanvasScaler.ScreenMatchMode screenMatchMode { get; set; }
	public float matchWidthOrHeight { get; set; }
	public CanvasScaler.Unit physicalUnit { get; set; }
	public float fallbackScreenDPI { get; set; }
	public float defaultSpriteDPI { get; set; }
	public float dynamicPixelsPerUnit { get; set; }

	// Methods

	// RVA: 0x1646520 Offset: 0x1646621 VA: 0x1646520
	public CanvasScaler.ScaleMode get_uiScaleMode() { }

	// RVA: 0x1646530 Offset: 0x1646631 VA: 0x1646530
	public void set_uiScaleMode(CanvasScaler.ScaleMode value) { }

	// RVA: 0x1646540 Offset: 0x1646641 VA: 0x1646540
	public float get_referencePixelsPerUnit() { }

	// RVA: 0x1646550 Offset: 0x1646651 VA: 0x1646550
	public void set_referencePixelsPerUnit(float value) { }

	// RVA: 0x1646560 Offset: 0x1646661 VA: 0x1646560
	public float get_scaleFactor() { }

	// RVA: 0x1646570 Offset: 0x1646671 VA: 0x1646570
	public void set_scaleFactor(float value) { }

	// RVA: 0x1646600 Offset: 0x1646701 VA: 0x1646600
	public Vector2 get_referenceResolution() { }

	// RVA: 0x1646610 Offset: 0x1646711 VA: 0x1646610
	public void set_referenceResolution(Vector2 value) { }

	// RVA: 0x1646710 Offset: 0x1646811 VA: 0x1646710
	public CanvasScaler.ScreenMatchMode get_screenMatchMode() { }

	// RVA: 0x1646720 Offset: 0x1646821 VA: 0x1646720
	public void set_screenMatchMode(CanvasScaler.ScreenMatchMode value) { }

	// RVA: 0x1646730 Offset: 0x1646831 VA: 0x1646730
	public float get_matchWidthOrHeight() { }

	// RVA: 0x1646740 Offset: 0x1646841 VA: 0x1646740
	public void set_matchWidthOrHeight(float value) { }

	// RVA: 0x1646750 Offset: 0x1646851 VA: 0x1646750
	public CanvasScaler.Unit get_physicalUnit() { }

	// RVA: 0x1646760 Offset: 0x1646861 VA: 0x1646760
	public void set_physicalUnit(CanvasScaler.Unit value) { }

	// RVA: 0x1646770 Offset: 0x1646871 VA: 0x1646770
	public float get_fallbackScreenDPI() { }

	// RVA: 0x1646780 Offset: 0x1646881 VA: 0x1646780
	public void set_fallbackScreenDPI(float value) { }

	// RVA: 0x1646790 Offset: 0x1646891 VA: 0x1646790
	public float get_defaultSpriteDPI() { }

	// RVA: 0x16467A0 Offset: 0x16468A1 VA: 0x16467A0
	public void set_defaultSpriteDPI(float value) { }

	// RVA: 0x1646820 Offset: 0x1646921 VA: 0x1646820
	public float get_dynamicPixelsPerUnit() { }

	// RVA: 0x1646830 Offset: 0x1646931 VA: 0x1646830
	public void set_dynamicPixelsPerUnit(float value) { }

	// RVA: 0x1646840 Offset: 0x1646941 VA: 0x1646840
	protected void .ctor() { }

	// RVA: 0x16468D0 Offset: 0x16469D1 VA: 0x16468D0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1646950 Offset: 0x1646A51 VA: 0x1646950 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1646AA0 Offset: 0x1646BA1 VA: 0x1646AA0 Slot: 17
	protected virtual void Update() { }

	// RVA: 0x1646AB0 Offset: 0x1646BB1 VA: 0x1646AB0 Slot: 18
	protected virtual void Handle() { }

	// RVA: 0x1646BE0 Offset: 0x1646CE1 VA: 0x1646BE0 Slot: 19
	protected virtual void HandleWorldCanvas() { }

	// RVA: 0x1646C80 Offset: 0x1646D81 VA: 0x1646C80 Slot: 20
	protected virtual void HandleConstantPixelSize() { }

	// RVA: 0x1646D20 Offset: 0x1646E21 VA: 0x1646D20 Slot: 21
	protected virtual void HandleScaleWithScreenSize() { }

	// RVA: 0x1647010 Offset: 0x1647111 VA: 0x1647010 Slot: 22
	protected virtual void HandleConstantPhysicalSize() { }

	// RVA: 0x16469E0 Offset: 0x1646AE1 VA: 0x16469E0
	protected void SetScaleFactor(float scaleFactor) { }

	// RVA: 0x1646A40 Offset: 0x1646B41 VA: 0x1646A40
	protected void SetReferencePixelsPerUnit(float referencePixelsPerUnit) { }
}

