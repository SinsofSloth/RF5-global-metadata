public class FishingManager : SingletonMonoBehaviour<FishingManager> // TypeDefIndex: 10296
{
	// Fields
	[SerializeField] // RVA: 0x180EC0 Offset: 0x180FC1 VA: 0x180EC0
	private float[] dist_tbl_; // 0x18
	[SerializeField] // RVA: 0x180ED0 Offset: 0x180FD1 VA: 0x180ED0
	public float EffectScale; // 0x20
	[SerializeField] // RVA: 0x180EE0 Offset: 0x180FE1 VA: 0x180EE0
	private float GetFishTime; // 0x24
	[SerializeField] // RVA: 0x180EF0 Offset: 0x180FF1 VA: 0x180EF0
	private Vector3 GetFishRotate; // 0x28
	[SerializeField] // RVA: 0x180F00 Offset: 0x181001 VA: 0x180F00
	[RangeAttribute] // RVA: 0x180F00 Offset: 0x181001 VA: 0x180F00
	private float SingleFishSpawnTime; // 0x34
	[SerializeField] // RVA: 0x180F50 Offset: 0x181051 VA: 0x180F50
	[RangeAttribute] // RVA: 0x180F50 Offset: 0x181051 VA: 0x180F50
	public float FishSwimTime; // 0x38
	[SerializeField] // RVA: 0x180FA0 Offset: 0x1810A1 VA: 0x180FA0
	[RangeAttribute] // RVA: 0x180FA0 Offset: 0x1810A1 VA: 0x180FA0
	public float FishSpawnInterval; // 0x3C
	[SerializeField] // RVA: 0x180FF0 Offset: 0x1810F1 VA: 0x180FF0
	[RangeAttribute] // RVA: 0x180FF0 Offset: 0x1810F1 VA: 0x180FF0
	public float GetFishSpawnInterval; // 0x40
	[SerializeField] // RVA: 0x181040 Offset: 0x181141 VA: 0x181040
	public float Depth; // 0x44
	[SerializeField] // RVA: 0x181050 Offset: 0x181151 VA: 0x181050
	private float Depth2; // 0x48
	[SerializeField] // RVA: 0x181060 Offset: 0x181161 VA: 0x181060
	public float NowDepth; // 0x4C
	[SerializeField] // RVA: 0x181070 Offset: 0x181171 VA: 0x181070
	private float PointDistance; // 0x50
	[SerializeField] // RVA: 0x181080 Offset: 0x181181 VA: 0x181080
	private Vector3 Effect_FishingGet_Pos; // 0x54
	[SerializeField] // RVA: 0x181090 Offset: 0x181191 VA: 0x181090
	private Vector3 Effect_FishingGetFirst_Pos; // 0x60
	public Vector3 FishManpuOffset; // 0x6C
	[HideInInspector] // RVA: 0x1810A0 Offset: 0x1811A1 VA: 0x1810A0
	public Vector3 OldCameraPos; // 0x78
	[HideInInspector] // RVA: 0x1810B0 Offset: 0x1811B1 VA: 0x1810B0
	public Quaternion OldCameraRot; // 0x84
	private FishingManager.State state; // 0x94
	private bool moyatto_effect; // 0x98
	private const int FishID = 17040;
	private const int FishIDNight = 17051;
	public readonly Vector3 DisableFishPos; // 0x9C
	public const float SPWAN_ADJUST = 0.45;
	private bool IsFirst; // 0xA8
	private bool IsMin; // 0xA9
	private bool IsMax; // 0xAA
	private bool IsGomi; // 0xAB
	private bool IsIka; // 0xAC
	private int FishType; // 0xB0
	private const float DAY_CHANGE_TIME = 1;
	private float DayChangeCountDown; // 0xB4
	private List<Vector3> FishingBoxList; // 0xB8
	private float FishSpawnIntervalCount; // 0xC0
	private List<KeyValuePair<int, FishSwim>> removeTargetLst; // 0xC8
	[HideInInspector] // RVA: 0x1810C0 Offset: 0x1811C1 VA: 0x1810C0
	public FishObjectPool FishObjectPool; // 0xD0
	private float[] fish_scale_tbl_; // 0xD8
	private int[] fish_size_tbl_; // 0xE0
	private GameObject[] FishShadow; // 0xE8
	private Material[] FishShadowMaterial; // 0xF0
	private List<FishingPoint> PointList; // 0xF8
	private List<FishSwim> AllFishList; // 0x100
	private FishSwim targetFish; // 0x108
	private int UniqueId; // 0x110
	private Dictionary<int, FishSwim> AimingFish; // 0x118
	private Dictionary<int, FishSwim> InactiveFish; // 0x120
	private Dictionary<int, FishSwim> PointSpwanFish; // 0x128
	private FishSwim[] hitFishSwimOrg; // 0x130
	private FishSwim hitFishSwim; // 0x138
	private int hitFishSize; // 0x140
	private Transform wkiModel; // 0x148
	private Transform wkiHitModel; // 0x150
	private Vector3 wkiTempPos; // 0x158
	private WkiController wki; // 0x168
	private WkiAnimation wkiAnimation; // 0x170
	private bool wki_entry_; // 0x178
	private const int WkiId = 17006;
	private const int WkiHitId = 17007;
	private GameObject wkiOya; // 0x180
	private FishingUI fishingUI; // 0x188
	private const int UI_ID = 16328;
	private bool IsPrevWater; // 0x190
	private Transform child0; // 0x198
	private Transform child1; // 0x1A0
	private Vector3 child0_pos; // 0x1A8
	private Vector3 child1_pos; // 0x1B4
	private Quaternion child0_rot; // 0x1C0
	private Quaternion child1_rot; // 0x1D0
	private OnGroundItem FirstFishObj; // 0x1E0
	private GameObject oya; // 0x1E8
	private ParticleSystem splash_effect_hard_; // 0x1F0
	private float fishingTime; // 0x1F8
	private bool isFishSpawn; // 0x1FC
	private bool isFirstAttack; // 0x1FD
	private bool isHatten; // 0x1FE
	private FishingManager.FishingState fishingState; // 0x200
	[CompilerGeneratedAttribute] // RVA: 0x1810D0 Offset: 0x1811D1 VA: 0x1810D0
	private string <ResultName>k__BackingField; // 0x208
	[CompilerGeneratedAttribute] // RVA: 0x1810E0 Offset: 0x1811E1 VA: 0x1810E0
	private string <ResultSize>k__BackingField; // 0x210
	[CompilerGeneratedAttribute] // RVA: 0x1810F0 Offset: 0x1811F1 VA: 0x1810F0
	private string <ResultCount>k__BackingField; // 0x218
	[CompilerGeneratedAttribute] // RVA: 0x181100 Offset: 0x181201 VA: 0x181100
	private int <ChargeLevel>k__BackingField; // 0x220
	private int RodType; // 0x224
	private ItemID EquipRod; // 0x228

	// Properties
	public Vector3 WkiPos { get; }
	private HumanController _human { get; }
	public string ResultName { get; set; }
	public string ResultSize { get; set; }
	public string ResultCount { get; set; }
	public int ChargeLevel { get; set; }

	// Methods

	// RVA: 0x1EF85B0 Offset: 0x1EF86B1 VA: 0x1EF85B0
	public void SetRecord(ItemID fish_id, int size, int stamp) { }

	// RVA: 0x1EF8830 Offset: 0x1EF8931 VA: 0x1EF8830
	public int SetStamp(ItemID name, int size) { }

	// RVA: 0x1EF8980 Offset: 0x1EF8A81 VA: 0x1EF8980
	private float GetDispScale(int disp_size_) { }

	// RVA: 0x1EF89C0 Offset: 0x1EF8AC1 VA: 0x1EF89C0
	private int GetDispSize(int size) { }

	// RVA: 0x1EF8A20 Offset: 0x1EF8B21 VA: 0x1EF8A20
	private void Start() { }

	// RVA: 0x1EF8DF0 Offset: 0x1EF8EF1 VA: 0x1EF8DF0
	private void OnDestroy() { }

	// RVA: 0x1EF9480 Offset: 0x1EF9581 VA: 0x1EF9480
	private void Update() { }

	// RVA: 0x1EF9C80 Offset: 0x1EF9D81 VA: 0x1EF9C80
	private void PointUpdate() { }

	// RVA: 0x1EFA770 Offset: 0x1EFA871 VA: 0x1EFA770
	public void RemovePoint(FishingPoint point) { }

	// RVA: 0x1EFA870 Offset: 0x1EFA971 VA: 0x1EFA870
	private void RemoveAllFishList(int unique_id) { }

	// RVA: 0x1EFA940 Offset: 0x1EFAA41 VA: 0x1EFA940
	private bool CheckDayFish() { }

	// RVA: 0x1EF9FA0 Offset: 0x1EFA0A1 VA: 0x1EF9FA0
	private void UpdateDayFish() { }

	// RVA: 0x1EFAAC0 Offset: 0x1EFABC1 VA: 0x1EFAAC0
	public int IsDay() { }

	// RVA: 0x1EFAB70 Offset: 0x1EFAC71 VA: 0x1EFAB70
	public void Create(FishingPoint point, int max = 3) { }

	// RVA: 0x1EFB780 Offset: 0x1EFB881 VA: 0x1EFB780
	private void Respawn(FishSwim fs) { }

	// RVA: 0x1EFBC60 Offset: 0x1EFBD61 VA: 0x1EFBC60
	public void SetTargetFish(FishSwim target) { }

	// RVA: 0x1EF7EE0 Offset: 0x1EF7FE1 VA: 0x1EF7EE0
	public int GetTargetFishSize() { }

	// RVA: 0x1EF61C0 Offset: 0x1EF62C1 VA: 0x1EF61C0
	public bool IsDecideTarget(int unique_id) { }

	// RVA: 0x1EF4D50 Offset: 0x1EF4E51 VA: 0x1EF4D50
	public int GetUniqueId() { }

	// RVA: 0x1EF6150 Offset: 0x1EF6251 VA: 0x1EF6150
	public void Add(int unique_id, FishSwim target) { }

	// RVA: 0x1EFBC70 Offset: 0x1EFBD71 VA: 0x1EFBC70
	private void Remove(int unique_id) { }

	// RVA: 0x1EFBCE0 Offset: 0x1EFBDE1 VA: 0x1EFBCE0
	private void WkiBack() { }

	// RVA: 0x1EFB6F0 Offset: 0x1EFB7F1 VA: 0x1EFB6F0
	private void InactiveAdd(int unique_id, FishSwim target, float time = 60) { }

	// RVA: 0x1EFBE50 Offset: 0x1EFBF51 VA: 0x1EFBE50
	private void InactiveRemove(int unique_id) { }

	// RVA: 0x1EFA270 Offset: 0x1EFA371 VA: 0x1EFA270
	private void InactiveUpdate() { }

	// RVA: 0x1EFB680 Offset: 0x1EFB781 VA: 0x1EFB680
	private void PointSpwanAdd(int unique_id, FishSwim target) { }

	// RVA: 0x1EFBEC0 Offset: 0x1EFBFC1 VA: 0x1EFBEC0
	private void PointSpwanRemove(int unique_id) { }

	// RVA: 0x1EFBF30 Offset: 0x1EFC031 VA: 0x1EFBF30
	public void PointSpwanCheck(Vector3 pos) { }

	// RVA: 0x1EF4EF0 Offset: 0x1EF4FF1 VA: 0x1EF4EF0
	public void DestroyFish(int unique_id) { }

	// RVA: 0x1EFC180 Offset: 0x1EFC281 VA: 0x1EFC180
	private void CreateHitFish() { }

	// RVA: 0x1EFC430 Offset: 0x1EFC531 VA: 0x1EFC430
	public void SpawnHitFish(Quaternion dir) { }

	// RVA: 0x1EFCD20 Offset: 0x1EFCE21 VA: 0x1EFCD20
	public float GetAim(Vector3 p1, Vector3 p2) { }

	// RVA: 0x1EF6090 Offset: 0x1EF6191 VA: 0x1EF6090
	public Vector3 get_WkiPos() { }

	// RVA: 0x1EFCDC0 Offset: 0x1EFCEC1 VA: 0x1EFCDC0
	private HumanController get__human() { }

	// RVA: 0x1EFCE30 Offset: 0x1EFCF31 VA: 0x1EFCE30
	public void WkiEntry() { }

	// RVA: 0x1EF9210 Offset: 0x1EF9311 VA: 0x1EF9210
	private void WkiRemove(Dictionary<EquipSlotType, HumanEquipItem> equipItemDic) { }

	// RVA: 0x1EFD040 Offset: 0x1EFD141 VA: 0x1EFD040
	public void WkiCast(Character chara, Vector3 pos, Quaternion dir) { }

	// RVA: 0x1EFD480 Offset: 0x1EFD581 VA: 0x1EFD480
	public bool IsWkiTopWater() { }

	// RVA: 0x1EFD580 Offset: 0x1EFD681 VA: 0x1EFD580
	public bool IsWkiGround() { }

	// RVA: 0x1EFD670 Offset: 0x1EFD771 VA: 0x1EFD670
	public bool IsReduceRp() { }

	// RVA: 0x1EFD140 Offset: 0x1EFD241 VA: 0x1EFD140
	private bool WkiCreate() { }

	// RVA: 0x1EFD680 Offset: 0x1EFD781 VA: 0x1EFD680
	public void WkiDestroy() { }

	// RVA: 0x1EFD460 Offset: 0x1EFD561 VA: 0x1EFD460
	public void WkiAnime(WkiAnimation.FishAnime anime) { }

	// RVA: 0x1EF5F50 Offset: 0x1EF6051 VA: 0x1EF5F50
	public bool IsNear(Vector3 fish_pos) { }

	// RVA: 0x1EFD7E0 Offset: 0x1EFD8E1 VA: 0x1EFD7E0
	private void UICreate() { }

	// RVA: 0x1EFD9E0 Offset: 0x1EFDAE1 VA: 0x1EFD9E0
	private void UIDestroy() { }

	// RVA: 0x1EF7D00 Offset: 0x1EF7E01 VA: 0x1EF7D00
	public void FishHit() { }

	// RVA: 0x1EF6370 Offset: 0x1EF6471 VA: 0x1EF6370
	public void Escape(bool motion_update = True) { }

	// RVA: 0x1EFDE70 Offset: 0x1EFDF71 VA: 0x1EFDE70
	private void WkiReturn(bool isEscape = False) { }

	// RVA: 0x1EF63B0 Offset: 0x1EF64B1 VA: 0x1EF63B0
	public void Leave(FishSwim target) { }

	// RVA: 0x1EFDFF0 Offset: 0x1EFE0F1 VA: 0x1EFDFF0
	public void CancelCore(bool is_escape) { }

	// RVA: 0x1EFE2E0 Offset: 0x1EFE3E1 VA: 0x1EFE2E0
	public void WarpCancel() { }

	// RVA: 0x1EFDB30 Offset: 0x1EFDC31 VA: 0x1EFDB30
	public void PlayerAnimation(string anime) { }

	// RVA: 0x1EFDA90 Offset: 0x1EFDB91 VA: 0x1EFDA90
	public bool IsHatten() { }

	// RVA: 0x1EFE510 Offset: 0x1EFE611 VA: 0x1EFE510
	public void Hatten() { }

	// RVA: 0x1EFE630 Offset: 0x1EFE731 VA: 0x1EFE630
	public void GetFish() { }

	[IteratorStateMachineAttribute] // RVA: 0x1ADFE0 Offset: 0x1AE0E1 VA: 0x1ADFE0
	// RVA: 0x1EFE820 Offset: 0x1EFE921 VA: 0x1EFE820
	private IEnumerator GetFish2() { }

	// RVA: 0x1EFE8A0 Offset: 0x1EFE9A1 VA: 0x1EFE8A0
	private void OnGroundItemInit(OnGroundItem obj, float xr, float yr, float zr) { }

	// RVA: 0x1EFEC00 Offset: 0x1EFED01 VA: 0x1EFEC00
	private ItemID ReLottery(ItemID item_id) { }

	// RVA: 0x1EFECB0 Offset: 0x1EFEDB1 VA: 0x1EFECB0
	private ItemID ChangeFish(ItemID name) { }

	// RVA: 0x1EFED70 Offset: 0x1EFEE71 VA: 0x1EFED70
	private bool CheckGomi(ItemID target) { }

	// RVA: 0x1EFEDB0 Offset: 0x1EFEEB1 VA: 0x1EFEDB0
	private bool CheckIka(ItemID target) { }

	// RVA: 0x1EFEDE0 Offset: 0x1EFEEE1 VA: 0x1EFEDE0
	private int CheckFishType(ItemID target) { }

	// RVA: 0x1EFDCF0 Offset: 0x1EFDDF1 VA: 0x1EFDCF0
	private void PlayStopSplashEffect(Transform trans) { }

	// RVA: 0x1EFE200 Offset: 0x1EFE301 VA: 0x1EFE200
	private void StopSplashEffect() { }

	// RVA: 0x1EFEE20 Offset: 0x1EFEF21 VA: 0x1EFEE20
	public void PlayWaitEffect(Transform trans) { }

	// RVA: 0x1EFAB60 Offset: 0x1EFAC61 VA: 0x1EFAB60
	public bool IsFishing() { }

	// RVA: 0x1EF9540 Offset: 0x1EF9641 VA: 0x1EF9540
	private void FishingUpdate() { }

	// RVA: 0x1EFF2E0 Offset: 0x1EFF3E1 VA: 0x1EFF2E0
	private bool IsIroiroTaikai() { }

	// RVA: 0x1EFB590 Offset: 0x1EFB691 VA: 0x1EFB590
	private bool IsIkaTaikai() { }

	// RVA: 0x1EFF3D0 Offset: 0x1EFF4D1 VA: 0x1EFF3D0
	private bool IsTaikaiEnd() { }

	// RVA: 0x1EFF460 Offset: 0x1EFF561 VA: 0x1EFF460
	private void Result(ItemID target) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE050 Offset: 0x1AE151 VA: 0x1AE050
	// RVA: 0x1EFF880 Offset: 0x1EFF981 VA: 0x1EFF880
	public string get_ResultName() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE060 Offset: 0x1AE161 VA: 0x1AE060
	// RVA: 0x1EFF890 Offset: 0x1EFF991 VA: 0x1EFF890
	private void set_ResultName(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE070 Offset: 0x1AE171 VA: 0x1AE070
	// RVA: 0x1EFF8A0 Offset: 0x1EFF9A1 VA: 0x1EFF8A0
	public string get_ResultSize() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE080 Offset: 0x1AE181 VA: 0x1AE080
	// RVA: 0x1EFF8B0 Offset: 0x1EFF9B1 VA: 0x1EFF8B0
	private void set_ResultSize(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE090 Offset: 0x1AE191 VA: 0x1AE090
	// RVA: 0x1EFF8C0 Offset: 0x1EFF9C1 VA: 0x1EFF8C0
	public string get_ResultCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE0A0 Offset: 0x1AE1A1 VA: 0x1AE0A0
	// RVA: 0x1EFF8D0 Offset: 0x1EFF9D1 VA: 0x1EFF8D0
	private void set_ResultCount(string value) { }

	// RVA: 0x1EFCB50 Offset: 0x1EFCC51 VA: 0x1EFCB50
	private string GetPointName() { }

	// RVA: 0x1EFF8E0 Offset: 0x1EFF9E1 VA: 0x1EFF8E0
	private bool IsSunny() { }

	// RVA: 0x1EFB390 Offset: 0x1EFB491 VA: 0x1EFB390
	private int GetSeason(string point_name) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE0B0 Offset: 0x1AE1B1 VA: 0x1AE0B0
	// RVA: 0x1EFF950 Offset: 0x1EFFA51 VA: 0x1EFF950
	public int get_ChargeLevel() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE0C0 Offset: 0x1AE1C1 VA: 0x1AE0C0
	// RVA: 0x1EFF960 Offset: 0x1EFFA61 VA: 0x1EFF960
	private void set_ChargeLevel(int value) { }

	// RVA: 0x1EFF970 Offset: 0x1EFFA71 VA: 0x1EFF970
	public void SetChargeLevel(int level) { }

	// RVA: 0x1EFF120 Offset: 0x1EFF221 VA: 0x1EFF120
	public void FishingRodAnime(RodAnimation.RodAnime anime) { }

	// RVA: 0x1EFF060 Offset: 0x1EFF161 VA: 0x1EFF060
	private void PlayManpu(EmotionType emotionType, float dispTime = 1000) { }

	// RVA: 0x1EFFAC0 Offset: 0x1EFFBC1 VA: 0x1EFFAC0
	public void Min2DEffect() { }

	// RVA: 0x1EFFAE0 Offset: 0x1EFFBE1 VA: 0x1EFFAE0
	public void Max2DEffect() { }

	// RVA: 0x1EFFB00 Offset: 0x1EFFC01 VA: 0x1EFFB00
	public void Stop2DEffect() { }

	// RVA: 0x1EFFB20 Offset: 0x1EFFC21 VA: 0x1EFFB20
	public FishingManager.ResultTwoPlay GetTwoPlayFish(string point = "HOME-P2-W") { }

	// RVA: 0x1EFFC70 Offset: 0x1EFFD71 VA: 0x1EFFC70
	private string GetCmSize(int mmsize) { }

	// RVA: 0x1EFB480 Offset: 0x1EFB581 VA: 0x1EFB480
	public ItemData GetRodItemData() { }

	// RVA: 0x1EFFD00 Offset: 0x1EFFE01 VA: 0x1EFFD00
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE0D0 Offset: 0x1AE1D1 VA: 0x1AE0D0
	// RVA: 0x1F001A0 Offset: 0x1F002A1 VA: 0x1F001A0
	private void <Start>b__44_0(AssetHandle<GameObject> handle) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE0E0 Offset: 0x1AE1E1 VA: 0x1AE0E0
	// RVA: 0x1F002D0 Offset: 0x1F003D1 VA: 0x1F002D0
	private void <Start>b__44_1(AssetHandle<GameObject> handle2) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE0F0 Offset: 0x1AE1F1 VA: 0x1AE0F0
	// RVA: 0x1F00450 Offset: 0x1F00551 VA: 0x1F00450
	private void <PlayStopSplashEffect>b__136_0(ParticleSystem par) { }
}

