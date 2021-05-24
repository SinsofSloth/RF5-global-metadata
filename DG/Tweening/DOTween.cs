public class DOTween // TypeDefIndex: 4918
{
	// Fields
	public static readonly string Version; // 0x0
	public static bool useSafeMode; // 0x8
	public static NestedTweenFailureBehaviour nestedTweenFailureBehaviour; // 0xC
	public static bool showUnityEditorReport; // 0x10
	public static float timeScale; // 0x14
	public static bool useSmoothDeltaTime; // 0x18
	public static float maxSmoothUnscaledTime; // 0x1C
	internal static RewindCallbackMode rewindCallbackMode; // 0x20
	private static LogBehaviour _logBehaviour; // 0x24
	public static Func<LogType, object, bool> onWillLog; // 0x28
	public static bool drawGizmos; // 0x30
	public static bool debugMode; // 0x31
	private static bool _fooDebugStoreTargetId; // 0x32
	public static UpdateType defaultUpdateType; // 0x34
	public static bool defaultTimeScaleIndependent; // 0x38
	public static AutoPlay defaultAutoPlay; // 0x3C
	public static bool defaultAutoKill; // 0x40
	public static LoopType defaultLoopType; // 0x44
	public static bool defaultRecyclable; // 0x48
	public static Ease defaultEaseType; // 0x4C
	public static float defaultEaseOvershootOrAmplitude; // 0x50
	public static float defaultEasePeriod; // 0x54
	public static DOTweenComponent instance; // 0x58
	internal static int maxActiveTweenersReached; // 0x60
	internal static int maxActiveSequencesReached; // 0x64
	internal static SafeModeReport safeModeReport; // 0x68
	internal static readonly List<TweenCallback> GizmosDelegates; // 0x78
	internal static bool initialized; // 0x80
	internal static bool isQuitting; // 0x81

	// Properties
	public static LogBehaviour logBehaviour { get; set; }
	public static bool debugStoreTargetId { get; set; }

	// Methods

	// RVA: 0x1993070 Offset: 0x1993171 VA: 0x1993070
	public static LogBehaviour get_logBehaviour() { }

	// RVA: 0x19930E0 Offset: 0x19931E1 VA: 0x19930E0
	public static void set_logBehaviour(LogBehaviour value) { }

	// RVA: 0x19931D0 Offset: 0x19932D1 VA: 0x19931D0
	public static bool get_debugStoreTargetId() { }

	// RVA: 0x19932C0 Offset: 0x19933C1 VA: 0x19932C0
	public static void set_debugStoreTargetId(bool value) { }

	// RVA: 0x1993330 Offset: 0x1993431 VA: 0x1993330
	public static IDOTweenInit Init(Nullable<bool> recycleAllByDefault, Nullable<bool> useSafeMode, Nullable<LogBehaviour> logBehaviour) { }

	// RVA: 0x1993DE0 Offset: 0x1993EE1 VA: 0x1993DE0
	private static void AutoInit() { }

	// RVA: 0x19934C0 Offset: 0x19935C1 VA: 0x19934C0
	private static IDOTweenInit Init(DOTweenSettings settings, Nullable<bool> recycleAllByDefault, Nullable<bool> useSafeMode, Nullable<LogBehaviour> logBehaviour) { }

	// RVA: 0x1993EB0 Offset: 0x1993FB1 VA: 0x1993EB0
	public static void SetTweensCapacity(int tweenersCapacity, int sequencesCapacity) { }

	// RVA: 0x19873F0 Offset: 0x19874F1 VA: 0x19873F0
	public static void Clear(bool destroy = False) { }

	// RVA: 0x19940D0 Offset: 0x19941D1 VA: 0x19940D0
	public static void ClearCachedTweens() { }

	// RVA: 0x1994140 Offset: 0x1994241 VA: 0x1994140
	public static int Validate() { }

	// RVA: 0x19941B0 Offset: 0x19942B1 VA: 0x19941B0
	public static void ManualUpdate(float deltaTime, float unscaledDeltaTime) { }

	// RVA: 0x19943B0 Offset: 0x19944B1 VA: 0x19943B0
	public static TweenerCore<float, float, FloatOptions> To(DOGetter<float> getter, DOSetter<float> setter, float endValue, float duration) { }

	// RVA: 0x1994450 Offset: 0x1994551 VA: 0x1994450
	public static TweenerCore<double, double, NoOptions> To(DOGetter<double> getter, DOSetter<double> setter, double endValue, float duration) { }

	// RVA: 0x19944F0 Offset: 0x19945F1 VA: 0x19944F0
	public static TweenerCore<int, int, NoOptions> To(DOGetter<int> getter, DOSetter<int> setter, int endValue, float duration) { }

	// RVA: 0x1994590 Offset: 0x1994691 VA: 0x1994590
	public static TweenerCore<uint, uint, UintOptions> To(DOGetter<uint> getter, DOSetter<uint> setter, uint endValue, float duration) { }

	// RVA: 0x1994630 Offset: 0x1994731 VA: 0x1994630
	public static TweenerCore<long, long, NoOptions> To(DOGetter<long> getter, DOSetter<long> setter, long endValue, float duration) { }

	// RVA: 0x19946D0 Offset: 0x19947D1 VA: 0x19946D0
	public static TweenerCore<ulong, ulong, NoOptions> To(DOGetter<ulong> getter, DOSetter<ulong> setter, ulong endValue, float duration) { }

	// RVA: 0x1994770 Offset: 0x1994871 VA: 0x1994770
	public static TweenerCore<string, string, StringOptions> To(DOGetter<string> getter, DOSetter<string> setter, string endValue, float duration) { }

	// RVA: 0x1994810 Offset: 0x1994911 VA: 0x1994810
	public static TweenerCore<Vector2, Vector2, VectorOptions> To(DOGetter<Vector2> getter, DOSetter<Vector2> setter, Vector2 endValue, float duration) { }

	// RVA: 0x19948C0 Offset: 0x19949C1 VA: 0x19948C0
	public static TweenerCore<Vector3, Vector3, VectorOptions> To(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3 endValue, float duration) { }

	// RVA: 0x1994980 Offset: 0x1994A81 VA: 0x1994980
	public static TweenerCore<Vector4, Vector4, VectorOptions> To(DOGetter<Vector4> getter, DOSetter<Vector4> setter, Vector4 endValue, float duration) { }

	// RVA: 0x1994A50 Offset: 0x1994B51 VA: 0x1994A50
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> To(DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, Vector3 endValue, float duration) { }

	// RVA: 0x1994B10 Offset: 0x1994C11 VA: 0x1994B10
	public static TweenerCore<Color, Color, ColorOptions> To(DOGetter<Color> getter, DOSetter<Color> setter, Color endValue, float duration) { }

	// RVA: 0x1994BE0 Offset: 0x1994CE1 VA: 0x1994BE0
	public static TweenerCore<Rect, Rect, RectOptions> To(DOGetter<Rect> getter, DOSetter<Rect> setter, Rect endValue, float duration) { }

	// RVA: 0x1994CB0 Offset: 0x1994DB1 VA: 0x1994CB0
	public static Tweener To(DOGetter<RectOffset> getter, DOSetter<RectOffset> setter, RectOffset endValue, float duration) { }

	// RVA: -1 Offset: -1
	public static TweenerCore<T1, T2, TPlugOptions> To<T1, T2, TPlugOptions>(ABSTweenPlugin<T1, T2, TPlugOptions> plugin, DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AB3650 Offset: 0x1AB3751 VA: 0x1AB3650
	|-DOTween.To<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x1AB3730 Offset: 0x1AB3831 VA: 0x1AB3730
	|-DOTween.To<Vector3, Path, PathOptions>
	|-DOTween.To<Vector3, object, PathOptions>
	*/

	// RVA: 0x1994D50 Offset: 0x1994E51 VA: 0x1994D50
	public static TweenerCore<Vector3, Vector3, VectorOptions> ToAxis(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float endValue, float duration, AxisConstraint axisConstraint = 2) { }

	// RVA: 0x1994E30 Offset: 0x1994F31 VA: 0x1994E30
	public static TweenerCore<Color, Color, ColorOptions> ToAlpha(DOGetter<Color> getter, DOSetter<Color> setter, float endValue, float duration) { }

	// RVA: 0x1994F10 Offset: 0x1995011 VA: 0x1994F10
	public static Tweener To(DOSetter<float> setter, float startValue, float endValue, float duration) { }

	// RVA: 0x19950C0 Offset: 0x19951C1 VA: 0x19950C0
	public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Punch(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3 direction, float duration, int vibrato = 10, float elasticity = 1) { }

	// RVA: 0x1995650 Offset: 0x1995751 VA: 0x1995650
	public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, float strength = 3, int vibrato = 10, float randomness = 90, bool ignoreZAxis = True, bool fadeOut = True) { }

	// RVA: 0x1995ED0 Offset: 0x1995FD1 VA: 0x1995ED0
	public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, Vector3 strength, int vibrato = 10, float randomness = 90, bool fadeOut = True) { }

	// RVA: 0x1995740 Offset: 0x1995841 VA: 0x1995740
	private static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, Vector3 strength, int vibrato, float randomness, bool ignoreZAxis, bool vectorBased, bool fadeOut) { }

	// RVA: 0x1995410 Offset: 0x1995511 VA: 0x1995410
	public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> ToArray(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3[] endValues, float[] durations) { }

	// RVA: 0x1995FB0 Offset: 0x19960B1 VA: 0x1995FB0
	internal static TweenerCore<Color2, Color2, ColorOptions> To(DOGetter<Color2> getter, DOSetter<Color2> setter, Color2 endValue, float duration) { }

	// RVA: 0x1996080 Offset: 0x1996181 VA: 0x1996080
	public static Sequence Sequence() { }

	// RVA: 0x1996120 Offset: 0x1996221 VA: 0x1996120
	public static int CompleteAll(bool withCallbacks = False) { }

	// RVA: 0x19961C0 Offset: 0x19962C1 VA: 0x19961C0
	public static int Complete(object targetOrId, bool withCallbacks = False) { }

	// RVA: 0x1996280 Offset: 0x1996381 VA: 0x1996280
	internal static int CompleteAndReturnKilledTot() { }

	// RVA: 0x1996300 Offset: 0x1996401 VA: 0x1996300
	internal static int CompleteAndReturnKilledTot(object targetOrId) { }

	// RVA: 0x1996390 Offset: 0x1996491 VA: 0x1996390
	internal static int CompleteAndReturnKilledTotExceptFor(object[] excludeTargetsOrIds) { }

	// RVA: 0x1996410 Offset: 0x1996511 VA: 0x1996410
	public static int FlipAll() { }

	// RVA: 0x1996490 Offset: 0x1996591 VA: 0x1996490
	public static int Flip(object targetOrId) { }

	// RVA: 0x1996520 Offset: 0x1996621 VA: 0x1996520
	public static int GotoAll(float to, bool andPlay = False) { }

	// RVA: 0x19965B0 Offset: 0x19966B1 VA: 0x19965B0
	public static int Goto(object targetOrId, float to, bool andPlay = False) { }

	// RVA: 0x1996660 Offset: 0x1996761 VA: 0x1996660
	public static int KillAll(bool complete = False) { }

	// RVA: 0x1996770 Offset: 0x1996871 VA: 0x1996770
	public static int KillAll(bool complete, object[] idsOrTargetsToExclude) { }

	// RVA: 0x1996970 Offset: 0x1996A71 VA: 0x1996970
	public static int Kill(object targetOrId, bool complete = False) { }

	// RVA: 0x1996AC0 Offset: 0x1996BC1 VA: 0x1996AC0
	public static int PauseAll() { }

	// RVA: 0x1996B40 Offset: 0x1996C41 VA: 0x1996B40
	public static int Pause(object targetOrId) { }

	// RVA: 0x1996BD0 Offset: 0x1996CD1 VA: 0x1996BD0
	public static int PlayAll() { }

	// RVA: 0x1996C50 Offset: 0x1996D51 VA: 0x1996C50
	public static int Play(object targetOrId) { }

	// RVA: 0x1996CE0 Offset: 0x1996DE1 VA: 0x1996CE0
	public static int Play(object target, object id) { }

	// RVA: 0x1996D90 Offset: 0x1996E91 VA: 0x1996D90
	public static int PlayBackwardsAll() { }

	// RVA: 0x1996E10 Offset: 0x1996F11 VA: 0x1996E10
	public static int PlayBackwards(object targetOrId) { }

	// RVA: 0x1996EA0 Offset: 0x1996FA1 VA: 0x1996EA0
	public static int PlayBackwards(object target, object id) { }

	// RVA: 0x1996F50 Offset: 0x1997051 VA: 0x1996F50
	public static int PlayForwardAll() { }

	// RVA: 0x1996FD0 Offset: 0x19970D1 VA: 0x1996FD0
	public static int PlayForward(object targetOrId) { }

	// RVA: 0x1997060 Offset: 0x1997161 VA: 0x1997060
	public static int PlayForward(object target, object id) { }

	// RVA: 0x1997110 Offset: 0x1997211 VA: 0x1997110
	public static int RestartAll(bool includeDelay = True) { }

	// RVA: 0x1997190 Offset: 0x1997291 VA: 0x1997190
	public static int Restart(object targetOrId, bool includeDelay = True, float changeDelayTo = -1) { }

	// RVA: 0x1997240 Offset: 0x1997341 VA: 0x1997240
	public static int Restart(object target, object id, bool includeDelay = True, float changeDelayTo = -1) { }

	// RVA: 0x1997300 Offset: 0x1997401 VA: 0x1997300
	public static int RewindAll(bool includeDelay = True) { }

	// RVA: 0x1997380 Offset: 0x1997481 VA: 0x1997380
	public static int Rewind(object targetOrId, bool includeDelay = True) { }

	// RVA: 0x1997420 Offset: 0x1997521 VA: 0x1997420
	public static int SmoothRewindAll() { }

	// RVA: 0x19974A0 Offset: 0x19975A1 VA: 0x19974A0
	public static int SmoothRewind(object targetOrId) { }

	// RVA: 0x1997530 Offset: 0x1997631 VA: 0x1997530
	public static int TogglePauseAll() { }

	// RVA: 0x19975B0 Offset: 0x19976B1 VA: 0x19975B0
	public static int TogglePause(object targetOrId) { }

	// RVA: 0x1997640 Offset: 0x1997741 VA: 0x1997640
	public static bool IsTweening(object targetOrId, bool alsoCheckIfIsPlaying = False) { }

	// RVA: 0x19976E0 Offset: 0x19977E1 VA: 0x19976E0
	public static int TotalPlayingTweens() { }

	// RVA: 0x1997750 Offset: 0x1997851 VA: 0x1997750
	public static List<Tween> PlayingTweens(List<Tween> fillableList) { }

	// RVA: 0x19977D0 Offset: 0x19978D1 VA: 0x19977D0
	public static List<Tween> PausedTweens(List<Tween> fillableList) { }

	// RVA: 0x1997850 Offset: 0x1997951 VA: 0x1997850
	public static List<Tween> TweensById(object id, bool playingOnly = False, List<Tween> fillableList) { }

	// RVA: 0x1997900 Offset: 0x1997A01 VA: 0x1997900
	public static List<Tween> TweensByTarget(object target, bool playingOnly = False, List<Tween> fillableList) { }

	// RVA: 0x19942E0 Offset: 0x19943E1 VA: 0x19942E0
	private static void InitCheck() { }

	// RVA: -1 Offset: -1
	private static TweenerCore<T1, T2, TPlugOptions> ApplyTo<T1, T2, TPlugOptions>(DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration, ABSTweenPlugin<T1, T2, TPlugOptions> plugin) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AB2040 Offset: 0x1AB2141 VA: 0x1AB2040
	|-DOTween.ApplyTo<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x1AB21A0 Offset: 0x1AB22A1 VA: 0x1AB21A0
	|-DOTween.ApplyTo<double, double, NoOptions>
	|
	|-RVA: 0x1AB22C0 Offset: 0x1AB23C1 VA: 0x1AB22C0
	|-DOTween.ApplyTo<int, int, NoOptions>
	|
	|-RVA: 0x1AB23F0 Offset: 0x1AB24F1 VA: 0x1AB23F0
	|-DOTween.ApplyTo<long, long, NoOptions>
	|
	|-RVA: 0x1AB2520 Offset: 0x1AB2621 VA: 0x1AB2520
	|-DOTween.ApplyTo<object, object, NoOptions>
	|-DOTween.ApplyTo<RectOffset, RectOffset, NoOptions>
	|
	|-RVA: 0x1AB2650 Offset: 0x1AB2751 VA: 0x1AB2650
	|-DOTween.ApplyTo<object, object, StringOptions>
	|-DOTween.ApplyTo<string, string, StringOptions>
	|
	|-RVA: 0x1AB2780 Offset: 0x1AB2881 VA: 0x1AB2780
	|-DOTween.ApplyTo<float, float, FloatOptions>
	|
	|-RVA: 0x1AB28A0 Offset: 0x1AB29A1 VA: 0x1AB28A0
	|-DOTween.ApplyTo<uint, uint, UintOptions>
	|
	|-RVA: 0x1AB29D0 Offset: 0x1AB2AD1 VA: 0x1AB29D0
	|-DOTween.ApplyTo<ulong, ulong, NoOptions>
	|
	|-RVA: 0x1AB2B00 Offset: 0x1AB2C01 VA: 0x1AB2B00
	|-DOTween.ApplyTo<Color, Color, ColorOptions>
	|
	|-RVA: 0x1AB2C50 Offset: 0x1AB2D51 VA: 0x1AB2C50
	|-DOTween.ApplyTo<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x1AB2DA0 Offset: 0x1AB2EA1 VA: 0x1AB2DA0
	|-DOTween.ApplyTo<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x1AB2EE0 Offset: 0x1AB2FE1 VA: 0x1AB2EE0
	|-DOTween.ApplyTo<Rect, Rect, RectOptions>
	|
	|-RVA: 0x1AB3030 Offset: 0x1AB3131 VA: 0x1AB3030
	|-DOTween.ApplyTo<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x1AB3160 Offset: 0x1AB3261 VA: 0x1AB3160
	|-DOTween.ApplyTo<Vector3, object, PathOptions>
	|
	|-RVA: 0x1AB3290 Offset: 0x1AB3391 VA: 0x1AB3290
	|-DOTween.ApplyTo<Vector3, object, Vector3ArrayOptions>
	|-DOTween.ApplyTo<Vector3, Vector3[], Vector3ArrayOptions>
	|
	|-RVA: 0x1AB33C0 Offset: 0x1AB34C1 VA: 0x1AB33C0
	|-DOTween.ApplyTo<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x1AB3500 Offset: 0x1AB3601 VA: 0x1AB3500
	|-DOTween.ApplyTo<Vector4, Vector4, VectorOptions>
	*/

	// RVA: 0x19979A0 Offset: 0x1997AA1 VA: 0x19979A0
	public void .ctor() { }

	// RVA: 0x19979B0 Offset: 0x1997AB1 VA: 0x19979B0
	private static void .cctor() { }
}

public class DOTween // TypeDefIndex: 4918
{
	// Fields
	public static readonly string Version; // 0x0
	public static bool useSafeMode; // 0x8
	public static NestedTweenFailureBehaviour nestedTweenFailureBehaviour; // 0xC
	public static bool showUnityEditorReport; // 0x10
	public static float timeScale; // 0x14
	public static bool useSmoothDeltaTime; // 0x18
	public static float maxSmoothUnscaledTime; // 0x1C
	internal static RewindCallbackMode rewindCallbackMode; // 0x20
	private static LogBehaviour _logBehaviour; // 0x24
	public static Func<LogType, object, bool> onWillLog; // 0x28
	public static bool drawGizmos; // 0x30
	public static bool debugMode; // 0x31
	private static bool _fooDebugStoreTargetId; // 0x32
	public static UpdateType defaultUpdateType; // 0x34
	public static bool defaultTimeScaleIndependent; // 0x38
	public static AutoPlay defaultAutoPlay; // 0x3C
	public static bool defaultAutoKill; // 0x40
	public static LoopType defaultLoopType; // 0x44
	public static bool defaultRecyclable; // 0x48
	public static Ease defaultEaseType; // 0x4C
	public static float defaultEaseOvershootOrAmplitude; // 0x50
	public static float defaultEasePeriod; // 0x54
	public static DOTweenComponent instance; // 0x58
	internal static int maxActiveTweenersReached; // 0x60
	internal static int maxActiveSequencesReached; // 0x64
	internal static SafeModeReport safeModeReport; // 0x68
	internal static readonly List<TweenCallback> GizmosDelegates; // 0x78
	internal static bool initialized; // 0x80
	internal static bool isQuitting; // 0x81

	// Properties
	public static LogBehaviour logBehaviour { get; set; }
	public static bool debugStoreTargetId { get; set; }

	// Methods

	// RVA: 0x1993070 Offset: 0x1993171 VA: 0x1993070
	public static LogBehaviour get_logBehaviour() { }

	// RVA: 0x19930E0 Offset: 0x19931E1 VA: 0x19930E0
	public static void set_logBehaviour(LogBehaviour value) { }

	// RVA: 0x19931D0 Offset: 0x19932D1 VA: 0x19931D0
	public static bool get_debugStoreTargetId() { }

	// RVA: 0x19932C0 Offset: 0x19933C1 VA: 0x19932C0
	public static void set_debugStoreTargetId(bool value) { }

	// RVA: 0x1993330 Offset: 0x1993431 VA: 0x1993330
	public static IDOTweenInit Init(Nullable<bool> recycleAllByDefault, Nullable<bool> useSafeMode, Nullable<LogBehaviour> logBehaviour) { }

	// RVA: 0x1993DE0 Offset: 0x1993EE1 VA: 0x1993DE0
	private static void AutoInit() { }

	// RVA: 0x19934C0 Offset: 0x19935C1 VA: 0x19934C0
	private static IDOTweenInit Init(DOTweenSettings settings, Nullable<bool> recycleAllByDefault, Nullable<bool> useSafeMode, Nullable<LogBehaviour> logBehaviour) { }

	// RVA: 0x1993EB0 Offset: 0x1993FB1 VA: 0x1993EB0
	public static void SetTweensCapacity(int tweenersCapacity, int sequencesCapacity) { }

	// RVA: 0x19873F0 Offset: 0x19874F1 VA: 0x19873F0
	public static void Clear(bool destroy = False) { }

	// RVA: 0x19940D0 Offset: 0x19941D1 VA: 0x19940D0
	public static void ClearCachedTweens() { }

	// RVA: 0x1994140 Offset: 0x1994241 VA: 0x1994140
	public static int Validate() { }

	// RVA: 0x19941B0 Offset: 0x19942B1 VA: 0x19941B0
	public static void ManualUpdate(float deltaTime, float unscaledDeltaTime) { }

	// RVA: 0x19943B0 Offset: 0x19944B1 VA: 0x19943B0
	public static TweenerCore<float, float, FloatOptions> To(DOGetter<float> getter, DOSetter<float> setter, float endValue, float duration) { }

	// RVA: 0x1994450 Offset: 0x1994551 VA: 0x1994450
	public static TweenerCore<double, double, NoOptions> To(DOGetter<double> getter, DOSetter<double> setter, double endValue, float duration) { }

	// RVA: 0x19944F0 Offset: 0x19945F1 VA: 0x19944F0
	public static TweenerCore<int, int, NoOptions> To(DOGetter<int> getter, DOSetter<int> setter, int endValue, float duration) { }

	// RVA: 0x1994590 Offset: 0x1994691 VA: 0x1994590
	public static TweenerCore<uint, uint, UintOptions> To(DOGetter<uint> getter, DOSetter<uint> setter, uint endValue, float duration) { }

	// RVA: 0x1994630 Offset: 0x1994731 VA: 0x1994630
	public static TweenerCore<long, long, NoOptions> To(DOGetter<long> getter, DOSetter<long> setter, long endValue, float duration) { }

	// RVA: 0x19946D0 Offset: 0x19947D1 VA: 0x19946D0
	public static TweenerCore<ulong, ulong, NoOptions> To(DOGetter<ulong> getter, DOSetter<ulong> setter, ulong endValue, float duration) { }

	// RVA: 0x1994770 Offset: 0x1994871 VA: 0x1994770
	public static TweenerCore<string, string, StringOptions> To(DOGetter<string> getter, DOSetter<string> setter, string endValue, float duration) { }

	// RVA: 0x1994810 Offset: 0x1994911 VA: 0x1994810
	public static TweenerCore<Vector2, Vector2, VectorOptions> To(DOGetter<Vector2> getter, DOSetter<Vector2> setter, Vector2 endValue, float duration) { }

	// RVA: 0x19948C0 Offset: 0x19949C1 VA: 0x19948C0
	public static TweenerCore<Vector3, Vector3, VectorOptions> To(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3 endValue, float duration) { }

	// RVA: 0x1994980 Offset: 0x1994A81 VA: 0x1994980
	public static TweenerCore<Vector4, Vector4, VectorOptions> To(DOGetter<Vector4> getter, DOSetter<Vector4> setter, Vector4 endValue, float duration) { }

	// RVA: 0x1994A50 Offset: 0x1994B51 VA: 0x1994A50
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> To(DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, Vector3 endValue, float duration) { }

	// RVA: 0x1994B10 Offset: 0x1994C11 VA: 0x1994B10
	public static TweenerCore<Color, Color, ColorOptions> To(DOGetter<Color> getter, DOSetter<Color> setter, Color endValue, float duration) { }

	// RVA: 0x1994BE0 Offset: 0x1994CE1 VA: 0x1994BE0
	public static TweenerCore<Rect, Rect, RectOptions> To(DOGetter<Rect> getter, DOSetter<Rect> setter, Rect endValue, float duration) { }

	// RVA: 0x1994CB0 Offset: 0x1994DB1 VA: 0x1994CB0
	public static Tweener To(DOGetter<RectOffset> getter, DOSetter<RectOffset> setter, RectOffset endValue, float duration) { }

	// RVA: -1 Offset: -1
	public static TweenerCore<T1, T2, TPlugOptions> To<T1, T2, TPlugOptions>(ABSTweenPlugin<T1, T2, TPlugOptions> plugin, DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AB3650 Offset: 0x1AB3751 VA: 0x1AB3650
	|-DOTween.To<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x1AB3730 Offset: 0x1AB3831 VA: 0x1AB3730
	|-DOTween.To<Vector3, Path, PathOptions>
	|-DOTween.To<Vector3, object, PathOptions>
	*/

	// RVA: 0x1994D50 Offset: 0x1994E51 VA: 0x1994D50
	public static TweenerCore<Vector3, Vector3, VectorOptions> ToAxis(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float endValue, float duration, AxisConstraint axisConstraint = 2) { }

	// RVA: 0x1994E30 Offset: 0x1994F31 VA: 0x1994E30
	public static TweenerCore<Color, Color, ColorOptions> ToAlpha(DOGetter<Color> getter, DOSetter<Color> setter, float endValue, float duration) { }

	// RVA: 0x1994F10 Offset: 0x1995011 VA: 0x1994F10
	public static Tweener To(DOSetter<float> setter, float startValue, float endValue, float duration) { }

	// RVA: 0x19950C0 Offset: 0x19951C1 VA: 0x19950C0
	public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Punch(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3 direction, float duration, int vibrato = 10, float elasticity = 1) { }

	// RVA: 0x1995650 Offset: 0x1995751 VA: 0x1995650
	public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, float strength = 3, int vibrato = 10, float randomness = 90, bool ignoreZAxis = True, bool fadeOut = True) { }

	// RVA: 0x1995ED0 Offset: 0x1995FD1 VA: 0x1995ED0
	public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, Vector3 strength, int vibrato = 10, float randomness = 90, bool fadeOut = True) { }

	// RVA: 0x1995740 Offset: 0x1995841 VA: 0x1995740
	private static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, Vector3 strength, int vibrato, float randomness, bool ignoreZAxis, bool vectorBased, bool fadeOut) { }

	// RVA: 0x1995410 Offset: 0x1995511 VA: 0x1995410
	public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> ToArray(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3[] endValues, float[] durations) { }

	// RVA: 0x1995FB0 Offset: 0x19960B1 VA: 0x1995FB0
	internal static TweenerCore<Color2, Color2, ColorOptions> To(DOGetter<Color2> getter, DOSetter<Color2> setter, Color2 endValue, float duration) { }

	// RVA: 0x1996080 Offset: 0x1996181 VA: 0x1996080
	public static Sequence Sequence() { }

	// RVA: 0x1996120 Offset: 0x1996221 VA: 0x1996120
	public static int CompleteAll(bool withCallbacks = False) { }

	// RVA: 0x19961C0 Offset: 0x19962C1 VA: 0x19961C0
	public static int Complete(object targetOrId, bool withCallbacks = False) { }

	// RVA: 0x1996280 Offset: 0x1996381 VA: 0x1996280
	internal static int CompleteAndReturnKilledTot() { }

	// RVA: 0x1996300 Offset: 0x1996401 VA: 0x1996300
	internal static int CompleteAndReturnKilledTot(object targetOrId) { }

	// RVA: 0x1996390 Offset: 0x1996491 VA: 0x1996390
	internal static int CompleteAndReturnKilledTotExceptFor(object[] excludeTargetsOrIds) { }

	// RVA: 0x1996410 Offset: 0x1996511 VA: 0x1996410
	public static int FlipAll() { }

	// RVA: 0x1996490 Offset: 0x1996591 VA: 0x1996490
	public static int Flip(object targetOrId) { }

	// RVA: 0x1996520 Offset: 0x1996621 VA: 0x1996520
	public static int GotoAll(float to, bool andPlay = False) { }

	// RVA: 0x19965B0 Offset: 0x19966B1 VA: 0x19965B0
	public static int Goto(object targetOrId, float to, bool andPlay = False) { }

	// RVA: 0x1996660 Offset: 0x1996761 VA: 0x1996660
	public static int KillAll(bool complete = False) { }

	// RVA: 0x1996770 Offset: 0x1996871 VA: 0x1996770
	public static int KillAll(bool complete, object[] idsOrTargetsToExclude) { }

	// RVA: 0x1996970 Offset: 0x1996A71 VA: 0x1996970
	public static int Kill(object targetOrId, bool complete = False) { }

	// RVA: 0x1996AC0 Offset: 0x1996BC1 VA: 0x1996AC0
	public static int PauseAll() { }

	// RVA: 0x1996B40 Offset: 0x1996C41 VA: 0x1996B40
	public static int Pause(object targetOrId) { }

	// RVA: 0x1996BD0 Offset: 0x1996CD1 VA: 0x1996BD0
	public static int PlayAll() { }

	// RVA: 0x1996C50 Offset: 0x1996D51 VA: 0x1996C50
	public static int Play(object targetOrId) { }

	// RVA: 0x1996CE0 Offset: 0x1996DE1 VA: 0x1996CE0
	public static int Play(object target, object id) { }

	// RVA: 0x1996D90 Offset: 0x1996E91 VA: 0x1996D90
	public static int PlayBackwardsAll() { }

	// RVA: 0x1996E10 Offset: 0x1996F11 VA: 0x1996E10
	public static int PlayBackwards(object targetOrId) { }

	// RVA: 0x1996EA0 Offset: 0x1996FA1 VA: 0x1996EA0
	public static int PlayBackwards(object target, object id) { }

	// RVA: 0x1996F50 Offset: 0x1997051 VA: 0x1996F50
	public static int PlayForwardAll() { }

	// RVA: 0x1996FD0 Offset: 0x19970D1 VA: 0x1996FD0
	public static int PlayForward(object targetOrId) { }

	// RVA: 0x1997060 Offset: 0x1997161 VA: 0x1997060
	public static int PlayForward(object target, object id) { }

	// RVA: 0x1997110 Offset: 0x1997211 VA: 0x1997110
	public static int RestartAll(bool includeDelay = True) { }

	// RVA: 0x1997190 Offset: 0x1997291 VA: 0x1997190
	public static int Restart(object targetOrId, bool includeDelay = True, float changeDelayTo = -1) { }

	// RVA: 0x1997240 Offset: 0x1997341 VA: 0x1997240
	public static int Restart(object target, object id, bool includeDelay = True, float changeDelayTo = -1) { }

	// RVA: 0x1997300 Offset: 0x1997401 VA: 0x1997300
	public static int RewindAll(bool includeDelay = True) { }

	// RVA: 0x1997380 Offset: 0x1997481 VA: 0x1997380
	public static int Rewind(object targetOrId, bool includeDelay = True) { }

	// RVA: 0x1997420 Offset: 0x1997521 VA: 0x1997420
	public static int SmoothRewindAll() { }

	// RVA: 0x19974A0 Offset: 0x19975A1 VA: 0x19974A0
	public static int SmoothRewind(object targetOrId) { }

	// RVA: 0x1997530 Offset: 0x1997631 VA: 0x1997530
	public static int TogglePauseAll() { }

	// RVA: 0x19975B0 Offset: 0x19976B1 VA: 0x19975B0
	public static int TogglePause(object targetOrId) { }

	// RVA: 0x1997640 Offset: 0x1997741 VA: 0x1997640
	public static bool IsTweening(object targetOrId, bool alsoCheckIfIsPlaying = False) { }

	// RVA: 0x19976E0 Offset: 0x19977E1 VA: 0x19976E0
	public static int TotalPlayingTweens() { }

	// RVA: 0x1997750 Offset: 0x1997851 VA: 0x1997750
	public static List<Tween> PlayingTweens(List<Tween> fillableList) { }

	// RVA: 0x19977D0 Offset: 0x19978D1 VA: 0x19977D0
	public static List<Tween> PausedTweens(List<Tween> fillableList) { }

	// RVA: 0x1997850 Offset: 0x1997951 VA: 0x1997850
	public static List<Tween> TweensById(object id, bool playingOnly = False, List<Tween> fillableList) { }

	// RVA: 0x1997900 Offset: 0x1997A01 VA: 0x1997900
	public static List<Tween> TweensByTarget(object target, bool playingOnly = False, List<Tween> fillableList) { }

	// RVA: 0x19942E0 Offset: 0x19943E1 VA: 0x19942E0
	private static void InitCheck() { }

	// RVA: -1 Offset: -1
	private static TweenerCore<T1, T2, TPlugOptions> ApplyTo<T1, T2, TPlugOptions>(DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration, ABSTweenPlugin<T1, T2, TPlugOptions> plugin) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AB2040 Offset: 0x1AB2141 VA: 0x1AB2040
	|-DOTween.ApplyTo<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x1AB21A0 Offset: 0x1AB22A1 VA: 0x1AB21A0
	|-DOTween.ApplyTo<double, double, NoOptions>
	|
	|-RVA: 0x1AB22C0 Offset: 0x1AB23C1 VA: 0x1AB22C0
	|-DOTween.ApplyTo<int, int, NoOptions>
	|
	|-RVA: 0x1AB23F0 Offset: 0x1AB24F1 VA: 0x1AB23F0
	|-DOTween.ApplyTo<long, long, NoOptions>
	|
	|-RVA: 0x1AB2520 Offset: 0x1AB2621 VA: 0x1AB2520
	|-DOTween.ApplyTo<object, object, NoOptions>
	|-DOTween.ApplyTo<RectOffset, RectOffset, NoOptions>
	|
	|-RVA: 0x1AB2650 Offset: 0x1AB2751 VA: 0x1AB2650
	|-DOTween.ApplyTo<object, object, StringOptions>
	|-DOTween.ApplyTo<string, string, StringOptions>
	|
	|-RVA: 0x1AB2780 Offset: 0x1AB2881 VA: 0x1AB2780
	|-DOTween.ApplyTo<float, float, FloatOptions>
	|
	|-RVA: 0x1AB28A0 Offset: 0x1AB29A1 VA: 0x1AB28A0
	|-DOTween.ApplyTo<uint, uint, UintOptions>
	|
	|-RVA: 0x1AB29D0 Offset: 0x1AB2AD1 VA: 0x1AB29D0
	|-DOTween.ApplyTo<ulong, ulong, NoOptions>
	|
	|-RVA: 0x1AB2B00 Offset: 0x1AB2C01 VA: 0x1AB2B00
	|-DOTween.ApplyTo<Color, Color, ColorOptions>
	|
	|-RVA: 0x1AB2C50 Offset: 0x1AB2D51 VA: 0x1AB2C50
	|-DOTween.ApplyTo<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x1AB2DA0 Offset: 0x1AB2EA1 VA: 0x1AB2DA0
	|-DOTween.ApplyTo<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x1AB2EE0 Offset: 0x1AB2FE1 VA: 0x1AB2EE0
	|-DOTween.ApplyTo<Rect, Rect, RectOptions>
	|
	|-RVA: 0x1AB3030 Offset: 0x1AB3131 VA: 0x1AB3030
	|-DOTween.ApplyTo<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x1AB3160 Offset: 0x1AB3261 VA: 0x1AB3160
	|-DOTween.ApplyTo<Vector3, object, PathOptions>
	|
	|-RVA: 0x1AB3290 Offset: 0x1AB3391 VA: 0x1AB3290
	|-DOTween.ApplyTo<Vector3, object, Vector3ArrayOptions>
	|-DOTween.ApplyTo<Vector3, Vector3[], Vector3ArrayOptions>
	|
	|-RVA: 0x1AB33C0 Offset: 0x1AB34C1 VA: 0x1AB33C0
	|-DOTween.ApplyTo<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x1AB3500 Offset: 0x1AB3601 VA: 0x1AB3500
	|-DOTween.ApplyTo<Vector4, Vector4, VectorOptions>
	*/

	// RVA: 0x19979A0 Offset: 0x1997AA1 VA: 0x19979A0
	public void .ctor() { }

	// RVA: 0x19979B0 Offset: 0x1997AB1 VA: 0x19979B0
	private static void .cctor() { }
}

public class DOTween // TypeDefIndex: 4918
{
	// Fields
	public static readonly string Version; // 0x0
	public static bool useSafeMode; // 0x8
	public static NestedTweenFailureBehaviour nestedTweenFailureBehaviour; // 0xC
	public static bool showUnityEditorReport; // 0x10
	public static float timeScale; // 0x14
	public static bool useSmoothDeltaTime; // 0x18
	public static float maxSmoothUnscaledTime; // 0x1C
	internal static RewindCallbackMode rewindCallbackMode; // 0x20
	private static LogBehaviour _logBehaviour; // 0x24
	public static Func<LogType, object, bool> onWillLog; // 0x28
	public static bool drawGizmos; // 0x30
	public static bool debugMode; // 0x31
	private static bool _fooDebugStoreTargetId; // 0x32
	public static UpdateType defaultUpdateType; // 0x34
	public static bool defaultTimeScaleIndependent; // 0x38
	public static AutoPlay defaultAutoPlay; // 0x3C
	public static bool defaultAutoKill; // 0x40
	public static LoopType defaultLoopType; // 0x44
	public static bool defaultRecyclable; // 0x48
	public static Ease defaultEaseType; // 0x4C
	public static float defaultEaseOvershootOrAmplitude; // 0x50
	public static float defaultEasePeriod; // 0x54
	public static DOTweenComponent instance; // 0x58
	internal static int maxActiveTweenersReached; // 0x60
	internal static int maxActiveSequencesReached; // 0x64
	internal static SafeModeReport safeModeReport; // 0x68
	internal static readonly List<TweenCallback> GizmosDelegates; // 0x78
	internal static bool initialized; // 0x80
	internal static bool isQuitting; // 0x81

	// Properties
	public static LogBehaviour logBehaviour { get; set; }
	public static bool debugStoreTargetId { get; set; }

	// Methods

	// RVA: 0x1993070 Offset: 0x1993171 VA: 0x1993070
	public static LogBehaviour get_logBehaviour() { }

	// RVA: 0x19930E0 Offset: 0x19931E1 VA: 0x19930E0
	public static void set_logBehaviour(LogBehaviour value) { }

	// RVA: 0x19931D0 Offset: 0x19932D1 VA: 0x19931D0
	public static bool get_debugStoreTargetId() { }

	// RVA: 0x19932C0 Offset: 0x19933C1 VA: 0x19932C0
	public static void set_debugStoreTargetId(bool value) { }

	// RVA: 0x1993330 Offset: 0x1993431 VA: 0x1993330
	public static IDOTweenInit Init(Nullable<bool> recycleAllByDefault, Nullable<bool> useSafeMode, Nullable<LogBehaviour> logBehaviour) { }

	// RVA: 0x1993DE0 Offset: 0x1993EE1 VA: 0x1993DE0
	private static void AutoInit() { }

	// RVA: 0x19934C0 Offset: 0x19935C1 VA: 0x19934C0
	private static IDOTweenInit Init(DOTweenSettings settings, Nullable<bool> recycleAllByDefault, Nullable<bool> useSafeMode, Nullable<LogBehaviour> logBehaviour) { }

	// RVA: 0x1993EB0 Offset: 0x1993FB1 VA: 0x1993EB0
	public static void SetTweensCapacity(int tweenersCapacity, int sequencesCapacity) { }

	// RVA: 0x19873F0 Offset: 0x19874F1 VA: 0x19873F0
	public static void Clear(bool destroy = False) { }

	// RVA: 0x19940D0 Offset: 0x19941D1 VA: 0x19940D0
	public static void ClearCachedTweens() { }

	// RVA: 0x1994140 Offset: 0x1994241 VA: 0x1994140
	public static int Validate() { }

	// RVA: 0x19941B0 Offset: 0x19942B1 VA: 0x19941B0
	public static void ManualUpdate(float deltaTime, float unscaledDeltaTime) { }

	// RVA: 0x19943B0 Offset: 0x19944B1 VA: 0x19943B0
	public static TweenerCore<float, float, FloatOptions> To(DOGetter<float> getter, DOSetter<float> setter, float endValue, float duration) { }

	// RVA: 0x1994450 Offset: 0x1994551 VA: 0x1994450
	public static TweenerCore<double, double, NoOptions> To(DOGetter<double> getter, DOSetter<double> setter, double endValue, float duration) { }

	// RVA: 0x19944F0 Offset: 0x19945F1 VA: 0x19944F0
	public static TweenerCore<int, int, NoOptions> To(DOGetter<int> getter, DOSetter<int> setter, int endValue, float duration) { }

	// RVA: 0x1994590 Offset: 0x1994691 VA: 0x1994590
	public static TweenerCore<uint, uint, UintOptions> To(DOGetter<uint> getter, DOSetter<uint> setter, uint endValue, float duration) { }

	// RVA: 0x1994630 Offset: 0x1994731 VA: 0x1994630
	public static TweenerCore<long, long, NoOptions> To(DOGetter<long> getter, DOSetter<long> setter, long endValue, float duration) { }

	// RVA: 0x19946D0 Offset: 0x19947D1 VA: 0x19946D0
	public static TweenerCore<ulong, ulong, NoOptions> To(DOGetter<ulong> getter, DOSetter<ulong> setter, ulong endValue, float duration) { }

	// RVA: 0x1994770 Offset: 0x1994871 VA: 0x1994770
	public static TweenerCore<string, string, StringOptions> To(DOGetter<string> getter, DOSetter<string> setter, string endValue, float duration) { }

	// RVA: 0x1994810 Offset: 0x1994911 VA: 0x1994810
	public static TweenerCore<Vector2, Vector2, VectorOptions> To(DOGetter<Vector2> getter, DOSetter<Vector2> setter, Vector2 endValue, float duration) { }

	// RVA: 0x19948C0 Offset: 0x19949C1 VA: 0x19948C0
	public static TweenerCore<Vector3, Vector3, VectorOptions> To(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3 endValue, float duration) { }

	// RVA: 0x1994980 Offset: 0x1994A81 VA: 0x1994980
	public static TweenerCore<Vector4, Vector4, VectorOptions> To(DOGetter<Vector4> getter, DOSetter<Vector4> setter, Vector4 endValue, float duration) { }

	// RVA: 0x1994A50 Offset: 0x1994B51 VA: 0x1994A50
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> To(DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, Vector3 endValue, float duration) { }

	// RVA: 0x1994B10 Offset: 0x1994C11 VA: 0x1994B10
	public static TweenerCore<Color, Color, ColorOptions> To(DOGetter<Color> getter, DOSetter<Color> setter, Color endValue, float duration) { }

	// RVA: 0x1994BE0 Offset: 0x1994CE1 VA: 0x1994BE0
	public static TweenerCore<Rect, Rect, RectOptions> To(DOGetter<Rect> getter, DOSetter<Rect> setter, Rect endValue, float duration) { }

	// RVA: 0x1994CB0 Offset: 0x1994DB1 VA: 0x1994CB0
	public static Tweener To(DOGetter<RectOffset> getter, DOSetter<RectOffset> setter, RectOffset endValue, float duration) { }

	// RVA: -1 Offset: -1
	public static TweenerCore<T1, T2, TPlugOptions> To<T1, T2, TPlugOptions>(ABSTweenPlugin<T1, T2, TPlugOptions> plugin, DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AB3650 Offset: 0x1AB3751 VA: 0x1AB3650
	|-DOTween.To<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x1AB3730 Offset: 0x1AB3831 VA: 0x1AB3730
	|-DOTween.To<Vector3, Path, PathOptions>
	|-DOTween.To<Vector3, object, PathOptions>
	*/

	// RVA: 0x1994D50 Offset: 0x1994E51 VA: 0x1994D50
	public static TweenerCore<Vector3, Vector3, VectorOptions> ToAxis(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float endValue, float duration, AxisConstraint axisConstraint = 2) { }

	// RVA: 0x1994E30 Offset: 0x1994F31 VA: 0x1994E30
	public static TweenerCore<Color, Color, ColorOptions> ToAlpha(DOGetter<Color> getter, DOSetter<Color> setter, float endValue, float duration) { }

	// RVA: 0x1994F10 Offset: 0x1995011 VA: 0x1994F10
	public static Tweener To(DOSetter<float> setter, float startValue, float endValue, float duration) { }

	// RVA: 0x19950C0 Offset: 0x19951C1 VA: 0x19950C0
	public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Punch(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3 direction, float duration, int vibrato = 10, float elasticity = 1) { }

	// RVA: 0x1995650 Offset: 0x1995751 VA: 0x1995650
	public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, float strength = 3, int vibrato = 10, float randomness = 90, bool ignoreZAxis = True, bool fadeOut = True) { }

	// RVA: 0x1995ED0 Offset: 0x1995FD1 VA: 0x1995ED0
	public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, Vector3 strength, int vibrato = 10, float randomness = 90, bool fadeOut = True) { }

	// RVA: 0x1995740 Offset: 0x1995841 VA: 0x1995740
	private static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, Vector3 strength, int vibrato, float randomness, bool ignoreZAxis, bool vectorBased, bool fadeOut) { }

	// RVA: 0x1995410 Offset: 0x1995511 VA: 0x1995410
	public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> ToArray(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3[] endValues, float[] durations) { }

	// RVA: 0x1995FB0 Offset: 0x19960B1 VA: 0x1995FB0
	internal static TweenerCore<Color2, Color2, ColorOptions> To(DOGetter<Color2> getter, DOSetter<Color2> setter, Color2 endValue, float duration) { }

	// RVA: 0x1996080 Offset: 0x1996181 VA: 0x1996080
	public static Sequence Sequence() { }

	// RVA: 0x1996120 Offset: 0x1996221 VA: 0x1996120
	public static int CompleteAll(bool withCallbacks = False) { }

	// RVA: 0x19961C0 Offset: 0x19962C1 VA: 0x19961C0
	public static int Complete(object targetOrId, bool withCallbacks = False) { }

	// RVA: 0x1996280 Offset: 0x1996381 VA: 0x1996280
	internal static int CompleteAndReturnKilledTot() { }

	// RVA: 0x1996300 Offset: 0x1996401 VA: 0x1996300
	internal static int CompleteAndReturnKilledTot(object targetOrId) { }

	// RVA: 0x1996390 Offset: 0x1996491 VA: 0x1996390
	internal static int CompleteAndReturnKilledTotExceptFor(object[] excludeTargetsOrIds) { }

	// RVA: 0x1996410 Offset: 0x1996511 VA: 0x1996410
	public static int FlipAll() { }

	// RVA: 0x1996490 Offset: 0x1996591 VA: 0x1996490
	public static int Flip(object targetOrId) { }

	// RVA: 0x1996520 Offset: 0x1996621 VA: 0x1996520
	public static int GotoAll(float to, bool andPlay = False) { }

	// RVA: 0x19965B0 Offset: 0x19966B1 VA: 0x19965B0
	public static int Goto(object targetOrId, float to, bool andPlay = False) { }

	// RVA: 0x1996660 Offset: 0x1996761 VA: 0x1996660
	public static int KillAll(bool complete = False) { }

	// RVA: 0x1996770 Offset: 0x1996871 VA: 0x1996770
	public static int KillAll(bool complete, object[] idsOrTargetsToExclude) { }

	// RVA: 0x1996970 Offset: 0x1996A71 VA: 0x1996970
	public static int Kill(object targetOrId, bool complete = False) { }

	// RVA: 0x1996AC0 Offset: 0x1996BC1 VA: 0x1996AC0
	public static int PauseAll() { }

	// RVA: 0x1996B40 Offset: 0x1996C41 VA: 0x1996B40
	public static int Pause(object targetOrId) { }

	// RVA: 0x1996BD0 Offset: 0x1996CD1 VA: 0x1996BD0
	public static int PlayAll() { }

	// RVA: 0x1996C50 Offset: 0x1996D51 VA: 0x1996C50
	public static int Play(object targetOrId) { }

	// RVA: 0x1996CE0 Offset: 0x1996DE1 VA: 0x1996CE0
	public static int Play(object target, object id) { }

	// RVA: 0x1996D90 Offset: 0x1996E91 VA: 0x1996D90
	public static int PlayBackwardsAll() { }

	// RVA: 0x1996E10 Offset: 0x1996F11 VA: 0x1996E10
	public static int PlayBackwards(object targetOrId) { }

	// RVA: 0x1996EA0 Offset: 0x1996FA1 VA: 0x1996EA0
	public static int PlayBackwards(object target, object id) { }

	// RVA: 0x1996F50 Offset: 0x1997051 VA: 0x1996F50
	public static int PlayForwardAll() { }

	// RVA: 0x1996FD0 Offset: 0x19970D1 VA: 0x1996FD0
	public static int PlayForward(object targetOrId) { }

	// RVA: 0x1997060 Offset: 0x1997161 VA: 0x1997060
	public static int PlayForward(object target, object id) { }

	// RVA: 0x1997110 Offset: 0x1997211 VA: 0x1997110
	public static int RestartAll(bool includeDelay = True) { }

	// RVA: 0x1997190 Offset: 0x1997291 VA: 0x1997190
	public static int Restart(object targetOrId, bool includeDelay = True, float changeDelayTo = -1) { }

	// RVA: 0x1997240 Offset: 0x1997341 VA: 0x1997240
	public static int Restart(object target, object id, bool includeDelay = True, float changeDelayTo = -1) { }

	// RVA: 0x1997300 Offset: 0x1997401 VA: 0x1997300
	public static int RewindAll(bool includeDelay = True) { }

	// RVA: 0x1997380 Offset: 0x1997481 VA: 0x1997380
	public static int Rewind(object targetOrId, bool includeDelay = True) { }

	// RVA: 0x1997420 Offset: 0x1997521 VA: 0x1997420
	public static int SmoothRewindAll() { }

	// RVA: 0x19974A0 Offset: 0x19975A1 VA: 0x19974A0
	public static int SmoothRewind(object targetOrId) { }

	// RVA: 0x1997530 Offset: 0x1997631 VA: 0x1997530
	public static int TogglePauseAll() { }

	// RVA: 0x19975B0 Offset: 0x19976B1 VA: 0x19975B0
	public static int TogglePause(object targetOrId) { }

	// RVA: 0x1997640 Offset: 0x1997741 VA: 0x1997640
	public static bool IsTweening(object targetOrId, bool alsoCheckIfIsPlaying = False) { }

	// RVA: 0x19976E0 Offset: 0x19977E1 VA: 0x19976E0
	public static int TotalPlayingTweens() { }

	// RVA: 0x1997750 Offset: 0x1997851 VA: 0x1997750
	public static List<Tween> PlayingTweens(List<Tween> fillableList) { }

	// RVA: 0x19977D0 Offset: 0x19978D1 VA: 0x19977D0
	public static List<Tween> PausedTweens(List<Tween> fillableList) { }

	// RVA: 0x1997850 Offset: 0x1997951 VA: 0x1997850
	public static List<Tween> TweensById(object id, bool playingOnly = False, List<Tween> fillableList) { }

	// RVA: 0x1997900 Offset: 0x1997A01 VA: 0x1997900
	public static List<Tween> TweensByTarget(object target, bool playingOnly = False, List<Tween> fillableList) { }

	// RVA: 0x19942E0 Offset: 0x19943E1 VA: 0x19942E0
	private static void InitCheck() { }

	// RVA: -1 Offset: -1
	private static TweenerCore<T1, T2, TPlugOptions> ApplyTo<T1, T2, TPlugOptions>(DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration, ABSTweenPlugin<T1, T2, TPlugOptions> plugin) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AB2040 Offset: 0x1AB2141 VA: 0x1AB2040
	|-DOTween.ApplyTo<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x1AB21A0 Offset: 0x1AB22A1 VA: 0x1AB21A0
	|-DOTween.ApplyTo<double, double, NoOptions>
	|
	|-RVA: 0x1AB22C0 Offset: 0x1AB23C1 VA: 0x1AB22C0
	|-DOTween.ApplyTo<int, int, NoOptions>
	|
	|-RVA: 0x1AB23F0 Offset: 0x1AB24F1 VA: 0x1AB23F0
	|-DOTween.ApplyTo<long, long, NoOptions>
	|
	|-RVA: 0x1AB2520 Offset: 0x1AB2621 VA: 0x1AB2520
	|-DOTween.ApplyTo<object, object, NoOptions>
	|-DOTween.ApplyTo<RectOffset, RectOffset, NoOptions>
	|
	|-RVA: 0x1AB2650 Offset: 0x1AB2751 VA: 0x1AB2650
	|-DOTween.ApplyTo<object, object, StringOptions>
	|-DOTween.ApplyTo<string, string, StringOptions>
	|
	|-RVA: 0x1AB2780 Offset: 0x1AB2881 VA: 0x1AB2780
	|-DOTween.ApplyTo<float, float, FloatOptions>
	|
	|-RVA: 0x1AB28A0 Offset: 0x1AB29A1 VA: 0x1AB28A0
	|-DOTween.ApplyTo<uint, uint, UintOptions>
	|
	|-RVA: 0x1AB29D0 Offset: 0x1AB2AD1 VA: 0x1AB29D0
	|-DOTween.ApplyTo<ulong, ulong, NoOptions>
	|
	|-RVA: 0x1AB2B00 Offset: 0x1AB2C01 VA: 0x1AB2B00
	|-DOTween.ApplyTo<Color, Color, ColorOptions>
	|
	|-RVA: 0x1AB2C50 Offset: 0x1AB2D51 VA: 0x1AB2C50
	|-DOTween.ApplyTo<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x1AB2DA0 Offset: 0x1AB2EA1 VA: 0x1AB2DA0
	|-DOTween.ApplyTo<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x1AB2EE0 Offset: 0x1AB2FE1 VA: 0x1AB2EE0
	|-DOTween.ApplyTo<Rect, Rect, RectOptions>
	|
	|-RVA: 0x1AB3030 Offset: 0x1AB3131 VA: 0x1AB3030
	|-DOTween.ApplyTo<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x1AB3160 Offset: 0x1AB3261 VA: 0x1AB3160
	|-DOTween.ApplyTo<Vector3, object, PathOptions>
	|
	|-RVA: 0x1AB3290 Offset: 0x1AB3391 VA: 0x1AB3290
	|-DOTween.ApplyTo<Vector3, object, Vector3ArrayOptions>
	|-DOTween.ApplyTo<Vector3, Vector3[], Vector3ArrayOptions>
	|
	|-RVA: 0x1AB33C0 Offset: 0x1AB34C1 VA: 0x1AB33C0
	|-DOTween.ApplyTo<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x1AB3500 Offset: 0x1AB3601 VA: 0x1AB3500
	|-DOTween.ApplyTo<Vector4, Vector4, VectorOptions>
	*/

	// RVA: 0x19979A0 Offset: 0x1997AA1 VA: 0x19979A0
	public void .ctor() { }

	// RVA: 0x19979B0 Offset: 0x1997AB1 VA: 0x19979B0
	private static void .cctor() { }
}

public class DOTween // TypeDefIndex: 4918
{
	// Fields
	public static readonly string Version; // 0x0
	public static bool useSafeMode; // 0x8
	public static NestedTweenFailureBehaviour nestedTweenFailureBehaviour; // 0xC
	public static bool showUnityEditorReport; // 0x10
	public static float timeScale; // 0x14
	public static bool useSmoothDeltaTime; // 0x18
	public static float maxSmoothUnscaledTime; // 0x1C
	internal static RewindCallbackMode rewindCallbackMode; // 0x20
	private static LogBehaviour _logBehaviour; // 0x24
	public static Func<LogType, object, bool> onWillLog; // 0x28
	public static bool drawGizmos; // 0x30
	public static bool debugMode; // 0x31
	private static bool _fooDebugStoreTargetId; // 0x32
	public static UpdateType defaultUpdateType; // 0x34
	public static bool defaultTimeScaleIndependent; // 0x38
	public static AutoPlay defaultAutoPlay; // 0x3C
	public static bool defaultAutoKill; // 0x40
	public static LoopType defaultLoopType; // 0x44
	public static bool defaultRecyclable; // 0x48
	public static Ease defaultEaseType; // 0x4C
	public static float defaultEaseOvershootOrAmplitude; // 0x50
	public static float defaultEasePeriod; // 0x54
	public static DOTweenComponent instance; // 0x58
	internal static int maxActiveTweenersReached; // 0x60
	internal static int maxActiveSequencesReached; // 0x64
	internal static SafeModeReport safeModeReport; // 0x68
	internal static readonly List<TweenCallback> GizmosDelegates; // 0x78
	internal static bool initialized; // 0x80
	internal static bool isQuitting; // 0x81

	// Properties
	public static LogBehaviour logBehaviour { get; set; }
	public static bool debugStoreTargetId { get; set; }

	// Methods

	// RVA: 0x1993070 Offset: 0x1993171 VA: 0x1993070
	public static LogBehaviour get_logBehaviour() { }

	// RVA: 0x19930E0 Offset: 0x19931E1 VA: 0x19930E0
	public static void set_logBehaviour(LogBehaviour value) { }

	// RVA: 0x19931D0 Offset: 0x19932D1 VA: 0x19931D0
	public static bool get_debugStoreTargetId() { }

	// RVA: 0x19932C0 Offset: 0x19933C1 VA: 0x19932C0
	public static void set_debugStoreTargetId(bool value) { }

	// RVA: 0x1993330 Offset: 0x1993431 VA: 0x1993330
	public static IDOTweenInit Init(Nullable<bool> recycleAllByDefault, Nullable<bool> useSafeMode, Nullable<LogBehaviour> logBehaviour) { }

	// RVA: 0x1993DE0 Offset: 0x1993EE1 VA: 0x1993DE0
	private static void AutoInit() { }

	// RVA: 0x19934C0 Offset: 0x19935C1 VA: 0x19934C0
	private static IDOTweenInit Init(DOTweenSettings settings, Nullable<bool> recycleAllByDefault, Nullable<bool> useSafeMode, Nullable<LogBehaviour> logBehaviour) { }

	// RVA: 0x1993EB0 Offset: 0x1993FB1 VA: 0x1993EB0
	public static void SetTweensCapacity(int tweenersCapacity, int sequencesCapacity) { }

	// RVA: 0x19873F0 Offset: 0x19874F1 VA: 0x19873F0
	public static void Clear(bool destroy = False) { }

	// RVA: 0x19940D0 Offset: 0x19941D1 VA: 0x19940D0
	public static void ClearCachedTweens() { }

	// RVA: 0x1994140 Offset: 0x1994241 VA: 0x1994140
	public static int Validate() { }

	// RVA: 0x19941B0 Offset: 0x19942B1 VA: 0x19941B0
	public static void ManualUpdate(float deltaTime, float unscaledDeltaTime) { }

	// RVA: 0x19943B0 Offset: 0x19944B1 VA: 0x19943B0
	public static TweenerCore<float, float, FloatOptions> To(DOGetter<float> getter, DOSetter<float> setter, float endValue, float duration) { }

	// RVA: 0x1994450 Offset: 0x1994551 VA: 0x1994450
	public static TweenerCore<double, double, NoOptions> To(DOGetter<double> getter, DOSetter<double> setter, double endValue, float duration) { }

	// RVA: 0x19944F0 Offset: 0x19945F1 VA: 0x19944F0
	public static TweenerCore<int, int, NoOptions> To(DOGetter<int> getter, DOSetter<int> setter, int endValue, float duration) { }

	// RVA: 0x1994590 Offset: 0x1994691 VA: 0x1994590
	public static TweenerCore<uint, uint, UintOptions> To(DOGetter<uint> getter, DOSetter<uint> setter, uint endValue, float duration) { }

	// RVA: 0x1994630 Offset: 0x1994731 VA: 0x1994630
	public static TweenerCore<long, long, NoOptions> To(DOGetter<long> getter, DOSetter<long> setter, long endValue, float duration) { }

	// RVA: 0x19946D0 Offset: 0x19947D1 VA: 0x19946D0
	public static TweenerCore<ulong, ulong, NoOptions> To(DOGetter<ulong> getter, DOSetter<ulong> setter, ulong endValue, float duration) { }

	// RVA: 0x1994770 Offset: 0x1994871 VA: 0x1994770
	public static TweenerCore<string, string, StringOptions> To(DOGetter<string> getter, DOSetter<string> setter, string endValue, float duration) { }

	// RVA: 0x1994810 Offset: 0x1994911 VA: 0x1994810
	public static TweenerCore<Vector2, Vector2, VectorOptions> To(DOGetter<Vector2> getter, DOSetter<Vector2> setter, Vector2 endValue, float duration) { }

	// RVA: 0x19948C0 Offset: 0x19949C1 VA: 0x19948C0
	public static TweenerCore<Vector3, Vector3, VectorOptions> To(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3 endValue, float duration) { }

	// RVA: 0x1994980 Offset: 0x1994A81 VA: 0x1994980
	public static TweenerCore<Vector4, Vector4, VectorOptions> To(DOGetter<Vector4> getter, DOSetter<Vector4> setter, Vector4 endValue, float duration) { }

	// RVA: 0x1994A50 Offset: 0x1994B51 VA: 0x1994A50
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> To(DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, Vector3 endValue, float duration) { }

	// RVA: 0x1994B10 Offset: 0x1994C11 VA: 0x1994B10
	public static TweenerCore<Color, Color, ColorOptions> To(DOGetter<Color> getter, DOSetter<Color> setter, Color endValue, float duration) { }

	// RVA: 0x1994BE0 Offset: 0x1994CE1 VA: 0x1994BE0
	public static TweenerCore<Rect, Rect, RectOptions> To(DOGetter<Rect> getter, DOSetter<Rect> setter, Rect endValue, float duration) { }

	// RVA: 0x1994CB0 Offset: 0x1994DB1 VA: 0x1994CB0
	public static Tweener To(DOGetter<RectOffset> getter, DOSetter<RectOffset> setter, RectOffset endValue, float duration) { }

	// RVA: -1 Offset: -1
	public static TweenerCore<T1, T2, TPlugOptions> To<T1, T2, TPlugOptions>(ABSTweenPlugin<T1, T2, TPlugOptions> plugin, DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AB3650 Offset: 0x1AB3751 VA: 0x1AB3650
	|-DOTween.To<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x1AB3730 Offset: 0x1AB3831 VA: 0x1AB3730
	|-DOTween.To<Vector3, Path, PathOptions>
	|-DOTween.To<Vector3, object, PathOptions>
	*/

	// RVA: 0x1994D50 Offset: 0x1994E51 VA: 0x1994D50
	public static TweenerCore<Vector3, Vector3, VectorOptions> ToAxis(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float endValue, float duration, AxisConstraint axisConstraint = 2) { }

	// RVA: 0x1994E30 Offset: 0x1994F31 VA: 0x1994E30
	public static TweenerCore<Color, Color, ColorOptions> ToAlpha(DOGetter<Color> getter, DOSetter<Color> setter, float endValue, float duration) { }

	// RVA: 0x1994F10 Offset: 0x1995011 VA: 0x1994F10
	public static Tweener To(DOSetter<float> setter, float startValue, float endValue, float duration) { }

	// RVA: 0x19950C0 Offset: 0x19951C1 VA: 0x19950C0
	public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Punch(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3 direction, float duration, int vibrato = 10, float elasticity = 1) { }

	// RVA: 0x1995650 Offset: 0x1995751 VA: 0x1995650
	public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, float strength = 3, int vibrato = 10, float randomness = 90, bool ignoreZAxis = True, bool fadeOut = True) { }

	// RVA: 0x1995ED0 Offset: 0x1995FD1 VA: 0x1995ED0
	public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, Vector3 strength, int vibrato = 10, float randomness = 90, bool fadeOut = True) { }

	// RVA: 0x1995740 Offset: 0x1995841 VA: 0x1995740
	private static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, Vector3 strength, int vibrato, float randomness, bool ignoreZAxis, bool vectorBased, bool fadeOut) { }

	// RVA: 0x1995410 Offset: 0x1995511 VA: 0x1995410
	public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> ToArray(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3[] endValues, float[] durations) { }

	// RVA: 0x1995FB0 Offset: 0x19960B1 VA: 0x1995FB0
	internal static TweenerCore<Color2, Color2, ColorOptions> To(DOGetter<Color2> getter, DOSetter<Color2> setter, Color2 endValue, float duration) { }

	// RVA: 0x1996080 Offset: 0x1996181 VA: 0x1996080
	public static Sequence Sequence() { }

	// RVA: 0x1996120 Offset: 0x1996221 VA: 0x1996120
	public static int CompleteAll(bool withCallbacks = False) { }

	// RVA: 0x19961C0 Offset: 0x19962C1 VA: 0x19961C0
	public static int Complete(object targetOrId, bool withCallbacks = False) { }

	// RVA: 0x1996280 Offset: 0x1996381 VA: 0x1996280
	internal static int CompleteAndReturnKilledTot() { }

	// RVA: 0x1996300 Offset: 0x1996401 VA: 0x1996300
	internal static int CompleteAndReturnKilledTot(object targetOrId) { }

	// RVA: 0x1996390 Offset: 0x1996491 VA: 0x1996390
	internal static int CompleteAndReturnKilledTotExceptFor(object[] excludeTargetsOrIds) { }

	// RVA: 0x1996410 Offset: 0x1996511 VA: 0x1996410
	public static int FlipAll() { }

	// RVA: 0x1996490 Offset: 0x1996591 VA: 0x1996490
	public static int Flip(object targetOrId) { }

	// RVA: 0x1996520 Offset: 0x1996621 VA: 0x1996520
	public static int GotoAll(float to, bool andPlay = False) { }

	// RVA: 0x19965B0 Offset: 0x19966B1 VA: 0x19965B0
	public static int Goto(object targetOrId, float to, bool andPlay = False) { }

	// RVA: 0x1996660 Offset: 0x1996761 VA: 0x1996660
	public static int KillAll(bool complete = False) { }

	// RVA: 0x1996770 Offset: 0x1996871 VA: 0x1996770
	public static int KillAll(bool complete, object[] idsOrTargetsToExclude) { }

	// RVA: 0x1996970 Offset: 0x1996A71 VA: 0x1996970
	public static int Kill(object targetOrId, bool complete = False) { }

	// RVA: 0x1996AC0 Offset: 0x1996BC1 VA: 0x1996AC0
	public static int PauseAll() { }

	// RVA: 0x1996B40 Offset: 0x1996C41 VA: 0x1996B40
	public static int Pause(object targetOrId) { }

	// RVA: 0x1996BD0 Offset: 0x1996CD1 VA: 0x1996BD0
	public static int PlayAll() { }

	// RVA: 0x1996C50 Offset: 0x1996D51 VA: 0x1996C50
	public static int Play(object targetOrId) { }

	// RVA: 0x1996CE0 Offset: 0x1996DE1 VA: 0x1996CE0
	public static int Play(object target, object id) { }

	// RVA: 0x1996D90 Offset: 0x1996E91 VA: 0x1996D90
	public static int PlayBackwardsAll() { }

	// RVA: 0x1996E10 Offset: 0x1996F11 VA: 0x1996E10
	public static int PlayBackwards(object targetOrId) { }

	// RVA: 0x1996EA0 Offset: 0x1996FA1 VA: 0x1996EA0
	public static int PlayBackwards(object target, object id) { }

	// RVA: 0x1996F50 Offset: 0x1997051 VA: 0x1996F50
	public static int PlayForwardAll() { }

	// RVA: 0x1996FD0 Offset: 0x19970D1 VA: 0x1996FD0
	public static int PlayForward(object targetOrId) { }

	// RVA: 0x1997060 Offset: 0x1997161 VA: 0x1997060
	public static int PlayForward(object target, object id) { }

	// RVA: 0x1997110 Offset: 0x1997211 VA: 0x1997110
	public static int RestartAll(bool includeDelay = True) { }

	// RVA: 0x1997190 Offset: 0x1997291 VA: 0x1997190
	public static int Restart(object targetOrId, bool includeDelay = True, float changeDelayTo = -1) { }

	// RVA: 0x1997240 Offset: 0x1997341 VA: 0x1997240
	public static int Restart(object target, object id, bool includeDelay = True, float changeDelayTo = -1) { }

	// RVA: 0x1997300 Offset: 0x1997401 VA: 0x1997300
	public static int RewindAll(bool includeDelay = True) { }

	// RVA: 0x1997380 Offset: 0x1997481 VA: 0x1997380
	public static int Rewind(object targetOrId, bool includeDelay = True) { }

	// RVA: 0x1997420 Offset: 0x1997521 VA: 0x1997420
	public static int SmoothRewindAll() { }

	// RVA: 0x19974A0 Offset: 0x19975A1 VA: 0x19974A0
	public static int SmoothRewind(object targetOrId) { }

	// RVA: 0x1997530 Offset: 0x1997631 VA: 0x1997530
	public static int TogglePauseAll() { }

	// RVA: 0x19975B0 Offset: 0x19976B1 VA: 0x19975B0
	public static int TogglePause(object targetOrId) { }

	// RVA: 0x1997640 Offset: 0x1997741 VA: 0x1997640
	public static bool IsTweening(object targetOrId, bool alsoCheckIfIsPlaying = False) { }

	// RVA: 0x19976E0 Offset: 0x19977E1 VA: 0x19976E0
	public static int TotalPlayingTweens() { }

	// RVA: 0x1997750 Offset: 0x1997851 VA: 0x1997750
	public static List<Tween> PlayingTweens(List<Tween> fillableList) { }

	// RVA: 0x19977D0 Offset: 0x19978D1 VA: 0x19977D0
	public static List<Tween> PausedTweens(List<Tween> fillableList) { }

	// RVA: 0x1997850 Offset: 0x1997951 VA: 0x1997850
	public static List<Tween> TweensById(object id, bool playingOnly = False, List<Tween> fillableList) { }

	// RVA: 0x1997900 Offset: 0x1997A01 VA: 0x1997900
	public static List<Tween> TweensByTarget(object target, bool playingOnly = False, List<Tween> fillableList) { }

	// RVA: 0x19942E0 Offset: 0x19943E1 VA: 0x19942E0
	private static void InitCheck() { }

	// RVA: -1 Offset: -1
	private static TweenerCore<T1, T2, TPlugOptions> ApplyTo<T1, T2, TPlugOptions>(DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration, ABSTweenPlugin<T1, T2, TPlugOptions> plugin) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AB2040 Offset: 0x1AB2141 VA: 0x1AB2040
	|-DOTween.ApplyTo<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x1AB21A0 Offset: 0x1AB22A1 VA: 0x1AB21A0
	|-DOTween.ApplyTo<double, double, NoOptions>
	|
	|-RVA: 0x1AB22C0 Offset: 0x1AB23C1 VA: 0x1AB22C0
	|-DOTween.ApplyTo<int, int, NoOptions>
	|
	|-RVA: 0x1AB23F0 Offset: 0x1AB24F1 VA: 0x1AB23F0
	|-DOTween.ApplyTo<long, long, NoOptions>
	|
	|-RVA: 0x1AB2520 Offset: 0x1AB2621 VA: 0x1AB2520
	|-DOTween.ApplyTo<object, object, NoOptions>
	|-DOTween.ApplyTo<RectOffset, RectOffset, NoOptions>
	|
	|-RVA: 0x1AB2650 Offset: 0x1AB2751 VA: 0x1AB2650
	|-DOTween.ApplyTo<object, object, StringOptions>
	|-DOTween.ApplyTo<string, string, StringOptions>
	|
	|-RVA: 0x1AB2780 Offset: 0x1AB2881 VA: 0x1AB2780
	|-DOTween.ApplyTo<float, float, FloatOptions>
	|
	|-RVA: 0x1AB28A0 Offset: 0x1AB29A1 VA: 0x1AB28A0
	|-DOTween.ApplyTo<uint, uint, UintOptions>
	|
	|-RVA: 0x1AB29D0 Offset: 0x1AB2AD1 VA: 0x1AB29D0
	|-DOTween.ApplyTo<ulong, ulong, NoOptions>
	|
	|-RVA: 0x1AB2B00 Offset: 0x1AB2C01 VA: 0x1AB2B00
	|-DOTween.ApplyTo<Color, Color, ColorOptions>
	|
	|-RVA: 0x1AB2C50 Offset: 0x1AB2D51 VA: 0x1AB2C50
	|-DOTween.ApplyTo<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x1AB2DA0 Offset: 0x1AB2EA1 VA: 0x1AB2DA0
	|-DOTween.ApplyTo<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x1AB2EE0 Offset: 0x1AB2FE1 VA: 0x1AB2EE0
	|-DOTween.ApplyTo<Rect, Rect, RectOptions>
	|
	|-RVA: 0x1AB3030 Offset: 0x1AB3131 VA: 0x1AB3030
	|-DOTween.ApplyTo<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x1AB3160 Offset: 0x1AB3261 VA: 0x1AB3160
	|-DOTween.ApplyTo<Vector3, object, PathOptions>
	|
	|-RVA: 0x1AB3290 Offset: 0x1AB3391 VA: 0x1AB3290
	|-DOTween.ApplyTo<Vector3, object, Vector3ArrayOptions>
	|-DOTween.ApplyTo<Vector3, Vector3[], Vector3ArrayOptions>
	|
	|-RVA: 0x1AB33C0 Offset: 0x1AB34C1 VA: 0x1AB33C0
	|-DOTween.ApplyTo<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x1AB3500 Offset: 0x1AB3601 VA: 0x1AB3500
	|-DOTween.ApplyTo<Vector4, Vector4, VectorOptions>
	*/

	// RVA: 0x19979A0 Offset: 0x1997AA1 VA: 0x19979A0
	public void .ctor() { }

	// RVA: 0x19979B0 Offset: 0x1997AB1 VA: 0x19979B0
	private static void .cctor() { }
}

public class DOTween // TypeDefIndex: 4918
{
	// Fields
	public static readonly string Version; // 0x0
	public static bool useSafeMode; // 0x8
	public static NestedTweenFailureBehaviour nestedTweenFailureBehaviour; // 0xC
	public static bool showUnityEditorReport; // 0x10
	public static float timeScale; // 0x14
	public static bool useSmoothDeltaTime; // 0x18
	public static float maxSmoothUnscaledTime; // 0x1C
	internal static RewindCallbackMode rewindCallbackMode; // 0x20
	private static LogBehaviour _logBehaviour; // 0x24
	public static Func<LogType, object, bool> onWillLog; // 0x28
	public static bool drawGizmos; // 0x30
	public static bool debugMode; // 0x31
	private static bool _fooDebugStoreTargetId; // 0x32
	public static UpdateType defaultUpdateType; // 0x34
	public static bool defaultTimeScaleIndependent; // 0x38
	public static AutoPlay defaultAutoPlay; // 0x3C
	public static bool defaultAutoKill; // 0x40
	public static LoopType defaultLoopType; // 0x44
	public static bool defaultRecyclable; // 0x48
	public static Ease defaultEaseType; // 0x4C
	public static float defaultEaseOvershootOrAmplitude; // 0x50
	public static float defaultEasePeriod; // 0x54
	public static DOTweenComponent instance; // 0x58
	internal static int maxActiveTweenersReached; // 0x60
	internal static int maxActiveSequencesReached; // 0x64
	internal static SafeModeReport safeModeReport; // 0x68
	internal static readonly List<TweenCallback> GizmosDelegates; // 0x78
	internal static bool initialized; // 0x80
	internal static bool isQuitting; // 0x81

	// Properties
	public static LogBehaviour logBehaviour { get; set; }
	public static bool debugStoreTargetId { get; set; }

	// Methods

	// RVA: 0x1993070 Offset: 0x1993171 VA: 0x1993070
	public static LogBehaviour get_logBehaviour() { }

	// RVA: 0x19930E0 Offset: 0x19931E1 VA: 0x19930E0
	public static void set_logBehaviour(LogBehaviour value) { }

	// RVA: 0x19931D0 Offset: 0x19932D1 VA: 0x19931D0
	public static bool get_debugStoreTargetId() { }

	// RVA: 0x19932C0 Offset: 0x19933C1 VA: 0x19932C0
	public static void set_debugStoreTargetId(bool value) { }

	// RVA: 0x1993330 Offset: 0x1993431 VA: 0x1993330
	public static IDOTweenInit Init(Nullable<bool> recycleAllByDefault, Nullable<bool> useSafeMode, Nullable<LogBehaviour> logBehaviour) { }

	// RVA: 0x1993DE0 Offset: 0x1993EE1 VA: 0x1993DE0
	private static void AutoInit() { }

	// RVA: 0x19934C0 Offset: 0x19935C1 VA: 0x19934C0
	private static IDOTweenInit Init(DOTweenSettings settings, Nullable<bool> recycleAllByDefault, Nullable<bool> useSafeMode, Nullable<LogBehaviour> logBehaviour) { }

	// RVA: 0x1993EB0 Offset: 0x1993FB1 VA: 0x1993EB0
	public static void SetTweensCapacity(int tweenersCapacity, int sequencesCapacity) { }

	// RVA: 0x19873F0 Offset: 0x19874F1 VA: 0x19873F0
	public static void Clear(bool destroy = False) { }

	// RVA: 0x19940D0 Offset: 0x19941D1 VA: 0x19940D0
	public static void ClearCachedTweens() { }

	// RVA: 0x1994140 Offset: 0x1994241 VA: 0x1994140
	public static int Validate() { }

	// RVA: 0x19941B0 Offset: 0x19942B1 VA: 0x19941B0
	public static void ManualUpdate(float deltaTime, float unscaledDeltaTime) { }

	// RVA: 0x19943B0 Offset: 0x19944B1 VA: 0x19943B0
	public static TweenerCore<float, float, FloatOptions> To(DOGetter<float> getter, DOSetter<float> setter, float endValue, float duration) { }

	// RVA: 0x1994450 Offset: 0x1994551 VA: 0x1994450
	public static TweenerCore<double, double, NoOptions> To(DOGetter<double> getter, DOSetter<double> setter, double endValue, float duration) { }

	// RVA: 0x19944F0 Offset: 0x19945F1 VA: 0x19944F0
	public static TweenerCore<int, int, NoOptions> To(DOGetter<int> getter, DOSetter<int> setter, int endValue, float duration) { }

	// RVA: 0x1994590 Offset: 0x1994691 VA: 0x1994590
	public static TweenerCore<uint, uint, UintOptions> To(DOGetter<uint> getter, DOSetter<uint> setter, uint endValue, float duration) { }

	// RVA: 0x1994630 Offset: 0x1994731 VA: 0x1994630
	public static TweenerCore<long, long, NoOptions> To(DOGetter<long> getter, DOSetter<long> setter, long endValue, float duration) { }

	// RVA: 0x19946D0 Offset: 0x19947D1 VA: 0x19946D0
	public static TweenerCore<ulong, ulong, NoOptions> To(DOGetter<ulong> getter, DOSetter<ulong> setter, ulong endValue, float duration) { }

	// RVA: 0x1994770 Offset: 0x1994871 VA: 0x1994770
	public static TweenerCore<string, string, StringOptions> To(DOGetter<string> getter, DOSetter<string> setter, string endValue, float duration) { }

	// RVA: 0x1994810 Offset: 0x1994911 VA: 0x1994810
	public static TweenerCore<Vector2, Vector2, VectorOptions> To(DOGetter<Vector2> getter, DOSetter<Vector2> setter, Vector2 endValue, float duration) { }

	// RVA: 0x19948C0 Offset: 0x19949C1 VA: 0x19948C0
	public static TweenerCore<Vector3, Vector3, VectorOptions> To(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3 endValue, float duration) { }

	// RVA: 0x1994980 Offset: 0x1994A81 VA: 0x1994980
	public static TweenerCore<Vector4, Vector4, VectorOptions> To(DOGetter<Vector4> getter, DOSetter<Vector4> setter, Vector4 endValue, float duration) { }

	// RVA: 0x1994A50 Offset: 0x1994B51 VA: 0x1994A50
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> To(DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, Vector3 endValue, float duration) { }

	// RVA: 0x1994B10 Offset: 0x1994C11 VA: 0x1994B10
	public static TweenerCore<Color, Color, ColorOptions> To(DOGetter<Color> getter, DOSetter<Color> setter, Color endValue, float duration) { }

	// RVA: 0x1994BE0 Offset: 0x1994CE1 VA: 0x1994BE0
	public static TweenerCore<Rect, Rect, RectOptions> To(DOGetter<Rect> getter, DOSetter<Rect> setter, Rect endValue, float duration) { }

	// RVA: 0x1994CB0 Offset: 0x1994DB1 VA: 0x1994CB0
	public static Tweener To(DOGetter<RectOffset> getter, DOSetter<RectOffset> setter, RectOffset endValue, float duration) { }

	// RVA: -1 Offset: -1
	public static TweenerCore<T1, T2, TPlugOptions> To<T1, T2, TPlugOptions>(ABSTweenPlugin<T1, T2, TPlugOptions> plugin, DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AB3650 Offset: 0x1AB3751 VA: 0x1AB3650
	|-DOTween.To<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x1AB3730 Offset: 0x1AB3831 VA: 0x1AB3730
	|-DOTween.To<Vector3, Path, PathOptions>
	|-DOTween.To<Vector3, object, PathOptions>
	*/

	// RVA: 0x1994D50 Offset: 0x1994E51 VA: 0x1994D50
	public static TweenerCore<Vector3, Vector3, VectorOptions> ToAxis(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float endValue, float duration, AxisConstraint axisConstraint = 2) { }

	// RVA: 0x1994E30 Offset: 0x1994F31 VA: 0x1994E30
	public static TweenerCore<Color, Color, ColorOptions> ToAlpha(DOGetter<Color> getter, DOSetter<Color> setter, float endValue, float duration) { }

	// RVA: 0x1994F10 Offset: 0x1995011 VA: 0x1994F10
	public static Tweener To(DOSetter<float> setter, float startValue, float endValue, float duration) { }

	// RVA: 0x19950C0 Offset: 0x19951C1 VA: 0x19950C0
	public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Punch(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3 direction, float duration, int vibrato = 10, float elasticity = 1) { }

	// RVA: 0x1995650 Offset: 0x1995751 VA: 0x1995650
	public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, float strength = 3, int vibrato = 10, float randomness = 90, bool ignoreZAxis = True, bool fadeOut = True) { }

	// RVA: 0x1995ED0 Offset: 0x1995FD1 VA: 0x1995ED0
	public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, Vector3 strength, int vibrato = 10, float randomness = 90, bool fadeOut = True) { }

	// RVA: 0x1995740 Offset: 0x1995841 VA: 0x1995740
	private static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, Vector3 strength, int vibrato, float randomness, bool ignoreZAxis, bool vectorBased, bool fadeOut) { }

	// RVA: 0x1995410 Offset: 0x1995511 VA: 0x1995410
	public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> ToArray(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3[] endValues, float[] durations) { }

	// RVA: 0x1995FB0 Offset: 0x19960B1 VA: 0x1995FB0
	internal static TweenerCore<Color2, Color2, ColorOptions> To(DOGetter<Color2> getter, DOSetter<Color2> setter, Color2 endValue, float duration) { }

	// RVA: 0x1996080 Offset: 0x1996181 VA: 0x1996080
	public static Sequence Sequence() { }

	// RVA: 0x1996120 Offset: 0x1996221 VA: 0x1996120
	public static int CompleteAll(bool withCallbacks = False) { }

	// RVA: 0x19961C0 Offset: 0x19962C1 VA: 0x19961C0
	public static int Complete(object targetOrId, bool withCallbacks = False) { }

	// RVA: 0x1996280 Offset: 0x1996381 VA: 0x1996280
	internal static int CompleteAndReturnKilledTot() { }

	// RVA: 0x1996300 Offset: 0x1996401 VA: 0x1996300
	internal static int CompleteAndReturnKilledTot(object targetOrId) { }

	// RVA: 0x1996390 Offset: 0x1996491 VA: 0x1996390
	internal static int CompleteAndReturnKilledTotExceptFor(object[] excludeTargetsOrIds) { }

	// RVA: 0x1996410 Offset: 0x1996511 VA: 0x1996410
	public static int FlipAll() { }

	// RVA: 0x1996490 Offset: 0x1996591 VA: 0x1996490
	public static int Flip(object targetOrId) { }

	// RVA: 0x1996520 Offset: 0x1996621 VA: 0x1996520
	public static int GotoAll(float to, bool andPlay = False) { }

	// RVA: 0x19965B0 Offset: 0x19966B1 VA: 0x19965B0
	public static int Goto(object targetOrId, float to, bool andPlay = False) { }

	// RVA: 0x1996660 Offset: 0x1996761 VA: 0x1996660
	public static int KillAll(bool complete = False) { }

	// RVA: 0x1996770 Offset: 0x1996871 VA: 0x1996770
	public static int KillAll(bool complete, object[] idsOrTargetsToExclude) { }

	// RVA: 0x1996970 Offset: 0x1996A71 VA: 0x1996970
	public static int Kill(object targetOrId, bool complete = False) { }

	// RVA: 0x1996AC0 Offset: 0x1996BC1 VA: 0x1996AC0
	public static int PauseAll() { }

	// RVA: 0x1996B40 Offset: 0x1996C41 VA: 0x1996B40
	public static int Pause(object targetOrId) { }

	// RVA: 0x1996BD0 Offset: 0x1996CD1 VA: 0x1996BD0
	public static int PlayAll() { }

	// RVA: 0x1996C50 Offset: 0x1996D51 VA: 0x1996C50
	public static int Play(object targetOrId) { }

	// RVA: 0x1996CE0 Offset: 0x1996DE1 VA: 0x1996CE0
	public static int Play(object target, object id) { }

	// RVA: 0x1996D90 Offset: 0x1996E91 VA: 0x1996D90
	public static int PlayBackwardsAll() { }

	// RVA: 0x1996E10 Offset: 0x1996F11 VA: 0x1996E10
	public static int PlayBackwards(object targetOrId) { }

	// RVA: 0x1996EA0 Offset: 0x1996FA1 VA: 0x1996EA0
	public static int PlayBackwards(object target, object id) { }

	// RVA: 0x1996F50 Offset: 0x1997051 VA: 0x1996F50
	public static int PlayForwardAll() { }

	// RVA: 0x1996FD0 Offset: 0x19970D1 VA: 0x1996FD0
	public static int PlayForward(object targetOrId) { }

	// RVA: 0x1997060 Offset: 0x1997161 VA: 0x1997060
	public static int PlayForward(object target, object id) { }

	// RVA: 0x1997110 Offset: 0x1997211 VA: 0x1997110
	public static int RestartAll(bool includeDelay = True) { }

	// RVA: 0x1997190 Offset: 0x1997291 VA: 0x1997190
	public static int Restart(object targetOrId, bool includeDelay = True, float changeDelayTo = -1) { }

	// RVA: 0x1997240 Offset: 0x1997341 VA: 0x1997240
	public static int Restart(object target, object id, bool includeDelay = True, float changeDelayTo = -1) { }

	// RVA: 0x1997300 Offset: 0x1997401 VA: 0x1997300
	public static int RewindAll(bool includeDelay = True) { }

	// RVA: 0x1997380 Offset: 0x1997481 VA: 0x1997380
	public static int Rewind(object targetOrId, bool includeDelay = True) { }

	// RVA: 0x1997420 Offset: 0x1997521 VA: 0x1997420
	public static int SmoothRewindAll() { }

	// RVA: 0x19974A0 Offset: 0x19975A1 VA: 0x19974A0
	public static int SmoothRewind(object targetOrId) { }

	// RVA: 0x1997530 Offset: 0x1997631 VA: 0x1997530
	public static int TogglePauseAll() { }

	// RVA: 0x19975B0 Offset: 0x19976B1 VA: 0x19975B0
	public static int TogglePause(object targetOrId) { }

	// RVA: 0x1997640 Offset: 0x1997741 VA: 0x1997640
	public static bool IsTweening(object targetOrId, bool alsoCheckIfIsPlaying = False) { }

	// RVA: 0x19976E0 Offset: 0x19977E1 VA: 0x19976E0
	public static int TotalPlayingTweens() { }

	// RVA: 0x1997750 Offset: 0x1997851 VA: 0x1997750
	public static List<Tween> PlayingTweens(List<Tween> fillableList) { }

	// RVA: 0x19977D0 Offset: 0x19978D1 VA: 0x19977D0
	public static List<Tween> PausedTweens(List<Tween> fillableList) { }

	// RVA: 0x1997850 Offset: 0x1997951 VA: 0x1997850
	public static List<Tween> TweensById(object id, bool playingOnly = False, List<Tween> fillableList) { }

	// RVA: 0x1997900 Offset: 0x1997A01 VA: 0x1997900
	public static List<Tween> TweensByTarget(object target, bool playingOnly = False, List<Tween> fillableList) { }

	// RVA: 0x19942E0 Offset: 0x19943E1 VA: 0x19942E0
	private static void InitCheck() { }

	// RVA: -1 Offset: -1
	private static TweenerCore<T1, T2, TPlugOptions> ApplyTo<T1, T2, TPlugOptions>(DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration, ABSTweenPlugin<T1, T2, TPlugOptions> plugin) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AB2040 Offset: 0x1AB2141 VA: 0x1AB2040
	|-DOTween.ApplyTo<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x1AB21A0 Offset: 0x1AB22A1 VA: 0x1AB21A0
	|-DOTween.ApplyTo<double, double, NoOptions>
	|
	|-RVA: 0x1AB22C0 Offset: 0x1AB23C1 VA: 0x1AB22C0
	|-DOTween.ApplyTo<int, int, NoOptions>
	|
	|-RVA: 0x1AB23F0 Offset: 0x1AB24F1 VA: 0x1AB23F0
	|-DOTween.ApplyTo<long, long, NoOptions>
	|
	|-RVA: 0x1AB2520 Offset: 0x1AB2621 VA: 0x1AB2520
	|-DOTween.ApplyTo<object, object, NoOptions>
	|-DOTween.ApplyTo<RectOffset, RectOffset, NoOptions>
	|
	|-RVA: 0x1AB2650 Offset: 0x1AB2751 VA: 0x1AB2650
	|-DOTween.ApplyTo<object, object, StringOptions>
	|-DOTween.ApplyTo<string, string, StringOptions>
	|
	|-RVA: 0x1AB2780 Offset: 0x1AB2881 VA: 0x1AB2780
	|-DOTween.ApplyTo<float, float, FloatOptions>
	|
	|-RVA: 0x1AB28A0 Offset: 0x1AB29A1 VA: 0x1AB28A0
	|-DOTween.ApplyTo<uint, uint, UintOptions>
	|
	|-RVA: 0x1AB29D0 Offset: 0x1AB2AD1 VA: 0x1AB29D0
	|-DOTween.ApplyTo<ulong, ulong, NoOptions>
	|
	|-RVA: 0x1AB2B00 Offset: 0x1AB2C01 VA: 0x1AB2B00
	|-DOTween.ApplyTo<Color, Color, ColorOptions>
	|
	|-RVA: 0x1AB2C50 Offset: 0x1AB2D51 VA: 0x1AB2C50
	|-DOTween.ApplyTo<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x1AB2DA0 Offset: 0x1AB2EA1 VA: 0x1AB2DA0
	|-DOTween.ApplyTo<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x1AB2EE0 Offset: 0x1AB2FE1 VA: 0x1AB2EE0
	|-DOTween.ApplyTo<Rect, Rect, RectOptions>
	|
	|-RVA: 0x1AB3030 Offset: 0x1AB3131 VA: 0x1AB3030
	|-DOTween.ApplyTo<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x1AB3160 Offset: 0x1AB3261 VA: 0x1AB3160
	|-DOTween.ApplyTo<Vector3, object, PathOptions>
	|
	|-RVA: 0x1AB3290 Offset: 0x1AB3391 VA: 0x1AB3290
	|-DOTween.ApplyTo<Vector3, object, Vector3ArrayOptions>
	|-DOTween.ApplyTo<Vector3, Vector3[], Vector3ArrayOptions>
	|
	|-RVA: 0x1AB33C0 Offset: 0x1AB34C1 VA: 0x1AB33C0
	|-DOTween.ApplyTo<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x1AB3500 Offset: 0x1AB3601 VA: 0x1AB3500
	|-DOTween.ApplyTo<Vector4, Vector4, VectorOptions>
	*/

	// RVA: 0x19979A0 Offset: 0x1997AA1 VA: 0x19979A0
	public void .ctor() { }

	// RVA: 0x19979B0 Offset: 0x1997AB1 VA: 0x19979B0
	private static void .cctor() { }
}

public class DOTween // TypeDefIndex: 4918
{
	// Fields
	public static readonly string Version; // 0x0
	public static bool useSafeMode; // 0x8
	public static NestedTweenFailureBehaviour nestedTweenFailureBehaviour; // 0xC
	public static bool showUnityEditorReport; // 0x10
	public static float timeScale; // 0x14
	public static bool useSmoothDeltaTime; // 0x18
	public static float maxSmoothUnscaledTime; // 0x1C
	internal static RewindCallbackMode rewindCallbackMode; // 0x20
	private static LogBehaviour _logBehaviour; // 0x24
	public static Func<LogType, object, bool> onWillLog; // 0x28
	public static bool drawGizmos; // 0x30
	public static bool debugMode; // 0x31
	private static bool _fooDebugStoreTargetId; // 0x32
	public static UpdateType defaultUpdateType; // 0x34
	public static bool defaultTimeScaleIndependent; // 0x38
	public static AutoPlay defaultAutoPlay; // 0x3C
	public static bool defaultAutoKill; // 0x40
	public static LoopType defaultLoopType; // 0x44
	public static bool defaultRecyclable; // 0x48
	public static Ease defaultEaseType; // 0x4C
	public static float defaultEaseOvershootOrAmplitude; // 0x50
	public static float defaultEasePeriod; // 0x54
	public static DOTweenComponent instance; // 0x58
	internal static int maxActiveTweenersReached; // 0x60
	internal static int maxActiveSequencesReached; // 0x64
	internal static SafeModeReport safeModeReport; // 0x68
	internal static readonly List<TweenCallback> GizmosDelegates; // 0x78
	internal static bool initialized; // 0x80
	internal static bool isQuitting; // 0x81

	// Properties
	public static LogBehaviour logBehaviour { get; set; }
	public static bool debugStoreTargetId { get; set; }

	// Methods

	// RVA: 0x1993070 Offset: 0x1993171 VA: 0x1993070
	public static LogBehaviour get_logBehaviour() { }

	// RVA: 0x19930E0 Offset: 0x19931E1 VA: 0x19930E0
	public static void set_logBehaviour(LogBehaviour value) { }

	// RVA: 0x19931D0 Offset: 0x19932D1 VA: 0x19931D0
	public static bool get_debugStoreTargetId() { }

	// RVA: 0x19932C0 Offset: 0x19933C1 VA: 0x19932C0
	public static void set_debugStoreTargetId(bool value) { }

	// RVA: 0x1993330 Offset: 0x1993431 VA: 0x1993330
	public static IDOTweenInit Init(Nullable<bool> recycleAllByDefault, Nullable<bool> useSafeMode, Nullable<LogBehaviour> logBehaviour) { }

	// RVA: 0x1993DE0 Offset: 0x1993EE1 VA: 0x1993DE0
	private static void AutoInit() { }

	// RVA: 0x19934C0 Offset: 0x19935C1 VA: 0x19934C0
	private static IDOTweenInit Init(DOTweenSettings settings, Nullable<bool> recycleAllByDefault, Nullable<bool> useSafeMode, Nullable<LogBehaviour> logBehaviour) { }

	// RVA: 0x1993EB0 Offset: 0x1993FB1 VA: 0x1993EB0
	public static void SetTweensCapacity(int tweenersCapacity, int sequencesCapacity) { }

	// RVA: 0x19873F0 Offset: 0x19874F1 VA: 0x19873F0
	public static void Clear(bool destroy = False) { }

	// RVA: 0x19940D0 Offset: 0x19941D1 VA: 0x19940D0
	public static void ClearCachedTweens() { }

	// RVA: 0x1994140 Offset: 0x1994241 VA: 0x1994140
	public static int Validate() { }

	// RVA: 0x19941B0 Offset: 0x19942B1 VA: 0x19941B0
	public static void ManualUpdate(float deltaTime, float unscaledDeltaTime) { }

	// RVA: 0x19943B0 Offset: 0x19944B1 VA: 0x19943B0
	public static TweenerCore<float, float, FloatOptions> To(DOGetter<float> getter, DOSetter<float> setter, float endValue, float duration) { }

	// RVA: 0x1994450 Offset: 0x1994551 VA: 0x1994450
	public static TweenerCore<double, double, NoOptions> To(DOGetter<double> getter, DOSetter<double> setter, double endValue, float duration) { }

	// RVA: 0x19944F0 Offset: 0x19945F1 VA: 0x19944F0
	public static TweenerCore<int, int, NoOptions> To(DOGetter<int> getter, DOSetter<int> setter, int endValue, float duration) { }

	// RVA: 0x1994590 Offset: 0x1994691 VA: 0x1994590
	public static TweenerCore<uint, uint, UintOptions> To(DOGetter<uint> getter, DOSetter<uint> setter, uint endValue, float duration) { }

	// RVA: 0x1994630 Offset: 0x1994731 VA: 0x1994630
	public static TweenerCore<long, long, NoOptions> To(DOGetter<long> getter, DOSetter<long> setter, long endValue, float duration) { }

	// RVA: 0x19946D0 Offset: 0x19947D1 VA: 0x19946D0
	public static TweenerCore<ulong, ulong, NoOptions> To(DOGetter<ulong> getter, DOSetter<ulong> setter, ulong endValue, float duration) { }

	// RVA: 0x1994770 Offset: 0x1994871 VA: 0x1994770
	public static TweenerCore<string, string, StringOptions> To(DOGetter<string> getter, DOSetter<string> setter, string endValue, float duration) { }

	// RVA: 0x1994810 Offset: 0x1994911 VA: 0x1994810
	public static TweenerCore<Vector2, Vector2, VectorOptions> To(DOGetter<Vector2> getter, DOSetter<Vector2> setter, Vector2 endValue, float duration) { }

	// RVA: 0x19948C0 Offset: 0x19949C1 VA: 0x19948C0
	public static TweenerCore<Vector3, Vector3, VectorOptions> To(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3 endValue, float duration) { }

	// RVA: 0x1994980 Offset: 0x1994A81 VA: 0x1994980
	public static TweenerCore<Vector4, Vector4, VectorOptions> To(DOGetter<Vector4> getter, DOSetter<Vector4> setter, Vector4 endValue, float duration) { }

	// RVA: 0x1994A50 Offset: 0x1994B51 VA: 0x1994A50
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> To(DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, Vector3 endValue, float duration) { }

	// RVA: 0x1994B10 Offset: 0x1994C11 VA: 0x1994B10
	public static TweenerCore<Color, Color, ColorOptions> To(DOGetter<Color> getter, DOSetter<Color> setter, Color endValue, float duration) { }

	// RVA: 0x1994BE0 Offset: 0x1994CE1 VA: 0x1994BE0
	public static TweenerCore<Rect, Rect, RectOptions> To(DOGetter<Rect> getter, DOSetter<Rect> setter, Rect endValue, float duration) { }

	// RVA: 0x1994CB0 Offset: 0x1994DB1 VA: 0x1994CB0
	public static Tweener To(DOGetter<RectOffset> getter, DOSetter<RectOffset> setter, RectOffset endValue, float duration) { }

	// RVA: -1 Offset: -1
	public static TweenerCore<T1, T2, TPlugOptions> To<T1, T2, TPlugOptions>(ABSTweenPlugin<T1, T2, TPlugOptions> plugin, DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AB3650 Offset: 0x1AB3751 VA: 0x1AB3650
	|-DOTween.To<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x1AB3730 Offset: 0x1AB3831 VA: 0x1AB3730
	|-DOTween.To<Vector3, Path, PathOptions>
	|-DOTween.To<Vector3, object, PathOptions>
	*/

	// RVA: 0x1994D50 Offset: 0x1994E51 VA: 0x1994D50
	public static TweenerCore<Vector3, Vector3, VectorOptions> ToAxis(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float endValue, float duration, AxisConstraint axisConstraint = 2) { }

	// RVA: 0x1994E30 Offset: 0x1994F31 VA: 0x1994E30
	public static TweenerCore<Color, Color, ColorOptions> ToAlpha(DOGetter<Color> getter, DOSetter<Color> setter, float endValue, float duration) { }

	// RVA: 0x1994F10 Offset: 0x1995011 VA: 0x1994F10
	public static Tweener To(DOSetter<float> setter, float startValue, float endValue, float duration) { }

	// RVA: 0x19950C0 Offset: 0x19951C1 VA: 0x19950C0
	public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Punch(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3 direction, float duration, int vibrato = 10, float elasticity = 1) { }

	// RVA: 0x1995650 Offset: 0x1995751 VA: 0x1995650
	public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, float strength = 3, int vibrato = 10, float randomness = 90, bool ignoreZAxis = True, bool fadeOut = True) { }

	// RVA: 0x1995ED0 Offset: 0x1995FD1 VA: 0x1995ED0
	public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, Vector3 strength, int vibrato = 10, float randomness = 90, bool fadeOut = True) { }

	// RVA: 0x1995740 Offset: 0x1995841 VA: 0x1995740
	private static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, Vector3 strength, int vibrato, float randomness, bool ignoreZAxis, bool vectorBased, bool fadeOut) { }

	// RVA: 0x1995410 Offset: 0x1995511 VA: 0x1995410
	public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> ToArray(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3[] endValues, float[] durations) { }

	// RVA: 0x1995FB0 Offset: 0x19960B1 VA: 0x1995FB0
	internal static TweenerCore<Color2, Color2, ColorOptions> To(DOGetter<Color2> getter, DOSetter<Color2> setter, Color2 endValue, float duration) { }

	// RVA: 0x1996080 Offset: 0x1996181 VA: 0x1996080
	public static Sequence Sequence() { }

	// RVA: 0x1996120 Offset: 0x1996221 VA: 0x1996120
	public static int CompleteAll(bool withCallbacks = False) { }

	// RVA: 0x19961C0 Offset: 0x19962C1 VA: 0x19961C0
	public static int Complete(object targetOrId, bool withCallbacks = False) { }

	// RVA: 0x1996280 Offset: 0x1996381 VA: 0x1996280
	internal static int CompleteAndReturnKilledTot() { }

	// RVA: 0x1996300 Offset: 0x1996401 VA: 0x1996300
	internal static int CompleteAndReturnKilledTot(object targetOrId) { }

	// RVA: 0x1996390 Offset: 0x1996491 VA: 0x1996390
	internal static int CompleteAndReturnKilledTotExceptFor(object[] excludeTargetsOrIds) { }

	// RVA: 0x1996410 Offset: 0x1996511 VA: 0x1996410
	public static int FlipAll() { }

	// RVA: 0x1996490 Offset: 0x1996591 VA: 0x1996490
	public static int Flip(object targetOrId) { }

	// RVA: 0x1996520 Offset: 0x1996621 VA: 0x1996520
	public static int GotoAll(float to, bool andPlay = False) { }

	// RVA: 0x19965B0 Offset: 0x19966B1 VA: 0x19965B0
	public static int Goto(object targetOrId, float to, bool andPlay = False) { }

	// RVA: 0x1996660 Offset: 0x1996761 VA: 0x1996660
	public static int KillAll(bool complete = False) { }

	// RVA: 0x1996770 Offset: 0x1996871 VA: 0x1996770
	public static int KillAll(bool complete, object[] idsOrTargetsToExclude) { }

	// RVA: 0x1996970 Offset: 0x1996A71 VA: 0x1996970
	public static int Kill(object targetOrId, bool complete = False) { }

	// RVA: 0x1996AC0 Offset: 0x1996BC1 VA: 0x1996AC0
	public static int PauseAll() { }

	// RVA: 0x1996B40 Offset: 0x1996C41 VA: 0x1996B40
	public static int Pause(object targetOrId) { }

	// RVA: 0x1996BD0 Offset: 0x1996CD1 VA: 0x1996BD0
	public static int PlayAll() { }

	// RVA: 0x1996C50 Offset: 0x1996D51 VA: 0x1996C50
	public static int Play(object targetOrId) { }

	// RVA: 0x1996CE0 Offset: 0x1996DE1 VA: 0x1996CE0
	public static int Play(object target, object id) { }

	// RVA: 0x1996D90 Offset: 0x1996E91 VA: 0x1996D90
	public static int PlayBackwardsAll() { }

	// RVA: 0x1996E10 Offset: 0x1996F11 VA: 0x1996E10
	public static int PlayBackwards(object targetOrId) { }

	// RVA: 0x1996EA0 Offset: 0x1996FA1 VA: 0x1996EA0
	public static int PlayBackwards(object target, object id) { }

	// RVA: 0x1996F50 Offset: 0x1997051 VA: 0x1996F50
	public static int PlayForwardAll() { }

	// RVA: 0x1996FD0 Offset: 0x19970D1 VA: 0x1996FD0
	public static int PlayForward(object targetOrId) { }

	// RVA: 0x1997060 Offset: 0x1997161 VA: 0x1997060
	public static int PlayForward(object target, object id) { }

	// RVA: 0x1997110 Offset: 0x1997211 VA: 0x1997110
	public static int RestartAll(bool includeDelay = True) { }

	// RVA: 0x1997190 Offset: 0x1997291 VA: 0x1997190
	public static int Restart(object targetOrId, bool includeDelay = True, float changeDelayTo = -1) { }

	// RVA: 0x1997240 Offset: 0x1997341 VA: 0x1997240
	public static int Restart(object target, object id, bool includeDelay = True, float changeDelayTo = -1) { }

	// RVA: 0x1997300 Offset: 0x1997401 VA: 0x1997300
	public static int RewindAll(bool includeDelay = True) { }

	// RVA: 0x1997380 Offset: 0x1997481 VA: 0x1997380
	public static int Rewind(object targetOrId, bool includeDelay = True) { }

	// RVA: 0x1997420 Offset: 0x1997521 VA: 0x1997420
	public static int SmoothRewindAll() { }

	// RVA: 0x19974A0 Offset: 0x19975A1 VA: 0x19974A0
	public static int SmoothRewind(object targetOrId) { }

	// RVA: 0x1997530 Offset: 0x1997631 VA: 0x1997530
	public static int TogglePauseAll() { }

	// RVA: 0x19975B0 Offset: 0x19976B1 VA: 0x19975B0
	public static int TogglePause(object targetOrId) { }

	// RVA: 0x1997640 Offset: 0x1997741 VA: 0x1997640
	public static bool IsTweening(object targetOrId, bool alsoCheckIfIsPlaying = False) { }

	// RVA: 0x19976E0 Offset: 0x19977E1 VA: 0x19976E0
	public static int TotalPlayingTweens() { }

	// RVA: 0x1997750 Offset: 0x1997851 VA: 0x1997750
	public static List<Tween> PlayingTweens(List<Tween> fillableList) { }

	// RVA: 0x19977D0 Offset: 0x19978D1 VA: 0x19977D0
	public static List<Tween> PausedTweens(List<Tween> fillableList) { }

	// RVA: 0x1997850 Offset: 0x1997951 VA: 0x1997850
	public static List<Tween> TweensById(object id, bool playingOnly = False, List<Tween> fillableList) { }

	// RVA: 0x1997900 Offset: 0x1997A01 VA: 0x1997900
	public static List<Tween> TweensByTarget(object target, bool playingOnly = False, List<Tween> fillableList) { }

	// RVA: 0x19942E0 Offset: 0x19943E1 VA: 0x19942E0
	private static void InitCheck() { }

	// RVA: -1 Offset: -1
	private static TweenerCore<T1, T2, TPlugOptions> ApplyTo<T1, T2, TPlugOptions>(DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration, ABSTweenPlugin<T1, T2, TPlugOptions> plugin) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AB2040 Offset: 0x1AB2141 VA: 0x1AB2040
	|-DOTween.ApplyTo<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x1AB21A0 Offset: 0x1AB22A1 VA: 0x1AB21A0
	|-DOTween.ApplyTo<double, double, NoOptions>
	|
	|-RVA: 0x1AB22C0 Offset: 0x1AB23C1 VA: 0x1AB22C0
	|-DOTween.ApplyTo<int, int, NoOptions>
	|
	|-RVA: 0x1AB23F0 Offset: 0x1AB24F1 VA: 0x1AB23F0
	|-DOTween.ApplyTo<long, long, NoOptions>
	|
	|-RVA: 0x1AB2520 Offset: 0x1AB2621 VA: 0x1AB2520
	|-DOTween.ApplyTo<object, object, NoOptions>
	|-DOTween.ApplyTo<RectOffset, RectOffset, NoOptions>
	|
	|-RVA: 0x1AB2650 Offset: 0x1AB2751 VA: 0x1AB2650
	|-DOTween.ApplyTo<object, object, StringOptions>
	|-DOTween.ApplyTo<string, string, StringOptions>
	|
	|-RVA: 0x1AB2780 Offset: 0x1AB2881 VA: 0x1AB2780
	|-DOTween.ApplyTo<float, float, FloatOptions>
	|
	|-RVA: 0x1AB28A0 Offset: 0x1AB29A1 VA: 0x1AB28A0
	|-DOTween.ApplyTo<uint, uint, UintOptions>
	|
	|-RVA: 0x1AB29D0 Offset: 0x1AB2AD1 VA: 0x1AB29D0
	|-DOTween.ApplyTo<ulong, ulong, NoOptions>
	|
	|-RVA: 0x1AB2B00 Offset: 0x1AB2C01 VA: 0x1AB2B00
	|-DOTween.ApplyTo<Color, Color, ColorOptions>
	|
	|-RVA: 0x1AB2C50 Offset: 0x1AB2D51 VA: 0x1AB2C50
	|-DOTween.ApplyTo<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x1AB2DA0 Offset: 0x1AB2EA1 VA: 0x1AB2DA0
	|-DOTween.ApplyTo<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x1AB2EE0 Offset: 0x1AB2FE1 VA: 0x1AB2EE0
	|-DOTween.ApplyTo<Rect, Rect, RectOptions>
	|
	|-RVA: 0x1AB3030 Offset: 0x1AB3131 VA: 0x1AB3030
	|-DOTween.ApplyTo<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x1AB3160 Offset: 0x1AB3261 VA: 0x1AB3160
	|-DOTween.ApplyTo<Vector3, object, PathOptions>
	|
	|-RVA: 0x1AB3290 Offset: 0x1AB3391 VA: 0x1AB3290
	|-DOTween.ApplyTo<Vector3, object, Vector3ArrayOptions>
	|-DOTween.ApplyTo<Vector3, Vector3[], Vector3ArrayOptions>
	|
	|-RVA: 0x1AB33C0 Offset: 0x1AB34C1 VA: 0x1AB33C0
	|-DOTween.ApplyTo<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x1AB3500 Offset: 0x1AB3601 VA: 0x1AB3500
	|-DOTween.ApplyTo<Vector4, Vector4, VectorOptions>
	*/

	// RVA: 0x19979A0 Offset: 0x1997AA1 VA: 0x19979A0
	public void .ctor() { }

	// RVA: 0x19979B0 Offset: 0x1997AB1 VA: 0x19979B0
	private static void .cctor() { }
}

