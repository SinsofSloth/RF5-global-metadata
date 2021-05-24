internal struct ColorTween : ITweenValue // TypeDefIndex: 4038
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

	// RVA: 0x59A0 Offset: 0x5AA1 VA: 0x59A0
	public Color get_startColor() { }

	// RVA: 0x59B0 Offset: 0x5AB1 VA: 0x59B0
	public void set_startColor(Color value) { }

	// RVA: 0x59D0 Offset: 0x5AD1 VA: 0x59D0
	public Color get_targetColor() { }

	// RVA: 0x59E0 Offset: 0x5AE1 VA: 0x59E0
	public void set_targetColor(Color value) { }

	// RVA: 0x5A00 Offset: 0x5B01 VA: 0x5A00
	public ColorTween.ColorTweenMode get_tweenMode() { }

	// RVA: 0x5A10 Offset: 0x5B11 VA: 0x5A10
	public void set_tweenMode(ColorTween.ColorTweenMode value) { }

	// RVA: 0x5A20 Offset: 0x5B21 VA: 0x5A20 Slot: 6
	public float get_duration() { }

	// RVA: 0x5A30 Offset: 0x5B31 VA: 0x5A30
	public void set_duration(float value) { }

	// RVA: 0x5A40 Offset: 0x5B41 VA: 0x5A40 Slot: 5
	public bool get_ignoreTimeScale() { }

	// RVA: 0x5A50 Offset: 0x5B51 VA: 0x5A50
	public void set_ignoreTimeScale(bool value) { }

	// RVA: 0x5A60 Offset: 0x5B61 VA: 0x5A60 Slot: 4
	public void TweenValue(float floatPercentage) { }

	// RVA: 0x5A70 Offset: 0x5B71 VA: 0x5A70
	public void AddOnChangedCallback(UnityAction<Color> callback) { }

	// RVA: 0x5A80 Offset: 0x5B81 VA: 0x5A80
	public bool GetIgnoreTimescale() { }

	// RVA: 0x5A90 Offset: 0x5B91 VA: 0x5A90
	public float GetDuration() { }

	// RVA: 0x5AA0 Offset: 0x5BA1 VA: 0x5AA0 Slot: 7
	public bool ValidTarget() { }
}

