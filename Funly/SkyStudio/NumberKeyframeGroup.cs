[Serializable]
public class NumberKeyframeGroup : KeyframeGroup<NumberKeyframe> // TypeDefIndex: 9642
{
	// Fields
	public float minValue; // 0x2C
	public float maxValue; // 0x30

	// Methods

	// RVA: 0x22B5100 Offset: 0x22B5201 VA: 0x22B5100
	public void .ctor(string name, float min, float max) { }

	// RVA: 0x22B5180 Offset: 0x22B5281 VA: 0x22B5180
	public void .ctor(string name, float min, float max, NumberKeyframe frame) { }

	// RVA: 0x22B5210 Offset: 0x22B5311 VA: 0x22B5210
	public float GetFirstValue() { }

	// RVA: 0x22B5280 Offset: 0x22B5381 VA: 0x22B5280
	public float ValueToPercent(float value) { }

	// RVA: 0x22B5310 Offset: 0x22B5411 VA: 0x22B5310
	public float ValuePercentAtTime(float time) { }

	// RVA: 0x22B5520 Offset: 0x22B5621 VA: 0x22B5520
	public float PercentToValue(float percent) { }

	// RVA: 0x22B53A0 Offset: 0x22B54A1 VA: 0x22B53A0
	public float NumericValueAtTime(float time) { }
}

