public class QuaternionPlugin : ABSTweenPlugin<Quaternion, Vector3, QuaternionOptions> // TypeDefIndex: 5026
{
	// Methods

	// RVA: 0x19E7510 Offset: 0x19E7611 VA: 0x19E7510 Slot: 4
	public override void Reset(TweenerCore<Quaternion, Vector3, QuaternionOptions> t) { }

	// RVA: 0x19E7520 Offset: 0x19E7621 VA: 0x19E7520 Slot: 5
	public override void SetFrom(TweenerCore<Quaternion, Vector3, QuaternionOptions> t, bool isRelative) { }

	// RVA: 0x19E7890 Offset: 0x19E7991 VA: 0x19E7890 Slot: 6
	public override void SetFrom(TweenerCore<Quaternion, Vector3, QuaternionOptions> t, Vector3 fromValue, bool setImmediately) { }

	// RVA: 0x19E7980 Offset: 0x19E7A81 VA: 0x19E7980 Slot: 7
	public override Vector3 ConvertToStartValue(TweenerCore<Quaternion, Vector3, QuaternionOptions> t, Quaternion value) { }

	// RVA: 0x19E79B0 Offset: 0x19E7AB1 VA: 0x19E79B0 Slot: 8
	public override void SetRelativeEndValue(TweenerCore<Quaternion, Vector3, QuaternionOptions> t) { }

	// RVA: 0x19E7A80 Offset: 0x19E7B81 VA: 0x19E7A80 Slot: 9
	public override void SetChangeValue(TweenerCore<Quaternion, Vector3, QuaternionOptions> t) { }

	// RVA: 0x19E7CC0 Offset: 0x19E7DC1 VA: 0x19E7CC0 Slot: 10
	public override float GetSpeedBasedDuration(QuaternionOptions options, float unitsXSecond, Vector3 changeValue) { }

	// RVA: 0x19E7D00 Offset: 0x19E7E01 VA: 0x19E7D00 Slot: 11
	public override void EvaluateAndApply(QuaternionOptions options, Tween t, bool isRelative, DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, float elapsed, Vector3 startValue, Vector3 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	// RVA: 0x19E8150 Offset: 0x19E8251 VA: 0x19E8150
	public void .ctor() { }
}

