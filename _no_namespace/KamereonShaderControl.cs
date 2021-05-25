public class KamereonShaderControl : MonoBehaviour // TypeDefIndex: 7899
{
	// Fields
	private int sp_Alpha; // 0x18
	private int sp_AlphaRimValue; // 0x1C
	private int sp_White; // 0x20
	private int sp_Centor; // 0x24
	private int sp_Fade; // 0x28
	private int sp_RainbowBlend; // 0x2C
	private float fadeTime; // 0x30
	private float alphaLoopTime; // 0x34
	private float loopLightSpeed; // 0x38
	private int rainbowParam; // 0x3C
	[SerializeField] // RVA: 0x169DD0 Offset: 0x169ED1 VA: 0x169DD0
	private Renderer targetRenderer; // 0x40
	private Material iMaterial; // 0x48
	private IEnumerator coroutine; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x169DE0 Offset: 0x169EE1 VA: 0x169DE0
	private bool <isInit>k__BackingField; // 0x58
	private readonly KamereonShaderControl.ShaderProperty defaultProperty; // 0x5C
	private readonly KamereonShaderControl.ShaderProperty alphaProperty; // 0x78

	// Properties
	private bool isInit { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A3FF0 Offset: 0x1A40F1 VA: 0x1A3FF0
	// RVA: 0x2096600 Offset: 0x2096701 VA: 0x2096600
	private bool get_isInit() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4000 Offset: 0x1A4101 VA: 0x1A4000
	// RVA: 0x2096610 Offset: 0x2096711 VA: 0x2096610
	private void set_isInit(bool value) { }

	// RVA: 0x2096620 Offset: 0x2096721 VA: 0x2096620
	private KamereonShaderControl.ShaderProperty GetNowProperty() { }

	// RVA: 0x2096710 Offset: 0x2096811 VA: 0x2096710
	public void Init() { }

	// RVA: 0x2096840 Offset: 0x2096941 VA: 0x2096840
	private void GetProperty() { }

	// RVA: 0x2095B00 Offset: 0x2095C01 VA: 0x2095B00
	public void Play(KamereonShaderControl.PlayType type, float fadeTime = 1, int param = -1) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A4010 Offset: 0x1A4111 VA: 0x1A4010
	// RVA: 0x2096910 Offset: 0x2096A11 VA: 0x2096910
	private IEnumerator PlayDefaultAsync() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A4080 Offset: 0x1A4181 VA: 0x1A4080
	// RVA: 0x2096990 Offset: 0x2096A91 VA: 0x2096990
	private IEnumerator PlayAlphaAsync(bool isRainbow) { }

	// RVA: 0x2096B20 Offset: 0x2096C21 VA: 0x2096B20
	private void SetDefault() { }

	// RVA: 0x2096B60 Offset: 0x2096C61 VA: 0x2096B60
	private void SetDefault(float timer, KamereonShaderControl.ShaderProperty now) { }

	// RVA: 0x2096D20 Offset: 0x2096E21 VA: 0x2096D20
	private void SetAlpha(bool isRainbow) { }

	// RVA: 0x2096D60 Offset: 0x2096E61 VA: 0x2096D60
	private void SetAlpha(bool isRainbow, float timer, KamereonShaderControl.ShaderProperty now) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A40F0 Offset: 0x1A41F1 VA: 0x1A40F0
	// RVA: 0x2096A20 Offset: 0x2096B21 VA: 0x2096A20
	private IEnumerator PlayAlphaLoopAsync(bool isRainbow, int count = -1) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A4160 Offset: 0x1A4261 VA: 0x1A4160
	// RVA: 0x2096FA0 Offset: 0x20970A1 VA: 0x2096FA0
	private IEnumerator PlayRainbowAsync() { }

	// RVA: 0x2097050 Offset: 0x2097151 VA: 0x2097050
	private void PlayyRainbowLoop() { }

	// RVA: 0x20970A0 Offset: 0x20971A1 VA: 0x20970A0
	public void EnableShadow(bool b) { }

	// RVA: 0x20970D0 Offset: 0x20971D1 VA: 0x20970D0
	private void OnDestroy() { }

	// RVA: 0x20971A0 Offset: 0x20972A1 VA: 0x20971A0
	public void .ctor() { }
}

