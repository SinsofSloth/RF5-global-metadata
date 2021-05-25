public class MovieRoom : UIScrollBoxBase // TypeDefIndex: 8777
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x173630 Offset: 0x173731 VA: 0x173630
	private static bool <IsActive>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x173640 Offset: 0x173741 VA: 0x173640
	private static int <NowPlayingNpc>k__BackingField; // 0x4
	[SerializeField] // RVA: 0x173650 Offset: 0x173751 VA: 0x173650
	private Text movieNameText; // 0x68
	[SerializeField] // RVA: 0x173660 Offset: 0x173761 VA: 0x173660
	private Text movieContentText; // 0x70
	[SerializeField] // RVA: 0x173670 Offset: 0x173771 VA: 0x173670
	private Image previewImage; // 0x78
	private SpriteAtlas movieSpriteAtlas; // 0x80
	private const int MOVIE_SPRITE_ATLAS_ID = 19766;
	private const string LOCKED_PREVIEW_IMAGE = "sn_dammy";
	private Dictionary<string, Sprite> movieSpriteDict; // 0x88
	[SerializeField] // RVA: 0x173680 Offset: 0x173781 VA: 0x173680
	private float flashSpeed; // 0x90
	private MovieRoomSkip movieSkip; // 0x98
	private readonly int MOVIE_SKIP_ID; // 0xA0
	[SerializeField] // RVA: 0x173690 Offset: 0x173791 VA: 0x173690
	private GameObject uiObject; // 0xA8
	private MovieRoomDataTable movieRoomDataTable; // 0xB0
	private BGMID currentBGM; // 0xB8
	private VariationNo playerVariation; // 0xBC
	private VariationNo npcVariation; // 0xC0
	private Vector3 playerPos; // 0xC4
	private Quaternion playerRot; // 0xD0
	private bool isPlaying; // 0xE0
	private float startInputDelay; // 0xE4

	// Properties
	public static bool IsActive { get; set; }
	public static int NowPlayingNpc { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A8580 Offset: 0x1A8681 VA: 0x1A8580
	// RVA: 0x1CDCDF0 Offset: 0x1CDCEF1 VA: 0x1CDCDF0
	public static bool get_IsActive() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8590 Offset: 0x1A8691 VA: 0x1A8590
	// RVA: 0x1CDCE60 Offset: 0x1CDCF61 VA: 0x1CDCE60
	private static void set_IsActive(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A85A0 Offset: 0x1A86A1 VA: 0x1A85A0
	// RVA: 0x1CDCED0 Offset: 0x1CDCFD1 VA: 0x1CDCED0
	public static int get_NowPlayingNpc() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A85B0 Offset: 0x1A86B1 VA: 0x1A85B0
	// RVA: 0x1CDCF40 Offset: 0x1CDD041 VA: 0x1CDCF40
	private static void set_NowPlayingNpc(int value) { }

	// RVA: 0x1CDCFB0 Offset: 0x1CDD0B1 VA: 0x1CDCFB0 Slot: 8
	protected override void Start() { }

	// RVA: 0x1CDD920 Offset: 0x1CDDA21 VA: 0x1CDD920
	private void OnDestroy() { }

	// RVA: 0x1CDD9F0 Offset: 0x1CDDAF1 VA: 0x1CDD9F0
	private void Close() { }

	// RVA: 0x1CDDD60 Offset: 0x1CDDE61 VA: 0x1CDDD60 Slot: 9
	protected override void Update() { }

	// RVA: 0x1CDDEF0 Offset: 0x1CDDFF1 VA: 0x1CDDEF0
	private void InputSubmit() { }

	// RVA: 0x1CDE730 Offset: 0x1CDE831 VA: 0x1CDE730
	public void OnSlotTouch(UIMovieSlot _slot) { }

	// RVA: 0x1CDD550 Offset: 0x1CDD651 VA: 0x1CDD550
	private void UpdateFocusMovie() { }

	// RVA: 0x1CDE890 Offset: 0x1CDE991 VA: 0x1CDE890
	private Sprite GetMoviePreviewSprite() { }

	// RVA: 0x1CDEB20 Offset: 0x1CDEC21 VA: 0x1CDEB20
	public string GetMovieName(int _index) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A85C0 Offset: 0x1A86C1 VA: 0x1A85C0
	// RVA: 0x1CDE810 Offset: 0x1CDE911 VA: 0x1CDE810
	private IEnumerator MoviePreviewImageFlash() { }

	// RVA: 0x1CDE070 Offset: 0x1CDE171 VA: 0x1CDE070
	private void PlayMovie(MovieRoomData _data) { }

	// RVA: 0x1CDEDC0 Offset: 0x1CDEEC1 VA: 0x1CDEDC0
	private void EndMovie(MovieRoomData _data) { }

	// RVA: 0x1CDE2E0 Offset: 0x1CDE3E1 VA: 0x1CDE2E0
	private void PlayShortPlay(MovieRoomData _data) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A8630 Offset: 0x1A8731 VA: 0x1A8630
	// RVA: 0x1CDEEA0 Offset: 0x1CDEFA1 VA: 0x1CDEEA0
	private IEnumerator CheckEnableSkipShortPlay(MovieRoomSkip _skip, MovieID _id) { }

	// RVA: 0x1CDEF70 Offset: 0x1CDF071 VA: 0x1CDEF70
	private void EndShortPlay(MovieRoomData _data) { }

	// RVA: 0x1CDF150 Offset: 0x1CDF251 VA: 0x1CDF150
	private void PlayStaffRoll(string _script) { }

	// RVA: 0x1CDF360 Offset: 0x1CDF461 VA: 0x1CDF360
	private void EndStaffRoll() { }

	// RVA: 0x1CDEE80 Offset: 0x1CDEF81 VA: 0x1CDEE80
	private bool IsMarriage(MovieID _id) { }

	// RVA: 0x1CDF430 Offset: 0x1CDF531 VA: 0x1CDF430 Slot: 5
	protected override int GetListCount() { }

	// RVA: 0x1CDF440 Offset: 0x1CDF541 VA: 0x1CDF440 Slot: 6
	protected override void SetButtonDisp(UIButtonLinkerInScrollBox button) { }

	// RVA: 0x1CDF4E0 Offset: 0x1CDF5E1 VA: 0x1CDF4E0 Slot: 7
	public override void SetFocusDetail() { }

	// RVA: 0x1CDF4F0 Offset: 0x1CDF5F1 VA: 0x1CDF4F0
	public void .ctor() { }

	// RVA: 0x1CDF5D0 Offset: 0x1CDF6D1 VA: 0x1CDF5D0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A86A0 Offset: 0x1A87A1 VA: 0x1A86A0
	// RVA: 0x1CDF630 Offset: 0x1CDF731 VA: 0x1CDF630
	private void <Start>b__27_0(AssetHandle<GameObject> _handle) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A86B0 Offset: 0x1A87B1 VA: 0x1A86B0
	// RVA: 0x1CDF6C0 Offset: 0x1CDF7C1 VA: 0x1CDF6C0
	private void <Start>b__27_1(AssetHandle<SpriteAtlas> _handle) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A86C0 Offset: 0x1A87C1 VA: 0x1A86C0
	// RVA: 0x1CDF790 Offset: 0x1CDF891 VA: 0x1CDF790
	private void <EndMovie>b__38_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A86D0 Offset: 0x1A87D1 VA: 0x1A86D0
	// RVA: 0x1CDF8C0 Offset: 0x1CDF9C1 VA: 0x1CDF8C0
	private void <EndMovie>b__38_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A86E0 Offset: 0x1A87E1 VA: 0x1A86E0
	// RVA: 0x1CDF920 Offset: 0x1CDFA21 VA: 0x1CDF920
	private void <EndStaffRoll>b__43_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A86F0 Offset: 0x1A87F1 VA: 0x1A86F0
	// RVA: 0x1CDFA20 Offset: 0x1CDFB21 VA: 0x1CDFA20
	private void <EndStaffRoll>b__43_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8700 Offset: 0x1A8801 VA: 0x1A8700
	// RVA: 0x1CDFC20 Offset: 0x1CDFD21 VA: 0x1CDFC20
	private void <EndStaffRoll>b__43_2() { }
}

