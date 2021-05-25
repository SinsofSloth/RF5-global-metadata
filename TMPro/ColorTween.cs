internal struct ColorTween : ITweenValue // TypeDefIndex: 5762
{
	// Fields
	private ColorTween.ColorTweenCallback m_Target; // 0x0
	private Color m_StartColor; // 0x8
	private Color m_TargetColor; // 0x18
	private ColorTween.ColorTweenMode m_TweenMode; // 0x28
	private float m_Duration; // 0x2C
	private bool m_IgnoreTimeScale; // 0x30

	// Properties
	public Color startColor { get; set; }
	public Color targetColor { get; set; }
	public ColorTween.ColorTweenMode tweenMode { get; set; }
	public float duration { get; set; }
	public bool ignoreTimeScale { get; set; }

	// Methods

	// RVA: 0x20B0 Offset: 0x21B1 VA: 0x20B0
	public Color get_startColor() { }

	// RVA: 0x20C0 Offset: 0x21C1 VA: 0x20C0
	public void set_startColor(Color value) { }

	// RVA: 0x20E0 Offset: 0x21E1 VA: 0x20E0
	public Color get_targetColor() { }

	// RVA: 0x20F0 Offset: 0x21F1 VA: 0x20F0
	public void set_targetColor(Color value) { }

	// RVA: 0x2110 Offset: 0x2211 VA: 0x2110
	public ColorTween.ColorTweenMode get_tweenMode() { }

	// RVA: 0x2120 Offset: 0x2221 VA: 0x2120
	public void set_tweenMode(ColorTween.ColorTweenMode value) { }

	// RVA: 0x2130 Offset: 0x2231 VA: 0x2130 Slot: 6
	public float get_duration() { }

	// RVA: 0x2140 Offset: 0x2241 VA: 0x2140
	public void set_duration(float value) { }

	// RVA: 0x2150 Offset: 0x2251 VA: 0x2150 Slot: 5
	public bool get_ignoreTimeScale() { }

	// RVA: 0x2160 Offset: 0x2261 VA: 0x2160
	public void set_ignoreTimeScale(bool value) { }

	// RVA: 0x2170 Offset: 0x2271 VA: 0x2170 Slot: 4
	public void TweenValue(float floatPercentage) { }

	// RVA: 0x2180 Offset: 0x2281 VA: 0x2180
	public void AddOnChangedCallback(UnityAction<Color> callback) { }

	// RVA: 0x2190 Offset: 0x2291 VA: 0x2190
	public bool GetIgnoreTimescale() { }

	// RVA: 0x21A0 Offset: 0x22A1 VA: 0x21A0
	public float GetDuration() { }

	// RVA: 0x21B0 Offset: 0x22B1 VA: 0x21B0 Slot: 7
	public bool ValidTarget() { }
}

