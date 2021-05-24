public abstract class ABSTweenPlugin<T1, T2, TPlugOptions> : ITweenPlugin // TypeDefIndex: 5052
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Reset(TweenerCore<T1, T2, TPlugOptions> t) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void SetFrom(TweenerCore<T1, T2, TPlugOptions> t, bool isRelative) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void SetFrom(TweenerCore<T1, T2, TPlugOptions> t, T2 fromValue, bool setImmediately) { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract T2 ConvertToStartValue(TweenerCore<T1, T2, TPlugOptions> t, T1 value) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void SetRelativeEndValue(TweenerCore<T1, T2, TPlugOptions> t) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void SetChangeValue(TweenerCore<T1, T2, TPlugOptions> t) { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract float GetSpeedBasedDuration(TPlugOptions options, float unitsXSecond, T2 changeValue) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void EvaluateAndApply(TPlugOptions options, Tween t, bool isRelative, DOGetter<T1> getter, DOSetter<T1> setter, float elapsed, T2 startValue, T2 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C871A0 Offset: 0x2C872A1 VA: 0x2C871A0
	|-ABSTweenPlugin<Color2, Color2, ColorOptions>..ctor
	|
	|-RVA: 0x2C871C0 Offset: 0x2C872C1 VA: 0x2C871C0
	|-ABSTweenPlugin<double, double, NoOptions>..ctor
	|
	|-RVA: 0x2C871E0 Offset: 0x2C872E1 VA: 0x2C871E0
	|-ABSTweenPlugin<int, int, NoOptions>..ctor
	|
	|-RVA: 0x2C87200 Offset: 0x2C87301 VA: 0x2C87200
	|-ABSTweenPlugin<long, long, NoOptions>..ctor
	|
	|-RVA: 0x2C87220 Offset: 0x2C87321 VA: 0x2C87220
	|-ABSTweenPlugin<object, object, NoOptions>..ctor
	|-ABSTweenPlugin<RectOffset, RectOffset, NoOptions>..ctor
	|
	|-RVA: 0x2C87240 Offset: 0x2C87341 VA: 0x2C87240
	|-ABSTweenPlugin<object, object, StringOptions>..ctor
	|-ABSTweenPlugin<string, string, StringOptions>..ctor
	|
	|-RVA: 0x2C87260 Offset: 0x2C87361 VA: 0x2C87260
	|-ABSTweenPlugin<float, float, FloatOptions>..ctor
	|
	|-RVA: 0x2C87280 Offset: 0x2C87381 VA: 0x2C87280
	|-ABSTweenPlugin<uint, uint, UintOptions>..ctor
	|
	|-RVA: 0x2C872A0 Offset: 0x2C873A1 VA: 0x2C872A0
	|-ABSTweenPlugin<ulong, ulong, NoOptions>..ctor
	|
	|-RVA: 0x2C872C0 Offset: 0x2C873C1 VA: 0x2C872C0
	|-ABSTweenPlugin<Color, Color, ColorOptions>..ctor
	|
	|-RVA: 0x2C872E0 Offset: 0x2C873E1 VA: 0x2C872E0
	|-ABSTweenPlugin<Quaternion, Quaternion, NoOptions>..ctor
	|
	|-RVA: 0x2C87300 Offset: 0x2C87401 VA: 0x2C87300
	|-ABSTweenPlugin<Quaternion, Vector3, QuaternionOptions>..ctor
	|
	|-RVA: 0x2C87320 Offset: 0x2C87421 VA: 0x2C87320
	|-ABSTweenPlugin<Rect, Rect, RectOptions>..ctor
	|
	|-RVA: 0x2C87340 Offset: 0x2C87441 VA: 0x2C87340
	|-ABSTweenPlugin<Vector2, Vector2, VectorOptions>..ctor
	|
	|-RVA: 0x2C87360 Offset: 0x2C87461 VA: 0x2C87360
	|-ABSTweenPlugin<Vector3, Path, PathOptions>..ctor
	|-ABSTweenPlugin<Vector3, object, PathOptions>..ctor
	|
	|-RVA: 0x2C87380 Offset: 0x2C87481 VA: 0x2C87380
	|-ABSTweenPlugin<Vector3, object, Vector3ArrayOptions>..ctor
	|-ABSTweenPlugin<Vector3, Vector3[], Vector3ArrayOptions>..ctor
	|
	|-RVA: 0x2C873A0 Offset: 0x2C874A1 VA: 0x2C873A0
	|-ABSTweenPlugin<Vector3, Vector3, VectorOptions>..ctor
	|
	|-RVA: 0x2C873C0 Offset: 0x2C874C1 VA: 0x2C873C0
	|-ABSTweenPlugin<Vector4, Vector4, VectorOptions>..ctor
	*/
}

