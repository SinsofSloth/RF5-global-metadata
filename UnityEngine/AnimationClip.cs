[NativeHeaderAttribute] // RVA: 0xE88A0 Offset: 0xE89A1 VA: 0xE88A0
[NativeTypeAttribute] // RVA: 0xE88A0 Offset: 0xE89A1 VA: 0xE88A0
public sealed class AnimationClip : Motion // TypeDefIndex: 3473
{
	// Properties
	[NativePropertyAttribute] // RVA: 0xEE3B0 Offset: 0xEE4B1 VA: 0xEE3B0
	public float length { get; }
	[NativePropertyAttribute] // RVA: 0xEE3F0 Offset: 0xEE4F1 VA: 0xEE3F0
	internal float startTime { get; }
	[NativePropertyAttribute] // RVA: 0xEE430 Offset: 0xEE531 VA: 0xEE430
	internal float stopTime { get; }
	[NativePropertyAttribute] // RVA: 0xEE470 Offset: 0xEE571 VA: 0xEE470
	public float frameRate { get; set; }
	[NativePropertyAttribute] // RVA: 0xEE4B0 Offset: 0xEE5B1 VA: 0xEE4B0
	public WrapMode wrapMode { get; set; }
	[NativePropertyAttribute] // RVA: 0xEE4F0 Offset: 0xEE5F1 VA: 0xEE4F0
	public Bounds localBounds { get; set; }
	public bool legacy { get; set; }
	public bool humanMotion { get; }
	public bool empty { get; }
	public bool hasGenericRootTransform { get; }
	public bool hasMotionFloatCurves { get; }
	public bool hasMotionCurves { get; }
	public bool hasRootCurves { get; }
	internal bool hasRootMotion { get; }
	public AnimationEvent[] events { get; set; }

	// Methods

	// RVA: 0x1AEC830 Offset: 0x1AEC931 VA: 0x1AEC830
	public void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0xEA8D0 Offset: 0xEA9D1 VA: 0xEA8D0
	// RVA: 0x1AEC940 Offset: 0x1AECA41 VA: 0x1AEC940
	private static void Internal_CreateAnimationClip(AnimationClip self) { }

	// RVA: 0x1AEC990 Offset: 0x1AECA91 VA: 0x1AEC990
	public void SampleAnimation(GameObject go, float time) { }

	[NativeHeaderAttribute] // RVA: 0xEA910 Offset: 0xEAA11 VA: 0xEA910
	[FreeFunctionAttribute] // RVA: 0xEA910 Offset: 0xEAA11 VA: 0xEA910
	// RVA: 0x1AECA70 Offset: 0x1AECB71 VA: 0x1AECA70
	internal static void SampleAnimation(GameObject go, AnimationClip clip, float inTime, WrapMode wrapMode) { }

	// RVA: 0x1AECAE0 Offset: 0x1AECBE1 VA: 0x1AECAE0
	public float get_length() { }

	// RVA: 0x1AECB30 Offset: 0x1AECC31 VA: 0x1AECB30
	internal float get_startTime() { }

	// RVA: 0x1AECB80 Offset: 0x1AECC81 VA: 0x1AECB80
	internal float get_stopTime() { }

	// RVA: 0x1AECBD0 Offset: 0x1AECCD1 VA: 0x1AECBD0
	public float get_frameRate() { }

	// RVA: 0x1AECC20 Offset: 0x1AECD21 VA: 0x1AECC20
	public void set_frameRate(float value) { }

	[FreeFunctionAttribute] // RVA: 0xEA960 Offset: 0xEAA61 VA: 0xEA960
	// RVA: 0x1AECC70 Offset: 0x1AECD71 VA: 0x1AECC70
	public void SetCurve(string relativePath, Type type, string propertyName, AnimationCurve curve) { }

	// RVA: 0x1AECCE0 Offset: 0x1AECDE1 VA: 0x1AECCE0
	public void EnsureQuaternionContinuity() { }

	// RVA: 0x1AECD30 Offset: 0x1AECE31 VA: 0x1AECD30
	public void ClearCurves() { }

	// RVA: 0x1AECA20 Offset: 0x1AECB21 VA: 0x1AECA20
	public WrapMode get_wrapMode() { }

	// RVA: 0x1AECD80 Offset: 0x1AECE81 VA: 0x1AECD80
	public void set_wrapMode(WrapMode value) { }

	// RVA: 0x1AECDD0 Offset: 0x1AECED1 VA: 0x1AECDD0
	public Bounds get_localBounds() { }

	// RVA: 0x1AECE90 Offset: 0x1AECF91 VA: 0x1AECE90
	public void set_localBounds(Bounds value) { }

	[NativeMethodAttribute] // RVA: 0xEA9B0 Offset: 0xEAAB1 VA: 0xEA9B0
	// RVA: 0x1AECF30 Offset: 0x1AED031 VA: 0x1AECF30
	public bool get_legacy() { }

	[NativeMethodAttribute] // RVA: 0xEA9F0 Offset: 0xEAAF1 VA: 0xEA9F0
	// RVA: 0x1AECF80 Offset: 0x1AED081 VA: 0x1AECF80
	public void set_legacy(bool value) { }

	[NativeMethodAttribute] // RVA: 0xEAA30 Offset: 0xEAB31 VA: 0xEAA30
	// RVA: 0x1AECFD0 Offset: 0x1AED0D1 VA: 0x1AECFD0
	public bool get_humanMotion() { }

	[NativeMethodAttribute] // RVA: 0xEAA70 Offset: 0xEAB71 VA: 0xEAA70
	// RVA: 0x1AED020 Offset: 0x1AED121 VA: 0x1AED020
	public bool get_empty() { }

	[NativeMethodAttribute] // RVA: 0xEAAB0 Offset: 0xEABB1 VA: 0xEAAB0
	// RVA: 0x1AED070 Offset: 0x1AED171 VA: 0x1AED070
	public bool get_hasGenericRootTransform() { }

	[NativeMethodAttribute] // RVA: 0xEAAF0 Offset: 0xEABF1 VA: 0xEAAF0
	// RVA: 0x1AED0C0 Offset: 0x1AED1C1 VA: 0x1AED0C0
	public bool get_hasMotionFloatCurves() { }

	[NativeMethodAttribute] // RVA: 0xEAB30 Offset: 0xEAC31 VA: 0xEAB30
	// RVA: 0x1AED110 Offset: 0x1AED211 VA: 0x1AED110
	public bool get_hasMotionCurves() { }

	[NativeMethodAttribute] // RVA: 0xEAB70 Offset: 0xEAC71 VA: 0xEAB70
	// RVA: 0x1AED160 Offset: 0x1AED261 VA: 0x1AED160
	public bool get_hasRootCurves() { }

	[FreeFunctionAttribute] // RVA: 0xEABB0 Offset: 0xEACB1 VA: 0xEABB0
	// RVA: 0x1AED1B0 Offset: 0x1AED2B1 VA: 0x1AED1B0
	internal bool get_hasRootMotion() { }

	// RVA: 0x1AED200 Offset: 0x1AED301 VA: 0x1AED200
	public void AddEvent(AnimationEvent evt) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0xEAC00 Offset: 0xEAD01 VA: 0xEAC00
	// RVA: 0x1AED2C0 Offset: 0x1AED3C1 VA: 0x1AED2C0
	internal void AddEventInternal(object evt) { }

	// RVA: 0x1AED310 Offset: 0x1AED411 VA: 0x1AED310
	public AnimationEvent[] get_events() { }

	// RVA: 0x1AED410 Offset: 0x1AED511 VA: 0x1AED410
	public void set_events(AnimationEvent[] value) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0xEAC10 Offset: 0xEAD11 VA: 0xEAC10
	// RVA: 0x1AED460 Offset: 0x1AED561 VA: 0x1AED460
	internal void SetEventsInternal(Array value) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0xEAC20 Offset: 0xEAD21 VA: 0xEAC20
	// RVA: 0x1AED3C0 Offset: 0x1AED4C1 VA: 0x1AED3C0
	internal Array GetEventsInternal() { }

	// RVA: 0x1AECE40 Offset: 0x1AECF41 VA: 0x1AECE40
	private void get_localBounds_Injected(out Bounds ret) { }

	// RVA: 0x1AECEE0 Offset: 0x1AECFE1 VA: 0x1AECEE0
	private void set_localBounds_Injected(ref Bounds value) { }
}

