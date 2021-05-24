internal struct FloatTween : ITweenValue // TypeDefIndex: 4041
{
	// Fields
	private FloatTween.FloatTweenCallback m_Target; // 0x0
	private float m_StartValue; // 0x8
	private float m_TargetValue; // 0xC
	private float m_Duration; // 0x10
	private bool m_IgnoreTimeScale; // 0x14

	// Properties
	public float startValue { get; set; }
	public float targetValue { get; set; }
	public float duration { get; set; }
	public bool ignoreTimeScale { get; set; }

	// Methods

	// RVA: 0x5B00 Offset: 0x5C01 VA: 0x5B00
	public float get_startValue() { }

	// RVA: 0x5B10 Offset: 0x5C11 VA: 0x5B10
	public void set_startValue(float value) { }

	// RVA: 0x5B20 Offset: 0x5C21 VA: 0x5B20
	public float get_targetValue() { }

	// RVA: 0x5B30 Offset: 0x5C31 VA: 0x5B30
	public void set_targetValue(float value) { }

	// RVA: 0x5B40 Offset: 0x5C41 VA: 0x5B40 Slot: 6
	public float get_duration() { }

	// RVA: 0x5B50 Offset: 0x5C51 VA: 0x5B50
	public void set_duration(float value) { }

	// RVA: 0x5B60 Offset: 0x5C61 VA: 0x5B60 Slot: 5
	public bool get_ignoreTimeScale() { }

	// RVA: 0x5B70 Offset: 0x5C71 VA: 0x5B70
	public void set_ignoreTimeScale(bool value) { }

	// RVA: 0x5B80 Offset: 0x5C81 VA: 0x5B80 Slot: 4
	public void TweenValue(float floatPercentage) { }

	// RVA: 0x5B90 Offset: 0x5C91 VA: 0x5B90
	public void AddOnChangedCallback(UnityAction<float> callback) { }

	// RVA: 0x5BA0 Offset: 0x5CA1 VA: 0x5BA0
	public bool GetIgnoreTimescale() { }

	// RVA: 0x5BB0 Offset: 0x5CB1 VA: 0x5BB0
	public float GetDuration() { }

	// RVA: 0x5BC0 Offset: 0x5CC1 VA: 0x5BC0 Slot: 7
	public bool ValidTarget() { }
}

