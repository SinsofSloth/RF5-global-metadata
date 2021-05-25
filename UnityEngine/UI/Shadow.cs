[AddComponentMenu] // RVA: 0x11A970 Offset: 0x11AA71 VA: 0x11A970
public class Shadow : BaseMeshEffect // TypeDefIndex: 4035
{
	// Fields
	[SerializeField] // RVA: 0x11CA00 Offset: 0x11CB01 VA: 0x11CA00
	private Color m_EffectColor; // 0x20
	[SerializeField] // RVA: 0x11CA10 Offset: 0x11CB11 VA: 0x11CA10
	private Vector2 m_EffectDistance; // 0x30
	[SerializeField] // RVA: 0x11CA20 Offset: 0x11CB21 VA: 0x11CA20
	private bool m_UseGraphicAlpha; // 0x38
	private const float kMaxEffectDistance = 600;

	// Properties
	public Color effectColor { get; set; }
	public Vector2 effectDistance { get; set; }
	public bool useGraphicAlpha { get; set; }

	// Methods

	// RVA: 0x18C2E70 Offset: 0x18C2F71 VA: 0x18C2E70
	protected void .ctor() { }

	// RVA: 0x18D2530 Offset: 0x18D2631 VA: 0x18D2530
	public Color get_effectColor() { }

	// RVA: 0x18D2540 Offset: 0x18D2641 VA: 0x18D2540
	public void set_effectColor(Color value) { }

	// RVA: 0x18D2620 Offset: 0x18D2721 VA: 0x18D2620
	public Vector2 get_effectDistance() { }

	// RVA: 0x18D2630 Offset: 0x18D2731 VA: 0x18D2630
	public void set_effectDistance(Vector2 value) { }

	// RVA: 0x18D2770 Offset: 0x18D2871 VA: 0x18D2770
	public bool get_useGraphicAlpha() { }

	// RVA: 0x18D2780 Offset: 0x18D2881 VA: 0x18D2780
	public void set_useGraphicAlpha(bool value) { }

	// RVA: 0x18C3120 Offset: 0x18C3221 VA: 0x18C3120
	protected void ApplyShadowZeroAlloc(List<UIVertex> verts, Color32 color, int start, int end, float x, float y) { }

	// RVA: 0x18D2850 Offset: 0x18D2951 VA: 0x18D2850
	protected void ApplyShadow(List<UIVertex> verts, Color32 color, int start, int end, float x, float y) { }

	// RVA: 0x18D2860 Offset: 0x18D2961 VA: 0x18D2860 Slot: 20
	public override void ModifyMesh(VertexHelper vh) { }
}

