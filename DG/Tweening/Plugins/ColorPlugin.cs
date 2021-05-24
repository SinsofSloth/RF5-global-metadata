public class ColorPlugin : ABSTweenPlugin<Color, Color, ColorOptions> // TypeDefIndex: 5024
{
	// Methods

	// RVA: 0x19990F0 Offset: 0x19991F1 VA: 0x19990F0 Slot: 4
	public override void Reset(TweenerCore<Color, Color, ColorOptions> t) { }

	// RVA: 0x1999100 Offset: 0x1999201 VA: 0x1999100 Slot: 5
	public override void SetFrom(TweenerCore<Color, Color, ColorOptions> t, bool isRelative) { }

	// RVA: 0x1999230 Offset: 0x1999331 VA: 0x1999230 Slot: 6
	public override void SetFrom(TweenerCore<Color, Color, ColorOptions> t, Color fromValue, bool setImmediately) { }

	// RVA: 0x1999320 Offset: 0x1999421 VA: 0x1999320 Slot: 7
	public override Color ConvertToStartValue(TweenerCore<Color, Color, ColorOptions> t, Color value) { }

	// RVA: 0x1999330 Offset: 0x1999431 VA: 0x1999330 Slot: 8
	public override void SetRelativeEndValue(TweenerCore<Color, Color, ColorOptions> t) { }

	// RVA: 0x1999390 Offset: 0x1999491 VA: 0x1999390 Slot: 9
	public override void SetChangeValue(TweenerCore<Color, Color, ColorOptions> t) { }

	// RVA: 0x19993F0 Offset: 0x19994F1 VA: 0x19993F0 Slot: 10
	public override float GetSpeedBasedDuration(ColorOptions options, float unitsXSecond, Color changeValue) { }

	// RVA: 0x1999400 Offset: 0x1999501 VA: 0x1999400 Slot: 11
	public override void EvaluateAndApply(ColorOptions options, Tween t, bool isRelative, DOGetter<Color> getter, DOSetter<Color> setter, float elapsed, Color startValue, Color changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	// RVA: 0x1999660 Offset: 0x1999761 VA: 0x1999660
	public void .ctor() { }
}

