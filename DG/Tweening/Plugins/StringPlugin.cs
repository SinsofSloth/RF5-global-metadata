public class StringPlugin : ABSTweenPlugin<string, string, StringOptions> // TypeDefIndex: 5032
{
	// Fields
	private static readonly StringBuilder _Buffer; // 0x0
	private static readonly List<char> _OpenedTags; // 0x8

	// Methods

	// RVA: 0x19EA0F0 Offset: 0x19EA1F1 VA: 0x19EA0F0 Slot: 5
	public override void SetFrom(TweenerCore<string, string, StringOptions> t, bool isRelative) { }

	// RVA: 0x19EA1A0 Offset: 0x19EA2A1 VA: 0x19EA1A0 Slot: 6
	public override void SetFrom(TweenerCore<string, string, StringOptions> t, string fromValue, bool setImmediately) { }

	// RVA: 0x19EA240 Offset: 0x19EA341 VA: 0x19EA240 Slot: 4
	public override void Reset(TweenerCore<string, string, StringOptions> t) { }

	// RVA: 0x19EA290 Offset: 0x19EA391 VA: 0x19EA290 Slot: 7
	public override string ConvertToStartValue(TweenerCore<string, string, StringOptions> t, string value) { }

	// RVA: 0x19EA2A0 Offset: 0x19EA3A1 VA: 0x19EA2A0 Slot: 8
	public override void SetRelativeEndValue(TweenerCore<string, string, StringOptions> t) { }

	// RVA: 0x19EA2B0 Offset: 0x19EA3B1 VA: 0x19EA2B0 Slot: 9
	public override void SetChangeValue(TweenerCore<string, string, StringOptions> t) { }

	// RVA: 0x19EA390 Offset: 0x19EA491 VA: 0x19EA390 Slot: 10
	public override float GetSpeedBasedDuration(StringOptions options, float unitsXSecond, string changeValue) { }

	// RVA: 0x19EA3D0 Offset: 0x19EA4D1 VA: 0x19EA3D0 Slot: 11
	public override void EvaluateAndApply(StringOptions options, Tween t, bool isRelative, DOGetter<string> getter, DOSetter<string> setter, float elapsed, string startValue, string changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	// RVA: 0x19EA890 Offset: 0x19EA991 VA: 0x19EA890
	private StringBuilder Append(string value, int startIndex, int length, bool richTextEnabled) { }

	// RVA: 0x19EAF80 Offset: 0x19EB081 VA: 0x19EAF80
	private char[] ScrambledCharsToUse(StringOptions options) { }

	// RVA: 0x19EB260 Offset: 0x19EB361 VA: 0x19EB260
	public void .ctor() { }

	// RVA: 0x19EB2B0 Offset: 0x19EB3B1 VA: 0x19EB2B0
	private static void .cctor() { }
}

