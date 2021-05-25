[Serializable]
public class CubicBezierCurve // TypeDefIndex: 9732
{
	// Fields
	private const int STEP_COUNT = 30;
	private const float T_STEP = 0.033333335;
	private readonly List<CurveSample> samples; // 0x10
	public SplineNode n1; // 0x18
	public SplineNode n2; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x17ED90 Offset: 0x17EE91 VA: 0x17ED90
	private float <Length>k__BackingField; // 0x28
	public UnityEvent Changed; // 0x30

	// Properties
	public float Length { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1ACEF0 Offset: 0x1ACFF1 VA: 0x1ACEF0
	// RVA: 0x211DAC0 Offset: 0x211DBC1 VA: 0x211DAC0
	public float get_Length() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ACF00 Offset: 0x1AD001 VA: 0x1ACF00
	// RVA: 0x211DAD0 Offset: 0x211DBD1 VA: 0x211DAD0
	private void set_Length(float value) { }

	// RVA: 0x211DAE0 Offset: 0x211DBE1 VA: 0x211DAE0
	public void .ctor(SplineNode n1, SplineNode n2) { }

	// RVA: 0x211DEA0 Offset: 0x211DFA1 VA: 0x211DEA0
	public void ConnectStart(SplineNode n1) { }

	// RVA: 0x211DF90 Offset: 0x211E091 VA: 0x211DF90
	public void ConnectEnd(SplineNode n2) { }

	// RVA: 0x211E080 Offset: 0x211E181 VA: 0x211E080
	public Vector3 GetInverseDirection() { }

	// RVA: 0x211E130 Offset: 0x211E231 VA: 0x211E130
	private Vector3 GetLocation(float t) { }

	// RVA: 0x211E2D0 Offset: 0x211E3D1 VA: 0x211E2D0
	private Vector3 GetTangent(float t) { }

	// RVA: 0x211E4A0 Offset: 0x211E5A1 VA: 0x211E4A0
	private Vector3 GetUp(float t) { }

	// RVA: 0x211E570 Offset: 0x211E671 VA: 0x211E570
	private Vector2 GetScale(float t) { }

	// RVA: 0x211E620 Offset: 0x211E721 VA: 0x211E620
	private float GetRoll(float t) { }

	// RVA: 0x211DC40 Offset: 0x211DD41 VA: 0x211DC40
	private void ComputeSamples(object sender, EventArgs e) { }

	// RVA: 0x211E6C0 Offset: 0x211E7C1 VA: 0x211E6C0
	private CurveSample CreateSample(float distance, float time) { }

	// RVA: 0x211E970 Offset: 0x211EA71 VA: 0x211E970
	public CurveSample GetSample(float time) { }

	// RVA: 0x211F150 Offset: 0x211F251 VA: 0x211F150
	public CurveSample GetSampleAtDistance(float d) { }

	// RVA: 0x211EDA0 Offset: 0x211EEA1 VA: 0x211EDA0
	private static void AssertTimeInBounds(float time) { }

	// RVA: 0x211F6D0 Offset: 0x211F7D1 VA: 0x211F6D0
	public CurveSample GetProjectionSample(Vector3 pointToProject) { }
}

