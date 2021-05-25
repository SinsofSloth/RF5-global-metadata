public class TCP2_Demo_Cat : MonoBehaviour // TypeDefIndex: 8984
{
	// Fields
	public TCP2_Demo_Cat.Ambience[] ambiences; // 0x18
	public int amb; // 0x20
	[SpaceAttribute] // RVA: 0x1751F0 Offset: 0x1752F1 VA: 0x1751F0
	public TCP2_Demo_Cat.ShaderStyle[] styles; // 0x28
	public int style; // 0x30
	[SpaceAttribute] // RVA: 0x175200 Offset: 0x175301 VA: 0x175200
	public GameObject shadedGroup; // 0x38
	public GameObject flatGroup; // 0x40
	[SpaceAttribute] // RVA: 0x175210 Offset: 0x175311 VA: 0x175210
	public GameObject[] cats; // 0x48
	public GameObject[] unityChans; // 0x50
	public GameObject unityChanCopyright; // 0x58
	[SpaceAttribute] // RVA: 0x175220 Offset: 0x175321 VA: 0x175220
	public AnimationClip[] catAnimations; // 0x60
	private int catAnim; // 0x68
	public AnimationClip[] unityChanAnimations; // 0x70
	private int uchanAnim; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x175230 Offset: 0x175331 VA: 0x175230
	private bool <animate>k__BackingField; // 0x7C
	private float animTime; // 0x80
	[SpaceAttribute] // RVA: 0x175240 Offset: 0x175341 VA: 0x175240
	public Light[] dirLights; // 0x88
	public Light[] otherLights; // 0x90
	public Transform rotatingPointLights; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x175250 Offset: 0x175351 VA: 0x175250
	private bool <rotateLights>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x175260 Offset: 0x175361 VA: 0x175260
	private bool <rotatePointLights>k__BackingField; // 0xA1
	[SpaceAttribute] // RVA: 0x175270 Offset: 0x175371 VA: 0x175270
	public Button[] ambiencesButtons; // 0xA8
	public Button[] stylesButtons; // 0xB0
	public Button[] characterButtons; // 0xB8
	public Button[] textureButtons; // 0xC0
	public Button[] animationButtons; // 0xC8
	[SpaceAttribute] // RVA: 0x175280 Offset: 0x175381 VA: 0x175280
	public Canvas canvas; // 0xD0

	// Properties
	public bool animate { get; set; }
	public bool rotateLights { get; set; }
	public bool rotatePointLights { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A94A0 Offset: 0x1A95A1 VA: 0x1A94A0
	// RVA: 0x1C6E100 Offset: 0x1C6E201 VA: 0x1C6E100
	public bool get_animate() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A94B0 Offset: 0x1A95B1 VA: 0x1A94B0
	// RVA: 0x1C6E110 Offset: 0x1C6E211 VA: 0x1C6E110
	public void set_animate(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A94C0 Offset: 0x1A95C1 VA: 0x1A94C0
	// RVA: 0x1C6E120 Offset: 0x1C6E221 VA: 0x1C6E120
	public bool get_rotateLights() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A94D0 Offset: 0x1A95D1 VA: 0x1A94D0
	// RVA: 0x1C6E130 Offset: 0x1C6E231 VA: 0x1C6E130
	public void set_rotateLights(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A94E0 Offset: 0x1A95E1 VA: 0x1A94E0
	// RVA: 0x1C6E140 Offset: 0x1C6E241 VA: 0x1C6E140
	public bool get_rotatePointLights() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A94F0 Offset: 0x1A95F1 VA: 0x1A94F0
	// RVA: 0x1C6E150 Offset: 0x1C6E251 VA: 0x1C6E150
	public void set_rotatePointLights(bool value) { }

	// RVA: 0x1C6E160 Offset: 0x1C6E261 VA: 0x1C6E160
	private void Awake() { }

	// RVA: 0x1C6EE30 Offset: 0x1C6EF31 VA: 0x1C6EE30
	private void Update() { }

	// RVA: 0x1C6F0C0 Offset: 0x1C6F1C1 VA: 0x1C6F0C0
	private void UpdateAnimation() { }

	// RVA: 0x1C6E1C0 Offset: 0x1C6E2C1 VA: 0x1C6E1C0
	public void SetAmbience(int index) { }

	// RVA: 0x1C6E450 Offset: 0x1C6E551 VA: 0x1C6E450
	public void SetStyle(int index) { }

	// RVA: 0x1C6E9C0 Offset: 0x1C6EAC1 VA: 0x1C6E9C0
	public void SetFlat(bool flat) { }

	// RVA: 0x1C6E690 Offset: 0x1C6E791 VA: 0x1C6E690
	public void SetCat(bool cat) { }

	// RVA: 0x1C6F200 Offset: 0x1C6F301 VA: 0x1C6F200
	public void SetLightShadows(bool on) { }

	// RVA: 0x1C6EC60 Offset: 0x1C6ED61 VA: 0x1C6EC60
	public void SetAnimation(int index) { }

	// RVA: 0x1C6F360 Offset: 0x1C6F461 VA: 0x1C6F360
	public void .ctor() { }
}

