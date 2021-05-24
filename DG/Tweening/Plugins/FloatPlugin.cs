public class FloatPlugin : ABSTweenPlugin<float, float, FloatOptions> // TypeDefIndex: 5034
{
	// Methods

	// RVA: 0x199DB90 Offset: 0x199DC91 VA: 0x199DB90 Slot: 4
	public override void Reset(TweenerCore<float, float, FloatOptions> t) { }

	// RVA: 0x199DBA0 Offset: 0x199DCA1 VA: 0x199DBA0 Slot: 5
	public override void SetFrom(TweenerCore<float, float, FloatOptions> t, bool isRelative) { }

	// RVA: 0x199DCF0 Offset: 0x199DDF1 VA: 0x199DCF0 Slot: 6
	public override void SetFrom(TweenerCore<float, float, FloatOptions> t, float fromValue, bool setImmediately) { }

	// RVA: 0x199DE30 Offset: 0x199DF31 VA: 0x199DE30 Slot: 7
	public override float ConvertToStartValue(TweenerCore<float, float, FloatOptions> t, float value) { }

	// RVA: 0x199DE40 Offset: 0x199DF41 VA: 0x199DE40 Slot: 8
	public override void SetRelativeEndValue(TweenerCore<float, float, FloatOptions> t) { }

	// RVA: 0x199DE70 Offset: 0x199DF71 VA: 0x199DE70 Slot: 9
	public override void SetChangeValue(TweenerCore<float, float, FloatOptions> t) { }

	// RVA: 0x199DEA0 Offset: 0x199DFA1 VA: 0x199DEA0 Slot: 10
	public override float GetSpeedBasedDuration(FloatOptions options, float unitsXSecond, float changeValue) { }

	// RVA: 0x199DEC0 Offset: 0x199DFC1 VA: 0x199DEC0 Slot: 11
	public override void EvaluateAndApply(FloatOptions options, Tween t, bool isRelative, DOGetter<float> getter, DOSetter<float> setter, float elapsed, float startValue, float changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	// RVA: 0x199E0B0 Offset: 0x199E1B1 VA: 0x199E0B0
	public void .ctor() { }
}

