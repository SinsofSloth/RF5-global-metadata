private class SimpleAnimationPlayable.StateInfo // TypeDefIndex: 5934
{
	// Fields
	private bool m_Enabled; // 0x10
	private int m_Index; // 0x14
	private string m_StateName; // 0x18
	private bool m_Fading; // 0x20
	private float m_Time; // 0x24
	private float m_TargetWeight; // 0x28
	private float m_Weight; // 0x2C
	private float m_FadeSpeed; // 0x30
	private AnimationClip m_Clip; // 0x38
	private Playable m_Playable; // 0x40
	private WrapMode m_WrapMode; // 0x50
	private bool m_IsClone; // 0x54
	private bool m_ReadyForCleanup; // 0x55
	public SimpleAnimationPlayable.StateHandle m_ParentState; // 0x58
	private bool m_WeightDirty; // 0x60
	private bool m_EnabledDirty; // 0x61
	private bool m_TimeIsUpToDate; // 0x62

	// Properties
	public bool enabled { get; }
	public int index { get; set; }
	public string stateName { get; set; }
	public bool fading { get; }
	public float targetWeight { get; }
	public float weight { get; }
	public float fadeSpeed { get; }
	public float speed { get; set; }
	public float playableDuration { get; }
	public AnimationClip clip { get; }
	public bool isDone { get; }
	public Playable playable { get; }
	public WrapMode wrapMode { get; }
	public bool isClone { get; }
	public bool isReadyForCleanup { get; }
	public SimpleAnimationPlayable.StateHandle parentState { get; }
	public bool enabledDirty { get; }
	public bool weightDirty { get; }

	// Methods

	// RVA: 0x1B8AC50 Offset: 0x1B8AD51 VA: 0x1B8AC50
	public void Initialize(string name, AnimationClip clip, WrapMode wrapMode) { }

	// RVA: 0x1B8CE40 Offset: 0x1B8CF41 VA: 0x1B8CE40
	public float GetTime() { }

	// RVA: 0x1B8F3A0 Offset: 0x1B8F4A1 VA: 0x1B8F3A0
	public void SetTime(float newTime) { }

	// RVA: 0x1B8B240 Offset: 0x1B8B341 VA: 0x1B8B240
	public void Enable() { }

	// RVA: 0x1B8CF20 Offset: 0x1B8D021 VA: 0x1B8CF20
	public void Disable() { }

	// RVA: 0x1B8ACA0 Offset: 0x1B8ADA1 VA: 0x1B8ACA0
	public void Pause() { }

	// RVA: 0x1B8CD30 Offset: 0x1B8CE31 VA: 0x1B8CD30
	public void Play() { }

	// RVA: 0x1B8CC90 Offset: 0x1B8CD91 VA: 0x1B8CC90
	public void Stop() { }

	// RVA: 0x1B8B260 Offset: 0x1B8B361 VA: 0x1B8B260
	public void ForceWeight(float weight) { }

	// RVA: 0x1B8CC80 Offset: 0x1B8CD81 VA: 0x1B8CC80
	public void SetWeight(float weight) { }

	// RVA: 0x1B8BCB0 Offset: 0x1B8BDB1 VA: 0x1B8BCB0
	public void FadeTo(float weight, float speed) { }

	// RVA: 0x1B8F4A0 Offset: 0x1B8F5A1 VA: 0x1B8F4A0
	public void DestroyPlayable() { }

	// RVA: 0x1B8BF80 Offset: 0x1B8C081 VA: 0x1B8BF80
	public void SetAsCloneOf(SimpleAnimationPlayable.StateHandle handle) { }

	// RVA: 0x1B8F540 Offset: 0x1B8F641 VA: 0x1B8F540
	public bool get_enabled() { }

	// RVA: 0x1B8F550 Offset: 0x1B8F651 VA: 0x1B8F550
	public int get_index() { }

	// RVA: 0x1B8F560 Offset: 0x1B8F661 VA: 0x1B8F560
	public void set_index(int value) { }

	// RVA: 0x1B8F570 Offset: 0x1B8F671 VA: 0x1B8F570
	public string get_stateName() { }

	// RVA: 0x1B8F580 Offset: 0x1B8F681 VA: 0x1B8F580
	public void set_stateName(string value) { }

	// RVA: 0x1B8F590 Offset: 0x1B8F691 VA: 0x1B8F590
	public bool get_fading() { }

	// RVA: 0x1B8F5A0 Offset: 0x1B8F6A1 VA: 0x1B8F5A0
	public float get_targetWeight() { }

	// RVA: 0x1B8F5B0 Offset: 0x1B8F6B1 VA: 0x1B8F5B0
	public float get_weight() { }

	// RVA: 0x1B8F5C0 Offset: 0x1B8F6C1 VA: 0x1B8F5C0
	public float get_fadeSpeed() { }

	// RVA: 0x1B8CDE0 Offset: 0x1B8CEE1 VA: 0x1B8CDE0
	public float get_speed() { }

	// RVA: 0x1B8F5D0 Offset: 0x1B8F6D1 VA: 0x1B8F5D0
	public void set_speed(float value) { }

	// RVA: 0x1B8CEC0 Offset: 0x1B8CFC1 VA: 0x1B8CEC0
	public float get_playableDuration() { }

	// RVA: 0x1B8F630 Offset: 0x1B8F731 VA: 0x1B8F630
	public AnimationClip get_clip() { }

	// RVA: 0x1B8F640 Offset: 0x1B8F741 VA: 0x1B8F640
	public void SetPlayable(Playable playable) { }

	// RVA: 0x1B8CD90 Offset: 0x1B8CE91 VA: 0x1B8CD90
	public bool get_isDone() { }

	// RVA: 0x1B8F650 Offset: 0x1B8F751 VA: 0x1B8F650
	public Playable get_playable() { }

	// RVA: 0x1B8F660 Offset: 0x1B8F761 VA: 0x1B8F660
	public WrapMode get_wrapMode() { }

	// RVA: 0x1B8F670 Offset: 0x1B8F771 VA: 0x1B8F670
	public bool get_isClone() { }

	// RVA: 0x1B8F680 Offset: 0x1B8F781 VA: 0x1B8F680
	public bool get_isReadyForCleanup() { }

	// RVA: 0x1B8F690 Offset: 0x1B8F791 VA: 0x1B8F690
	public SimpleAnimationPlayable.StateHandle get_parentState() { }

	// RVA: 0x1B8F6A0 Offset: 0x1B8F7A1 VA: 0x1B8F6A0
	public bool get_enabledDirty() { }

	// RVA: 0x1B8F6B0 Offset: 0x1B8F7B1 VA: 0x1B8F6B0
	public bool get_weightDirty() { }

	// RVA: 0x1B8CF40 Offset: 0x1B8D041 VA: 0x1B8CF40
	public void ResetDirtyFlags() { }

	// RVA: 0x1B8D550 Offset: 0x1B8D651 VA: 0x1B8D550
	public void InvalidateTime() { }

	// RVA: 0x1B8F6C0 Offset: 0x1B8F7C1 VA: 0x1B8F6C0
	public void .ctor() { }
}

