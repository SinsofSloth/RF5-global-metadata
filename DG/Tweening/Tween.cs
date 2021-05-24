public abstract class Tween : ABSSequentiable // TypeDefIndex: 5014
{
	// Fields
	public float timeScale; // 0x28
	public bool isBackwards; // 0x2C
	public object id; // 0x30
	public string stringId; // 0x38
	public int intId; // 0x40
	public object target; // 0x48
	internal UpdateType updateType; // 0x50
	internal bool isIndependentUpdate; // 0x54
	public TweenCallback onPlay; // 0x58
	public TweenCallback onPause; // 0x60
	public TweenCallback onRewind; // 0x68
	public TweenCallback onUpdate; // 0x70
	public TweenCallback onStepComplete; // 0x78
	public TweenCallback onComplete; // 0x80
	public TweenCallback onKill; // 0x88
	public TweenCallback<int> onWaypointChange; // 0x90
	internal bool isFrom; // 0x98
	internal bool isBlendable; // 0x99
	internal bool isRecyclable; // 0x9A
	internal bool isSpeedBased; // 0x9B
	internal bool autoKill; // 0x9C
	internal float duration; // 0xA0
	internal int loops; // 0xA4
	internal LoopType loopType; // 0xA8
	internal float delay; // 0xAC
	[CompilerGeneratedAttribute] // RVA: 0x137B50 Offset: 0x137C51 VA: 0x137B50
	private bool <isRelative>k__BackingField; // 0xB0
	internal Ease easeType; // 0xB4
	internal EaseFunction customEase; // 0xB8
	public float easeOvershootOrAmplitude; // 0xC0
	public float easePeriod; // 0xC4
	public string debugTargetId; // 0xC8
	internal Type typeofT1; // 0xD0
	internal Type typeofT2; // 0xD8
	internal Type typeofTPlugOptions; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x137B60 Offset: 0x137C61 VA: 0x137B60
	private bool <active>k__BackingField; // 0xE8
	internal bool isSequenced; // 0xE9
	internal Sequence sequenceParent; // 0xF0
	internal int activeId; // 0xF8
	internal SpecialStartupMode specialStartupMode; // 0xFC
	internal bool creationLocked; // 0x100
	internal bool startupDone; // 0x101
	[CompilerGeneratedAttribute] // RVA: 0x137B70 Offset: 0x137C71 VA: 0x137B70
	private bool <playedOnce>k__BackingField; // 0x102
	[CompilerGeneratedAttribute] // RVA: 0x137B80 Offset: 0x137C81 VA: 0x137B80
	private float <position>k__BackingField; // 0x104
	internal float fullDuration; // 0x108
	internal int completedLoops; // 0x10C
	internal bool isPlaying; // 0x110
	internal bool isComplete; // 0x111
	internal float elapsedDelay; // 0x114
	internal bool delayComplete; // 0x118
	internal int miscInt; // 0x11C

	// Properties
	public bool isRelative { get; set; }
	public bool active { get; set; }
	public float fullPosition { get; set; }
	public bool playedOnce { get; set; }
	public float position { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x138940 Offset: 0x138A41 VA: 0x138940
	// RVA: 0x1B90540 Offset: 0x1B90641 VA: 0x1B90540
	public bool get_isRelative() { }

	[CompilerGeneratedAttribute] // RVA: 0x138950 Offset: 0x138A51 VA: 0x138950
	// RVA: 0x1B90550 Offset: 0x1B90651 VA: 0x1B90550
	internal void set_isRelative(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x138960 Offset: 0x138A61 VA: 0x138960
	// RVA: 0x1B90560 Offset: 0x1B90661 VA: 0x1B90560
	public bool get_active() { }

	[CompilerGeneratedAttribute] // RVA: 0x138970 Offset: 0x138A71 VA: 0x138970
	// RVA: 0x1B90570 Offset: 0x1B90671 VA: 0x1B90570
	internal void set_active(bool value) { }

	// RVA: 0x1B90580 Offset: 0x1B90681 VA: 0x1B90580
	public float get_fullPosition() { }

	// RVA: 0x1B90700 Offset: 0x1B90801 VA: 0x1B90700
	public void set_fullPosition(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x138980 Offset: 0x138A81 VA: 0x138980
	// RVA: 0x1B90930 Offset: 0x1B90A31 VA: 0x1B90930
	public bool get_playedOnce() { }

	[CompilerGeneratedAttribute] // RVA: 0x138990 Offset: 0x138A91 VA: 0x138990
	// RVA: 0x1B90940 Offset: 0x1B90A41 VA: 0x1B90940
	private void set_playedOnce(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1389A0 Offset: 0x138AA1 VA: 0x1389A0
	// RVA: 0x1B90950 Offset: 0x1B90A51 VA: 0x1B90950
	public float get_position() { }

	[CompilerGeneratedAttribute] // RVA: 0x1389B0 Offset: 0x138AB1 VA: 0x1389B0
	// RVA: 0x1B90960 Offset: 0x1B90A61 VA: 0x1B90960
	internal void set_position(float value) { }

	// RVA: 0x1B90970 Offset: 0x1B90A71 VA: 0x1B90970 Slot: 4
	internal virtual void Reset() { }

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract bool Validate() { }

	// RVA: 0x1B90AC0 Offset: 0x1B90BC1 VA: 0x1B90AC0 Slot: 6
	internal virtual float UpdateDelay(float elapsed) { }

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract bool Startup() { }

	// RVA: -1 Offset: -1 Slot: 8
	internal abstract bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode, UpdateNotice updateNotice) { }

	// RVA: 0x1B90AD0 Offset: 0x1B90BD1 VA: 0x1B90AD0
	internal static bool DoGoto(Tween t, float toPosition, int toCompletedLoops, UpdateMode updateMode) { }

	// RVA: 0x1B90E30 Offset: 0x1B90F31 VA: 0x1B90E30
	internal static bool OnTweenCallback(TweenCallback callback, Tween t) { }

	// RVA: -1 Offset: -1
	internal static bool OnTweenCallback<T>(TweenCallback<T> callback, Tween t, T param) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x281C890 Offset: 0x281C991 VA: 0x281C890
	|-Tween.OnTweenCallback<int>
	|
	|-RVA: 0x281CAB0 Offset: 0x281CBB1 VA: 0x281CAB0
	|-Tween.OnTweenCallback<object>
	*/

	// RVA: 0x1B91290 Offset: 0x1B91391 VA: 0x1B91290
	protected void .ctor() { }
}

