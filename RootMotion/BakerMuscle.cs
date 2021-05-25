[Serializable]
public class BakerMuscle // TypeDefIndex: 6067
{
	// Fields
	public AnimationCurve curve; // 0x10
	private int muscleIndex; // 0x18
	private string propertyName; // 0x20

	// Methods

	// RVA: 0x1A46390 Offset: 0x1A46491 VA: 0x1A46390
	public void .ctor(int muscleIndex) { }

	// RVA: 0x1A46460 Offset: 0x1A46561 VA: 0x1A46460
	private string MuscleNameToPropertyName(string n) { }

	// RVA: 0x1A46D30 Offset: 0x1A46E31 VA: 0x1A46D30
	public void MultiplyLength(AnimationCurve curve, float mlp) { }

	// RVA: 0x1A46DF0 Offset: 0x1A46EF1 VA: 0x1A46DF0
	public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp) { }

	// RVA: 0x1A46CC0 Offset: 0x1A46DC1 VA: 0x1A46CC0
	public void Reset() { }

	// RVA: 0x1A46F00 Offset: 0x1A47001 VA: 0x1A46F00
	public void SetKeyframe(float time, float[] muscles) { }

	// RVA: 0x1A46F50 Offset: 0x1A47051 VA: 0x1A46F50
	public void SetLoopFrame(float time) { }
}

