[Serializable]
public class TransformTweenBehaviour : PlayableBehaviour // TypeDefIndex: 6094
{
	// Fields
	public Transform startLocation; // 0x10
	public Transform endLocation; // 0x18
	public bool tweenPosition; // 0x20
	public bool tweenRotation; // 0x21
	public TransformTweenBehaviour.TweenType tweenType; // 0x24
	public AnimationCurve customCurve; // 0x28
	public Vector3 startingPosition; // 0x30
	public Quaternion startingRotation; // 0x3C
	private AnimationCurve m_LinearCurve; // 0x50
	private AnimationCurve m_DecelerationCurve; // 0x58
	private AnimationCurve m_HarmonicCurve; // 0x60
	private const float k_RightAngleInRads = 1.5707964;

	// Methods

	// RVA: 0x1D2C090 Offset: 0x1D2C191 VA: 0x1D2C090 Slot: 19
	public override void PrepareFrame(Playable playable, FrameData info) { }

	// RVA: 0x1D2C150 Offset: 0x1D2C251 VA: 0x1D2C150
	public float EvaluateCurrentCurve(float time) { }

	// RVA: 0x1D2C250 Offset: 0x1D2C351 VA: 0x1D2C250
	private bool IsCustomCurveNormalised() { }

	// RVA: 0x1D2C4A0 Offset: 0x1D2C5A1 VA: 0x1D2C4A0
	public void .ctor() { }
}

