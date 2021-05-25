[NativeHeaderAttribute] // RVA: 0xC4360 Offset: 0xC4461 VA: 0xC4360
[NativeHeaderAttribute] // RVA: 0xC4360 Offset: 0xC4461 VA: 0xC4360
[NativeHeaderAttribute] // RVA: 0xC4360 Offset: 0xC4461 VA: 0xC4360
[UsedByNativeCodeAttribute] // RVA: 0xC4360 Offset: 0xC4461 VA: 0xC4360
[RequireComponent] // RVA: 0xC4360 Offset: 0xC4461 VA: 0xC4360
[NativeHeaderAttribute] // RVA: 0xC4360 Offset: 0xC4461 VA: 0xC4360
[NativeHeaderAttribute] // RVA: 0xC4360 Offset: 0xC4461 VA: 0xC4360
[NativeHeaderAttribute] // RVA: 0xC4360 Offset: 0xC4461 VA: 0xC4360
[NativeHeaderAttribute] // RVA: 0xC4360 Offset: 0xC4461 VA: 0xC4360
public sealed class Camera : Behaviour // TypeDefIndex: 2839
{
	// Fields
	public static Camera.CameraCallback onPreCull; // 0x0
	public static Camera.CameraCallback onPreRender; // 0x8
	public static Camera.CameraCallback onPostRender; // 0x10

	// Properties
	[NativePropertyAttribute] // RVA: 0xDDC70 Offset: 0xDDD71 VA: 0xDDC70
	public float nearClipPlane { get; set; }
	[NativePropertyAttribute] // RVA: 0xDDCB0 Offset: 0xDDDB1 VA: 0xDDCB0
	public float farClipPlane { get; set; }
	[NativePropertyAttribute] // RVA: 0xDDCF0 Offset: 0xDDDF1 VA: 0xDDCF0
	public float fieldOfView { get; set; }
	public RenderingPath renderingPath { get; set; }
	public RenderingPath actualRenderingPath { get; }
	public bool allowHDR { get; set; }
	public bool allowMSAA { get; set; }
	public bool allowDynamicResolution { get; set; }
	[NativePropertyAttribute] // RVA: 0xDDD30 Offset: 0xDDE31 VA: 0xDDD30
	public bool forceIntoRenderTexture { get; set; }
	public float orthographicSize { get; set; }
	public bool orthographic { get; set; }
	public OpaqueSortMode opaqueSortMode { get; set; }
	public TransparencySortMode transparencySortMode { get; set; }
	public Vector3 transparencySortAxis { get; set; }
	public float depth { get; set; }
	public float aspect { get; set; }
	public Vector3 velocity { get; }
	public int cullingMask { get; set; }
	public int eventMask { get; set; }
	public bool layerCullSpherical { get; set; }
	public CameraType cameraType { get; set; }
	[NativeConditionalAttribute] // RVA: 0xDDD70 Offset: 0xDDE71 VA: 0xDDD70
	public ulong overrideSceneCullingMask { get; set; }
	public float[] layerCullDistances { get; set; }
	internal static int PreviewCullingLayer { get; }
	public bool useOcclusionCulling { get; set; }
	public Matrix4x4 cullingMatrix { get; set; }
	public Color backgroundColor { get; set; }
	public CameraClearFlags clearFlags { get; set; }
	public DepthTextureMode depthTextureMode { get; set; }
	public bool clearStencilAfterLightingPass { get; set; }
	internal Camera.ProjectionMatrixMode projectionMatrixMode { get; }
	public bool usePhysicalProperties { get; set; }
	public Vector2 sensorSize { get; set; }
	public Vector2 lensShift { get; set; }
	public float focalLength { get; set; }
	public Camera.GateFitMode gateFit { get; set; }
	[NativePropertyAttribute] // RVA: 0xDDDB0 Offset: 0xDDEB1 VA: 0xDDDB0
	public Rect rect { get; set; }
	[NativePropertyAttribute] // RVA: 0xDDDF0 Offset: 0xDDEF1 VA: 0xDDDF0
	public Rect pixelRect { get; set; }
	public int pixelWidth { get; }
	public int pixelHeight { get; }
	public int scaledPixelWidth { get; }
	public int scaledPixelHeight { get; }
	public RenderTexture targetTexture { get; set; }
	public RenderTexture activeTexture { get; }
	public int targetDisplay { get; set; }
	public Matrix4x4 cameraToWorldMatrix { get; }
	public Matrix4x4 worldToCameraMatrix { get; set; }
	public Matrix4x4 projectionMatrix { get; set; }
	public Matrix4x4 nonJitteredProjectionMatrix { get; set; }
	[NativePropertyAttribute] // RVA: 0xDDE30 Offset: 0xDDF31 VA: 0xDDE30
	public bool useJitteredProjectionMatrixForTransparentRendering { get; set; }
	public Matrix4x4 previousViewProjectionMatrix { get; }
	public static Camera main { get; }
	public static Camera current { get; }
	public Scene scene { get; set; }
	public bool stereoEnabled { get; }
	public float stereoSeparation { get; set; }
	public float stereoConvergence { get; set; }
	public bool areVRStereoViewMatricesWithinSingleCullTolerance { get; }
	public StereoTargetEyeMask stereoTargetEye { get; set; }
	public Camera.MonoOrStereoscopicEye stereoActiveEye { get; }
	public static int allCamerasCount { get; }
	public static Camera[] allCameras { get; }
	public int commandBufferCount { get; }

	// Methods

	// RVA: 0x2AFA020 Offset: 0x2AFA121 VA: 0x2AFA020
	public float get_nearClipPlane() { }

	// RVA: 0x2AFA070 Offset: 0x2AFA171 VA: 0x2AFA070
	public void set_nearClipPlane(float value) { }

	// RVA: 0x2AFA0C0 Offset: 0x2AFA1C1 VA: 0x2AFA0C0
	public float get_farClipPlane() { }

	// RVA: 0x2AFA110 Offset: 0x2AFA211 VA: 0x2AFA110
	public void set_farClipPlane(float value) { }

	// RVA: 0x2AFA160 Offset: 0x2AFA261 VA: 0x2AFA160
	public float get_fieldOfView() { }

	// RVA: 0x2AFA1B0 Offset: 0x2AFA2B1 VA: 0x2AFA1B0
	public void set_fieldOfView(float value) { }

	// RVA: 0x2AFA200 Offset: 0x2AFA301 VA: 0x2AFA200
	public RenderingPath get_renderingPath() { }

	// RVA: 0x2AFA250 Offset: 0x2AFA351 VA: 0x2AFA250
	public void set_renderingPath(RenderingPath value) { }

	[NativeNameAttribute] // RVA: 0xCCD50 Offset: 0xCCE51 VA: 0xCCD50
	// RVA: 0x2AFA2A0 Offset: 0x2AFA3A1 VA: 0x2AFA2A0
	public RenderingPath get_actualRenderingPath() { }

	// RVA: 0x2AFA2F0 Offset: 0x2AFA3F1 VA: 0x2AFA2F0
	public void Reset() { }

	// RVA: 0x2AFA340 Offset: 0x2AFA441 VA: 0x2AFA340
	public bool get_allowHDR() { }

	// RVA: 0x2AFA390 Offset: 0x2AFA491 VA: 0x2AFA390
	public void set_allowHDR(bool value) { }

	// RVA: 0x2AFA3E0 Offset: 0x2AFA4E1 VA: 0x2AFA3E0
	public bool get_allowMSAA() { }

	// RVA: 0x2AFA430 Offset: 0x2AFA531 VA: 0x2AFA430
	public void set_allowMSAA(bool value) { }

	// RVA: 0x2AFA480 Offset: 0x2AFA581 VA: 0x2AFA480
	public bool get_allowDynamicResolution() { }

	// RVA: 0x2AFA4D0 Offset: 0x2AFA5D1 VA: 0x2AFA4D0
	public void set_allowDynamicResolution(bool value) { }

	// RVA: 0x2AFA520 Offset: 0x2AFA621 VA: 0x2AFA520
	public bool get_forceIntoRenderTexture() { }

	// RVA: 0x2AFA570 Offset: 0x2AFA671 VA: 0x2AFA570
	public void set_forceIntoRenderTexture(bool value) { }

	// RVA: 0x2AFA5C0 Offset: 0x2AFA6C1 VA: 0x2AFA5C0
	public float get_orthographicSize() { }

	// RVA: 0x2AFA610 Offset: 0x2AFA711 VA: 0x2AFA610
	public void set_orthographicSize(float value) { }

	// RVA: 0x2AFA660 Offset: 0x2AFA761 VA: 0x2AFA660
	public bool get_orthographic() { }

	// RVA: 0x2AFA6B0 Offset: 0x2AFA7B1 VA: 0x2AFA6B0
	public void set_orthographic(bool value) { }

	// RVA: 0x2AFA700 Offset: 0x2AFA801 VA: 0x2AFA700
	public OpaqueSortMode get_opaqueSortMode() { }

	// RVA: 0x2AFA750 Offset: 0x2AFA851 VA: 0x2AFA750
	public void set_opaqueSortMode(OpaqueSortMode value) { }

	// RVA: 0x2AFA7A0 Offset: 0x2AFA8A1 VA: 0x2AFA7A0
	public TransparencySortMode get_transparencySortMode() { }

	// RVA: 0x2AFA7F0 Offset: 0x2AFA8F1 VA: 0x2AFA7F0
	public void set_transparencySortMode(TransparencySortMode value) { }

	// RVA: 0x2AFA840 Offset: 0x2AFA941 VA: 0x2AFA840
	public Vector3 get_transparencySortAxis() { }

	// RVA: 0x2AFA8F0 Offset: 0x2AFA9F1 VA: 0x2AFA8F0
	public void set_transparencySortAxis(Vector3 value) { }

	// RVA: 0x2AFA9A0 Offset: 0x2AFAAA1 VA: 0x2AFA9A0
	public void ResetTransparencySortSettings() { }

	// RVA: 0x2AFA9F0 Offset: 0x2AFAAF1 VA: 0x2AFA9F0
	public float get_depth() { }

	// RVA: 0x2AFAA40 Offset: 0x2AFAB41 VA: 0x2AFAA40
	public void set_depth(float value) { }

	// RVA: 0x2AFAA90 Offset: 0x2AFAB91 VA: 0x2AFAA90
	public float get_aspect() { }

	// RVA: 0x2AFAAE0 Offset: 0x2AFABE1 VA: 0x2AFAAE0
	public void set_aspect(float value) { }

	// RVA: 0x2AFAB30 Offset: 0x2AFAC31 VA: 0x2AFAB30
	public void ResetAspect() { }

	// RVA: 0x2AFAB80 Offset: 0x2AFAC81 VA: 0x2AFAB80
	public Vector3 get_velocity() { }

	// RVA: 0x2AFAC30 Offset: 0x2AFAD31 VA: 0x2AFAC30
	public int get_cullingMask() { }

	// RVA: 0x2AFAC80 Offset: 0x2AFAD81 VA: 0x2AFAC80
	public void set_cullingMask(int value) { }

	// RVA: 0x2AFACD0 Offset: 0x2AFADD1 VA: 0x2AFACD0
	public int get_eventMask() { }

	// RVA: 0x2AFAD20 Offset: 0x2AFAE21 VA: 0x2AFAD20
	public void set_eventMask(int value) { }

	// RVA: 0x2AFAD70 Offset: 0x2AFAE71 VA: 0x2AFAD70
	public bool get_layerCullSpherical() { }

	// RVA: 0x2AFADC0 Offset: 0x2AFAEC1 VA: 0x2AFADC0
	public void set_layerCullSpherical(bool value) { }

	// RVA: 0x2AFAE10 Offset: 0x2AFAF11 VA: 0x2AFAE10
	public CameraType get_cameraType() { }

	// RVA: 0x2AFAE60 Offset: 0x2AFAF61 VA: 0x2AFAE60
	public void set_cameraType(CameraType value) { }

	// RVA: 0x2AFAEB0 Offset: 0x2AFAFB1 VA: 0x2AFAEB0
	public ulong get_overrideSceneCullingMask() { }

	// RVA: 0x2AFAF00 Offset: 0x2AFB001 VA: 0x2AFAF00
	public void set_overrideSceneCullingMask(ulong value) { }

	[FreeFunctionAttribute] // RVA: 0xCCD90 Offset: 0xCCE91 VA: 0xCCD90
	// RVA: 0x2AFAF50 Offset: 0x2AFB051 VA: 0x2AFAF50
	private float[] GetLayerCullDistances() { }

	[FreeFunctionAttribute] // RVA: 0xCCDE0 Offset: 0xCCEE1 VA: 0xCCDE0
	// RVA: 0x2AFAFA0 Offset: 0x2AFB0A1 VA: 0x2AFAFA0
	private void SetLayerCullDistances(float[] d) { }

	// RVA: 0x2AFAFF0 Offset: 0x2AFB0F1 VA: 0x2AFAFF0
	public float[] get_layerCullDistances() { }

	// RVA: 0x2AFB040 Offset: 0x2AFB141 VA: 0x2AFB040
	public void set_layerCullDistances(float[] value) { }

	[FreeFunctionAttribute] // RVA: 0xCCE30 Offset: 0xCCF31 VA: 0xCCE30
	// RVA: 0x2AFB110 Offset: 0x2AFB211 VA: 0x2AFB110
	internal static int get_PreviewCullingLayer() { }

	// RVA: 0x2AFB150 Offset: 0x2AFB251 VA: 0x2AFB150
	public bool get_useOcclusionCulling() { }

	// RVA: 0x2AFB1A0 Offset: 0x2AFB2A1 VA: 0x2AFB1A0
	public void set_useOcclusionCulling(bool value) { }

	// RVA: 0x2AFB1F0 Offset: 0x2AFB2F1 VA: 0x2AFB1F0
	public Matrix4x4 get_cullingMatrix() { }

	// RVA: 0x2AFB2D0 Offset: 0x2AFB3D1 VA: 0x2AFB2D0
	public void set_cullingMatrix(Matrix4x4 value) { }

	// RVA: 0x2AFB370 Offset: 0x2AFB471 VA: 0x2AFB370
	public void ResetCullingMatrix() { }

	// RVA: 0x2AFB3C0 Offset: 0x2AFB4C1 VA: 0x2AFB3C0
	public Color get_backgroundColor() { }

	// RVA: 0x2AFB470 Offset: 0x2AFB571 VA: 0x2AFB470
	public void set_backgroundColor(Color value) { }

	// RVA: 0x2AFB520 Offset: 0x2AFB621 VA: 0x2AFB520
	public CameraClearFlags get_clearFlags() { }

	// RVA: 0x2AFB570 Offset: 0x2AFB671 VA: 0x2AFB570
	public void set_clearFlags(CameraClearFlags value) { }

	// RVA: 0x2AFB5C0 Offset: 0x2AFB6C1 VA: 0x2AFB5C0
	public DepthTextureMode get_depthTextureMode() { }

	// RVA: 0x2AFB610 Offset: 0x2AFB711 VA: 0x2AFB610
	public void set_depthTextureMode(DepthTextureMode value) { }

	// RVA: 0x2AFB660 Offset: 0x2AFB761 VA: 0x2AFB660
	public bool get_clearStencilAfterLightingPass() { }

	// RVA: 0x2AFB6B0 Offset: 0x2AFB7B1 VA: 0x2AFB6B0
	public void set_clearStencilAfterLightingPass(bool value) { }

	// RVA: 0x2AFB700 Offset: 0x2AFB801 VA: 0x2AFB700
	public void SetReplacementShader(Shader shader, string replacementTag) { }

	// RVA: 0x2AFB760 Offset: 0x2AFB861 VA: 0x2AFB760
	public void ResetReplacementShader() { }

	// RVA: 0x2AFB7B0 Offset: 0x2AFB8B1 VA: 0x2AFB7B0
	internal Camera.ProjectionMatrixMode get_projectionMatrixMode() { }

	// RVA: 0x2AFB800 Offset: 0x2AFB901 VA: 0x2AFB800
	public bool get_usePhysicalProperties() { }

	// RVA: 0x2AFB850 Offset: 0x2AFB951 VA: 0x2AFB850
	public void set_usePhysicalProperties(bool value) { }

	// RVA: 0x2AFB8A0 Offset: 0x2AFB9A1 VA: 0x2AFB8A0
	public Vector2 get_sensorSize() { }

	// RVA: 0x2AFB950 Offset: 0x2AFBA51 VA: 0x2AFB950
	public void set_sensorSize(Vector2 value) { }

	// RVA: 0x2AFBA00 Offset: 0x2AFBB01 VA: 0x2AFBA00
	public Vector2 get_lensShift() { }

	// RVA: 0x2AFBAB0 Offset: 0x2AFBBB1 VA: 0x2AFBAB0
	public void set_lensShift(Vector2 value) { }

	// RVA: 0x2AFBB60 Offset: 0x2AFBC61 VA: 0x2AFBB60
	public float get_focalLength() { }

	// RVA: 0x2AFBBB0 Offset: 0x2AFBCB1 VA: 0x2AFBBB0
	public void set_focalLength(float value) { }

	// RVA: 0x2AFBC00 Offset: 0x2AFBD01 VA: 0x2AFBC00
	public Camera.GateFitMode get_gateFit() { }

	// RVA: 0x2AFBC50 Offset: 0x2AFBD51 VA: 0x2AFBC50
	public void set_gateFit(Camera.GateFitMode value) { }

	// RVA: 0x2AFBCA0 Offset: 0x2AFBDA1 VA: 0x2AFBCA0
	public float GetGateFittedFieldOfView() { }

	// RVA: 0x2AFBCF0 Offset: 0x2AFBDF1 VA: 0x2AFBCF0
	public Vector2 GetGateFittedLensShift() { }

	// RVA: 0x2AFBDA0 Offset: 0x2AFBEA1 VA: 0x2AFBDA0
	internal Vector3 GetLocalSpaceAim() { }

	// RVA: 0x2AFBE50 Offset: 0x2AFBF51 VA: 0x2AFBE50
	public Rect get_rect() { }

	// RVA: 0x2AFBF00 Offset: 0x2AFC001 VA: 0x2AFBF00
	public void set_rect(Rect value) { }

	// RVA: 0x2AFBFB0 Offset: 0x2AFC0B1 VA: 0x2AFBFB0
	public Rect get_pixelRect() { }

	// RVA: 0x2AFC060 Offset: 0x2AFC161 VA: 0x2AFC060
	public void set_pixelRect(Rect value) { }

	[FreeFunctionAttribute] // RVA: 0xCCE70 Offset: 0xCCF71 VA: 0xCCE70
	// RVA: 0x2AFC110 Offset: 0x2AFC211 VA: 0x2AFC110
	public int get_pixelWidth() { }

	[FreeFunctionAttribute] // RVA: 0xCCEC0 Offset: 0xCCFC1 VA: 0xCCEC0
	// RVA: 0x2AFC160 Offset: 0x2AFC261 VA: 0x2AFC160
	public int get_pixelHeight() { }

	[FreeFunctionAttribute] // RVA: 0xCCF10 Offset: 0xCD011 VA: 0xCCF10
	// RVA: 0x2AFC1B0 Offset: 0x2AFC2B1 VA: 0x2AFC1B0
	public int get_scaledPixelWidth() { }

	[FreeFunctionAttribute] // RVA: 0xCCF60 Offset: 0xCD061 VA: 0xCCF60
	// RVA: 0x2AFC200 Offset: 0x2AFC301 VA: 0x2AFC200
	public int get_scaledPixelHeight() { }

	// RVA: 0x2AFC250 Offset: 0x2AFC351 VA: 0x2AFC250
	public RenderTexture get_targetTexture() { }

	// RVA: 0x2AFC2A0 Offset: 0x2AFC3A1 VA: 0x2AFC2A0
	public void set_targetTexture(RenderTexture value) { }

	[NativeNameAttribute] // RVA: 0xCCFB0 Offset: 0xCD0B1 VA: 0xCCFB0
	// RVA: 0x2AFC2F0 Offset: 0x2AFC3F1 VA: 0x2AFC2F0
	public RenderTexture get_activeTexture() { }

	// RVA: 0x2AFC340 Offset: 0x2AFC441 VA: 0x2AFC340
	public int get_targetDisplay() { }

	// RVA: 0x2AFC390 Offset: 0x2AFC491 VA: 0x2AFC390
	public void set_targetDisplay(int value) { }

	[FreeFunctionAttribute] // RVA: 0xCCFF0 Offset: 0xCD0F1 VA: 0xCCFF0
	// RVA: 0x2AFC3E0 Offset: 0x2AFC4E1 VA: 0x2AFC3E0
	private void SetTargetBuffersImpl(RenderBuffer color, RenderBuffer depth) { }

	// RVA: 0x2AFC4A0 Offset: 0x2AFC5A1 VA: 0x2AFC4A0
	public void SetTargetBuffers(RenderBuffer colorBuffer, RenderBuffer depthBuffer) { }

	[FreeFunctionAttribute] // RVA: 0xCD040 Offset: 0xCD141 VA: 0xCD040
	// RVA: 0x2AFC500 Offset: 0x2AFC601 VA: 0x2AFC500
	private void SetTargetBuffersMRTImpl(RenderBuffer[] color, RenderBuffer depth) { }

	// RVA: 0x2AFC5D0 Offset: 0x2AFC6D1 VA: 0x2AFC5D0
	public void SetTargetBuffers(RenderBuffer[] colorBuffer, RenderBuffer depthBuffer) { }

	// RVA: 0x2AFC640 Offset: 0x2AFC741 VA: 0x2AFC640
	internal string[] GetCameraBufferWarnings() { }

	// RVA: 0x2AFC690 Offset: 0x2AFC791 VA: 0x2AFC690
	public Matrix4x4 get_cameraToWorldMatrix() { }

	// RVA: 0x2AFC770 Offset: 0x2AFC871 VA: 0x2AFC770
	public Matrix4x4 get_worldToCameraMatrix() { }

	// RVA: 0x2AFC850 Offset: 0x2AFC951 VA: 0x2AFC850
	public void set_worldToCameraMatrix(Matrix4x4 value) { }

	// RVA: 0x2AFC8F0 Offset: 0x2AFC9F1 VA: 0x2AFC8F0
	public Matrix4x4 get_projectionMatrix() { }

	// RVA: 0x2AFC9D0 Offset: 0x2AFCAD1 VA: 0x2AFC9D0
	public void set_projectionMatrix(Matrix4x4 value) { }

	// RVA: 0x2AFCA70 Offset: 0x2AFCB71 VA: 0x2AFCA70
	public Matrix4x4 get_nonJitteredProjectionMatrix() { }

	// RVA: 0x2AFCB50 Offset: 0x2AFCC51 VA: 0x2AFCB50
	public void set_nonJitteredProjectionMatrix(Matrix4x4 value) { }

	// RVA: 0x2AFCBF0 Offset: 0x2AFCCF1 VA: 0x2AFCBF0
	public bool get_useJitteredProjectionMatrixForTransparentRendering() { }

	// RVA: 0x2AFCC40 Offset: 0x2AFCD41 VA: 0x2AFCC40
	public void set_useJitteredProjectionMatrixForTransparentRendering(bool value) { }

	// RVA: 0x2AFCC90 Offset: 0x2AFCD91 VA: 0x2AFCC90
	public Matrix4x4 get_previousViewProjectionMatrix() { }

	// RVA: 0x2AFCD70 Offset: 0x2AFCE71 VA: 0x2AFCD70
	public void ResetWorldToCameraMatrix() { }

	// RVA: 0x2AFCDC0 Offset: 0x2AFCEC1 VA: 0x2AFCDC0
	public void ResetProjectionMatrix() { }

	[FreeFunctionAttribute] // RVA: 0xCD090 Offset: 0xCD191 VA: 0xCD090
	// RVA: 0x2AFCE10 Offset: 0x2AFCF11 VA: 0x2AFCE10
	public Matrix4x4 CalculateObliqueMatrix(Vector4 clipPlane) { }

	// RVA: 0x2AFCF10 Offset: 0x2AFD011 VA: 0x2AFCF10
	public Vector3 WorldToScreenPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x2AFD000 Offset: 0x2AFD101 VA: 0x2AFD000
	public Vector3 WorldToViewportPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x2AFD0F0 Offset: 0x2AFD1F1 VA: 0x2AFD0F0
	public Vector3 ViewportToWorldPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x2AFD1E0 Offset: 0x2AFD2E1 VA: 0x2AFD1E0
	public Vector3 ScreenToWorldPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x2AFD2D0 Offset: 0x2AFD3D1 VA: 0x2AFD2D0
	public Vector3 WorldToScreenPoint(Vector3 position) { }

	// RVA: 0x2AFD340 Offset: 0x2AFD441 VA: 0x2AFD340
	public Vector3 WorldToViewportPoint(Vector3 position) { }

	// RVA: 0x2AFD3B0 Offset: 0x2AFD4B1 VA: 0x2AFD3B0
	public Vector3 ViewportToWorldPoint(Vector3 position) { }

	// RVA: 0x2AFD420 Offset: 0x2AFD521 VA: 0x2AFD420
	public Vector3 ScreenToWorldPoint(Vector3 position) { }

	// RVA: 0x2AFD490 Offset: 0x2AFD591 VA: 0x2AFD490
	public Vector3 ScreenToViewportPoint(Vector3 position) { }

	// RVA: 0x2AFD560 Offset: 0x2AFD661 VA: 0x2AFD560
	public Vector3 ViewportToScreenPoint(Vector3 position) { }

	// RVA: 0x2AFD630 Offset: 0x2AFD731 VA: 0x2AFD630
	internal Vector2 GetFrustumPlaneSizeAt(float distance) { }

	// RVA: 0x2AFD6F0 Offset: 0x2AFD7F1 VA: 0x2AFD6F0
	private Ray ViewportPointToRay(Vector2 pos, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x2AFD7F0 Offset: 0x2AFD8F1 VA: 0x2AFD7F0
	public Ray ViewportPointToRay(Vector3 pos, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x2AFD910 Offset: 0x2AFDA11 VA: 0x2AFD910
	public Ray ViewportPointToRay(Vector3 pos) { }

	// RVA: 0x2AFD960 Offset: 0x2AFDA61 VA: 0x2AFD960
	private Ray ScreenPointToRay(Vector2 pos, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x2AFDA60 Offset: 0x2AFDB61 VA: 0x2AFDA60
	public Ray ScreenPointToRay(Vector3 pos, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x2AFDB80 Offset: 0x2AFDC81 VA: 0x2AFDB80
	public Ray ScreenPointToRay(Vector3 pos) { }

	[FreeFunctionAttribute] // RVA: 0xCD0E0 Offset: 0xCD1E1 VA: 0xCD0E0
	// RVA: 0x2AFDBD0 Offset: 0x2AFDCD1 VA: 0x2AFDBD0
	private void CalculateFrustumCornersInternal(Rect viewport, float z, Camera.MonoOrStereoscopicEye eye, [Out] Vector3[] outCorners) { }

	// RVA: 0x2AFDCD0 Offset: 0x2AFDDD1 VA: 0x2AFDCD0
	public void CalculateFrustumCorners(Rect viewport, float z, Camera.MonoOrStereoscopicEye eye, Vector3[] outCorners) { }

	[NativeNameAttribute] // RVA: 0xCD130 Offset: 0xCD231 VA: 0xCD130
	// RVA: 0x2AFDE20 Offset: 0x2AFDF21 VA: 0x2AFDE20
	private static void CalculateProjectionMatrixFromPhysicalPropertiesInternal(out Matrix4x4 output, float focalLength, Vector2 sensorSize, Vector2 lensShift, float nearClip, float farClip, float gateAspect, Camera.GateFitMode gateFitMode) { }

	// RVA: 0x2AFDF60 Offset: 0x2AFE061 VA: 0x2AFDF60
	public static void CalculateProjectionMatrixFromPhysicalProperties(out Matrix4x4 output, float focalLength, Vector2 sensorSize, Vector2 lensShift, float nearClip, float farClip, Camera.GateFitParameters gateFitParameters) { }

	[NativeNameAttribute] // RVA: 0xCD170 Offset: 0xCD271 VA: 0xCD170
	// RVA: 0x2AFE000 Offset: 0x2AFE101 VA: 0x2AFE000
	public static float FocalLengthToFieldOfView(float focalLength, float sensorSize) { }

	[NativeNameAttribute] // RVA: 0xCD1B0 Offset: 0xCD2B1 VA: 0xCD1B0
	// RVA: 0x2AFE050 Offset: 0x2AFE151 VA: 0x2AFE050
	public static float FieldOfViewToFocalLength(float fieldOfView, float sensorSize) { }

	[NativeNameAttribute] // RVA: 0xCD1F0 Offset: 0xCD2F1 VA: 0xCD1F0
	// RVA: 0x2AFE0A0 Offset: 0x2AFE1A1 VA: 0x2AFE0A0
	public static float HorizontalToVerticalFieldOfView(float horizontalFieldOfView, float aspectRatio) { }

	// RVA: 0x2AFE0F0 Offset: 0x2AFE1F1 VA: 0x2AFE0F0
	public static float VerticalToHorizontalFieldOfView(float verticalFieldOfView, float aspectRatio) { }

	[FreeFunctionAttribute] // RVA: 0xCD230 Offset: 0xCD331 VA: 0xCD230
	// RVA: 0x2AFE140 Offset: 0x2AFE241 VA: 0x2AFE140
	public static Camera get_main() { }

	[FreeFunctionAttribute] // RVA: 0xCD270 Offset: 0xCD371 VA: 0xCD270
	// RVA: 0x2AFE180 Offset: 0x2AFE281 VA: 0x2AFE180
	public static Camera get_current() { }

	[FreeFunctionAttribute] // RVA: 0xCD2B0 Offset: 0xCD3B1 VA: 0xCD2B0
	// RVA: 0x2AFE1C0 Offset: 0x2AFE2C1 VA: 0x2AFE1C0
	public Scene get_scene() { }

	[FreeFunctionAttribute] // RVA: 0xCD300 Offset: 0xCD401 VA: 0xCD300
	// RVA: 0x2AFE270 Offset: 0x2AFE371 VA: 0x2AFE270
	public void set_scene(Scene value) { }

	// RVA: 0x2AFE320 Offset: 0x2AFE421 VA: 0x2AFE320
	public bool get_stereoEnabled() { }

	// RVA: 0x2AFE370 Offset: 0x2AFE471 VA: 0x2AFE370
	public float get_stereoSeparation() { }

	// RVA: 0x2AFE3C0 Offset: 0x2AFE4C1 VA: 0x2AFE3C0
	public void set_stereoSeparation(float value) { }

	// RVA: 0x2AFE410 Offset: 0x2AFE511 VA: 0x2AFE410
	public float get_stereoConvergence() { }

	// RVA: 0x2AFE460 Offset: 0x2AFE561 VA: 0x2AFE460
	public void set_stereoConvergence(float value) { }

	[NativeNameAttribute] // RVA: 0xCD350 Offset: 0xCD451 VA: 0xCD350
	// RVA: 0x2AFE4B0 Offset: 0x2AFE5B1 VA: 0x2AFE4B0
	public bool get_areVRStereoViewMatricesWithinSingleCullTolerance() { }

	// RVA: 0x2AFE500 Offset: 0x2AFE601 VA: 0x2AFE500
	public StereoTargetEyeMask get_stereoTargetEye() { }

	// RVA: 0x2AFE550 Offset: 0x2AFE651 VA: 0x2AFE550
	public void set_stereoTargetEye(StereoTargetEyeMask value) { }

	[FreeFunctionAttribute] // RVA: 0xCD390 Offset: 0xCD491 VA: 0xCD390
	// RVA: 0x2AFE5A0 Offset: 0x2AFE6A1 VA: 0x2AFE5A0
	public Camera.MonoOrStereoscopicEye get_stereoActiveEye() { }

	// RVA: 0x2AFE5F0 Offset: 0x2AFE6F1 VA: 0x2AFE5F0
	public Matrix4x4 GetStereoNonJitteredProjectionMatrix(Camera.StereoscopicEye eye) { }

	[FreeFunctionAttribute] // RVA: 0xCD3E0 Offset: 0xCD4E1 VA: 0xCD3E0
	// RVA: 0x2AFE6F0 Offset: 0x2AFE7F1 VA: 0x2AFE6F0
	public Matrix4x4 GetStereoViewMatrix(Camera.StereoscopicEye eye) { }

	// RVA: 0x2AFE7F0 Offset: 0x2AFE8F1 VA: 0x2AFE7F0
	public void CopyStereoDeviceProjectionMatrixToNonJittered(Camera.StereoscopicEye eye) { }

	[FreeFunctionAttribute] // RVA: 0xCD430 Offset: 0xCD531 VA: 0xCD430
	// RVA: 0x2AFE840 Offset: 0x2AFE941 VA: 0x2AFE840
	public Matrix4x4 GetStereoProjectionMatrix(Camera.StereoscopicEye eye) { }

	// RVA: 0x2AFE940 Offset: 0x2AFEA41 VA: 0x2AFE940
	public void SetStereoProjectionMatrix(Camera.StereoscopicEye eye, Matrix4x4 matrix) { }

	// RVA: 0x2AFEA00 Offset: 0x2AFEB01 VA: 0x2AFEA00
	public void ResetStereoProjectionMatrices() { }

	// RVA: 0x2AFEA50 Offset: 0x2AFEB51 VA: 0x2AFEA50
	public void SetStereoViewMatrix(Camera.StereoscopicEye eye, Matrix4x4 matrix) { }

	// RVA: 0x2AFEB10 Offset: 0x2AFEC11 VA: 0x2AFEB10
	public void ResetStereoViewMatrices() { }

	[FreeFunctionAttribute] // RVA: 0xCD480 Offset: 0xCD581 VA: 0xCD480
	// RVA: 0x2AFEB60 Offset: 0x2AFEC61 VA: 0x2AFEB60
	private static int GetAllCamerasCount() { }

	[FreeFunctionAttribute] // RVA: 0xCD4C0 Offset: 0xCD5C1 VA: 0xCD4C0
	// RVA: 0x2AFEBA0 Offset: 0x2AFECA1 VA: 0x2AFEBA0
	private static int GetAllCamerasImpl([Out] Camera[] cam) { }

	// RVA: 0x2AFEBF0 Offset: 0x2AFECF1 VA: 0x2AFEBF0
	public static int get_allCamerasCount() { }

	// RVA: 0x2AFEC30 Offset: 0x2AFED31 VA: 0x2AFEC30
	public static Camera[] get_allCameras() { }

	// RVA: 0x2AFECE0 Offset: 0x2AFEDE1 VA: 0x2AFECE0
	public static int GetAllCameras(Camera[] cameras) { }

	[FreeFunctionAttribute] // RVA: 0xCD500 Offset: 0xCD601 VA: 0xCD500
	// RVA: 0x2AFEDF0 Offset: 0x2AFEEF1 VA: 0x2AFEDF0
	private bool RenderToCubemapImpl(Texture tex, int faceMask) { }

	// RVA: 0x2AFEE50 Offset: 0x2AFEF51 VA: 0x2AFEE50
	public bool RenderToCubemap(Cubemap cubemap, int faceMask) { }

	// RVA: 0x2AFEEB0 Offset: 0x2AFEFB1 VA: 0x2AFEEB0
	public bool RenderToCubemap(Cubemap cubemap) { }

	// RVA: 0x2AFEF10 Offset: 0x2AFF011 VA: 0x2AFEF10
	public bool RenderToCubemap(RenderTexture cubemap, int faceMask) { }

	// RVA: 0x2AFEF70 Offset: 0x2AFF071 VA: 0x2AFEF70
	public bool RenderToCubemap(RenderTexture cubemap) { }

	[NativeNameAttribute] // RVA: 0xCD550 Offset: 0xCD651 VA: 0xCD550
	// RVA: 0x2AFEFD0 Offset: 0x2AFF0D1 VA: 0x2AFEFD0
	private bool RenderToCubemapEyeImpl(RenderTexture cubemap, int faceMask, Camera.MonoOrStereoscopicEye stereoEye) { }

	// RVA: 0x2AFF040 Offset: 0x2AFF141 VA: 0x2AFF040
	public bool RenderToCubemap(RenderTexture cubemap, int faceMask, Camera.MonoOrStereoscopicEye stereoEye) { }

	[FreeFunctionAttribute] // RVA: 0xCD590 Offset: 0xCD691 VA: 0xCD590
	// RVA: 0x2AFF0B0 Offset: 0x2AFF1B1 VA: 0x2AFF0B0
	public void Render() { }

	[FreeFunctionAttribute] // RVA: 0xCD5E0 Offset: 0xCD6E1 VA: 0xCD5E0
	// RVA: 0x2AFF100 Offset: 0x2AFF201 VA: 0x2AFF100
	public void RenderWithShader(Shader shader, string replacementTag) { }

	[FreeFunctionAttribute] // RVA: 0xCD630 Offset: 0xCD731 VA: 0xCD630
	// RVA: 0x2AFF160 Offset: 0x2AFF261 VA: 0x2AFF160
	public void RenderDontRestore() { }

	[FreeFunctionAttribute] // RVA: 0xCD680 Offset: 0xCD781 VA: 0xCD680
	// RVA: 0x2AFF1B0 Offset: 0x2AFF2B1 VA: 0x2AFF1B0
	public static void SetupCurrent(Camera cur) { }

	[FreeFunctionAttribute] // RVA: 0xCD6C0 Offset: 0xCD7C1 VA: 0xCD6C0
	// RVA: 0x2AFF200 Offset: 0x2AFF301 VA: 0x2AFF200
	public void CopyFrom(Camera other) { }

	// RVA: 0x2AFF250 Offset: 0x2AFF351 VA: 0x2AFF250
	public int get_commandBufferCount() { }

	// RVA: 0x2AFF2A0 Offset: 0x2AFF3A1 VA: 0x2AFF2A0
	public void RemoveCommandBuffers(CameraEvent evt) { }

	// RVA: 0x2AFF2F0 Offset: 0x2AFF3F1 VA: 0x2AFF2F0
	public void RemoveAllCommandBuffers() { }

	[NativeNameAttribute] // RVA: 0xCD710 Offset: 0xCD811 VA: 0xCD710
	// RVA: 0x2AFF340 Offset: 0x2AFF441 VA: 0x2AFF340
	private void AddCommandBufferImpl(CameraEvent evt, CommandBuffer buffer) { }

	[NativeNameAttribute] // RVA: 0xCD750 Offset: 0xCD851 VA: 0xCD750
	// RVA: 0x2AFF3A0 Offset: 0x2AFF4A1 VA: 0x2AFF3A0
	private void AddCommandBufferAsyncImpl(CameraEvent evt, CommandBuffer buffer, ComputeQueueType queueType) { }

	[NativeNameAttribute] // RVA: 0xCD790 Offset: 0xCD891 VA: 0xCD790
	// RVA: 0x2AFF410 Offset: 0x2AFF511 VA: 0x2AFF410
	private void RemoveCommandBufferImpl(CameraEvent evt, CommandBuffer buffer) { }

	// RVA: 0x2AFF470 Offset: 0x2AFF571 VA: 0x2AFF470
	public void AddCommandBuffer(CameraEvent evt, CommandBuffer buffer) { }

	// RVA: 0x2AFF5C0 Offset: 0x2AFF6C1 VA: 0x2AFF5C0
	public void AddCommandBufferAsync(CameraEvent evt, CommandBuffer buffer, ComputeQueueType queueType) { }

	// RVA: 0x2AFF710 Offset: 0x2AFF811 VA: 0x2AFF710
	public void RemoveCommandBuffer(CameraEvent evt, CommandBuffer buffer) { }

	[FreeFunctionAttribute] // RVA: 0xCD7D0 Offset: 0xCD8D1 VA: 0xCD7D0
	// RVA: 0x2AFF860 Offset: 0x2AFF961 VA: 0x2AFF860
	public CommandBuffer[] GetCommandBuffers(CameraEvent evt) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xCD820 Offset: 0xCD921 VA: 0xCD820
	// RVA: 0x2AFF8B0 Offset: 0x2AFF9B1 VA: 0x2AFF8B0
	private static void FireOnPreCull(Camera cam) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xCD830 Offset: 0xCD931 VA: 0xCD830
	// RVA: 0x2AFFCF0 Offset: 0x2AFFDF1 VA: 0x2AFFCF0
	private static void FireOnPreRender(Camera cam) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xCD840 Offset: 0xCD941 VA: 0xCD840
	// RVA: 0x2AFFD60 Offset: 0x2AFFE61 VA: 0x2AFFD60
	private static void FireOnPostRender(Camera cam) { }

	// RVA: 0x2AFFDD0 Offset: 0x2AFFED1 VA: 0x2AFFDD0
	internal void OnlyUsedForTesting1() { }

	// RVA: 0x2AFFDE0 Offset: 0x2AFFEE1 VA: 0x2AFFDE0
	internal void OnlyUsedForTesting2() { }

	// RVA: 0x2AFFDF0 Offset: 0x2AFFEF1 VA: 0x2AFFDF0
	public bool TryGetCullingParameters(out ScriptableCullingParameters cullingParameters) { }

	// RVA: 0x2AFFEC0 Offset: 0x2AFFFC1 VA: 0x2AFFEC0
	public bool TryGetCullingParameters(bool stereoAware, out ScriptableCullingParameters cullingParameters) { }

	[FreeFunctionAttribute] // RVA: 0xCD850 Offset: 0xCD951 VA: 0xCD850
	[NativeHeaderAttribute] // RVA: 0xCD850 Offset: 0xCD951 VA: 0xCD850
	// RVA: 0x2AFFE50 Offset: 0x2AFFF51 VA: 0x2AFFE50
	private static bool GetCullingParameters_Internal(Camera camera, bool stereoAware, out ScriptableCullingParameters cullingParameters, int managedCullingParametersSize) { }

	// RVA: 0x2AFFF20 Offset: 0x2B00021 VA: 0x2AFFF20
	public void .ctor() { }

	// RVA: 0x2AFA8A0 Offset: 0x2AFA9A1 VA: 0x2AFA8A0
	private void get_transparencySortAxis_Injected(out Vector3 ret) { }

	// RVA: 0x2AFA950 Offset: 0x2AFAA51 VA: 0x2AFA950
	private void set_transparencySortAxis_Injected(ref Vector3 value) { }

	// RVA: 0x2AFABE0 Offset: 0x2AFACE1 VA: 0x2AFABE0
	private void get_velocity_Injected(out Vector3 ret) { }

	// RVA: 0x2AFB280 Offset: 0x2AFB381 VA: 0x2AFB280
	private void get_cullingMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x2AFB320 Offset: 0x2AFB421 VA: 0x2AFB320
	private void set_cullingMatrix_Injected(ref Matrix4x4 value) { }

	// RVA: 0x2AFB420 Offset: 0x2AFB521 VA: 0x2AFB420
	private void get_backgroundColor_Injected(out Color ret) { }

	// RVA: 0x2AFB4D0 Offset: 0x2AFB5D1 VA: 0x2AFB4D0
	private void set_backgroundColor_Injected(ref Color value) { }

	// RVA: 0x2AFB900 Offset: 0x2AFBA01 VA: 0x2AFB900
	private void get_sensorSize_Injected(out Vector2 ret) { }

	// RVA: 0x2AFB9B0 Offset: 0x2AFBAB1 VA: 0x2AFB9B0
	private void set_sensorSize_Injected(ref Vector2 value) { }

	// RVA: 0x2AFBA60 Offset: 0x2AFBB61 VA: 0x2AFBA60
	private void get_lensShift_Injected(out Vector2 ret) { }

	// RVA: 0x2AFBB10 Offset: 0x2AFBC11 VA: 0x2AFBB10
	private void set_lensShift_Injected(ref Vector2 value) { }

	// RVA: 0x2AFBD50 Offset: 0x2AFBE51 VA: 0x2AFBD50
	private void GetGateFittedLensShift_Injected(out Vector2 ret) { }

	// RVA: 0x2AFBE00 Offset: 0x2AFBF01 VA: 0x2AFBE00
	private void GetLocalSpaceAim_Injected(out Vector3 ret) { }

	// RVA: 0x2AFBEB0 Offset: 0x2AFBFB1 VA: 0x2AFBEB0
	private void get_rect_Injected(out Rect ret) { }

	// RVA: 0x2AFBF60 Offset: 0x2AFC061 VA: 0x2AFBF60
	private void set_rect_Injected(ref Rect value) { }

	// RVA: 0x2AFC010 Offset: 0x2AFC111 VA: 0x2AFC010
	private void get_pixelRect_Injected(out Rect ret) { }

	// RVA: 0x2AFC0C0 Offset: 0x2AFC1C1 VA: 0x2AFC0C0
	private void set_pixelRect_Injected(ref Rect value) { }

	// RVA: 0x2AFC440 Offset: 0x2AFC541 VA: 0x2AFC440
	private void SetTargetBuffersImpl_Injected(ref RenderBuffer color, ref RenderBuffer depth) { }

	// RVA: 0x2AFC570 Offset: 0x2AFC671 VA: 0x2AFC570
	private void SetTargetBuffersMRTImpl_Injected(RenderBuffer[] color, ref RenderBuffer depth) { }

	// RVA: 0x2AFC720 Offset: 0x2AFC821 VA: 0x2AFC720
	private void get_cameraToWorldMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x2AFC800 Offset: 0x2AFC901 VA: 0x2AFC800
	private void get_worldToCameraMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x2AFC8A0 Offset: 0x2AFC9A1 VA: 0x2AFC8A0
	private void set_worldToCameraMatrix_Injected(ref Matrix4x4 value) { }

	// RVA: 0x2AFC980 Offset: 0x2AFCA81 VA: 0x2AFC980
	private void get_projectionMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x2AFCA20 Offset: 0x2AFCB21 VA: 0x2AFCA20
	private void set_projectionMatrix_Injected(ref Matrix4x4 value) { }

	// RVA: 0x2AFCB00 Offset: 0x2AFCC01 VA: 0x2AFCB00
	private void get_nonJitteredProjectionMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x2AFCBA0 Offset: 0x2AFCCA1 VA: 0x2AFCBA0
	private void set_nonJitteredProjectionMatrix_Injected(ref Matrix4x4 value) { }

	// RVA: 0x2AFCD20 Offset: 0x2AFCE21 VA: 0x2AFCD20
	private void get_previousViewProjectionMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x2AFCEB0 Offset: 0x2AFCFB1 VA: 0x2AFCEB0
	private void CalculateObliqueMatrix_Injected(ref Vector4 clipPlane, out Matrix4x4 ret) { }

	// RVA: 0x2AFCF90 Offset: 0x2AFD091 VA: 0x2AFCF90
	private void WorldToScreenPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret) { }

	// RVA: 0x2AFD080 Offset: 0x2AFD181 VA: 0x2AFD080
	private void WorldToViewportPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret) { }

	// RVA: 0x2AFD170 Offset: 0x2AFD271 VA: 0x2AFD170
	private void ViewportToWorldPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret) { }

	// RVA: 0x2AFD260 Offset: 0x2AFD361 VA: 0x2AFD260
	private void ScreenToWorldPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret) { }

	// RVA: 0x2AFD500 Offset: 0x2AFD601 VA: 0x2AFD500
	private void ScreenToViewportPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x2AFD5D0 Offset: 0x2AFD6D1 VA: 0x2AFD5D0
	private void ViewportToScreenPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x2AFD690 Offset: 0x2AFD791 VA: 0x2AFD690
	private void GetFrustumPlaneSizeAt_Injected(float distance, out Vector2 ret) { }

	// RVA: 0x2AFD780 Offset: 0x2AFD881 VA: 0x2AFD780
	private void ViewportPointToRay_Injected(ref Vector2 pos, Camera.MonoOrStereoscopicEye eye, out Ray ret) { }

	// RVA: 0x2AFD9F0 Offset: 0x2AFDAF1 VA: 0x2AFD9F0
	private void ScreenPointToRay_Injected(ref Vector2 pos, Camera.MonoOrStereoscopicEye eye, out Ray ret) { }

	// RVA: 0x2AFDC50 Offset: 0x2AFDD51 VA: 0x2AFDC50
	private void CalculateFrustumCornersInternal_Injected(ref Rect viewport, float z, Camera.MonoOrStereoscopicEye eye, [Out] Vector3[] outCorners) { }

	// RVA: 0x2AFDEC0 Offset: 0x2AFDFC1 VA: 0x2AFDEC0
	private static void CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected(out Matrix4x4 output, float focalLength, ref Vector2 sensorSize, ref Vector2 lensShift, float nearClip, float farClip, float gateAspect, Camera.GateFitMode gateFitMode) { }

	// RVA: 0x2AFE220 Offset: 0x2AFE321 VA: 0x2AFE220
	private void get_scene_Injected(out Scene ret) { }

	// RVA: 0x2AFE2D0 Offset: 0x2AFE3D1 VA: 0x2AFE2D0
	private void set_scene_Injected(ref Scene value) { }

	// RVA: 0x2AFE690 Offset: 0x2AFE791 VA: 0x2AFE690
	private void GetStereoNonJitteredProjectionMatrix_Injected(Camera.StereoscopicEye eye, out Matrix4x4 ret) { }

	// RVA: 0x2AFE790 Offset: 0x2AFE891 VA: 0x2AFE790
	private void GetStereoViewMatrix_Injected(Camera.StereoscopicEye eye, out Matrix4x4 ret) { }

	// RVA: 0x2AFE8E0 Offset: 0x2AFE9E1 VA: 0x2AFE8E0
	private void GetStereoProjectionMatrix_Injected(Camera.StereoscopicEye eye, out Matrix4x4 ret) { }

	// RVA: 0x2AFE9A0 Offset: 0x2AFEAA1 VA: 0x2AFE9A0
	private void SetStereoProjectionMatrix_Injected(Camera.StereoscopicEye eye, ref Matrix4x4 matrix) { }

	// RVA: 0x2AFEAB0 Offset: 0x2AFEBB1 VA: 0x2AFEAB0
	private void SetStereoViewMatrix_Injected(Camera.StereoscopicEye eye, ref Matrix4x4 matrix) { }
}

