public class Vector2Plugin : ABSTweenPlugin<Vector2, Vector2, VectorOptions> // TypeDefIndex: 5030
{
	// Methods

	// RVA: 0x19EBD70 Offset: 0x19EBE71 VA: 0x19EBD70 Slot: 4
	public override void Reset(TweenerCore<Vector2, Vector2, VectorOptions> t) { }

	// RVA: 0x19EBD80 Offset: 0x19EBE81 VA: 0x19EBD80 Slot: 5
	public override void SetFrom(TweenerCore<Vector2, Vector2, VectorOptions> t, bool isRelative) { }

	// RVA: 0x19EBFD0 Offset: 0x19EC0D1 VA: 0x19EBFD0 Slot: 6
	public override void SetFrom(TweenerCore<Vector2, Vector2, VectorOptions> t, Vector2 fromValue, bool setImmediately) { }

	// RVA: 0x19EC1F0 Offset: 0x19EC2F1 VA: 0x19EC1F0 Slot: 7
	public override Vector2 ConvertToStartValue(TweenerCore<Vector2, Vector2, VectorOptions> t, Vector2 value) { }

	// RVA: 0x19EC200 Offset: 0x19EC301 VA: 0x19EC200 Slot: 8
	public override void SetRelativeEndValue(TweenerCore<Vector2, Vector2, VectorOptions> t) { }

	// RVA: 0x19EC2B0 Offset: 0x19EC3B1 VA: 0x19EC2B0 Slot: 9
	public override void SetChangeValue(TweenerCore<Vector2, Vector2, VectorOptions> t) { }

	// RVA: 0x19EC3C0 Offset: 0x19EC4C1 VA: 0x19EC3C0 Slot: 10
	public override float GetSpeedBasedDuration(VectorOptions options, float unitsXSecond, Vector2 changeValue) { }

	// RVA: 0x19EC3F0 Offset: 0x19EC4F1 VA: 0x19EC3F0 Slot: 11
	public override void EvaluateAndApply(VectorOptions options, Tween t, bool isRelative, DOGetter<Vector2> getter, DOSetter<Vector2> setter, float elapsed, Vector2 startValue, Vector2 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice) { }

	// RVA: 0x19EC8E0 Offset: 0x19EC9E1 VA: 0x19EC8E0
	public void .ctor() { }
}

