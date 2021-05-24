public class Vector4Plugin : ABSTweenPlugin<Vector4, Vector4, VectorOptions> // TypeDefIndex: 5031
{
	// Methods

	// RVA: 0x19EE790 Offset: 0x19EE891 VA: 0x19EE790 Slot: 4
	public override void Reset(TweenerCore<Vector4, Vector4, VectorOptions> t) { }

	// RVA: 0x19EE7A0 Offset: 0x19EE8A1 VA: 0x19EE7A0 Slot: 5
	public override void SetFrom(TweenerCore<Vector4, Vector4, VectorOptions> t, bool isRelative) { }

	// RVA: 0x19EEB70 Offset: 0x19EEC71 VA: 0x19EEB70 Slot: 6
	public override void SetFrom(TweenerCore<Vector4, Vector4, VectorOptions> t, Vector4 fromValue, bool setImmediately) { }

	// RVA: 0x19EEF20 Offset: 0x19EF021 VA: 0x19EEF20 Slot: 7
	public override Vector4 ConvertToStartValue(TweenerCore<Vector4, Vector4, VectorOptions> t, Vector4 value) { }

	// RVA: 0x19EEF30 Offset: 0x19EF031 VA: 0x19EEF30 Slot: 8
	public override void SetRelativeEndValue(TweenerCore<Vector4, Vector4, VectorOptions> t) { }

	// RVA: 0x19EF010 Offset: 0x19EF111 VA: 0x19EF010 Slot: 9
	public override void SetChangeValue(TweenerCore<Vector4, Vector4, VectorOptions> t) { }

	// RVA: 0x19EF1E0 Offset: 0x19EF2E1 VA: 0x19EF1E0 Slot: 10
	public override float GetSpeedBasedDuration(VectorOptions options, float unitsXSecond, Vector4 changeValue) { }

	// RVA: 0x19EF220 Offset: 0x19EF321 VA: 0x19EF220 Slot: 11
	public override void EvaluateAndApply(VectorOptions options, Tween t, bool isRelative, DOGetter<Vector4> getter, DOSetter<Vector4> setter, float elapsed, Vector4 startValue, Vector4 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	// RVA: 0x19EFAC0 Offset: 0x19EFBC1 VA: 0x19EFAC0
	public void .ctor() { }
}

