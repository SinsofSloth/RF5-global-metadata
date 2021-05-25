public class SubtitleManager : SingletonMonoBehaviour<SubtitleManager> // TypeDefIndex: 9770
{
	// Fields
	private bool isUsingTitle; // 0x18
	private int titleVoiceId; // 0x1C
	private UISubtitleTitle UISubtitleTitle; // 0x20
	private UISystemTextData TitleTextData; // 0x28
	private AssetHandle TitleHandle; // 0x30
	private float lifeTime; // 0x38
	private bool isUsingVoiceComment; // 0x3C
	private int voiceId; // 0x40
	private AudioSource voiceAudioSource; // 0x48
	private UISubtitleVoiceComment uiSubtitleVoiceComment; // 0x50
	private UISystemTextData VoiceTextData; // 0x58
	private AssetHandle VoiceCommentHandle; // 0x60
	private bool isUsingMovieSubtitle; // 0x68
	private int movieId; // 0x6C
	private MoviePlayer moviePlayer; // 0x70
	private AudioSource movieAudioSource; // 0x78
	private UISubtitleMovie uiSubtitleMovieSubtitle; // 0x80
	private AssetHandle MovieSubtitleHandle; // 0x88
	public UISubtitleHUDMain UISubtitleHUDMain; // 0x90
	private bool IsHUDSubtitleEnable; // 0x98
	private bool IsHUDSubtitleEnableWithoutHud; // 0x99

	// Properties
	private bool IsJpn { get; }
	private bool IsAsia { get; }

	// Methods

	// RVA: 0x1DFB350 Offset: 0x1DFB451 VA: 0x1DFB350
	private bool get_IsJpn() { }

	// RVA: 0x1DFB380 Offset: 0x1DFB481 VA: 0x1DFB380
	private bool get_IsAsia() { }

	// RVA: 0x1DFB400 Offset: 0x1DFB501 VA: 0x1DFB400
	private void ClearSubOnTitle() { }

	// RVA: 0x1DFB570 Offset: 0x1DFB671 VA: 0x1DFB570
	public void PlayOnTitle(int _voiceId, float _lifeTime = 5) { }

	// RVA: 0x1DFB6F0 Offset: 0x1DFB7F1 VA: 0x1DFB6F0
	public void EndOnTitle() { }

	// RVA: 0x1DFB700 Offset: 0x1DFB801 VA: 0x1DFB700
	private void ClearVoiceComment() { }

	// RVA: 0x1DFB880 Offset: 0x1DFB981 VA: 0x1DFB880
	public void PlayVoiceComment(int _voiceId, AudioSource audioSource) { }

	// RVA: 0x1DFBA40 Offset: 0x1DFBB41 VA: 0x1DFBA40
	public void EndVoiceComment() { }

	// RVA: 0x1DFBA50 Offset: 0x1DFBB51 VA: 0x1DFBA50
	private void MovieLoaded(AssetHandle<GameObject> handle) { }

	// RVA: 0x1DFBBE0 Offset: 0x1DFBCE1 VA: 0x1DFBBE0
	private void ClearMovieSubtitle() { }

	// RVA: 0x1DF2580 Offset: 0x1DF2681 VA: 0x1DF2580
	public void PlayMovieSubtitle(int _movieId, AudioSource audioSource) { }

	// RVA: 0x1DFBD30 Offset: 0x1DFBE31 VA: 0x1DFBD30
	public void PlayMovieSubtitle(int _movieId, MoviePlayer _moviePlayer) { }

	// RVA: 0x1DF2B00 Offset: 0x1DF2C01 VA: 0x1DF2B00
	public void EndMovieSubtitle() { }

	// RVA: 0x1DFBF40 Offset: 0x1DFC041 VA: 0x1DFBF40
	public void SetHUDSubtitleEnable(bool enableState) { }

	// RVA: 0x1DFC320 Offset: 0x1DFC421 VA: 0x1DFC320
	public void SetHUDSubtitleEnableAlone(bool enableState) { }

	// RVA: 0x1DFC3E0 Offset: 0x1DFC4E1 VA: 0x1DFC3E0
	public SubtitleHandler PlayHUD(int _voiceId, AudioSource _audioSource) { }

	// RVA: 0x1DFC5C0 Offset: 0x1DFC6C1 VA: 0x1DFC5C0
	public SubtitleHandler PlayHUD(SkillID skillID) { }

	// RVA: 0x1DFC750 Offset: 0x1DFC851 VA: 0x1DFC750
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ACFC0 Offset: 0x1AD0C1 VA: 0x1ACFC0
	// RVA: 0x1DFC7C0 Offset: 0x1DFC8C1 VA: 0x1DFC7C0
	private void <PlayOnTitle>b__11_0(AssetHandle<UISystemTextData> texthandle) { }

	[CompilerGeneratedAttribute] // RVA: 0x1ACFD0 Offset: 0x1AD0D1 VA: 0x1ACFD0
	// RVA: 0x1DFC8B0 Offset: 0x1DFC9B1 VA: 0x1DFC8B0
	private void <PlayOnTitle>b__11_1(AssetHandle<GameObject> handle) { }

	[CompilerGeneratedAttribute] // RVA: 0x1ACFE0 Offset: 0x1AD0E1 VA: 0x1ACFE0
	// RVA: 0x1DFC9E0 Offset: 0x1DFCAE1 VA: 0x1DFC9E0
	private void <PlayVoiceComment>b__20_0(AssetHandle<UISystemTextData> texthandle) { }

	[CompilerGeneratedAttribute] // RVA: 0x1ACFF0 Offset: 0x1AD0F1 VA: 0x1ACFF0
	// RVA: 0x1DFCAD0 Offset: 0x1DFCBD1 VA: 0x1DFCAD0
	private void <PlayVoiceComment>b__20_1(AssetHandle<GameObject> handle) { }
}

