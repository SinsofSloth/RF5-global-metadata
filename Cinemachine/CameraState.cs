public struct CameraState // TypeDefIndex: 4812
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x134380 Offset: 0x134481 VA: 0x134380
	private LensSettings <Lens>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x134390 Offset: 0x134491 VA: 0x134390
	private Vector3 <ReferenceUp>k__BackingField; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0x1343A0 Offset: 0x1344A1 VA: 0x1343A0
	private Vector3 <ReferenceLookAt>k__BackingField; // 0x38
	public static Vector3 kNoPoint; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x1343B0 Offset: 0x1344B1 VA: 0x1343B0
	private Vector3 <RawPosition>k__BackingField; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x1343C0 Offset: 0x1344C1 VA: 0x1343C0
	private Quaternion <RawOrientation>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x1343D0 Offset: 0x1344D1 VA: 0x1343D0
	private Vector3 <PositionDampingBypass>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x1343E0 Offset: 0x1344E1 VA: 0x1343E0
	private float <ShotQuality>k__BackingField; // 0x6C
	[CompilerGeneratedAttribute] // RVA: 0x1343F0 Offset: 0x1344F1 VA: 0x1343F0
	private Vector3 <PositionCorrection>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x134400 Offset: 0x134501 VA: 0x134400
	private Quaternion <OrientationCorrection>k__BackingField; // 0x7C
	[CompilerGeneratedAttribute] // RVA: 0x134410 Offset: 0x134511 VA: 0x134410
	private CameraState.BlendHintValue <BlendHint>k__BackingField; // 0x8C
	private CameraState.CustomBlendable mCustom0; // 0x90
	private CameraState.CustomBlendable mCustom1; // 0xA0
	private CameraState.CustomBlendable mCustom2; // 0xB0
	private CameraState.CustomBlendable mCustom3; // 0xC0
	private List<CameraState.CustomBlendable> m_CustomOverflow; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x134420 Offset: 0x134521 VA: 0x134420
	private int <NumCustomBlendables>k__BackingField; // 0xD8

	// Properties
	public LensSettings Lens { get; set; }
	public Vector3 ReferenceUp { get; set; }
	public Vector3 ReferenceLookAt { get; set; }
	public bool HasLookAt { get; }
	public Vector3 RawPosition { get; set; }
	public Quaternion RawOrientation { get; set; }
	public Vector3 PositionDampingBypass { get; set; }
	public float ShotQuality { get; set; }
	public Vector3 PositionCorrection { get; set; }
	public Quaternion OrientationCorrection { get; set; }
	public Vector3 CorrectedPosition { get; }
	public Quaternion CorrectedOrientation { get; }
	public Vector3 FinalPosition { get; }
	public Quaternion FinalOrientation { get; }
	public CameraState.BlendHintValue BlendHint { get; set; }
	public static CameraState Default { get; }
	public int NumCustomBlendables { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x136E00 Offset: 0x136F01 VA: 0x136E00
	// RVA: 0xDB60 Offset: 0xDC61 VA: 0xDB60
	public LensSettings get_Lens() { }

	[CompilerGeneratedAttribute] // RVA: 0x136E10 Offset: 0x136F11 VA: 0x136E10
	// RVA: 0xDB90 Offset: 0xDC91 VA: 0xDB90
	public void set_Lens(LensSettings value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136E20 Offset: 0x136F21 VA: 0x136E20
	// RVA: 0xDBB0 Offset: 0xDCB1 VA: 0xDBB0
	public Vector3 get_ReferenceUp() { }

	[CompilerGeneratedAttribute] // RVA: 0x136E30 Offset: 0x136F31 VA: 0x136E30
	// RVA: 0xDBC0 Offset: 0xDCC1 VA: 0xDBC0
	public void set_ReferenceUp(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136E40 Offset: 0x136F41 VA: 0x136E40
	// RVA: 0xDBD0 Offset: 0xDCD1 VA: 0xDBD0
	public Vector3 get_ReferenceLookAt() { }

	[CompilerGeneratedAttribute] // RVA: 0x136E50 Offset: 0x136F51 VA: 0x136E50
	// RVA: 0xDBE0 Offset: 0xDCE1 VA: 0xDBE0
	public void set_ReferenceLookAt(Vector3 value) { }

	// RVA: 0xDBF0 Offset: 0xDCF1 VA: 0xDBF0
	public bool get_HasLookAt() { }

	[CompilerGeneratedAttribute] // RVA: 0x136E60 Offset: 0x136F61 VA: 0x136E60
	// RVA: 0xDC90 Offset: 0xDD91 VA: 0xDC90
	public Vector3 get_RawPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x136E70 Offset: 0x136F71 VA: 0x136E70
	// RVA: 0xDCA0 Offset: 0xDDA1 VA: 0xDCA0
	public void set_RawPosition(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136E80 Offset: 0x136F81 VA: 0x136E80
	// RVA: 0xDCB0 Offset: 0xDDB1 VA: 0xDCB0
	public Quaternion get_RawOrientation() { }

	[CompilerGeneratedAttribute] // RVA: 0x136E90 Offset: 0x136F91 VA: 0x136E90
	// RVA: 0xDCC0 Offset: 0xDDC1 VA: 0xDCC0
	public void set_RawOrientation(Quaternion value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136EA0 Offset: 0x136FA1 VA: 0x136EA0
	// RVA: 0xDCE0 Offset: 0xDDE1 VA: 0xDCE0
	public Vector3 get_PositionDampingBypass() { }

	[CompilerGeneratedAttribute] // RVA: 0x136EB0 Offset: 0x136FB1 VA: 0x136EB0
	// RVA: 0xDCF0 Offset: 0xDDF1 VA: 0xDCF0
	public void set_PositionDampingBypass(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136EC0 Offset: 0x136FC1 VA: 0x136EC0
	// RVA: 0xDD00 Offset: 0xDE01 VA: 0xDD00
	public float get_ShotQuality() { }

	[CompilerGeneratedAttribute] // RVA: 0x136ED0 Offset: 0x136FD1 VA: 0x136ED0
	// RVA: 0xDD10 Offset: 0xDE11 VA: 0xDD10
	public void set_ShotQuality(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136EE0 Offset: 0x136FE1 VA: 0x136EE0
	// RVA: 0xDD20 Offset: 0xDE21 VA: 0xDD20
	public Vector3 get_PositionCorrection() { }

	[CompilerGeneratedAttribute] // RVA: 0x136EF0 Offset: 0x136FF1 VA: 0x136EF0
	// RVA: 0xDD30 Offset: 0xDE31 VA: 0xDD30
	public void set_PositionCorrection(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136F00 Offset: 0x137001 VA: 0x136F00
	// RVA: 0xDD40 Offset: 0xDE41 VA: 0xDD40
	public Quaternion get_OrientationCorrection() { }

	[CompilerGeneratedAttribute] // RVA: 0x136F10 Offset: 0x137011 VA: 0x136F10
	// RVA: 0xDD50 Offset: 0xDE51 VA: 0xDD50
	public void set_OrientationCorrection(Quaternion value) { }

	// RVA: 0xDD70 Offset: 0xDE71 VA: 0xDD70
	public Vector3 get_CorrectedPosition() { }

	// RVA: 0xDE20 Offset: 0xDF21 VA: 0xDE20
	public Quaternion get_CorrectedOrientation() { }

	// RVA: 0xDEE0 Offset: 0xDFE1 VA: 0xDEE0
	public Vector3 get_FinalPosition() { }

	// RVA: 0xDF90 Offset: 0xE091 VA: 0xDF90
	public Quaternion get_FinalOrientation() { }

	[CompilerGeneratedAttribute] // RVA: 0x136F20 Offset: 0x137021 VA: 0x136F20
	// RVA: 0xDFA0 Offset: 0xE0A1 VA: 0xDFA0
	public CameraState.BlendHintValue get_BlendHint() { }

	[CompilerGeneratedAttribute] // RVA: 0x136F30 Offset: 0x137031 VA: 0x136F30
	// RVA: 0xDFB0 Offset: 0xE0B1 VA: 0xDFB0
	public void set_BlendHint(CameraState.BlendHintValue value) { }

	// RVA: 0x1884160 Offset: 0x1884261 VA: 0x1884160
	public static CameraState get_Default() { }

	[CompilerGeneratedAttribute] // RVA: 0x136F40 Offset: 0x137041 VA: 0x136F40
	// RVA: 0xDFC0 Offset: 0xE0C1 VA: 0xDFC0
	public int get_NumCustomBlendables() { }

	[CompilerGeneratedAttribute] // RVA: 0x136F50 Offset: 0x137051 VA: 0x136F50
	// RVA: 0xDFD0 Offset: 0xE0D1 VA: 0xDFD0
	private void set_NumCustomBlendables(int value) { }

	// RVA: 0xDFE0 Offset: 0xE0E1 VA: 0xDFE0
	public CameraState.CustomBlendable GetCustomBlendable(int index) { }

	// RVA: 0xDFF0 Offset: 0xE0F1 VA: 0xDFF0
	private int FindCustomBlendable(Object custom) { }

	// RVA: 0xE000 Offset: 0xE101 VA: 0xE000
	public void AddCustomBlendable(CameraState.CustomBlendable b) { }

	// RVA: 0x18848B0 Offset: 0x18849B1 VA: 0x18848B0
	public static CameraState Lerp(CameraState stateA, CameraState stateB, float t) { }

	// RVA: 0x1885C30 Offset: 0x1885D31 VA: 0x1885C30
	private static float InterpolateFOV(float fovA, float fovB, float dA, float dB, float t) { }

	// RVA: 0x1885B80 Offset: 0x1885C81 VA: 0x1885B80
	private static Vector3 ApplyPosBlendHint(Vector3 posA, CameraState.BlendHintValue hintA, Vector3 posB, CameraState.BlendHintValue hintB, Vector3 original, Vector3 blended) { }

	// RVA: 0x1885BD0 Offset: 0x1885CD1 VA: 0x1885BD0
	private static Quaternion ApplyRotBlendHint(Quaternion rotA, CameraState.BlendHintValue hintA, Quaternion rotB, CameraState.BlendHintValue hintB, Quaternion original, Quaternion blended) { }

	// RVA: 0xE010 Offset: 0xE111 VA: 0xE010
	private Vector3 InterpolatePosition(Vector3 posA, Vector3 pivotA, Vector3 posB, Vector3 pivotB, float t) { }

	// RVA: 0x1886120 Offset: 0x1886221 VA: 0x1886120
	private static void .cctor() { }
}

