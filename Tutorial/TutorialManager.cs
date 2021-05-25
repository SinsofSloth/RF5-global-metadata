public class TutorialManager : SingletonMonoBehaviour<TutorialManager> // TypeDefIndex: 9849
{
	// Fields
	private Vector3[] BattleTutorialPlayerPos; // 0x18
	private Tutorial ActiveTutorial; // 0x20
	private int monster_count_; // 0x24
	private TutorialDataTableArray LoadData; // 0x28
	private int cmd_index; // 0x30
	private bool is_cmd; // 0x34
	private Action EndAction; // 0x38
	[SerializeField] // RVA: 0x17F860 Offset: 0x17F961 VA: 0x17F860
	private int TutorialStep; // 0x40
	[SerializeField] // RVA: 0x17F870 Offset: 0x17F971 VA: 0x17F870
	private bool is_FarmHoe; // 0x44
	[SerializeField] // RVA: 0x17F880 Offset: 0x17F981 VA: 0x17F880
	private bool is_FarmSeed; // 0x45
	[SerializeField] // RVA: 0x17F890 Offset: 0x17F991 VA: 0x17F890
	private bool is_FarmPot; // 0x46
	[SerializeField] // RVA: 0x17F8A0 Offset: 0x17F9A1 VA: 0x17F8A0
	private bool is_CraftUIClose; // 0x47
	[SerializeField] // RVA: 0x17F8B0 Offset: 0x17F9B1 VA: 0x17F8B0
	private bool is_Making_RuckBig; // 0x48
	[SerializeField] // RVA: 0x17F8C0 Offset: 0x17F9C1 VA: 0x17F8C0
	private bool is_Making_Festival; // 0x49
	[SerializeField] // RVA: 0x17F8D0 Offset: 0x17F9D1 VA: 0x17F8D0
	private bool is_CloseMaking; // 0x4A
	[SerializeField] // RVA: 0x17F8E0 Offset: 0x17F9E1 VA: 0x17F8E0
	private bool is_BoxIn; // 0x4B
	private bool KeepPause; // 0x4C
	private EnemyBehaviorController[] enemyBehaviorController; // 0x50
	private GameObject FarmBlock; // 0x58
	private bool is_read; // 0x60
	private bool is_read_martin; // 0x61
	private bool emotion_flag; // 0x62
	private int LastKeyBuf; // 0x64
	private float wait_time_; // 0x68
	private string backup_focusName; // 0x70
	private const int WallID = 16346;
	private GameObject WallPrefab; // 0x78
	private GameObject[] Wall; // 0x80
	private int WallIndex; // 0x88
	private Vector3[] WallPos; // 0x90
	private float[] WallRotY; // 0x98

	// Methods

	// RVA: 0x1D2DEC0 Offset: 0x1D2DFC1 VA: 0x1D2DEC0
	public bool IsTutorial() { }

	// RVA: 0x1D2DED0 Offset: 0x1D2DFD1 VA: 0x1D2DED0
	public bool IsBattleTutorial() { }

	// RVA: 0x1D2DEF0 Offset: 0x1D2DFF1 VA: 0x1D2DEF0
	public bool IsFarmTutorial() { }

	// RVA: 0x1D2DF10 Offset: 0x1D2E011 VA: 0x1D2DF10
	public bool IsBlacksmithTutorial() { }

	// RVA: 0x1D2DF30 Offset: 0x1D2E031 VA: 0x1D2DF30
	public bool IsFarmEquipError() { }

	// RVA: 0x1D2DF60 Offset: 0x1D2E061 VA: 0x1D2DF60
	public TutorialManager.TutorialMaking IsMakingTutorial() { }

	// RVA: 0x1D2D650 Offset: 0x1D2D751 VA: 0x1D2D650
	public bool IsMonsterDead() { }

	// RVA: 0x1D2DFA0 Offset: 0x1D2E0A1 VA: 0x1D2DFA0
	public bool IsRead(int npcId) { }

	// RVA: 0x1D2E050 Offset: 0x1D2E151 VA: 0x1D2E050
	public void TutorialStart(Tutorial tuto, Action end_action) { }

	// RVA: 0x1D2E220 Offset: 0x1D2E321 VA: 0x1D2E220
	private void Start() { }

	// RVA: 0x1D2E2B0 Offset: 0x1D2E3B1 VA: 0x1D2E2B0
	private void OnDestroy() { }

	// RVA: 0x1D2E2C0 Offset: 0x1D2E3C1 VA: 0x1D2E2C0
	public void FarmInBox() { }

	// RVA: 0x1D2E3C0 Offset: 0x1D2E4C1 VA: 0x1D2E3C0
	private int GetOnGrounditemCount() { }

	// RVA: 0x1D2E7A0 Offset: 0x1D2E8A1 VA: 0x1D2E7A0
	private void Update() { }

	// RVA: 0x1D2F0D0 Offset: 0x1D2F1D1 VA: 0x1D2F0D0
	private void Next() { }

	// RVA: 0x1D2F3C0 Offset: 0x1D2F4C1 VA: 0x1D2F3C0
	private bool CheckFlag(string name) { }

	// RVA: 0x1D2EFE0 Offset: 0x1D2F0E1 VA: 0x1D2EFE0
	private void FarmClearEmotion() { }

	// RVA: 0x1D2FB60 Offset: 0x1D2FC61 VA: 0x1D2FB60
	private void PlayEmotionEffect(NPCID npcId, EmotionType emotionType) { }

	// RVA: 0x1D2E660 Offset: 0x1D2E761 VA: 0x1D2E660
	public bool CallScript(string script_name, Action end_action) { }

	// RVA: 0x1D2FC00 Offset: 0x1D2FD01 VA: 0x1D2FC00
	public void CallScript_Farm(string script_name) { }

	// RVA: 0x1D2FD80 Offset: 0x1D2FE81 VA: 0x1D2FD80
	public void CallScript_CarftUI(string script_name, Action end_action) { }

	// RVA: 0x1D2F0F0 Offset: 0x1D2F1F1 VA: 0x1D2F0F0
	private void EnableKey(int buf) { }

	// RVA: 0x1D2FF40 Offset: 0x1D30041 VA: 0x1D2FF40
	public void MonsterCreate(string monster, float x, float y, float z) { }

	// RVA: 0x1D2F2F0 Offset: 0x1D2F3F1 VA: 0x1D2F2F0
	private bool MonsterSetup(string monster) { }

	// RVA: 0x1D302A0 Offset: 0x1D303A1 VA: 0x1D302A0
	private bool MonsterSetup(int index) { }

	// RVA: 0x1D30350 Offset: 0x1D30451 VA: 0x1D30350
	private Vector3 GetPlayerPos(int index) { }

	// RVA: 0x1D30160 Offset: 0x1D30261 VA: 0x1D30160
	private void Monster(MonsterDataID monsterId, Vector3 pos, UnityAction<MonsterControllerBase> dead, int index) { }

	// RVA: 0x1D303A0 Offset: 0x1D304A1 VA: 0x1D303A0
	private void MocoDead(MonsterControllerBase monster) { }

	// RVA: 0x1D303B0 Offset: 0x1D304B1 VA: 0x1D303B0
	private void WaitStart(float time) { }

	// RVA: 0x1D303C0 Offset: 0x1D304C1 VA: 0x1D303C0
	public string GetNpcTalk(int npcId) { }

	// RVA: 0x1D30680 Offset: 0x1D30781 VA: 0x1D30680
	public void GetItem1() { }

	// RVA: 0x1D30710 Offset: 0x1D30811 VA: 0x1D30710
	public void GetItem2() { }

	// RVA: 0x1D307A0 Offset: 0x1D308A1 VA: 0x1D307A0
	public void GetItem3() { }

	// RVA: 0x1D30830 Offset: 0x1D30931 VA: 0x1D30830
	public void GetKabu1() { }

	// RVA: 0x1D308F0 Offset: 0x1D309F1 VA: 0x1D308F0
	public void GetKabu9() { }

	// RVA: 0x1D309B0 Offset: 0x1D30AB1 VA: 0x1D309B0
	public void GetIron1() { }

	// RVA: 0x1D2EEF0 Offset: 0x1D2EFF1 VA: 0x1D2EEF0
	public bool IsBox() { }

	// RVA: 0x1D2F4D0 Offset: 0x1D2F5D1 VA: 0x1D2F4D0
	private void CallUI() { }

	// RVA: 0x1D30A50 Offset: 0x1D30B51 VA: 0x1D30A50
	private void KeepPauseProc() { }

	// RVA: 0x1D2F880 Offset: 0x1D2F981 VA: 0x1D2F880
	private void SetFocusName(int npcId, string name) { }

	// RVA: 0x1D2F620 Offset: 0x1D2F721 VA: 0x1D2F620
	private void WallCreate() { }

	// RVA: 0x1D2F960 Offset: 0x1D2FA61 VA: 0x1D2F960
	private bool WallCreateSub() { }

	// RVA: 0x1D2F710 Offset: 0x1D2F811 VA: 0x1D2F710
	private void WallDelete() { }

	// RVA: 0x1D30AE0 Offset: 0x1D30BE1 VA: 0x1D30AE0
	public void FarmHoe() { }

	// RVA: 0x1D30B00 Offset: 0x1D30C01 VA: 0x1D30B00
	public void FarmSeed() { }

	// RVA: 0x1D30B20 Offset: 0x1D30C21 VA: 0x1D30B20
	public void FarmPot() { }

	// RVA: 0x1D30B40 Offset: 0x1D30C41 VA: 0x1D30B40
	public void FarmComplete() { }

	// RVA: 0x1D2D740 Offset: 0x1D2D841 VA: 0x1D2D740
	public bool IsFarmComplete() { }

	// RVA: 0x1D2D800 Offset: 0x1D2D901 VA: 0x1D2D800
	public bool IsBlacksmithNextStep() { }

	// RVA: 0x1D30B50 Offset: 0x1D30C51 VA: 0x1D30B50
	public void BlacksmithNextStep() { }

	// RVA: 0x1D30B60 Offset: 0x1D30C61 VA: 0x1D30B60
	public bool IsCraftUiClose() { }

	// RVA: 0x1D30B70 Offset: 0x1D30C71 VA: 0x1D30B70
	public void MakingClose(bool close) { }

	// RVA: 0x1D30B80 Offset: 0x1D30C81 VA: 0x1D30B80
	public bool IsMakingClose() { }

	// RVA: 0x1D30B90 Offset: 0x1D30C91 VA: 0x1D30B90
	public void MakingRuckBig() { }

	// RVA: 0x1D30C40 Offset: 0x1D30D41 VA: 0x1D30C40
	public void MakingFestival() { }

	// RVA: 0x1D30CF0 Offset: 0x1D30DF1 VA: 0x1D30CF0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD100 Offset: 0x1AD201 VA: 0x1AD100
	// RVA: 0x1D30FD0 Offset: 0x1D310D1 VA: 0x1D30FD0
	private void <TutorialStart>b__32_0(AssetHandle<TutorialDataTableArray> handle) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD110 Offset: 0x1AD211 VA: 0x1AD110
	// RVA: 0x1D31050 Offset: 0x1D31151 VA: 0x1D31050
	private void <TutorialStart>b__32_1(AssetHandle<GameObject> handle2) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD120 Offset: 0x1AD221 VA: 0x1AD120
	// RVA: 0x1D31110 Offset: 0x1D31211 VA: 0x1D31110
	private void <Update>b__37_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD130 Offset: 0x1AD231 VA: 0x1AD130
	// RVA: 0x1D311A0 Offset: 0x1D312A1 VA: 0x1D311A0
	private void <CallUI>b__64_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD140 Offset: 0x1AD241 VA: 0x1AD140
	// RVA: 0x1D311B0 Offset: 0x1D312B1 VA: 0x1D311B0
	private void <WallCreate>b__72_0(AssetHandle<GameObject> handle) { }
}

