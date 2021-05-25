public class TCP2_Demo_PBS : MonoBehaviour // TypeDefIndex: 8992
{
	// Fields
	public Light DirLight; // 0x18
	public GameObject PointLights; // 0x20
	public MeshRenderer Robot; // 0x28
	public GameObject Canvas; // 0x30
	public TCP2_Demo_PBS.SkyboxSetting[] SkySettings; // 0x38
	public bool FlipLight; // 0x40
	public Texture2D[] RampTextures; // 0x48
	public Slider SmoothnessSlider; // 0x50
	public Text SmoothnessValue; // 0x58
	public Slider MetallicSlider; // 0x60
	public Text MetallicValue; // 0x68
	public Text BumpScaleValue; // 0x70
	public Text ShaderText; // 0x78
	public Text SkyboxValue; // 0x80
	public Text RampValue; // 0x88
	public Slider RampThresholdSlider; // 0x90
	public Text RampThresholdValue; // 0x98
	public Slider RampSmoothSlider; // 0xA0
	public Text RampSmoothValue; // 0xA8
	public Slider RampSmoothAddSlider; // 0xB0
	public Text RampSmoothAddValue; // 0xB8
	public RawImage RampImage; // 0xC0
	private int currentSky; // 0xC8
	private int currentRamp; // 0xCC
	private Material robotMaterial; // 0xD0
	private bool mUseOutline; // 0xD8
	private bool mRotatePointLights; // 0xD9

	// Properties
	public bool ShowPointLights { set; }
	public bool ShowDirLight { set; }
	public bool RotatePointLights { get; set; }
	public bool UseOutline { get; set; }
	public bool UseRampTexture { set; }
	public bool UseStylizedFresnel { set; }
	public bool UseStylizedSpecular { set; }

	// Methods

	// RVA: 0x1C6F3D0 Offset: 0x1C6F4D1 VA: 0x1C6F3D0
	public void set_ShowPointLights(bool value) { }

	// RVA: 0x1C6F3F0 Offset: 0x1C6F4F1 VA: 0x1C6F3F0
	public void set_ShowDirLight(bool value) { }

	// RVA: 0x1C6F410 Offset: 0x1C6F511 VA: 0x1C6F410
	public bool get_RotatePointLights() { }

	// RVA: 0x1C6F420 Offset: 0x1C6F521 VA: 0x1C6F420
	public void set_RotatePointLights(bool value) { }

	// RVA: 0x1C6F430 Offset: 0x1C6F531 VA: 0x1C6F430
	public bool get_UseOutline() { }

	// RVA: 0x1C6F440 Offset: 0x1C6F541 VA: 0x1C6F440
	public void set_UseOutline(bool value) { }

	// RVA: 0x1C6F5B0 Offset: 0x1C6F6B1 VA: 0x1C6F5B0
	public void set_UseRampTexture(bool value) { }

	// RVA: 0x1C6F660 Offset: 0x1C6F761 VA: 0x1C6F660
	public void set_UseStylizedFresnel(bool value) { }

	// RVA: 0x1C6F710 Offset: 0x1C6F811 VA: 0x1C6F710
	public void set_UseStylizedSpecular(bool value) { }

	// RVA: 0x1C6F7C0 Offset: 0x1C6F8C1 VA: 0x1C6F7C0
	private void Awake() { }

	// RVA: 0x1C6FCD0 Offset: 0x1C6FDD1 VA: 0x1C6FCD0
	private void Update() { }

	// RVA: 0x1C6FEF0 Offset: 0x1C6FFF1 VA: 0x1C6FEF0
	public void ToggleShader() { }

	// RVA: 0x1C6FE70 Offset: 0x1C6FF71 VA: 0x1C6FE70
	public void NextSky() { }

	// RVA: 0x1C6FEB0 Offset: 0x1C6FFB1 VA: 0x1C6FEB0
	public void PrevSky() { }

	// RVA: 0x1C70070 Offset: 0x1C70171 VA: 0x1C70070
	public void NextRamp() { }

	// RVA: 0x1C700B0 Offset: 0x1C701B1 VA: 0x1C700B0
	public void PrevRamp() { }

	// RVA: 0x1C700F0 Offset: 0x1C701F1 VA: 0x1C700F0
	public void SetMetallic(float f) { }

	// RVA: 0x1C701A0 Offset: 0x1C702A1 VA: 0x1C701A0
	public void SetSmoothness(float f) { }

	// RVA: 0x1C70250 Offset: 0x1C70351 VA: 0x1C70250
	public void SetBumpScale(float f) { }

	// RVA: 0x1C70300 Offset: 0x1C70401 VA: 0x1C70300
	public void SetRampThreshold(float f) { }

	// RVA: 0x1C703B0 Offset: 0x1C704B1 VA: 0x1C703B0
	public void SetRampSmooth(float f) { }

	// RVA: 0x1C70460 Offset: 0x1C70561 VA: 0x1C70460
	public void SetRampSmoothAdd(float f) { }

	// RVA: 0x1C6FB80 Offset: 0x1C6FC81 VA: 0x1C6FB80
	private void UpdateRamp() { }

	// RVA: 0x1C6F990 Offset: 0x1C6FA91 VA: 0x1C6F990
	private void UpdateSky() { }

	// RVA: 0x1C70000 Offset: 0x1C70101 VA: 0x1C70000
	private void ShowUnityStandardShader() { }

	// RVA: 0x1C6F4F0 Offset: 0x1C6F5F1 VA: 0x1C6F4F0
	public void ShowTCP2Shader() { }

	// RVA: 0x1C70510 Offset: 0x1C70611 VA: 0x1C70510
	private void ToggleKeyword(Material m, bool enabled, string keyword) { }

	// RVA: 0x1C70540 Offset: 0x1C70641 VA: 0x1C70540
	public void .ctor() { }
}

