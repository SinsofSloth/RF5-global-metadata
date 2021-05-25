[NativeHeaderAttribute] // RVA: 0xC4EF0 Offset: 0xC4FF1 VA: 0xC4EF0
[NativeHeaderAttribute] // RVA: 0xC4EF0 Offset: 0xC4FF1 VA: 0xC4EF0
public sealed class TrailRenderer : Renderer // TypeDefIndex: 2885
{
	// Properties
	[ObsoleteAttribute] // RVA: 0xDE4F0 Offset: 0xDE5F1 VA: 0xDE4F0
	public int numPositions { get; }
	public float time { get; set; }
	public float startWidth { get; set; }
	public float endWidth { get; set; }
	public float widthMultiplier { get; set; }
	public bool autodestruct { get; set; }
	public bool emitting { get; set; }
	public int numCornerVertices { get; set; }
	public int numCapVertices { get; set; }
	public float minVertexDistance { get; set; }
	public Color startColor { get; set; }
	public Color endColor { get; set; }
	[NativePropertyAttribute] // RVA: 0xDE530 Offset: 0xDE631 VA: 0xDE530
	public int positionCount { get; }
	public float shadowBias { get; set; }
	public bool generateLightingData { get; set; }
	public LineTextureMode textureMode { get; set; }
	public LineAlignment alignment { get; set; }
	public AnimationCurve widthCurve { get; set; }
	public Gradient colorGradient { get; set; }

	// Methods

	// RVA: 0x2A36ED0 Offset: 0x2A36FD1 VA: 0x2A36ED0
	public int get_numPositions() { }

	// RVA: 0x2A36F70 Offset: 0x2A37071 VA: 0x2A36F70
	public float get_time() { }

	// RVA: 0x2A36FC0 Offset: 0x2A370C1 VA: 0x2A36FC0
	public void set_time(float value) { }

	// RVA: 0x2A37010 Offset: 0x2A37111 VA: 0x2A37010
	public float get_startWidth() { }

	// RVA: 0x2A37060 Offset: 0x2A37161 VA: 0x2A37060
	public void set_startWidth(float value) { }

	// RVA: 0x2A370B0 Offset: 0x2A371B1 VA: 0x2A370B0
	public float get_endWidth() { }

	// RVA: 0x2A37100 Offset: 0x2A37201 VA: 0x2A37100
	public void set_endWidth(float value) { }

	// RVA: 0x2A37150 Offset: 0x2A37251 VA: 0x2A37150
	public float get_widthMultiplier() { }

	// RVA: 0x2A371A0 Offset: 0x2A372A1 VA: 0x2A371A0
	public void set_widthMultiplier(float value) { }

	// RVA: 0x2A371F0 Offset: 0x2A372F1 VA: 0x2A371F0
	public bool get_autodestruct() { }

	// RVA: 0x2A37240 Offset: 0x2A37341 VA: 0x2A37240
	public void set_autodestruct(bool value) { }

	// RVA: 0x2A37290 Offset: 0x2A37391 VA: 0x2A37290
	public bool get_emitting() { }

	// RVA: 0x2A372E0 Offset: 0x2A373E1 VA: 0x2A372E0
	public void set_emitting(bool value) { }

	// RVA: 0x2A37330 Offset: 0x2A37431 VA: 0x2A37330
	public int get_numCornerVertices() { }

	// RVA: 0x2A37380 Offset: 0x2A37481 VA: 0x2A37380
	public void set_numCornerVertices(int value) { }

	// RVA: 0x2A373D0 Offset: 0x2A374D1 VA: 0x2A373D0
	public int get_numCapVertices() { }

	// RVA: 0x2A37420 Offset: 0x2A37521 VA: 0x2A37420
	public void set_numCapVertices(int value) { }

	// RVA: 0x2A37470 Offset: 0x2A37571 VA: 0x2A37470
	public float get_minVertexDistance() { }

	// RVA: 0x2A374C0 Offset: 0x2A375C1 VA: 0x2A374C0
	public void set_minVertexDistance(float value) { }

	// RVA: 0x2A37510 Offset: 0x2A37611 VA: 0x2A37510
	public Color get_startColor() { }

	// RVA: 0x2A375C0 Offset: 0x2A376C1 VA: 0x2A375C0
	public void set_startColor(Color value) { }

	// RVA: 0x2A37670 Offset: 0x2A37771 VA: 0x2A37670
	public Color get_endColor() { }

	// RVA: 0x2A37720 Offset: 0x2A37821 VA: 0x2A37720
	public void set_endColor(Color value) { }

	// RVA: 0x2A36F20 Offset: 0x2A37021 VA: 0x2A36F20
	public int get_positionCount() { }

	// RVA: 0x2A377D0 Offset: 0x2A378D1 VA: 0x2A377D0
	public void SetPosition(int index, Vector3 position) { }

	// RVA: 0x2A378A0 Offset: 0x2A379A1 VA: 0x2A378A0
	public Vector3 GetPosition(int index) { }

	// RVA: 0x2A37970 Offset: 0x2A37A71 VA: 0x2A37970
	public float get_shadowBias() { }

	// RVA: 0x2A379C0 Offset: 0x2A37AC1 VA: 0x2A379C0
	public void set_shadowBias(float value) { }

	// RVA: 0x2A37A10 Offset: 0x2A37B11 VA: 0x2A37A10
	public bool get_generateLightingData() { }

	// RVA: 0x2A37A60 Offset: 0x2A37B61 VA: 0x2A37A60
	public void set_generateLightingData(bool value) { }

	// RVA: 0x2A37AB0 Offset: 0x2A37BB1 VA: 0x2A37AB0
	public LineTextureMode get_textureMode() { }

	// RVA: 0x2A37B00 Offset: 0x2A37C01 VA: 0x2A37B00
	public void set_textureMode(LineTextureMode value) { }

	// RVA: 0x2A37B50 Offset: 0x2A37C51 VA: 0x2A37B50
	public LineAlignment get_alignment() { }

	// RVA: 0x2A37BA0 Offset: 0x2A37CA1 VA: 0x2A37BA0
	public void set_alignment(LineAlignment value) { }

	// RVA: 0x2A37BF0 Offset: 0x2A37CF1 VA: 0x2A37BF0
	public void Clear() { }

	// RVA: 0x2A37C40 Offset: 0x2A37D41 VA: 0x2A37C40
	public void BakeMesh(Mesh mesh, bool useTransform = False) { }

	// RVA: 0x2A37CB0 Offset: 0x2A37DB1 VA: 0x2A37CB0
	public void BakeMesh(Mesh mesh, Camera camera, bool useTransform = False) { }

	// RVA: 0x2A37D20 Offset: 0x2A37E21 VA: 0x2A37D20
	public AnimationCurve get_widthCurve() { }

	// RVA: 0x2A37DC0 Offset: 0x2A37EC1 VA: 0x2A37DC0
	public void set_widthCurve(AnimationCurve value) { }

	// RVA: 0x2A37E60 Offset: 0x2A37F61 VA: 0x2A37E60
	public Gradient get_colorGradient() { }

	// RVA: 0x2A37F00 Offset: 0x2A38001 VA: 0x2A37F00
	public void set_colorGradient(Gradient value) { }

	// RVA: 0x2A37D70 Offset: 0x2A37E71 VA: 0x2A37D70
	private AnimationCurve GetWidthCurveCopy() { }

	// RVA: 0x2A37E10 Offset: 0x2A37F11 VA: 0x2A37E10
	private void SetWidthCurve(AnimationCurve curve) { }

	// RVA: 0x2A37EB0 Offset: 0x2A37FB1 VA: 0x2A37EB0
	private Gradient GetColorGradientCopy() { }

	// RVA: 0x2A37F50 Offset: 0x2A38051 VA: 0x2A37F50
	private void SetColorGradient(Gradient curve) { }

	[FreeFunctionAttribute] // RVA: 0xCEF40 Offset: 0xCF041 VA: 0xCEF40
	// RVA: 0x2A37FA0 Offset: 0x2A380A1 VA: 0x2A37FA0
	public int GetPositions([Out] Vector3[] positions) { }

	[FreeFunctionAttribute] // RVA: 0xCEF90 Offset: 0xCF091 VA: 0xCEF90
	// RVA: 0x2A37FF0 Offset: 0x2A380F1 VA: 0x2A37FF0
	public void SetPositions(Vector3[] positions) { }

	[FreeFunctionAttribute] // RVA: 0xCEFE0 Offset: 0xCF0E1 VA: 0xCEFE0
	// RVA: 0x2A38040 Offset: 0x2A38141 VA: 0x2A38040
	public void AddPosition(Vector3 position) { }

	[FreeFunctionAttribute] // RVA: 0xCF030 Offset: 0xCF131 VA: 0xCF030
	// RVA: 0x2A380F0 Offset: 0x2A381F1 VA: 0x2A380F0
	public void AddPositions(Vector3[] positions) { }

	// RVA: 0x2A38140 Offset: 0x2A38241 VA: 0x2A38140
	public void .ctor() { }

	// RVA: 0x2A37570 Offset: 0x2A37671 VA: 0x2A37570
	private void get_startColor_Injected(out Color ret) { }

	// RVA: 0x2A37620 Offset: 0x2A37721 VA: 0x2A37620
	private void set_startColor_Injected(ref Color value) { }

	// RVA: 0x2A376D0 Offset: 0x2A377D1 VA: 0x2A376D0
	private void get_endColor_Injected(out Color ret) { }

	// RVA: 0x2A37780 Offset: 0x2A37881 VA: 0x2A37780
	private void set_endColor_Injected(ref Color value) { }

	// RVA: 0x2A37840 Offset: 0x2A37941 VA: 0x2A37840
	private void SetPosition_Injected(int index, ref Vector3 position) { }

	// RVA: 0x2A37910 Offset: 0x2A37A11 VA: 0x2A37910
	private void GetPosition_Injected(int index, out Vector3 ret) { }

	// RVA: 0x2A380A0 Offset: 0x2A381A1 VA: 0x2A380A0
	private void AddPosition_Injected(ref Vector3 position) { }
}

