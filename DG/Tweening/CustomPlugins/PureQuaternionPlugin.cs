public class PureQuaternionPlugin : ABSTweenPlugin<Quaternion, Quaternion, NoOptions> // TypeDefIndex: 5060
{
	// Fields
	private static PureQuaternionPlugin _plug; // 0x0

	// Methods

	// RVA: 0x1992AA0 Offset: 0x1992BA1 VA: 0x1992AA0
	public static PureQuaternionPlugin Plug() { }

	// RVA: 0x1992BB0 Offset: 0x1992CB1 VA: 0x1992BB0 Slot: 4
	public override void Reset(TweenerCore<Quaternion, Quaternion, NoOptions> t) { }

	// RVA: 0x1992BC0 Offset: 0x1992CC1 VA: 0x1992BC0 Slot: 5
	public override void SetFrom(TweenerCore<Quaternion, Quaternion, NoOptions> t, bool isRelative) { }

	// RVA: 0x1992D10 Offset: 0x1992E11 VA: 0x1992D10 Slot: 6
	public override void SetFrom(TweenerCore<Quaternion, Quaternion, NoOptions> t, Quaternion fromValue, bool setImmediately) { }

	// RVA: 0x1992DE0 Offset: 0x1992EE1 VA: 0x1992DE0 Slot: 7
	public override Quaternion ConvertToStartValue(TweenerCore<Quaternion, Quaternion, NoOptions> t, Quaternion value) { }

	// RVA: 0x1992DF0 Offset: 0x1992EF1 VA: 0x1992DF0 Slot: 8
	public override void SetRelativeEndValue(TweenerCore<Quaternion, Quaternion, NoOptions> t) { }

	// RVA: 0x1992ED0 Offset: 0x1992FD1 VA: 0x1992ED0 Slot: 9
	public override void SetChangeValue(TweenerCore<Quaternion, Quaternion, NoOptions> t) { }

	// RVA: 0x1992F10 Offset: 0x1993011 VA: 0x1992F10 Slot: 10
	public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, Quaternion changeValue) { }

	// RVA: 0x1992F60 Offset: 0x1993061 VA: 0x1992F60 Slot: 11
	public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, float elapsed, Quaternion startValue, Quaternion changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	// RVA: 0x1992B60 Offset: 0x1992C61 VA: 0x1992B60
	public void .ctor() { }
}

