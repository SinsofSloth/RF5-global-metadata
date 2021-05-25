public class TweenParams // TypeDefIndex: 5011
{
	// Fields
	public static readonly TweenParams Params; // 0x0
	internal object id; // 0x10
	internal object target; // 0x18
	internal UpdateType updateType; // 0x20
	internal bool isIndependentUpdate; // 0x24
	internal TweenCallback onStart; // 0x28
	internal TweenCallback onPlay; // 0x30
	internal TweenCallback onRewind; // 0x38
	internal TweenCallback onUpdate; // 0x40
	internal TweenCallback onStepComplete; // 0x48
	internal TweenCallback onComplete; // 0x50
	internal TweenCallback onKill; // 0x58
	internal TweenCallback<int> onWaypointChange; // 0x60
	internal bool isRecyclable; // 0x68
	internal bool isSpeedBased; // 0x69
	internal bool autoKill; // 0x6A
	internal int loops; // 0x6C
	internal LoopType loopType; // 0x70
	internal float delay; // 0x74
	internal bool isRelative; // 0x78
	internal Ease easeType; // 0x7C
	internal EaseFunction customEase; // 0x80
	internal float easeOvershootOrAmplitude; // 0x88
	internal float easePeriod; // 0x8C

	// Methods

	// RVA: 0x1B93D70 Offset: 0x1B93E71 VA: 0x1B93D70
	public void .ctor() { }

	// RVA: 0x1B93DA0 Offset: 0x1B93EA1 VA: 0x1B93DA0
	public TweenParams Clear() { }

	// RVA: 0x1B93F30 Offset: 0x1B94031 VA: 0x1B93F30
	public TweenParams SetAutoKill(bool autoKillOnCompletion = True) { }

	// RVA: 0x1B93F40 Offset: 0x1B94041 VA: 0x1B93F40
	public TweenParams SetId(object id) { }

	// RVA: 0x1B93F70 Offset: 0x1B94071 VA: 0x1B93F70
	public TweenParams SetTarget(object target) { }

	// RVA: 0x1B93FA0 Offset: 0x1B940A1 VA: 0x1B93FA0
	public TweenParams SetLoops(int loops, Nullable<LoopType> loopType) { }

	// RVA: 0x1B94040 Offset: 0x1B94141 VA: 0x1B94040
	public TweenParams SetEase(Ease ease, Nullable<float> overshootOrAmplitude, Nullable<float> period) { }

	// RVA: 0x1B94160 Offset: 0x1B94261 VA: 0x1B94160
	public TweenParams SetEase(AnimationCurve animCurve) { }

	// RVA: 0x1B94220 Offset: 0x1B94321 VA: 0x1B94220
	public TweenParams SetEase(EaseFunction customEase) { }

	// RVA: 0x1B94250 Offset: 0x1B94351 VA: 0x1B94250
	public TweenParams SetRecyclable(bool recyclable = True) { }

	// RVA: 0x1B94260 Offset: 0x1B94361 VA: 0x1B94260
	public TweenParams SetUpdate(bool isIndependentUpdate) { }

	// RVA: 0x1B942F0 Offset: 0x1B943F1 VA: 0x1B942F0
	public TweenParams SetUpdate(UpdateType updateType, bool isIndependentUpdate = False) { }

	// RVA: 0x1B94300 Offset: 0x1B94401 VA: 0x1B94300
	public TweenParams OnStart(TweenCallback action) { }

	// RVA: 0x1B94330 Offset: 0x1B94431 VA: 0x1B94330
	public TweenParams OnPlay(TweenCallback action) { }

	// RVA: 0x1B94360 Offset: 0x1B94461 VA: 0x1B94360
	public TweenParams OnRewind(TweenCallback action) { }

	// RVA: 0x1B94390 Offset: 0x1B94491 VA: 0x1B94390
	public TweenParams OnUpdate(TweenCallback action) { }

	// RVA: 0x1B943C0 Offset: 0x1B944C1 VA: 0x1B943C0
	public TweenParams OnStepComplete(TweenCallback action) { }

	// RVA: 0x1B943F0 Offset: 0x1B944F1 VA: 0x1B943F0
	public TweenParams OnComplete(TweenCallback action) { }

	// RVA: 0x1B94420 Offset: 0x1B94521 VA: 0x1B94420
	public TweenParams OnKill(TweenCallback action) { }

	// RVA: 0x1B94450 Offset: 0x1B94551 VA: 0x1B94450
	public TweenParams OnWaypointChange(TweenCallback<int> action) { }

	// RVA: 0x1B94480 Offset: 0x1B94581 VA: 0x1B94480
	public TweenParams SetDelay(float delay) { }

	// RVA: 0x1B94490 Offset: 0x1B94591 VA: 0x1B94490
	public TweenParams SetRelative(bool isRelative = True) { }

	// RVA: 0x1B944A0 Offset: 0x1B945A1 VA: 0x1B944A0
	public TweenParams SetSpeedBased(bool isSpeedBased = True) { }

	// RVA: 0x1B944B0 Offset: 0x1B945B1 VA: 0x1B944B0
	private static void .cctor() { }
}

