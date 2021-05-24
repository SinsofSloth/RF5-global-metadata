[RequireComponent] // RVA: 0xC5450 Offset: 0xC5551 VA: 0xC5450
[RequireComponent] // RVA: 0xC5450 Offset: 0xC5551 VA: 0xC5450
[NativeHeaderAttribute] // RVA: 0xC5450 Offset: 0xC5551 VA: 0xC5450
[NativeHeaderAttribute] // RVA: 0xC5450 Offset: 0xC5551 VA: 0xC5450
public sealed class Light : Behaviour // TypeDefIndex: 2896
{
	// Fields
	private int m_BakedIndex; // 0x18

	// Properties
	[NativePropertyAttribute] // RVA: 0xDE870 Offset: 0xDE971 VA: 0xDE870
	public LightType type { get; set; }
	[NativePropertyAttribute] // RVA: 0xDE8B0 Offset: 0xDE9B1 VA: 0xDE8B0
	public LightShape shape { get; set; }
	public float spotAngle { get; set; }
	public float innerSpotAngle { get; set; }
	public Color color { get; set; }
	public float colorTemperature { get; set; }
	public bool useColorTemperature { get; set; }
	public float intensity { get; set; }
	public float bounceIntensity { get; set; }
	public bool useBoundingSphereOverride { get; set; }
	public Vector4 boundingSphereOverride { get; set; }
	public int shadowCustomResolution { get; set; }
	public float shadowBias { get; set; }
	public float shadowNormalBias { get; set; }
	public float shadowNearPlane { get; set; }
	public bool useShadowMatrixOverride { get; set; }
	public Matrix4x4 shadowMatrixOverride { get; set; }
	public float range { get; set; }
	public Flare flare { get; set; }
	public LightBakingOutput bakingOutput { get; set; }
	public int cullingMask { get; set; }
	public int renderingLayerMask { get; set; }
	public LightShadowCasterMode lightShadowCasterMode { get; set; }
	public LightShadows shadows { get; set; }
	public float shadowStrength { get; set; }
	public LightShadowResolution shadowResolution { get; set; }
	[ObsoleteAttribute] // RVA: 0xDE8F0 Offset: 0xDE9F1 VA: 0xDE8F0
	[EditorBrowsableAttribute] // RVA: 0xDE8F0 Offset: 0xDE9F1 VA: 0xDE8F0
	public float shadowSoftness { get; set; }
	[EditorBrowsableAttribute] // RVA: 0xDE950 Offset: 0xDEA51 VA: 0xDE950
	[ObsoleteAttribute] // RVA: 0xDE950 Offset: 0xDEA51 VA: 0xDE950
	public float shadowSoftnessFade { get; set; }
	public float[] layerShadowCullDistances { get; set; }
	public float cookieSize { get; set; }
	public Texture cookie { get; set; }
	public LightRenderMode renderMode { get; set; }
	[EditorBrowsableAttribute] // RVA: 0xDE9B0 Offset: 0xDEAB1 VA: 0xDE9B0
	[ObsoleteAttribute] // RVA: 0xDE9B0 Offset: 0xDEAB1 VA: 0xDE9B0
	public int bakedIndex { get; set; }
	public int commandBufferCount { get; }
	[ObsoleteAttribute] // RVA: 0xDEA10 Offset: 0xDEB11 VA: 0xDEA10
	public static int pixelLightCount { get; set; }
	[ObsoleteAttribute] // RVA: 0xDEA50 Offset: 0xDEB51 VA: 0xDEA50
	public float shadowConstantBias { get; set; }
	[ObsoleteAttribute] // RVA: 0xDEA90 Offset: 0xDEB91 VA: 0xDEA90
	public float shadowObjectSizeBias { get; set; }
	[ObsoleteAttribute] // RVA: 0xDEAD0 Offset: 0xDEBD1 VA: 0xDEAD0
	public bool attenuate { get; set; }

	// Methods

	// RVA: 0x1A2D1E0 Offset: 0x1A2D2E1 VA: 0x1A2D1E0
	public LightType get_type() { }

	// RVA: 0x1A2D230 Offset: 0x1A2D331 VA: 0x1A2D230
	public void set_type(LightType value) { }

	// RVA: 0x1A2D280 Offset: 0x1A2D381 VA: 0x1A2D280
	public LightShape get_shape() { }

	// RVA: 0x1A2D2D0 Offset: 0x1A2D3D1 VA: 0x1A2D2D0
	public void set_shape(LightShape value) { }

	// RVA: 0x1A2D320 Offset: 0x1A2D421 VA: 0x1A2D320
	public float get_spotAngle() { }

	// RVA: 0x1A2D370 Offset: 0x1A2D471 VA: 0x1A2D370
	public void set_spotAngle(float value) { }

	// RVA: 0x1A2D3C0 Offset: 0x1A2D4C1 VA: 0x1A2D3C0
	public float get_innerSpotAngle() { }

	// RVA: 0x1A2D410 Offset: 0x1A2D511 VA: 0x1A2D410
	public void set_innerSpotAngle(float value) { }

	// RVA: 0x1A2D460 Offset: 0x1A2D561 VA: 0x1A2D460
	public Color get_color() { }

	// RVA: 0x1A2D510 Offset: 0x1A2D611 VA: 0x1A2D510
	public void set_color(Color value) { }

	// RVA: 0x1A2D5C0 Offset: 0x1A2D6C1 VA: 0x1A2D5C0
	public float get_colorTemperature() { }

	// RVA: 0x1A2D610 Offset: 0x1A2D711 VA: 0x1A2D610
	public void set_colorTemperature(float value) { }

	// RVA: 0x1A2D660 Offset: 0x1A2D761 VA: 0x1A2D660
	public bool get_useColorTemperature() { }

	// RVA: 0x1A2D6B0 Offset: 0x1A2D7B1 VA: 0x1A2D6B0
	public void set_useColorTemperature(bool value) { }

	// RVA: 0x1A2D700 Offset: 0x1A2D801 VA: 0x1A2D700
	public float get_intensity() { }

	// RVA: 0x1A2D750 Offset: 0x1A2D851 VA: 0x1A2D750
	public void set_intensity(float value) { }

	// RVA: 0x1A2D7A0 Offset: 0x1A2D8A1 VA: 0x1A2D7A0
	public float get_bounceIntensity() { }

	// RVA: 0x1A2D7F0 Offset: 0x1A2D8F1 VA: 0x1A2D7F0
	public void set_bounceIntensity(float value) { }

	// RVA: 0x1A2D840 Offset: 0x1A2D941 VA: 0x1A2D840
	public bool get_useBoundingSphereOverride() { }

	// RVA: 0x1A2D890 Offset: 0x1A2D991 VA: 0x1A2D890
	public void set_useBoundingSphereOverride(bool value) { }

	// RVA: 0x1A2D8E0 Offset: 0x1A2D9E1 VA: 0x1A2D8E0
	public Vector4 get_boundingSphereOverride() { }

	// RVA: 0x1A2D990 Offset: 0x1A2DA91 VA: 0x1A2D990
	public void set_boundingSphereOverride(Vector4 value) { }

	// RVA: 0x1A2DA40 Offset: 0x1A2DB41 VA: 0x1A2DA40
	public int get_shadowCustomResolution() { }

	// RVA: 0x1A2DA90 Offset: 0x1A2DB91 VA: 0x1A2DA90
	public void set_shadowCustomResolution(int value) { }

	// RVA: 0x1A2DAE0 Offset: 0x1A2DBE1 VA: 0x1A2DAE0
	public float get_shadowBias() { }

	// RVA: 0x1A2DB30 Offset: 0x1A2DC31 VA: 0x1A2DB30
	public void set_shadowBias(float value) { }

	// RVA: 0x1A2DB80 Offset: 0x1A2DC81 VA: 0x1A2DB80
	public float get_shadowNormalBias() { }

	// RVA: 0x1A2DBD0 Offset: 0x1A2DCD1 VA: 0x1A2DBD0
	public void set_shadowNormalBias(float value) { }

	// RVA: 0x1A2DC20 Offset: 0x1A2DD21 VA: 0x1A2DC20
	public float get_shadowNearPlane() { }

	// RVA: 0x1A2DC70 Offset: 0x1A2DD71 VA: 0x1A2DC70
	public void set_shadowNearPlane(float value) { }

	// RVA: 0x1A2DCC0 Offset: 0x1A2DDC1 VA: 0x1A2DCC0
	public bool get_useShadowMatrixOverride() { }

	// RVA: 0x1A2DD10 Offset: 0x1A2DE11 VA: 0x1A2DD10
	public void set_useShadowMatrixOverride(bool value) { }

	// RVA: 0x1A2DD60 Offset: 0x1A2DE61 VA: 0x1A2DD60
	public Matrix4x4 get_shadowMatrixOverride() { }

	// RVA: 0x1A2DE40 Offset: 0x1A2DF41 VA: 0x1A2DE40
	public void set_shadowMatrixOverride(Matrix4x4 value) { }

	// RVA: 0x1A2DEE0 Offset: 0x1A2DFE1 VA: 0x1A2DEE0
	public float get_range() { }

	// RVA: 0x1A2DF30 Offset: 0x1A2E031 VA: 0x1A2DF30
	public void set_range(float value) { }

	// RVA: 0x1A2DF80 Offset: 0x1A2E081 VA: 0x1A2DF80
	public Flare get_flare() { }

	// RVA: 0x1A2DFD0 Offset: 0x1A2E0D1 VA: 0x1A2DFD0
	public void set_flare(Flare value) { }

	// RVA: 0x1A2E020 Offset: 0x1A2E121 VA: 0x1A2E020
	public LightBakingOutput get_bakingOutput() { }

	// RVA: 0x1A2E0F0 Offset: 0x1A2E1F1 VA: 0x1A2E0F0
	public void set_bakingOutput(LightBakingOutput value) { }

	// RVA: 0x1A2E190 Offset: 0x1A2E291 VA: 0x1A2E190
	public int get_cullingMask() { }

	// RVA: 0x1A2E1E0 Offset: 0x1A2E2E1 VA: 0x1A2E1E0
	public void set_cullingMask(int value) { }

	// RVA: 0x1A2E230 Offset: 0x1A2E331 VA: 0x1A2E230
	public int get_renderingLayerMask() { }

	// RVA: 0x1A2E280 Offset: 0x1A2E381 VA: 0x1A2E280
	public void set_renderingLayerMask(int value) { }

	// RVA: 0x1A2E2D0 Offset: 0x1A2E3D1 VA: 0x1A2E2D0
	public LightShadowCasterMode get_lightShadowCasterMode() { }

	// RVA: 0x1A2E320 Offset: 0x1A2E421 VA: 0x1A2E320
	public void set_lightShadowCasterMode(LightShadowCasterMode value) { }

	// RVA: 0x1A2E370 Offset: 0x1A2E471 VA: 0x1A2E370
	public void Reset() { }

	[NativeMethodAttribute] // RVA: 0xD14A0 Offset: 0xD15A1 VA: 0xD14A0
	// RVA: 0x1A2E3C0 Offset: 0x1A2E4C1 VA: 0x1A2E3C0
	public LightShadows get_shadows() { }

	[FreeFunctionAttribute] // RVA: 0xD14E0 Offset: 0xD15E1 VA: 0xD14E0
	// RVA: 0x1A2E410 Offset: 0x1A2E511 VA: 0x1A2E410
	public void set_shadows(LightShadows value) { }

	// RVA: 0x1A2E460 Offset: 0x1A2E561 VA: 0x1A2E460
	public float get_shadowStrength() { }

	[FreeFunctionAttribute] // RVA: 0xD1530 Offset: 0xD1631 VA: 0xD1530
	// RVA: 0x1A2E4B0 Offset: 0x1A2E5B1 VA: 0x1A2E4B0
	public void set_shadowStrength(float value) { }

	// RVA: 0x1A2E500 Offset: 0x1A2E601 VA: 0x1A2E500
	public LightShadowResolution get_shadowResolution() { }

	[FreeFunctionAttribute] // RVA: 0xD1580 Offset: 0xD1681 VA: 0xD1580
	// RVA: 0x1A2E550 Offset: 0x1A2E651 VA: 0x1A2E550
	public void set_shadowResolution(LightShadowResolution value) { }

	// RVA: 0x1A2E5A0 Offset: 0x1A2E6A1 VA: 0x1A2E5A0
	public float get_shadowSoftness() { }

	// RVA: 0x1A2E5B0 Offset: 0x1A2E6B1 VA: 0x1A2E5B0
	public void set_shadowSoftness(float value) { }

	// RVA: 0x1A2E5C0 Offset: 0x1A2E6C1 VA: 0x1A2E5C0
	public float get_shadowSoftnessFade() { }

	// RVA: 0x1A2E5D0 Offset: 0x1A2E6D1 VA: 0x1A2E5D0
	public void set_shadowSoftnessFade(float value) { }

	[FreeFunctionAttribute] // RVA: 0xD15D0 Offset: 0xD16D1 VA: 0xD15D0
	// RVA: 0x1A2E5E0 Offset: 0x1A2E6E1 VA: 0x1A2E5E0
	public float[] get_layerShadowCullDistances() { }

	[FreeFunctionAttribute] // RVA: 0xD1620 Offset: 0xD1721 VA: 0xD1620
	// RVA: 0x1A2E630 Offset: 0x1A2E731 VA: 0x1A2E630
	public void set_layerShadowCullDistances(float[] value) { }

	// RVA: 0x1A2E680 Offset: 0x1A2E781 VA: 0x1A2E680
	public float get_cookieSize() { }

	// RVA: 0x1A2E6D0 Offset: 0x1A2E7D1 VA: 0x1A2E6D0
	public void set_cookieSize(float value) { }

	// RVA: 0x1A2E720 Offset: 0x1A2E821 VA: 0x1A2E720
	public Texture get_cookie() { }

	// RVA: 0x1A2E770 Offset: 0x1A2E871 VA: 0x1A2E770
	public void set_cookie(Texture value) { }

	// RVA: 0x1A2E7C0 Offset: 0x1A2E8C1 VA: 0x1A2E7C0
	public LightRenderMode get_renderMode() { }

	[FreeFunctionAttribute] // RVA: 0xD1670 Offset: 0xD1771 VA: 0xD1670
	// RVA: 0x1A2E810 Offset: 0x1A2E911 VA: 0x1A2E810
	public void set_renderMode(LightRenderMode value) { }

	// RVA: 0x1A2E860 Offset: 0x1A2E961 VA: 0x1A2E860
	public int get_bakedIndex() { }

	// RVA: 0x1A2E870 Offset: 0x1A2E971 VA: 0x1A2E870
	public void set_bakedIndex(int value) { }

	// RVA: 0x1A2E880 Offset: 0x1A2E981 VA: 0x1A2E880
	public void AddCommandBuffer(LightEvent evt, CommandBuffer buffer) { }

	[FreeFunctionAttribute] // RVA: 0xD16C0 Offset: 0xD17C1 VA: 0xD16C0
	// RVA: 0x1A2E8E0 Offset: 0x1A2E9E1 VA: 0x1A2E8E0
	public void AddCommandBuffer(LightEvent evt, CommandBuffer buffer, ShadowMapPass shadowPassMask) { }

	// RVA: 0x1A2E950 Offset: 0x1A2EA51 VA: 0x1A2E950
	public void AddCommandBufferAsync(LightEvent evt, CommandBuffer buffer, ComputeQueueType queueType) { }

	[FreeFunctionAttribute] // RVA: 0xD1710 Offset: 0xD1811 VA: 0xD1710
	// RVA: 0x1A2E9C0 Offset: 0x1A2EAC1 VA: 0x1A2E9C0
	public void AddCommandBufferAsync(LightEvent evt, CommandBuffer buffer, ShadowMapPass shadowPassMask, ComputeQueueType queueType) { }

	// RVA: 0x1A2EA30 Offset: 0x1A2EB31 VA: 0x1A2EA30
	public void RemoveCommandBuffer(LightEvent evt, CommandBuffer buffer) { }

	// RVA: 0x1A2EA90 Offset: 0x1A2EB91 VA: 0x1A2EA90
	public void RemoveCommandBuffers(LightEvent evt) { }

	// RVA: 0x1A2EAE0 Offset: 0x1A2EBE1 VA: 0x1A2EAE0
	public void RemoveAllCommandBuffers() { }

	[FreeFunctionAttribute] // RVA: 0xD1760 Offset: 0xD1861 VA: 0xD1760
	// RVA: 0x1A2EB30 Offset: 0x1A2EC31 VA: 0x1A2EB30
	public CommandBuffer[] GetCommandBuffers(LightEvent evt) { }

	// RVA: 0x1A2EB80 Offset: 0x1A2EC81 VA: 0x1A2EB80
	public int get_commandBufferCount() { }

	// RVA: 0x1A2EBD0 Offset: 0x1A2ECD1 VA: 0x1A2EBD0
	public static int get_pixelLightCount() { }

	// RVA: 0x1A2EBE0 Offset: 0x1A2ECE1 VA: 0x1A2EBE0
	public static void set_pixelLightCount(int value) { }

	[FreeFunctionAttribute] // RVA: 0xD17B0 Offset: 0xD18B1 VA: 0xD17B0
	// RVA: 0x1A2EBF0 Offset: 0x1A2ECF1 VA: 0x1A2EBF0
	public static Light[] GetLights(LightType type, int layer) { }

	// RVA: 0x1A2EC40 Offset: 0x1A2ED41 VA: 0x1A2EC40
	public float get_shadowConstantBias() { }

	// RVA: 0x1A2EC50 Offset: 0x1A2ED51 VA: 0x1A2EC50
	public void set_shadowConstantBias(float value) { }

	// RVA: 0x1A2EC60 Offset: 0x1A2ED61 VA: 0x1A2EC60
	public float get_shadowObjectSizeBias() { }

	// RVA: 0x1A2EC70 Offset: 0x1A2ED71 VA: 0x1A2EC70
	public void set_shadowObjectSizeBias(float value) { }

	// RVA: 0x1A2EC80 Offset: 0x1A2ED81 VA: 0x1A2EC80
	public bool get_attenuate() { }

	// RVA: 0x1A2EC90 Offset: 0x1A2ED91 VA: 0x1A2EC90
	public void set_attenuate(bool value) { }

	// RVA: 0x1A2ECA0 Offset: 0x1A2EDA1 VA: 0x1A2ECA0
	public void .ctor() { }

	// RVA: 0x1A2D4C0 Offset: 0x1A2D5C1 VA: 0x1A2D4C0
	private void get_color_Injected(out Color ret) { }

	// RVA: 0x1A2D570 Offset: 0x1A2D671 VA: 0x1A2D570
	private void set_color_Injected(ref Color value) { }

	// RVA: 0x1A2D940 Offset: 0x1A2DA41 VA: 0x1A2D940
	private void get_boundingSphereOverride_Injected(out Vector4 ret) { }

	// RVA: 0x1A2D9F0 Offset: 0x1A2DAF1 VA: 0x1A2D9F0
	private void set_boundingSphereOverride_Injected(ref Vector4 value) { }

	// RVA: 0x1A2DDF0 Offset: 0x1A2DEF1 VA: 0x1A2DDF0
	private void get_shadowMatrixOverride_Injected(out Matrix4x4 ret) { }

	// RVA: 0x1A2DE90 Offset: 0x1A2DF91 VA: 0x1A2DE90
	private void set_shadowMatrixOverride_Injected(ref Matrix4x4 value) { }

	// RVA: 0x1A2E0A0 Offset: 0x1A2E1A1 VA: 0x1A2E0A0
	private void get_bakingOutput_Injected(out LightBakingOutput ret) { }

	// RVA: 0x1A2E140 Offset: 0x1A2E241 VA: 0x1A2E140
	private void set_bakingOutput_Injected(ref LightBakingOutput value) { }
}

