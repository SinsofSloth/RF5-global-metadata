public class PathPlugin : ABSTweenPlugin<Vector3, Path, PathOptions> // TypeDefIndex: 5023
{
	// Fields
	public const float MinLookAhead = 0.0001;

	// Methods

	// RVA: 0x19E6120 Offset: 0x19E6221 VA: 0x19E6120 Slot: 4
	public override void Reset(TweenerCore<Vector3, Path, PathOptions> t) { }

	// RVA: 0x19E6190 Offset: 0x19E6291 VA: 0x19E6190 Slot: 5
	public override void SetFrom(TweenerCore<Vector3, Path, PathOptions> t, bool isRelative) { }

	// RVA: 0x19E61A0 Offset: 0x19E62A1 VA: 0x19E61A0 Slot: 6
	public override void SetFrom(TweenerCore<Vector3, Path, PathOptions> t, Path fromValue, bool setImmediately) { }

	// RVA: 0x19E61B0 Offset: 0x19E62B1 VA: 0x19E61B0
	public static ABSTweenPlugin<Vector3, Path, PathOptions> Get() { }

	// RVA: 0x19E6200 Offset: 0x19E6301 VA: 0x19E6200 Slot: 7
	public override Path ConvertToStartValue(TweenerCore<Vector3, Path, PathOptions> t, Vector3 value) { }

	// RVA: 0x19E6220 Offset: 0x19E6321 VA: 0x19E6220 Slot: 8
	public override void SetRelativeEndValue(TweenerCore<Vector3, Path, PathOptions> t) { }

	// RVA: 0x19E6380 Offset: 0x19E6481 VA: 0x19E6380 Slot: 9
	public override void SetChangeValue(TweenerCore<Vector3, Path, PathOptions> t) { }

	// RVA: 0x19E6790 Offset: 0x19E6891 VA: 0x19E6790 Slot: 10
	public override float GetSpeedBasedDuration(PathOptions options, float unitsXSecond, Path changeValue) { }

	// RVA: 0x19E67B0 Offset: 0x19E68B1 VA: 0x19E67B0 Slot: 11
	public override void EvaluateAndApply(PathOptions options, Tween t, bool isRelative, DOGetter<Vector3> getter, DOSetter<Vector3> setter, float elapsed, Path startValue, Path changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	// RVA: 0x19E6AA0 Offset: 0x19E6BA1 VA: 0x19E6AA0
	public void SetOrientation(PathOptions options, Tween t, Path path, float pathPerc, Vector3 tPos, UpdateNotice updateNotice) { }

	// RVA: 0x19E74C0 Offset: 0x19E75C1 VA: 0x19E74C0
	public void .ctor() { }
}

