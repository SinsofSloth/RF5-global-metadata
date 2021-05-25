internal static class TweenManager // TypeDefIndex: 5082
{
	// Fields
	private const int _DefaultMaxTweeners = 200;
	private const int _DefaultMaxSequences = 50;
	private const string _MaxTweensReached = "Max Tweens reached: capacity has automatically been increased from #0 to #1. Use DOTween.SetTweensCapacity to set it manually at startup";
	private const float _EpsilonVsTimeCheck = 1E-06;
	internal static bool isUnityEditor; // 0x0
	internal static bool isDebugBuild; // 0x1
	internal static int maxActive; // 0x4
	internal static int maxTweeners; // 0x8
	internal static int maxSequences; // 0xC
	internal static bool hasActiveTweens; // 0x10
	internal static bool hasActiveDefaultTweens; // 0x11
	internal static bool hasActiveLateTweens; // 0x12
	internal static bool hasActiveFixedTweens; // 0x13
	internal static bool hasActiveManualTweens; // 0x14
	internal static int totActiveTweens; // 0x18
	internal static int totActiveDefaultTweens; // 0x1C
	internal static int totActiveLateTweens; // 0x20
	internal static int totActiveFixedTweens; // 0x24
	internal static int totActiveManualTweens; // 0x28
	internal static int totActiveTweeners; // 0x2C
	internal static int totActiveSequences; // 0x30
	internal static int totPooledTweeners; // 0x34
	internal static int totPooledSequences; // 0x38
	internal static int totTweeners; // 0x3C
	internal static int totSequences; // 0x40
	internal static bool isUpdateLoop; // 0x44
	internal static Tween[] _activeTweens; // 0x48
	private static Tween[] _pooledTweeners; // 0x50
	private static readonly Stack<Tween> _PooledSequences; // 0x58
	private static readonly List<Tween> _KillList; // 0x60
	private static readonly Dictionary<Tween, TweenLink> _TweenLinks; // 0x68
	private static int _totTweenLinks; // 0x70
	private static int _maxActiveLookupId; // 0x74
	private static bool _requiresActiveReorganization; // 0x78
	private static int _reorganizeFromId; // 0x7C
	private static int _minPooledTweenerId; // 0x80
	private static int _maxPooledTweenerId; // 0x84
	private static bool _despawnAllCalledFromUpdateLoopCallback; // 0x88

	// Methods

	// RVA: 0x198D3E0 Offset: 0x198D4E1 VA: 0x198D3E0
	private static void .cctor() { }

	// RVA: -1 Offset: -1
	internal static TweenerCore<T1, T2, TPlugOptions> GetTweener<T1, T2, TPlugOptions>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AAAEA0 Offset: 0x1AAAFA1 VA: 0x1AAAEA0
	|-TweenManager.GetTweener<Color2, Color2, ColorOptions>
	|
	|-RVA: 0x1AAB4F0 Offset: 0x1AAB5F1 VA: 0x1AAB4F0
	|-TweenManager.GetTweener<double, double, NoOptions>
	|
	|-RVA: 0x1AABB40 Offset: 0x1AABC41 VA: 0x1AABB40
	|-TweenManager.GetTweener<int, int, NoOptions>
	|
	|-RVA: 0x1AAC190 Offset: 0x1AAC291 VA: 0x1AAC190
	|-TweenManager.GetTweener<long, long, NoOptions>
	|
	|-RVA: 0x1AAC7E0 Offset: 0x1AAC8E1 VA: 0x1AAC7E0
	|-TweenManager.GetTweener<object, object, NoOptions>
	|
	|-RVA: 0x1AACE30 Offset: 0x1AACF31 VA: 0x1AACE30
	|-TweenManager.GetTweener<object, object, StringOptions>
	|
	|-RVA: 0x1AAD480 Offset: 0x1AAD581 VA: 0x1AAD480
	|-TweenManager.GetTweener<float, float, FloatOptions>
	|
	|-RVA: 0x1AADAD0 Offset: 0x1AADBD1 VA: 0x1AADAD0
	|-TweenManager.GetTweener<uint, uint, UintOptions>
	|
	|-RVA: 0x1AAE120 Offset: 0x1AAE221 VA: 0x1AAE120
	|-TweenManager.GetTweener<ulong, ulong, NoOptions>
	|
	|-RVA: 0x1AAE770 Offset: 0x1AAE871 VA: 0x1AAE770
	|-TweenManager.GetTweener<Color, Color, ColorOptions>
	|
	|-RVA: 0x1AAEDC0 Offset: 0x1AAEEC1 VA: 0x1AAEDC0
	|-TweenManager.GetTweener<Quaternion, Quaternion, NoOptions>
	|
	|-RVA: 0x1AAF410 Offset: 0x1AAF511 VA: 0x1AAF410
	|-TweenManager.GetTweener<Quaternion, Vector3, QuaternionOptions>
	|
	|-RVA: 0x1AAFA60 Offset: 0x1AAFB61 VA: 0x1AAFA60
	|-TweenManager.GetTweener<Rect, Rect, RectOptions>
	|
	|-RVA: 0x1AB00B0 Offset: 0x1AB01B1 VA: 0x1AB00B0
	|-TweenManager.GetTweener<Vector2, Vector2, VectorOptions>
	|
	|-RVA: 0x1AB0700 Offset: 0x1AB0801 VA: 0x1AB0700
	|-TweenManager.GetTweener<Vector3, object, PathOptions>
	|
	|-RVA: 0x1AB0D50 Offset: 0x1AB0E51 VA: 0x1AB0D50
	|-TweenManager.GetTweener<Vector3, object, Vector3ArrayOptions>
	|
	|-RVA: 0x1AB13A0 Offset: 0x1AB14A1 VA: 0x1AB13A0
	|-TweenManager.GetTweener<Vector3, Vector3, VectorOptions>
	|
	|-RVA: 0x1AB19F0 Offset: 0x1AB1AF1 VA: 0x1AB19F0
	|-TweenManager.GetTweener<Vector4, Vector4, VectorOptions>
	*/

	// RVA: 0x198D590 Offset: 0x198D691 VA: 0x198D590
	internal static Sequence GetSequence() { }

	// RVA: 0x198DF20 Offset: 0x198E021 VA: 0x198DF20
	internal static void SetUpdateType(Tween t, UpdateType updateType, bool isIndependentUpdate) { }

	// RVA: 0x198E210 Offset: 0x198E311 VA: 0x198E210
	internal static void AddActiveTweenToSequence(Tween t) { }

	// RVA: 0x198E970 Offset: 0x198EA71 VA: 0x198E970
	internal static int DespawnAll() { }

	// RVA: 0x198EC00 Offset: 0x198ED01 VA: 0x198EC00
	internal static void Despawn(Tween t, bool modifyActiveLists = True) { }

	// RVA: 0x198F230 Offset: 0x198F331 VA: 0x198F230
	internal static void PurgeAll() { }

	// RVA: 0x198F490 Offset: 0x198F591 VA: 0x198F490
	internal static void PurgePools() { }

	// RVA: 0x198F650 Offset: 0x198F751 VA: 0x198F650
	internal static void AddTweenLink(Tween t, TweenLink tweenLink) { }

	// RVA: 0x198F950 Offset: 0x198FA51 VA: 0x198F950
	private static void RemoveTweenLink(Tween t) { }

	// RVA: 0x198F5E0 Offset: 0x198F6E1 VA: 0x198F5E0
	internal static void ResetCapacities() { }

	// RVA: 0x1987710 Offset: 0x1987811 VA: 0x1987710
	internal static void SetCapacities(int tweenersCapacity, int sequencesCapacity) { }

	// RVA: 0x198FA30 Offset: 0x198FB31 VA: 0x198FA30
	internal static int Validate() { }

	// RVA: 0x1986340 Offset: 0x1986441 VA: 0x1986340
	internal static void Update(UpdateType updateType, float deltaTime, float independentTime) { }

	// RVA: 0x19903F0 Offset: 0x19904F1 VA: 0x19903F0
	internal static int FilteredOperation(OperationType operationType, FilterType filterType, object id, bool optionalBool, float optionalFloat, object optionalObj, object[] optionalArray) { }

	// RVA: 0x1990F80 Offset: 0x1991081 VA: 0x1990F80
	internal static bool Complete(Tween t, bool modifyActiveLists = True, UpdateMode updateMode = 1) { }

	// RVA: 0x1991090 Offset: 0x1991191 VA: 0x1991090
	internal static bool Flip(Tween t) { }

	// RVA: 0x1990EA0 Offset: 0x1990FA1 VA: 0x1990EA0
	internal static void ForceInit(Tween t, bool isSequenced = False) { }

	// RVA: 0x19910C0 Offset: 0x19911C1 VA: 0x19910C0
	internal static bool Goto(Tween t, float to, bool andPlay = False, UpdateMode updateMode = 1) { }

	// RVA: 0x198F900 Offset: 0x198FA01 VA: 0x198F900
	internal static bool Pause(Tween t) { }

	// RVA: 0x198F860 Offset: 0x198F961 VA: 0x198F860
	internal static bool Play(Tween t) { }

	// RVA: 0x1991210 Offset: 0x1991311 VA: 0x1991210
	internal static bool PlayBackwards(Tween t) { }

	// RVA: 0x19913D0 Offset: 0x19914D1 VA: 0x19913D0
	internal static bool PlayForward(Tween t) { }

	// RVA: 0x1991530 Offset: 0x1991631 VA: 0x1991530
	internal static bool Restart(Tween t, bool includeDelay = True, float changeDelayTo = -1) { }

	// RVA: 0x1991610 Offset: 0x1991711 VA: 0x1991610
	internal static bool Rewind(Tween t, bool includeDelay = True) { }

	// RVA: 0x1991740 Offset: 0x1991841 VA: 0x1991740
	internal static bool SmoothRewind(Tween t) { }

	// RVA: 0x1991860 Offset: 0x1991961 VA: 0x1991860
	internal static bool TogglePause(Tween t) { }

	// RVA: 0x1991A90 Offset: 0x1991B91 VA: 0x1991A90
	internal static int TotalPooledTweens() { }

	// RVA: 0x1991B00 Offset: 0x1991C01 VA: 0x1991B00
	internal static int TotalPlayingTweens() { }

	// RVA: 0x1991C70 Offset: 0x1991D71 VA: 0x1991C70
	internal static List<Tween> GetActiveTweens(bool playing, List<Tween> fillableList) { }

	// RVA: 0x1991EC0 Offset: 0x1991FC1 VA: 0x1991EC0
	internal static List<Tween> GetTweensById(object id, bool playingOnly, List<Tween> fillableList) { }

	// RVA: 0x1992200 Offset: 0x1992301 VA: 0x1992200
	internal static List<Tween> GetTweensByTarget(object target, bool playingOnly, List<Tween> fillableList) { }

	// RVA: 0x198FF20 Offset: 0x1990021 VA: 0x198FF20
	private static void MarkForKilling(Tween t) { }

	// RVA: 0x19900A0 Offset: 0x19901A1 VA: 0x19900A0
	private static void EvaluateTweenLink(Tween t) { }

	// RVA: 0x198D890 Offset: 0x198D991 VA: 0x198D890
	private static void AddActiveTween(Tween t) { }

	// RVA: 0x198FC60 Offset: 0x198FD61 VA: 0x198FC60
	private static void ReorganizeActiveTweens() { }

	// RVA: 0x198FFB0 Offset: 0x19900B1 VA: 0x198FFB0
	private static void DespawnActiveTweens(List<Tween> tweens) { }

	// RVA: 0x198E290 Offset: 0x198E391 VA: 0x198E290
	private static void RemoveActiveTween(Tween t) { }

	// RVA: 0x198F1A0 Offset: 0x198F2A1 VA: 0x198F1A0
	private static void ClearTweenArray(Tween[] tweens) { }

	// RVA: 0x198DC70 Offset: 0x198DD71 VA: 0x198DC70
	private static void IncreaseCapacities(TweenManager.CapacityIncreaseMode increaseMode) { }

	// RVA: 0x19919A0 Offset: 0x1991AA1 VA: 0x19919A0
	private static void ManageOnRewindCallbackWhenAlreadyRewinded(Tween t, bool isPlayBackwardsOrSmoothRewind) { }
}

