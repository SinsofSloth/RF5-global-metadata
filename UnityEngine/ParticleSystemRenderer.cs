[RequireComponent] // RVA: 0x111E30 Offset: 0x111F31 VA: 0x111E30
[NativeHeaderAttribute] // RVA: 0x111E30 Offset: 0x111F31 VA: 0x111E30
[NativeHeaderAttribute] // RVA: 0x111E30 Offset: 0x111F31 VA: 0x111E30
[NativeHeaderAttribute] // RVA: 0x111E30 Offset: 0x111F31 VA: 0x111E30
public sealed class ParticleSystemRenderer : Renderer // TypeDefIndex: 3867
{
	// Properties
	[NativeNameAttribute] // RVA: 0x113C30 Offset: 0x113D31 VA: 0x113C30
	public ParticleSystemRenderSpace alignment { get; set; }
	public ParticleSystemRenderMode renderMode { get; set; }
	public ParticleSystemSortMode sortMode { get; set; }
	public float lengthScale { get; set; }
	public float velocityScale { get; set; }
	public float cameraVelocityScale { get; set; }
	public float normalDirection { get; set; }
	public float shadowBias { get; set; }
	public float sortingFudge { get; set; }
	public float minParticleSize { get; set; }
	public float maxParticleSize { get; set; }
	public Vector3 pivot { get; set; }
	public Vector3 flip { get; set; }
	public SpriteMaskInteraction maskInteraction { get; set; }
	public Material trailMaterial { get; set; }
	public bool enableGPUInstancing { get; set; }
	public bool allowRoll { get; set; }
	public Mesh mesh { get; set; }
	public int meshCount { get; }
	public int activeVertexStreamsCount { get; }

	// Methods

	[ObsoleteAttribute] // RVA: 0x112F10 Offset: 0x113011 VA: 0x112F10
	// RVA: 0x1B64C10 Offset: 0x1B64D11 VA: 0x1B64C10
	public void EnableVertexStreams(ParticleSystemVertexStreams streams) { }

	[ObsoleteAttribute] // RVA: 0x112F50 Offset: 0x113051 VA: 0x112F50
	// RVA: 0x1B652F0 Offset: 0x1B653F1 VA: 0x1B652F0
	public void DisableVertexStreams(ParticleSystemVertexStreams streams) { }

	[ObsoleteAttribute] // RVA: 0x112F90 Offset: 0x113091 VA: 0x112F90
	// RVA: 0x1B65300 Offset: 0x1B65401 VA: 0x1B65300
	public bool AreVertexStreamsEnabled(ParticleSystemVertexStreams streams) { }

	[ObsoleteAttribute] // RVA: 0x112FD0 Offset: 0x1130D1 VA: 0x112FD0
	// RVA: 0x1B655A0 Offset: 0x1B656A1 VA: 0x1B655A0
	public ParticleSystemVertexStreams GetEnabledVertexStreams(ParticleSystemVertexStreams streams) { }

	[ObsoleteAttribute] // RVA: 0x113010 Offset: 0x113111 VA: 0x113010
	// RVA: 0x1B64C20 Offset: 0x1B64D21 VA: 0x1B64C20
	internal void Internal_SetVertexStreams(ParticleSystemVertexStreams streams, bool enabled) { }

	[ObsoleteAttribute] // RVA: 0x113050 Offset: 0x113151 VA: 0x113050
	// RVA: 0x1B65330 Offset: 0x1B65431 VA: 0x1B65330
	internal ParticleSystemVertexStreams Internal_GetEnabledVertexStreams(ParticleSystemVertexStreams streams) { }

	// RVA: 0x1B656A0 Offset: 0x1B657A1 VA: 0x1B656A0
	public ParticleSystemRenderSpace get_alignment() { }

	// RVA: 0x1B656F0 Offset: 0x1B657F1 VA: 0x1B656F0
	public void set_alignment(ParticleSystemRenderSpace value) { }

	// RVA: 0x1B65740 Offset: 0x1B65841 VA: 0x1B65740
	public ParticleSystemRenderMode get_renderMode() { }

	// RVA: 0x1B65790 Offset: 0x1B65891 VA: 0x1B65790
	public void set_renderMode(ParticleSystemRenderMode value) { }

	// RVA: 0x1B657E0 Offset: 0x1B658E1 VA: 0x1B657E0
	public ParticleSystemSortMode get_sortMode() { }

	// RVA: 0x1B65830 Offset: 0x1B65931 VA: 0x1B65830
	public void set_sortMode(ParticleSystemSortMode value) { }

	// RVA: 0x1B65880 Offset: 0x1B65981 VA: 0x1B65880
	public float get_lengthScale() { }

	// RVA: 0x1B658D0 Offset: 0x1B659D1 VA: 0x1B658D0
	public void set_lengthScale(float value) { }

	// RVA: 0x1B65920 Offset: 0x1B65A21 VA: 0x1B65920
	public float get_velocityScale() { }

	// RVA: 0x1B65970 Offset: 0x1B65A71 VA: 0x1B65970
	public void set_velocityScale(float value) { }

	// RVA: 0x1B659C0 Offset: 0x1B65AC1 VA: 0x1B659C0
	public float get_cameraVelocityScale() { }

	// RVA: 0x1B65A10 Offset: 0x1B65B11 VA: 0x1B65A10
	public void set_cameraVelocityScale(float value) { }

	// RVA: 0x1B65A60 Offset: 0x1B65B61 VA: 0x1B65A60
	public float get_normalDirection() { }

	// RVA: 0x1B65AB0 Offset: 0x1B65BB1 VA: 0x1B65AB0
	public void set_normalDirection(float value) { }

	// RVA: 0x1B65B00 Offset: 0x1B65C01 VA: 0x1B65B00
	public float get_shadowBias() { }

	// RVA: 0x1B65B50 Offset: 0x1B65C51 VA: 0x1B65B50
	public void set_shadowBias(float value) { }

	// RVA: 0x1B65BA0 Offset: 0x1B65CA1 VA: 0x1B65BA0
	public float get_sortingFudge() { }

	// RVA: 0x1B65BF0 Offset: 0x1B65CF1 VA: 0x1B65BF0
	public void set_sortingFudge(float value) { }

	// RVA: 0x1B65C40 Offset: 0x1B65D41 VA: 0x1B65C40
	public float get_minParticleSize() { }

	// RVA: 0x1B65C90 Offset: 0x1B65D91 VA: 0x1B65C90
	public void set_minParticleSize(float value) { }

	// RVA: 0x1B65CE0 Offset: 0x1B65DE1 VA: 0x1B65CE0
	public float get_maxParticleSize() { }

	// RVA: 0x1B65D30 Offset: 0x1B65E31 VA: 0x1B65D30
	public void set_maxParticleSize(float value) { }

	// RVA: 0x1B65D80 Offset: 0x1B65E81 VA: 0x1B65D80
	public Vector3 get_pivot() { }

	// RVA: 0x1B65E30 Offset: 0x1B65F31 VA: 0x1B65E30
	public void set_pivot(Vector3 value) { }

	// RVA: 0x1B65EE0 Offset: 0x1B65FE1 VA: 0x1B65EE0
	public Vector3 get_flip() { }

	// RVA: 0x1B65F90 Offset: 0x1B66091 VA: 0x1B65F90
	public void set_flip(Vector3 value) { }

	// RVA: 0x1B66040 Offset: 0x1B66141 VA: 0x1B66040
	public SpriteMaskInteraction get_maskInteraction() { }

	// RVA: 0x1B66090 Offset: 0x1B66191 VA: 0x1B66090
	public void set_maskInteraction(SpriteMaskInteraction value) { }

	// RVA: 0x1B660E0 Offset: 0x1B661E1 VA: 0x1B660E0
	public Material get_trailMaterial() { }

	// RVA: 0x1B66130 Offset: 0x1B66231 VA: 0x1B66130
	public void set_trailMaterial(Material value) { }

	// RVA: 0x1B66180 Offset: 0x1B66281 VA: 0x1B66180
	public bool get_enableGPUInstancing() { }

	// RVA: 0x1B661D0 Offset: 0x1B662D1 VA: 0x1B661D0
	public void set_enableGPUInstancing(bool value) { }

	// RVA: 0x1B66220 Offset: 0x1B66321 VA: 0x1B66220
	public bool get_allowRoll() { }

	// RVA: 0x1B66270 Offset: 0x1B66371 VA: 0x1B66270
	public void set_allowRoll(bool value) { }

	[FreeFunctionAttribute] // RVA: 0x113090 Offset: 0x113191 VA: 0x113090
	// RVA: 0x1B662C0 Offset: 0x1B663C1 VA: 0x1B662C0
	public Mesh get_mesh() { }

	[FreeFunctionAttribute] // RVA: 0x1130E0 Offset: 0x1131E1 VA: 0x1130E0
	// RVA: 0x1B66310 Offset: 0x1B66411 VA: 0x1B66310
	public void set_mesh(Mesh value) { }

	[FreeFunctionAttribute] // RVA: 0x113130 Offset: 0x113231 VA: 0x113130
	[RequiredByNativeCodeAttribute] // RVA: 0x113130 Offset: 0x113231 VA: 0x113130
	// RVA: 0x1B66360 Offset: 0x1B66461 VA: 0x1B66360
	public int GetMeshes([Out] Mesh[] meshes) { }

	[FreeFunctionAttribute] // RVA: 0x113190 Offset: 0x113291 VA: 0x113190
	// RVA: 0x1B663B0 Offset: 0x1B664B1 VA: 0x1B663B0
	public void SetMeshes(Mesh[] meshes, int size) { }

	// RVA: 0x1B66410 Offset: 0x1B66511 VA: 0x1B66410
	public void SetMeshes(Mesh[] meshes) { }

	// RVA: 0x1B66470 Offset: 0x1B66571 VA: 0x1B66470
	public int get_meshCount() { }

	// RVA: 0x1B664C0 Offset: 0x1B665C1 VA: 0x1B664C0
	public void BakeMesh(Mesh mesh, bool useTransform = False) { }

	// RVA: 0x1B66530 Offset: 0x1B66631 VA: 0x1B66530
	public void BakeMesh(Mesh mesh, Camera camera, bool useTransform = False) { }

	// RVA: 0x1B665A0 Offset: 0x1B666A1 VA: 0x1B665A0
	public void BakeTrailsMesh(Mesh mesh, bool useTransform = False) { }

	// RVA: 0x1B66610 Offset: 0x1B66711 VA: 0x1B66610
	public void BakeTrailsMesh(Mesh mesh, Camera camera, bool useTransform = False) { }

	// RVA: 0x1B655B0 Offset: 0x1B656B1 VA: 0x1B655B0
	public int get_activeVertexStreamsCount() { }

	[FreeFunctionAttribute] // RVA: 0x1131E0 Offset: 0x1132E1 VA: 0x1131E0
	// RVA: 0x1B65650 Offset: 0x1B65751 VA: 0x1B65650
	public void SetActiveVertexStreams(List<ParticleSystemVertexStream> streams) { }

	[FreeFunctionAttribute] // RVA: 0x113230 Offset: 0x113331 VA: 0x113230
	// RVA: 0x1B65600 Offset: 0x1B65701 VA: 0x1B65600
	public void GetActiveVertexStreams(List<ParticleSystemVertexStream> streams) { }

	// RVA: 0x1B66680 Offset: 0x1B66781 VA: 0x1B66680
	public void .ctor() { }

	// RVA: 0x1B65DE0 Offset: 0x1B65EE1 VA: 0x1B65DE0
	private void get_pivot_Injected(out Vector3 ret) { }

	// RVA: 0x1B65E90 Offset: 0x1B65F91 VA: 0x1B65E90
	private void set_pivot_Injected(ref Vector3 value) { }

	// RVA: 0x1B65F40 Offset: 0x1B66041 VA: 0x1B65F40
	private void get_flip_Injected(out Vector3 ret) { }

	// RVA: 0x1B65FF0 Offset: 0x1B660F1 VA: 0x1B65FF0
	private void set_flip_Injected(ref Vector3 value) { }
}

