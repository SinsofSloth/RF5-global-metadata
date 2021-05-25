public class TCP2_Demo : MonoBehaviour // TypeDefIndex: 8991
{
	// Fields
	public Material[] AffectedMaterials; // 0x18
	public Texture2D[] RampTextures; // 0x20
	public GUISkin GuiSkin; // 0x28
	public Light DirLight; // 0x30
	public GameObject Robot; // 0x38
	public GameObject Ethan; // 0x40
	private bool mUnityShader; // 0x48
	private bool mShaderSpecular; // 0x49
	private bool mShaderBump; // 0x4A
	private bool mShaderReflection; // 0x4B
	private bool mShaderRim; // 0x4C
	private bool mShaderRimOutline; // 0x4D
	private bool mShaderOutline; // 0x4E
	private float mRimMin; // 0x50
	private float mRimMax; // 0x54
	private bool mRampTextureFlag; // 0x58
	private Texture2D mRampTexture; // 0x60
	private float mRampSmoothing; // 0x68
	private float mLightRotationX; // 0x6C
	private float mLightRotationY; // 0x70
	private bool mViewRobot; // 0x74
	private bool mRobotOutlineNormals; // 0x75
	private TCP2_Demo_View DemoView; // 0x78

	// Methods

	// RVA: 0x1C6A200 Offset: 0x1C6A301 VA: 0x1C6A200
	private void Awake() { }

	// RVA: 0x1C6A8C0 Offset: 0x1C6A9C1 VA: 0x1C6A8C0
	private void OnDestroy() { }

	// RVA: 0x1C6AA50 Offset: 0x1C6AB51 VA: 0x1C6AA50
	private void OnGUI() { }

	// RVA: 0x1C6D0C0 Offset: 0x1C6D1C1 VA: 0x1C6D0C0
	private void UnityDiffuseShader() { }

	// RVA: 0x1C6A2A0 Offset: 0x1C6A3A1 VA: 0x1C6A2A0
	private void UpdateShader() { }

	// RVA: 0x1C6CE10 Offset: 0x1C6CF11 VA: 0x1C6CE10
	private void RimOutlineColor() { }

	// RVA: 0x1C6A8F0 Offset: 0x1C6A9F1 VA: 0x1C6A8F0
	private void RestoreRimColors() { }

	// RVA: 0x1C6D1D0 Offset: 0x1C6D2D1 VA: 0x1C6D1D0
	private void ToggleKeyword(Material m, bool enabled, string keyword) { }

	// RVA: 0x1C6CED0 Offset: 0x1C6CFD1 VA: 0x1C6CED0
	private void PrevRamp() { }

	// RVA: 0x1C6CFD0 Offset: 0x1C6D0D1 VA: 0x1C6CFD0
	private void NextRamp() { }

	// RVA: 0x1C6D630 Offset: 0x1C6D731 VA: 0x1C6D630
	public void .ctor() { }
}

