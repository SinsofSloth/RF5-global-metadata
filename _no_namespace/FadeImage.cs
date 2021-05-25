public class FadeImage : Graphic, IFade // TypeDefIndex: 7702
{
	// Fields
	[SerializeField] // RVA: 0x168B60 Offset: 0x168C61 VA: 0x168B60
	private Texture maskTexture; // 0x90
	[SerializeField] // RVA: 0x168B70 Offset: 0x168C71 VA: 0x168B70
	[RangeAttribute] // RVA: 0x168B70 Offset: 0x168C71 VA: 0x168B70
	private float cutoutRange; // 0x98
	private Color m_color; // 0x9C

	// Properties
	public float Range { get; set; }
	public Color fadeColor { get; set; }

	// Methods

	// RVA: 0x2084A00 Offset: 0x2084B01 VA: 0x2084A00 Slot: 50
	public float get_Range() { }

	// RVA: 0x2084A10 Offset: 0x2084B11 VA: 0x2084A10 Slot: 51
	public void set_Range(float value) { }

	// RVA: 0x2084B90 Offset: 0x2084C91 VA: 0x2084B90 Slot: 52
	public Color get_fadeColor() { }

	// RVA: 0x2084BA0 Offset: 0x2084CA1 VA: 0x2084BA0 Slot: 53
	public void set_fadeColor(Color value) { }

	// RVA: 0x2084CF0 Offset: 0x2084DF1 VA: 0x2084CF0 Slot: 6
	protected override void Start() { }

	// RVA: 0x2084AD0 Offset: 0x2084BD1 VA: 0x2084AD0
	private void UpdateMaskCutout(float range) { }

	// RVA: 0x2084D20 Offset: 0x2084E21 VA: 0x2084D20
	public void UpdateMaskTexture(Texture texture) { }

	// RVA: 0x2084C50 Offset: 0x2084D51 VA: 0x2084C50
	public void UpdateMaskColor(Color fadecolor) { }

	// RVA: 0x2084DF0 Offset: 0x2084EF1 VA: 0x2084DF0
	public void .ctor() { }
}

