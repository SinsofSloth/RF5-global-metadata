public class ScreenFadeManager : SingletonMonoBehaviour<ScreenFadeManager> // TypeDefIndex: 7705
{
	// Fields
	private const float DefaultFadeDuration = 0.5;
	private static Fade m_fade; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x168C30 Offset: 0x168D31 VA: 0x168C30
	private static bool <IsPlaying>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x168C40 Offset: 0x168D41 VA: 0x168C40
	private static ScreenFadeManager.State <FadeState>k__BackingField; // 0xC

	// Properties
	public static bool IsPlaying { get; set; }
	public static ScreenFadeManager.State FadeState { get; set; }
	public static bool IsReady { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A28E0 Offset: 0x1A29E1 VA: 0x1A28E0
	// RVA: 0x21053D0 Offset: 0x21054D1 VA: 0x21053D0
	private static void set_IsPlaying(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A28F0 Offset: 0x1A29F1 VA: 0x1A28F0
	// RVA: 0x2105440 Offset: 0x2105541 VA: 0x2105440
	public static bool get_IsPlaying() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2900 Offset: 0x1A2A01 VA: 0x1A2900
	// RVA: 0x21054B0 Offset: 0x21055B1 VA: 0x21054B0
	private static void set_FadeState(ScreenFadeManager.State value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2910 Offset: 0x1A2A11 VA: 0x1A2910
	// RVA: 0x2105520 Offset: 0x2105621 VA: 0x2105520
	public static ScreenFadeManager.State get_FadeState() { }

	// RVA: 0x2105590 Offset: 0x2105691 VA: 0x2105590
	public static bool get_IsReady() { }

	// RVA: 0x2105680 Offset: 0x2105781 VA: 0x2105680 Slot: 4
	protected override void Awake() { }

	// RVA: 0x2105790 Offset: 0x2105891 VA: 0x2105790
	private void Start() { }

	// RVA: 0x21058B0 Offset: 0x21059B1 VA: 0x21058B0
	public static Coroutine FadeOut(float time = 0.5, Action action, ScreenFadeManager.ColorType colorType = 1, bool onLoad = True, bool onHint = False) { }

	// RVA: 0x2105BD0 Offset: 0x2105CD1 VA: 0x2105BD0
	public static Coroutine FadeIn(float time = 0.5, Action action, ScreenFadeManager.ColorType colorType = 1, bool onLoad = True) { }

	// RVA: 0x2105800 Offset: 0x2105901 VA: 0x2105800
	public static void LoadLoadingAnim() { }

	// RVA: 0x2105E60 Offset: 0x2105F61 VA: 0x2105E60
	public void .ctor() { }

	// RVA: 0x2105EB0 Offset: 0x2105FB1 VA: 0x2105EB0
	private static void .cctor() { }
}

