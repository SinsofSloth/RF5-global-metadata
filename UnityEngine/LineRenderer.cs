[NativeHeaderAttribute] // RVA: 0xC4F50 Offset: 0xC5051 VA: 0xC4F50
[NativeHeaderAttribute] // RVA: 0xC4F50 Offset: 0xC5051 VA: 0xC4F50
public sealed class LineRenderer : Renderer // TypeDefIndex: 2886
{
	// Properties
	[ObsoleteAttribute] // RVA: 0xDE570 Offset: 0xDE671 VA: 0xDE570
	public int numPositions { get; set; }
	public float startWidth { get; set; }
	public float endWidth { get; set; }
	public float widthMultiplier { get; set; }
	public int numCornerVertices { get; set; }
	public int numCapVertices { get; set; }
	public bool useWorldSpace { get; set; }
	public bool loop { get; set; }
	public Color startColor { get; set; }
	public Color endColor { get; set; }
	[NativePropertyAttribute] // RVA: 0xDE5B0 Offset: 0xDE6B1 VA: 0xDE5B0
	public int positionCount { get; set; }
	public float shadowBias { get; set; }
	public bool generateLightingData { get; set; }
	public LineTextureMode textureMode { get; set; }
	public LineAlignment alignment { get; set; }
	public AnimationCurve widthCurve { get; set; }
	public Gradient colorGradient { get; set; }

	// Methods

	[ObsoleteAttribute] // RVA: 0xCF080 Offset: 0xCF181 VA: 0xCF080
	// RVA: 0x1A2F7C0 Offset: 0x1A2F8C1 VA: 0x1A2F7C0
	public void SetWidth(float start, float end) { }

	[ObsoleteAttribute] // RVA: 0xCF0C0 Offset: 0xCF1C1 VA: 0xCF0C0
	// RVA: 0x1A2F8E0 Offset: 0x1A2F9E1 VA: 0x1A2F8E0
	public void SetColors(Color start, Color end) { }

	[ObsoleteAttribute] // RVA: 0xCF100 Offset: 0xCF201 VA: 0xCF100
	// RVA: 0x1A2FA50 Offset: 0x1A2FB51 VA: 0x1A2FA50
	public void SetVertexCount(int count) { }

	// RVA: 0x1A2FAF0 Offset: 0x1A2FBF1 VA: 0x1A2FAF0
	public int get_numPositions() { }

	// RVA: 0x1A2FB90 Offset: 0x1A2FC91 VA: 0x1A2FB90
	public void set_numPositions(int value) { }

	// RVA: 0x1A2FBE0 Offset: 0x1A2FCE1 VA: 0x1A2FBE0
	public float get_startWidth() { }

	// RVA: 0x1A2F840 Offset: 0x1A2F941 VA: 0x1A2F840
	public void set_startWidth(float value) { }

	// RVA: 0x1A2FC30 Offset: 0x1A2FD31 VA: 0x1A2FC30
	public float get_endWidth() { }

	// RVA: 0x1A2F890 Offset: 0x1A2F991 VA: 0x1A2F890
	public void set_endWidth(float value) { }

	// RVA: 0x1A2FC80 Offset: 0x1A2FD81 VA: 0x1A2FC80
	public float get_widthMultiplier() { }

	// RVA: 0x1A2FCD0 Offset: 0x1A2FDD1 VA: 0x1A2FCD0
	public void set_widthMultiplier(float value) { }

	// RVA: 0x1A2FD20 Offset: 0x1A2FE21 VA: 0x1A2FD20
	public int get_numCornerVertices() { }

	// RVA: 0x1A2FD70 Offset: 0x1A2FE71 VA: 0x1A2FD70
	public void set_numCornerVertices(int value) { }

	// RVA: 0x1A2FDC0 Offset: 0x1A2FEC1 VA: 0x1A2FDC0
	public int get_numCapVertices() { }

	// RVA: 0x1A2FE10 Offset: 0x1A2FF11 VA: 0x1A2FE10
	public void set_numCapVertices(int value) { }

	// RVA: 0x1A2FE60 Offset: 0x1A2FF61 VA: 0x1A2FE60
	public bool get_useWorldSpace() { }

	// RVA: 0x1A2FEB0 Offset: 0x1A2FFB1 VA: 0x1A2FEB0
	public void set_useWorldSpace(bool value) { }

	// RVA: 0x1A2FF00 Offset: 0x1A30001 VA: 0x1A2FF00
	public bool get_loop() { }

	// RVA: 0x1A2FF50 Offset: 0x1A30051 VA: 0x1A2FF50
	public void set_loop(bool value) { }

	// RVA: 0x1A2FFA0 Offset: 0x1A300A1 VA: 0x1A2FFA0
	public Color get_startColor() { }

	// RVA: 0x1A2F990 Offset: 0x1A2FA91 VA: 0x1A2F990
	public void set_startColor(Color value) { }

	// RVA: 0x1A300A0 Offset: 0x1A301A1 VA: 0x1A300A0
	public Color get_endColor() { }

	// RVA: 0x1A2F9F0 Offset: 0x1A2FAF1 VA: 0x1A2F9F0
	public void set_endColor(Color value) { }

	// RVA: 0x1A2FB40 Offset: 0x1A2FC41 VA: 0x1A2FB40
	public int get_positionCount() { }

	// RVA: 0x1A2FAA0 Offset: 0x1A2FBA1 VA: 0x1A2FAA0
	public void set_positionCount(int value) { }

	// RVA: 0x1A301A0 Offset: 0x1A302A1 VA: 0x1A301A0
	public void SetPosition(int index, Vector3 position) { }

	// RVA: 0x1A30270 Offset: 0x1A30371 VA: 0x1A30270
	public Vector3 GetPosition(int index) { }

	// RVA: 0x1A30340 Offset: 0x1A30441 VA: 0x1A30340
	public float get_shadowBias() { }

	// RVA: 0x1A30390 Offset: 0x1A30491 VA: 0x1A30390
	public void set_shadowBias(float value) { }

	// RVA: 0x1A303E0 Offset: 0x1A304E1 VA: 0x1A303E0
	public bool get_generateLightingData() { }

	// RVA: 0x1A30430 Offset: 0x1A30531 VA: 0x1A30430
	public void set_generateLightingData(bool value) { }

	// RVA: 0x1A30480 Offset: 0x1A30581 VA: 0x1A30480
	public LineTextureMode get_textureMode() { }

	// RVA: 0x1A304D0 Offset: 0x1A305D1 VA: 0x1A304D0
	public void set_textureMode(LineTextureMode value) { }

	// RVA: 0x1A30520 Offset: 0x1A30621 VA: 0x1A30520
	public LineAlignment get_alignment() { }

	// RVA: 0x1A30570 Offset: 0x1A30671 VA: 0x1A30570
	public void set_alignment(LineAlignment value) { }

	// RVA: 0x1A305C0 Offset: 0x1A306C1 VA: 0x1A305C0
	public void Simplify(float tolerance) { }

	// RVA: 0x1A30610 Offset: 0x1A30711 VA: 0x1A30610
	public void BakeMesh(Mesh mesh, bool useTransform = False) { }

	// RVA: 0x1A30680 Offset: 0x1A30781 VA: 0x1A30680
	public void BakeMesh(Mesh mesh, Camera camera, bool useTransform = False) { }

	// RVA: 0x1A306F0 Offset: 0x1A307F1 VA: 0x1A306F0
	public AnimationCurve get_widthCurve() { }

	// RVA: 0x1A30790 Offset: 0x1A30891 VA: 0x1A30790
	public void set_widthCurve(AnimationCurve value) { }

	// RVA: 0x1A30830 Offset: 0x1A30931 VA: 0x1A30830
	public Gradient get_colorGradient() { }

	// RVA: 0x1A308D0 Offset: 0x1A309D1 VA: 0x1A308D0
	public void set_colorGradient(Gradient value) { }

	// RVA: 0x1A30740 Offset: 0x1A30841 VA: 0x1A30740
	private AnimationCurve GetWidthCurveCopy() { }

	// RVA: 0x1A307E0 Offset: 0x1A308E1 VA: 0x1A307E0
	private void SetWidthCurve(AnimationCurve curve) { }

	// RVA: 0x1A30880 Offset: 0x1A30981 VA: 0x1A30880
	private Gradient GetColorGradientCopy() { }

	// RVA: 0x1A30920 Offset: 0x1A30A21 VA: 0x1A30920
	private void SetColorGradient(Gradient curve) { }

	[FreeFunctionAttribute] // RVA: 0xCF140 Offset: 0xCF241 VA: 0xCF140
	// RVA: 0x1A30970 Offset: 0x1A30A71 VA: 0x1A30970
	public int GetPositions([Out] Vector3[] positions) { }

	[FreeFunctionAttribute] // RVA: 0xCF190 Offset: 0xCF291 VA: 0xCF190
	// RVA: 0x1A309C0 Offset: 0x1A30AC1 VA: 0x1A309C0
	public void SetPositions(Vector3[] positions) { }

	// RVA: 0x1A30A10 Offset: 0x1A30B11 VA: 0x1A30A10
	public void .ctor() { }

	// RVA: 0x1A30000 Offset: 0x1A30101 VA: 0x1A30000
	private void get_startColor_Injected(out Color ret) { }

	// RVA: 0x1A30050 Offset: 0x1A30151 VA: 0x1A30050
	private void set_startColor_Injected(ref Color value) { }

	// RVA: 0x1A30100 Offset: 0x1A30201 VA: 0x1A30100
	private void get_endColor_Injected(out Color ret) { }

	// RVA: 0x1A30150 Offset: 0x1A30251 VA: 0x1A30150
	private void set_endColor_Injected(ref Color value) { }

	// RVA: 0x1A30210 Offset: 0x1A30311 VA: 0x1A30210
	private void SetPosition_Injected(int index, ref Vector3 position) { }

	// RVA: 0x1A302E0 Offset: 0x1A303E1 VA: 0x1A302E0
	private void GetPosition_Injected(int index, out Vector3 ret) { }
}

