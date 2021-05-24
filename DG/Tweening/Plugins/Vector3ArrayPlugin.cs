public class Vector3ArrayPlugin : ABSTweenPlugin<Vector3, Vector3[], Vector3ArrayOptions> // TypeDefIndex: 5022
{
	// Methods

	// RVA: 0x19EC930 Offset: 0x19ECA31 VA: 0x19EC930 Slot: 4
	public override void Reset(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t) { }

	// RVA: 0x19EC980 Offset: 0x19ECA81 VA: 0x19EC980 Slot: 5
	public override void SetFrom(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, bool isRelative) { }

	// RVA: 0x19EC990 Offset: 0x19ECA91 VA: 0x19EC990 Slot: 6
	public override void SetFrom(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, Vector3[] fromValue, bool setImmediately) { }

	// RVA: 0x19EC9A0 Offset: 0x19ECAA1 VA: 0x19EC9A0 Slot: 7
	public override Vector3[] ConvertToStartValue(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, Vector3 value) { }

	// RVA: 0x19ECAC0 Offset: 0x19ECBC1 VA: 0x19ECAC0 Slot: 8
	public override void SetRelativeEndValue(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t) { }

	// RVA: 0x19ECC60 Offset: 0x19ECD61 VA: 0x19ECC60 Slot: 9
	public override void SetChangeValue(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t) { }

	// RVA: 0x19ECDD0 Offset: 0x19ECED1 VA: 0x19ECDD0 Slot: 10
	public override float GetSpeedBasedDuration(Vector3ArrayOptions options, float unitsXSecond, Vector3[] changeValue) { }

	// RVA: 0x19ECEB0 Offset: 0x19ECFB1 VA: 0x19ECEB0 Slot: 11
	public override void EvaluateAndApply(Vector3ArrayOptions options, Tween t, bool isRelative, DOGetter<Vector3> getter, DOSetter<Vector3> setter, float elapsed, Vector3[] startValue, Vector3[] changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	// RVA: 0x19ED7A0 Offset: 0x19ED8A1 VA: 0x19ED7A0
	public void .ctor() { }
}

