public class FestivalManager : SingletonMonoBehaviour<FestivalManager> // TypeDefIndex: 10314
{
	// Fields
	public static bool IsMemories; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x181280 Offset: 0x181381 VA: 0x181280
	private static bool <IsMiniGame>k__BackingField; // 0x1
	[CompilerGeneratedAttribute] // RVA: 0x181290 Offset: 0x181391 VA: 0x181290
	private FestivalParamter <FestivalParamter>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x1812A0 Offset: 0x1813A1 VA: 0x1812A0
	private float <TimeCount>k__BackingField; // 0x20
	public const float FIELD_HEIGHT = 13.31;
	[CompilerGeneratedAttribute] // RVA: 0x1812B0 Offset: 0x1813B1 VA: 0x1812B0
	private float <PlayerScore>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x1812C0 Offset: 0x1813C1 VA: 0x1812C0
	private List<ActorID> <GluttonActorList>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x1812D0 Offset: 0x1813D1 VA: 0x1812D0
	private List<ActorID> <PetActorList>k__BackingField; // 0x30
	private List<ActorID> petRankingList; // 0x38
	private List<ActorID> festivalVistorActorList; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x1812E0 Offset: 0x1813E1 VA: 0x1812E0
	private List<ActorID> <PartnerNPCList>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x1812F0 Offset: 0x1813F1 VA: 0x1812F0
	private bool <IsLoading>k__BackingField; // 0x50
	private bool nextRound; // 0x51
	private bool isBattleEnd; // 0x52
	private CheerVoiceDataTable cheerVoiceDataTable; // 0x58
	[SerializeField] // RVA: 0x181300 Offset: 0x181401 VA: 0x181300
	private FestivalPlayerInput festivalInput; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x181310 Offset: 0x181411 VA: 0x181310
	private FestivalUI <FestivalUI>k__BackingField; // 0x68
	private int festivalUIID; // 0x70
	private readonly Dictionary<FestivalType, Event> FESTIVAL_TYPE_TO_EVENT; // 0x78
	private bool isTimeLimit; // 0x80
	public static FestivalType Type; // 0x4
	[CompilerGeneratedAttribute] // RVA: 0x181320 Offset: 0x181421 VA: 0x181320
	private FestivalState <State>k__BackingField; // 0x84

	// Properties
	public static FestivalCharacterController FestivalPlayer { get; }
	public static bool IsMiniGame { get; set; }
	public FestivalParamter FestivalParamter { get; set; }
	public float TimeCount { get; set; }
	public float PlayerScore { get; set; }
	public List<ActorID> GluttonActorList { get; set; }
	public List<ActorID> PetActorList { get; set; }
	public List<ActorID> PartnerNPCList { get; set; }
	public bool IsLoading { get; set; }
	public bool NextRound { get; set; }
	public bool IsBattleEnd { get; set; }
	public bool IsPlaying { get; }
	public FestivalUI FestivalUI { get; set; }
	public FestivalState State { get; set; }

	// Methods

	// RVA: 0x2037050 Offset: 0x2037151 VA: 0x2037050
	public static FestivalCharacterController get_FestivalPlayer() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE1B0 Offset: 0x1AE2B1 VA: 0x1AE1B0
	// RVA: 0x2037D10 Offset: 0x2037E11 VA: 0x2037D10
	public static bool get_IsMiniGame() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE1C0 Offset: 0x1AE2C1 VA: 0x1AE1C0
	// RVA: 0x2037D80 Offset: 0x2037E81 VA: 0x2037D80
	private static void set_IsMiniGame(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE1D0 Offset: 0x1AE2D1 VA: 0x1AE1D0
	// RVA: 0x2037DF0 Offset: 0x2037EF1 VA: 0x2037DF0
	public FestivalParamter get_FestivalParamter() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE1E0 Offset: 0x1AE2E1 VA: 0x1AE1E0
	// RVA: 0x2037E00 Offset: 0x2037F01 VA: 0x2037E00
	private void set_FestivalParamter(FestivalParamter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE1F0 Offset: 0x1AE2F1 VA: 0x1AE1F0
	// RVA: 0x2037E10 Offset: 0x2037F11 VA: 0x2037E10
	public float get_TimeCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE200 Offset: 0x1AE301 VA: 0x1AE200
	// RVA: 0x2037E20 Offset: 0x2037F21 VA: 0x2037E20
	private void set_TimeCount(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE210 Offset: 0x1AE311 VA: 0x1AE210
	// RVA: 0x2037E30 Offset: 0x2037F31 VA: 0x2037E30
	public float get_PlayerScore() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE220 Offset: 0x1AE321 VA: 0x1AE220
	// RVA: 0x2037E40 Offset: 0x2037F41 VA: 0x2037E40
	private void set_PlayerScore(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE230 Offset: 0x1AE331 VA: 0x1AE230
	// RVA: 0x2037E50 Offset: 0x2037F51 VA: 0x2037E50
	public List<ActorID> get_GluttonActorList() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE240 Offset: 0x1AE341 VA: 0x1AE240
	// RVA: 0x2037E60 Offset: 0x2037F61 VA: 0x2037E60
	private void set_GluttonActorList(List<ActorID> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE250 Offset: 0x1AE351 VA: 0x1AE250
	// RVA: 0x2037E70 Offset: 0x2037F71 VA: 0x2037E70
	public List<ActorID> get_PetActorList() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE260 Offset: 0x1AE361 VA: 0x1AE260
	// RVA: 0x2037E80 Offset: 0x2037F81 VA: 0x2037E80
	private void set_PetActorList(List<ActorID> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE270 Offset: 0x1AE371 VA: 0x1AE270
	// RVA: 0x2037E90 Offset: 0x2037F91 VA: 0x2037E90
	public List<ActorID> get_PartnerNPCList() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE280 Offset: 0x1AE381 VA: 0x1AE280
	// RVA: 0x2037EA0 Offset: 0x2037FA1 VA: 0x2037EA0
	private void set_PartnerNPCList(List<ActorID> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE290 Offset: 0x1AE391 VA: 0x1AE290
	// RVA: 0x2037EB0 Offset: 0x2037FB1 VA: 0x2037EB0
	public bool get_IsLoading() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE2A0 Offset: 0x1AE3A1 VA: 0x1AE2A0
	// RVA: 0x2037EC0 Offset: 0x2037FC1 VA: 0x2037EC0
	private void set_IsLoading(bool value) { }

	// RVA: 0x2037ED0 Offset: 0x2037FD1 VA: 0x2037ED0
	public bool get_NextRound() { }

	// RVA: 0x2037EE0 Offset: 0x2037FE1 VA: 0x2037EE0
	public void set_NextRound(bool value) { }

	// RVA: 0x2037F70 Offset: 0x2038071 VA: 0x2037F70
	public bool get_IsBattleEnd() { }

	// RVA: 0x2037F80 Offset: 0x2038081 VA: 0x2037F80
	public void set_IsBattleEnd(bool value) { }

	// RVA: 0x2038010 Offset: 0x2038111 VA: 0x2038010
	public bool get_IsPlaying() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE2B0 Offset: 0x1AE3B1 VA: 0x1AE2B0
	// RVA: 0x2038040 Offset: 0x2038141 VA: 0x2038040
	public FestivalUI get_FestivalUI() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE2C0 Offset: 0x1AE3C1 VA: 0x1AE2C0
	// RVA: 0x2038050 Offset: 0x2038151 VA: 0x2038050
	private void set_FestivalUI(FestivalUI value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE2D0 Offset: 0x1AE3D1 VA: 0x1AE2D0
	// RVA: 0x2038060 Offset: 0x2038161 VA: 0x2038060
	public FestivalState get_State() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE2E0 Offset: 0x1AE3E1 VA: 0x1AE2E0
	// RVA: 0x2038070 Offset: 0x2038171 VA: 0x2038070
	private void set_State(FestivalState value) { }

	// RVA: 0x2038080 Offset: 0x2038181 VA: 0x2038080 Slot: 4
	protected override void Awake() { }

	// RVA: 0x20382B0 Offset: 0x20383B1 VA: 0x20382B0
	private void Start() { }

	// RVA: 0x2038B60 Offset: 0x2038C61 VA: 0x2038B60
	private void Update() { }

	// RVA: 0x20393F0 Offset: 0x20394F1 VA: 0x20393F0
	private void OnDestroy() { }

	// RVA: 0x2038A20 Offset: 0x2038B21 VA: 0x2038A20
	private void UILoading() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AE2F0 Offset: 0x1AE3F1 VA: 0x1AE2F0
	// RVA: 0x2039460 Offset: 0x2039561 VA: 0x2039460
	public IEnumerator CountDown() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AE360 Offset: 0x1AE461 VA: 0x1AE360
	// RVA: 0x2039510 Offset: 0x2039611 VA: 0x2039510
	public IEnumerator OnFinishCoroutine() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AE3D0 Offset: 0x1AE4D1 VA: 0x1AE3D0
	// RVA: 0x2039590 Offset: 0x2039691 VA: 0x2039590
	public IEnumerator OnNextRoundCoroutine() { }

	// RVA: 0x2039610 Offset: 0x2039711 VA: 0x2039610
	public void AddScore(float _score) { }

	// RVA: 0x2039650 Offset: 0x2039751 VA: 0x2039650
	public void SetScore(float _score) { }

	// RVA: 0x2039750 Offset: 0x2039851 VA: 0x2039750
	public ActorID FestivalActorLottery() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AE440 Offset: 0x1AE541 VA: 0x1AE440
	// RVA: 0x20397E0 Offset: 0x20398E1 VA: 0x20397E0
	public IEnumerator PlayCheerVoice() { }

	// RVA: 0x2039860 Offset: 0x2039961 VA: 0x2039860
	public void RemoveCheerActor(List<ActorID> _ignore_list) { }

	// RVA: 0x2039980 Offset: 0x2039A81 VA: 0x2039980
	public void RemoveCheerActor(ActorID _actor_id) { }

	// RVA: 0x20399A0 Offset: 0x2039AA1 VA: 0x20399A0
	public void SetPetRankingList(List<ActorID> _ranking_list) { }

	[IteratorStateMachineAttribute] // RVA: 0x1AE4B0 Offset: 0x1AE5B1 VA: 0x1AE4B0
	// RVA: 0x2039A50 Offset: 0x2039B51 VA: 0x2039A50
	private IEnumerator OnTalkingADV(string _script_name) { }

	// RVA: 0x2039AD0 Offset: 0x2039BD1 VA: 0x2039AD0
	private void CallBackAfterTeleporting() { }

	// RVA: 0x2039C70 Offset: 0x2039D71 VA: 0x2039C70
	public void .ctor() { }

	// RVA: 0x2039E50 Offset: 0x2039F51 VA: 0x2039E50
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE520 Offset: 0x1AE621 VA: 0x1AE520
	// RVA: 0x2039E60 Offset: 0x2039F61 VA: 0x2039E60
	private void <Update>b__64_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE530 Offset: 0x1AE631 VA: 0x1AE530
	// RVA: 0x203A0F0 Offset: 0x203A1F1 VA: 0x203A0F0
	private void <Update>b__64_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE540 Offset: 0x1AE641 VA: 0x1AE540
	// RVA: 0x203A210 Offset: 0x203A311 VA: 0x203A210
	private void <Update>b__64_2() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE550 Offset: 0x1AE651 VA: 0x1AE550
	// RVA: 0x203A220 Offset: 0x203A321 VA: 0x203A220
	private void <UILoading>b__66_0(AssetHandle<GameObject> _handle) { }
}

public class FestivalManager : SingletonMonoBehaviour<FestivalManager> // TypeDefIndex: 10314
{
	// Fields
	public static bool IsMemories; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x181280 Offset: 0x181381 VA: 0x181280
	private static bool <IsMiniGame>k__BackingField; // 0x1
	[CompilerGeneratedAttribute] // RVA: 0x181290 Offset: 0x181391 VA: 0x181290
	private FestivalParamter <FestivalParamter>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x1812A0 Offset: 0x1813A1 VA: 0x1812A0
	private float <TimeCount>k__BackingField; // 0x20
	public const float FIELD_HEIGHT = 13.31;
	[CompilerGeneratedAttribute] // RVA: 0x1812B0 Offset: 0x1813B1 VA: 0x1812B0
	private float <PlayerScore>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x1812C0 Offset: 0x1813C1 VA: 0x1812C0
	private List<ActorID> <GluttonActorList>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x1812D0 Offset: 0x1813D1 VA: 0x1812D0
	private List<ActorID> <PetActorList>k__BackingField; // 0x30
	private List<ActorID> petRankingList; // 0x38
	private List<ActorID> festivalVistorActorList; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x1812E0 Offset: 0x1813E1 VA: 0x1812E0
	private List<ActorID> <PartnerNPCList>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x1812F0 Offset: 0x1813F1 VA: 0x1812F0
	private bool <IsLoading>k__BackingField; // 0x50
	private bool nextRound; // 0x51
	private bool isBattleEnd; // 0x52
	private CheerVoiceDataTable cheerVoiceDataTable; // 0x58
	[SerializeField] // RVA: 0x181300 Offset: 0x181401 VA: 0x181300
	private FestivalPlayerInput festivalInput; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x181310 Offset: 0x181411 VA: 0x181310
	private FestivalUI <FestivalUI>k__BackingField; // 0x68
	private int festivalUIID; // 0x70
	private readonly Dictionary<FestivalType, Event> FESTIVAL_TYPE_TO_EVENT; // 0x78
	private bool isTimeLimit; // 0x80
	public static FestivalType Type; // 0x4
	[CompilerGeneratedAttribute] // RVA: 0x181320 Offset: 0x181421 VA: 0x181320
	private FestivalState <State>k__BackingField; // 0x84

	// Properties
	public static FestivalCharacterController FestivalPlayer { get; }
	public static bool IsMiniGame { get; set; }
	public FestivalParamter FestivalParamter { get; set; }
	public float TimeCount { get; set; }
	public float PlayerScore { get; set; }
	public List<ActorID> GluttonActorList { get; set; }
	public List<ActorID> PetActorList { get; set; }
	public List<ActorID> PartnerNPCList { get; set; }
	public bool IsLoading { get; set; }
	public bool NextRound { get; set; }
	public bool IsBattleEnd { get; set; }
	public bool IsPlaying { get; }
	public FestivalUI FestivalUI { get; set; }
	public FestivalState State { get; set; }

	// Methods

	// RVA: 0x2037050 Offset: 0x2037151 VA: 0x2037050
	public static FestivalCharacterController get_FestivalPlayer() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE1B0 Offset: 0x1AE2B1 VA: 0x1AE1B0
	// RVA: 0x2037D10 Offset: 0x2037E11 VA: 0x2037D10
	public static bool get_IsMiniGame() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE1C0 Offset: 0x1AE2C1 VA: 0x1AE1C0
	// RVA: 0x2037D80 Offset: 0x2037E81 VA: 0x2037D80
	private static void set_IsMiniGame(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE1D0 Offset: 0x1AE2D1 VA: 0x1AE1D0
	// RVA: 0x2037DF0 Offset: 0x2037EF1 VA: 0x2037DF0
	public FestivalParamter get_FestivalParamter() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE1E0 Offset: 0x1AE2E1 VA: 0x1AE1E0
	// RVA: 0x2037E00 Offset: 0x2037F01 VA: 0x2037E00
	private void set_FestivalParamter(FestivalParamter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE1F0 Offset: 0x1AE2F1 VA: 0x1AE1F0
	// RVA: 0x2037E10 Offset: 0x2037F11 VA: 0x2037E10
	public float get_TimeCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE200 Offset: 0x1AE301 VA: 0x1AE200
	// RVA: 0x2037E20 Offset: 0x2037F21 VA: 0x2037E20
	private void set_TimeCount(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE210 Offset: 0x1AE311 VA: 0x1AE210
	// RVA: 0x2037E30 Offset: 0x2037F31 VA: 0x2037E30
	public float get_PlayerScore() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE220 Offset: 0x1AE321 VA: 0x1AE220
	// RVA: 0x2037E40 Offset: 0x2037F41 VA: 0x2037E40
	private void set_PlayerScore(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE230 Offset: 0x1AE331 VA: 0x1AE230
	// RVA: 0x2037E50 Offset: 0x2037F51 VA: 0x2037E50
	public List<ActorID> get_GluttonActorList() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE240 Offset: 0x1AE341 VA: 0x1AE240
	// RVA: 0x2037E60 Offset: 0x2037F61 VA: 0x2037E60
	private void set_GluttonActorList(List<ActorID> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE250 Offset: 0x1AE351 VA: 0x1AE250
	// RVA: 0x2037E70 Offset: 0x2037F71 VA: 0x2037E70
	public List<ActorID> get_PetActorList() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE260 Offset: 0x1AE361 VA: 0x1AE260
	// RVA: 0x2037E80 Offset: 0x2037F81 VA: 0x2037E80
	private void set_PetActorList(List<ActorID> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE270 Offset: 0x1AE371 VA: 0x1AE270
	// RVA: 0x2037E90 Offset: 0x2037F91 VA: 0x2037E90
	public List<ActorID> get_PartnerNPCList() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE280 Offset: 0x1AE381 VA: 0x1AE280
	// RVA: 0x2037EA0 Offset: 0x2037FA1 VA: 0x2037EA0
	private void set_PartnerNPCList(List<ActorID> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE290 Offset: 0x1AE391 VA: 0x1AE290
	// RVA: 0x2037EB0 Offset: 0x2037FB1 VA: 0x2037EB0
	public bool get_IsLoading() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE2A0 Offset: 0x1AE3A1 VA: 0x1AE2A0
	// RVA: 0x2037EC0 Offset: 0x2037FC1 VA: 0x2037EC0
	private void set_IsLoading(bool value) { }

	// RVA: 0x2037ED0 Offset: 0x2037FD1 VA: 0x2037ED0
	public bool get_NextRound() { }

	// RVA: 0x2037EE0 Offset: 0x2037FE1 VA: 0x2037EE0
	public void set_NextRound(bool value) { }

	// RVA: 0x2037F70 Offset: 0x2038071 VA: 0x2037F70
	public bool get_IsBattleEnd() { }

	// RVA: 0x2037F80 Offset: 0x2038081 VA: 0x2037F80
	public void set_IsBattleEnd(bool value) { }

	// RVA: 0x2038010 Offset: 0x2038111 VA: 0x2038010
	public bool get_IsPlaying() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE2B0 Offset: 0x1AE3B1 VA: 0x1AE2B0
	// RVA: 0x2038040 Offset: 0x2038141 VA: 0x2038040
	public FestivalUI get_FestivalUI() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE2C0 Offset: 0x1AE3C1 VA: 0x1AE2C0
	// RVA: 0x2038050 Offset: 0x2038151 VA: 0x2038050
	private void set_FestivalUI(FestivalUI value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE2D0 Offset: 0x1AE3D1 VA: 0x1AE2D0
	// RVA: 0x2038060 Offset: 0x2038161 VA: 0x2038060
	public FestivalState get_State() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE2E0 Offset: 0x1AE3E1 VA: 0x1AE2E0
	// RVA: 0x2038070 Offset: 0x2038171 VA: 0x2038070
	private void set_State(FestivalState value) { }

	// RVA: 0x2038080 Offset: 0x2038181 VA: 0x2038080 Slot: 4
	protected override void Awake() { }

	// RVA: 0x20382B0 Offset: 0x20383B1 VA: 0x20382B0
	private void Start() { }

	// RVA: 0x2038B60 Offset: 0x2038C61 VA: 0x2038B60
	private void Update() { }

	// RVA: 0x20393F0 Offset: 0x20394F1 VA: 0x20393F0
	private void OnDestroy() { }

	// RVA: 0x2038A20 Offset: 0x2038B21 VA: 0x2038A20
	private void UILoading() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AE2F0 Offset: 0x1AE3F1 VA: 0x1AE2F0
	// RVA: 0x2039460 Offset: 0x2039561 VA: 0x2039460
	public IEnumerator CountDown() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AE360 Offset: 0x1AE461 VA: 0x1AE360
	// RVA: 0x2039510 Offset: 0x2039611 VA: 0x2039510
	public IEnumerator OnFinishCoroutine() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AE3D0 Offset: 0x1AE4D1 VA: 0x1AE3D0
	// RVA: 0x2039590 Offset: 0x2039691 VA: 0x2039590
	public IEnumerator OnNextRoundCoroutine() { }

	// RVA: 0x2039610 Offset: 0x2039711 VA: 0x2039610
	public void AddScore(float _score) { }

	// RVA: 0x2039650 Offset: 0x2039751 VA: 0x2039650
	public void SetScore(float _score) { }

	// RVA: 0x2039750 Offset: 0x2039851 VA: 0x2039750
	public ActorID FestivalActorLottery() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AE440 Offset: 0x1AE541 VA: 0x1AE440
	// RVA: 0x20397E0 Offset: 0x20398E1 VA: 0x20397E0
	public IEnumerator PlayCheerVoice() { }

	// RVA: 0x2039860 Offset: 0x2039961 VA: 0x2039860
	public void RemoveCheerActor(List<ActorID> _ignore_list) { }

	// RVA: 0x2039980 Offset: 0x2039A81 VA: 0x2039980
	public void RemoveCheerActor(ActorID _actor_id) { }

	// RVA: 0x20399A0 Offset: 0x2039AA1 VA: 0x20399A0
	public void SetPetRankingList(List<ActorID> _ranking_list) { }

	[IteratorStateMachineAttribute] // RVA: 0x1AE4B0 Offset: 0x1AE5B1 VA: 0x1AE4B0
	// RVA: 0x2039A50 Offset: 0x2039B51 VA: 0x2039A50
	private IEnumerator OnTalkingADV(string _script_name) { }

	// RVA: 0x2039AD0 Offset: 0x2039BD1 VA: 0x2039AD0
	private void CallBackAfterTeleporting() { }

	// RVA: 0x2039C70 Offset: 0x2039D71 VA: 0x2039C70
	public void .ctor() { }

	// RVA: 0x2039E50 Offset: 0x2039F51 VA: 0x2039E50
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE520 Offset: 0x1AE621 VA: 0x1AE520
	// RVA: 0x2039E60 Offset: 0x2039F61 VA: 0x2039E60
	private void <Update>b__64_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE530 Offset: 0x1AE631 VA: 0x1AE530
	// RVA: 0x203A0F0 Offset: 0x203A1F1 VA: 0x203A0F0
	private void <Update>b__64_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE540 Offset: 0x1AE641 VA: 0x1AE540
	// RVA: 0x203A210 Offset: 0x203A311 VA: 0x203A210
	private void <Update>b__64_2() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE550 Offset: 0x1AE651 VA: 0x1AE550
	// RVA: 0x203A220 Offset: 0x203A321 VA: 0x203A220
	private void <UILoading>b__66_0(AssetHandle<GameObject> _handle) { }
}

public class FestivalManager : SingletonMonoBehaviour<FestivalManager> // TypeDefIndex: 10314
{
	// Fields
	public static bool IsMemories; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x181280 Offset: 0x181381 VA: 0x181280
	private static bool <IsMiniGame>k__BackingField; // 0x1
	[CompilerGeneratedAttribute] // RVA: 0x181290 Offset: 0x181391 VA: 0x181290
	private FestivalParamter <FestivalParamter>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x1812A0 Offset: 0x1813A1 VA: 0x1812A0
	private float <TimeCount>k__BackingField; // 0x20
	public const float FIELD_HEIGHT = 13.31;
	[CompilerGeneratedAttribute] // RVA: 0x1812B0 Offset: 0x1813B1 VA: 0x1812B0
	private float <PlayerScore>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x1812C0 Offset: 0x1813C1 VA: 0x1812C0
	private List<ActorID> <GluttonActorList>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x1812D0 Offset: 0x1813D1 VA: 0x1812D0
	private List<ActorID> <PetActorList>k__BackingField; // 0x30
	private List<ActorID> petRankingList; // 0x38
	private List<ActorID> festivalVistorActorList; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x1812E0 Offset: 0x1813E1 VA: 0x1812E0
	private List<ActorID> <PartnerNPCList>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x1812F0 Offset: 0x1813F1 VA: 0x1812F0
	private bool <IsLoading>k__BackingField; // 0x50
	private bool nextRound; // 0x51
	private bool isBattleEnd; // 0x52
	private CheerVoiceDataTable cheerVoiceDataTable; // 0x58
	[SerializeField] // RVA: 0x181300 Offset: 0x181401 VA: 0x181300
	private FestivalPlayerInput festivalInput; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x181310 Offset: 0x181411 VA: 0x181310
	private FestivalUI <FestivalUI>k__BackingField; // 0x68
	private int festivalUIID; // 0x70
	private readonly Dictionary<FestivalType, Event> FESTIVAL_TYPE_TO_EVENT; // 0x78
	private bool isTimeLimit; // 0x80
	public static FestivalType Type; // 0x4
	[CompilerGeneratedAttribute] // RVA: 0x181320 Offset: 0x181421 VA: 0x181320
	private FestivalState <State>k__BackingField; // 0x84

	// Properties
	public static FestivalCharacterController FestivalPlayer { get; }
	public static bool IsMiniGame { get; set; }
	public FestivalParamter FestivalParamter { get; set; }
	public float TimeCount { get; set; }
	public float PlayerScore { get; set; }
	public List<ActorID> GluttonActorList { get; set; }
	public List<ActorID> PetActorList { get; set; }
	public List<ActorID> PartnerNPCList { get; set; }
	public bool IsLoading { get; set; }
	public bool NextRound { get; set; }
	public bool IsBattleEnd { get; set; }
	public bool IsPlaying { get; }
	public FestivalUI FestivalUI { get; set; }
	public FestivalState State { get; set; }

	// Methods

	// RVA: 0x2037050 Offset: 0x2037151 VA: 0x2037050
	public static FestivalCharacterController get_FestivalPlayer() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE1B0 Offset: 0x1AE2B1 VA: 0x1AE1B0
	// RVA: 0x2037D10 Offset: 0x2037E11 VA: 0x2037D10
	public static bool get_IsMiniGame() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE1C0 Offset: 0x1AE2C1 VA: 0x1AE1C0
	// RVA: 0x2037D80 Offset: 0x2037E81 VA: 0x2037D80
	private static void set_IsMiniGame(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE1D0 Offset: 0x1AE2D1 VA: 0x1AE1D0
	// RVA: 0x2037DF0 Offset: 0x2037EF1 VA: 0x2037DF0
	public FestivalParamter get_FestivalParamter() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE1E0 Offset: 0x1AE2E1 VA: 0x1AE1E0
	// RVA: 0x2037E00 Offset: 0x2037F01 VA: 0x2037E00
	private void set_FestivalParamter(FestivalParamter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE1F0 Offset: 0x1AE2F1 VA: 0x1AE1F0
	// RVA: 0x2037E10 Offset: 0x2037F11 VA: 0x2037E10
	public float get_TimeCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE200 Offset: 0x1AE301 VA: 0x1AE200
	// RVA: 0x2037E20 Offset: 0x2037F21 VA: 0x2037E20
	private void set_TimeCount(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE210 Offset: 0x1AE311 VA: 0x1AE210
	// RVA: 0x2037E30 Offset: 0x2037F31 VA: 0x2037E30
	public float get_PlayerScore() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE220 Offset: 0x1AE321 VA: 0x1AE220
	// RVA: 0x2037E40 Offset: 0x2037F41 VA: 0x2037E40
	private void set_PlayerScore(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE230 Offset: 0x1AE331 VA: 0x1AE230
	// RVA: 0x2037E50 Offset: 0x2037F51 VA: 0x2037E50
	public List<ActorID> get_GluttonActorList() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE240 Offset: 0x1AE341 VA: 0x1AE240
	// RVA: 0x2037E60 Offset: 0x2037F61 VA: 0x2037E60
	private void set_GluttonActorList(List<ActorID> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE250 Offset: 0x1AE351 VA: 0x1AE250
	// RVA: 0x2037E70 Offset: 0x2037F71 VA: 0x2037E70
	public List<ActorID> get_PetActorList() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE260 Offset: 0x1AE361 VA: 0x1AE260
	// RVA: 0x2037E80 Offset: 0x2037F81 VA: 0x2037E80
	private void set_PetActorList(List<ActorID> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE270 Offset: 0x1AE371 VA: 0x1AE270
	// RVA: 0x2037E90 Offset: 0x2037F91 VA: 0x2037E90
	public List<ActorID> get_PartnerNPCList() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE280 Offset: 0x1AE381 VA: 0x1AE280
	// RVA: 0x2037EA0 Offset: 0x2037FA1 VA: 0x2037EA0
	private void set_PartnerNPCList(List<ActorID> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE290 Offset: 0x1AE391 VA: 0x1AE290
	// RVA: 0x2037EB0 Offset: 0x2037FB1 VA: 0x2037EB0
	public bool get_IsLoading() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE2A0 Offset: 0x1AE3A1 VA: 0x1AE2A0
	// RVA: 0x2037EC0 Offset: 0x2037FC1 VA: 0x2037EC0
	private void set_IsLoading(bool value) { }

	// RVA: 0x2037ED0 Offset: 0x2037FD1 VA: 0x2037ED0
	public bool get_NextRound() { }

	// RVA: 0x2037EE0 Offset: 0x2037FE1 VA: 0x2037EE0
	public void set_NextRound(bool value) { }

	// RVA: 0x2037F70 Offset: 0x2038071 VA: 0x2037F70
	public bool get_IsBattleEnd() { }

	// RVA: 0x2037F80 Offset: 0x2038081 VA: 0x2037F80
	public void set_IsBattleEnd(bool value) { }

	// RVA: 0x2038010 Offset: 0x2038111 VA: 0x2038010
	public bool get_IsPlaying() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE2B0 Offset: 0x1AE3B1 VA: 0x1AE2B0
	// RVA: 0x2038040 Offset: 0x2038141 VA: 0x2038040
	public FestivalUI get_FestivalUI() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE2C0 Offset: 0x1AE3C1 VA: 0x1AE2C0
	// RVA: 0x2038050 Offset: 0x2038151 VA: 0x2038050
	private void set_FestivalUI(FestivalUI value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE2D0 Offset: 0x1AE3D1 VA: 0x1AE2D0
	// RVA: 0x2038060 Offset: 0x2038161 VA: 0x2038060
	public FestivalState get_State() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE2E0 Offset: 0x1AE3E1 VA: 0x1AE2E0
	// RVA: 0x2038070 Offset: 0x2038171 VA: 0x2038070
	private void set_State(FestivalState value) { }

	// RVA: 0x2038080 Offset: 0x2038181 VA: 0x2038080 Slot: 4
	protected override void Awake() { }

	// RVA: 0x20382B0 Offset: 0x20383B1 VA: 0x20382B0
	private void Start() { }

	// RVA: 0x2038B60 Offset: 0x2038C61 VA: 0x2038B60
	private void Update() { }

	// RVA: 0x20393F0 Offset: 0x20394F1 VA: 0x20393F0
	private void OnDestroy() { }

	// RVA: 0x2038A20 Offset: 0x2038B21 VA: 0x2038A20
	private void UILoading() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AE2F0 Offset: 0x1AE3F1 VA: 0x1AE2F0
	// RVA: 0x2039460 Offset: 0x2039561 VA: 0x2039460
	public IEnumerator CountDown() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AE360 Offset: 0x1AE461 VA: 0x1AE360
	// RVA: 0x2039510 Offset: 0x2039611 VA: 0x2039510
	public IEnumerator OnFinishCoroutine() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AE3D0 Offset: 0x1AE4D1 VA: 0x1AE3D0
	// RVA: 0x2039590 Offset: 0x2039691 VA: 0x2039590
	public IEnumerator OnNextRoundCoroutine() { }

	// RVA: 0x2039610 Offset: 0x2039711 VA: 0x2039610
	public void AddScore(float _score) { }

	// RVA: 0x2039650 Offset: 0x2039751 VA: 0x2039650
	public void SetScore(float _score) { }

	// RVA: 0x2039750 Offset: 0x2039851 VA: 0x2039750
	public ActorID FestivalActorLottery() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AE440 Offset: 0x1AE541 VA: 0x1AE440
	// RVA: 0x20397E0 Offset: 0x20398E1 VA: 0x20397E0
	public IEnumerator PlayCheerVoice() { }

	// RVA: 0x2039860 Offset: 0x2039961 VA: 0x2039860
	public void RemoveCheerActor(List<ActorID> _ignore_list) { }

	// RVA: 0x2039980 Offset: 0x2039A81 VA: 0x2039980
	public void RemoveCheerActor(ActorID _actor_id) { }

	// RVA: 0x20399A0 Offset: 0x2039AA1 VA: 0x20399A0
	public void SetPetRankingList(List<ActorID> _ranking_list) { }

	[IteratorStateMachineAttribute] // RVA: 0x1AE4B0 Offset: 0x1AE5B1 VA: 0x1AE4B0
	// RVA: 0x2039A50 Offset: 0x2039B51 VA: 0x2039A50
	private IEnumerator OnTalkingADV(string _script_name) { }

	// RVA: 0x2039AD0 Offset: 0x2039BD1 VA: 0x2039AD0
	private void CallBackAfterTeleporting() { }

	// RVA: 0x2039C70 Offset: 0x2039D71 VA: 0x2039C70
	public void .ctor() { }

	// RVA: 0x2039E50 Offset: 0x2039F51 VA: 0x2039E50
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE520 Offset: 0x1AE621 VA: 0x1AE520
	// RVA: 0x2039E60 Offset: 0x2039F61 VA: 0x2039E60
	private void <Update>b__64_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE530 Offset: 0x1AE631 VA: 0x1AE530
	// RVA: 0x203A0F0 Offset: 0x203A1F1 VA: 0x203A0F0
	private void <Update>b__64_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE540 Offset: 0x1AE641 VA: 0x1AE540
	// RVA: 0x203A210 Offset: 0x203A311 VA: 0x203A210
	private void <Update>b__64_2() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE550 Offset: 0x1AE651 VA: 0x1AE550
	// RVA: 0x203A220 Offset: 0x203A321 VA: 0x203A220
	private void <UILoading>b__66_0(AssetHandle<GameObject> _handle) { }
}

public class FestivalManager : SingletonMonoBehaviour<FestivalManager> // TypeDefIndex: 10314
{
	// Fields
	public static bool IsMemories; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x181280 Offset: 0x181381 VA: 0x181280
	private static bool <IsMiniGame>k__BackingField; // 0x1
	[CompilerGeneratedAttribute] // RVA: 0x181290 Offset: 0x181391 VA: 0x181290
	private FestivalParamter <FestivalParamter>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x1812A0 Offset: 0x1813A1 VA: 0x1812A0
	private float <TimeCount>k__BackingField; // 0x20
	public const float FIELD_HEIGHT = 13.31;
	[CompilerGeneratedAttribute] // RVA: 0x1812B0 Offset: 0x1813B1 VA: 0x1812B0
	private float <PlayerScore>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x1812C0 Offset: 0x1813C1 VA: 0x1812C0
	private List<ActorID> <GluttonActorList>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x1812D0 Offset: 0x1813D1 VA: 0x1812D0
	private List<ActorID> <PetActorList>k__BackingField; // 0x30
	private List<ActorID> petRankingList; // 0x38
	private List<ActorID> festivalVistorActorList; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x1812E0 Offset: 0x1813E1 VA: 0x1812E0
	private List<ActorID> <PartnerNPCList>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x1812F0 Offset: 0x1813F1 VA: 0x1812F0
	private bool <IsLoading>k__BackingField; // 0x50
	private bool nextRound; // 0x51
	private bool isBattleEnd; // 0x52
	private CheerVoiceDataTable cheerVoiceDataTable; // 0x58
	[SerializeField] // RVA: 0x181300 Offset: 0x181401 VA: 0x181300
	private FestivalPlayerInput festivalInput; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x181310 Offset: 0x181411 VA: 0x181310
	private FestivalUI <FestivalUI>k__BackingField; // 0x68
	private int festivalUIID; // 0x70
	private readonly Dictionary<FestivalType, Event> FESTIVAL_TYPE_TO_EVENT; // 0x78
	private bool isTimeLimit; // 0x80
	public static FestivalType Type; // 0x4
	[CompilerGeneratedAttribute] // RVA: 0x181320 Offset: 0x181421 VA: 0x181320
	private FestivalState <State>k__BackingField; // 0x84

	// Properties
	public static FestivalCharacterController FestivalPlayer { get; }
	public static bool IsMiniGame { get; set; }
	public FestivalParamter FestivalParamter { get; set; }
	public float TimeCount { get; set; }
	public float PlayerScore { get; set; }
	public List<ActorID> GluttonActorList { get; set; }
	public List<ActorID> PetActorList { get; set; }
	public List<ActorID> PartnerNPCList { get; set; }
	public bool IsLoading { get; set; }
	public bool NextRound { get; set; }
	public bool IsBattleEnd { get; set; }
	public bool IsPlaying { get; }
	public FestivalUI FestivalUI { get; set; }
	public FestivalState State { get; set; }

	// Methods

	// RVA: 0x2037050 Offset: 0x2037151 VA: 0x2037050
	public static FestivalCharacterController get_FestivalPlayer() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE1B0 Offset: 0x1AE2B1 VA: 0x1AE1B0
	// RVA: 0x2037D10 Offset: 0x2037E11 VA: 0x2037D10
	public static bool get_IsMiniGame() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE1C0 Offset: 0x1AE2C1 VA: 0x1AE1C0
	// RVA: 0x2037D80 Offset: 0x2037E81 VA: 0x2037D80
	private static void set_IsMiniGame(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE1D0 Offset: 0x1AE2D1 VA: 0x1AE1D0
	// RVA: 0x2037DF0 Offset: 0x2037EF1 VA: 0x2037DF0
	public FestivalParamter get_FestivalParamter() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE1E0 Offset: 0x1AE2E1 VA: 0x1AE1E0
	// RVA: 0x2037E00 Offset: 0x2037F01 VA: 0x2037E00
	private void set_FestivalParamter(FestivalParamter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE1F0 Offset: 0x1AE2F1 VA: 0x1AE1F0
	// RVA: 0x2037E10 Offset: 0x2037F11 VA: 0x2037E10
	public float get_TimeCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE200 Offset: 0x1AE301 VA: 0x1AE200
	// RVA: 0x2037E20 Offset: 0x2037F21 VA: 0x2037E20
	private void set_TimeCount(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE210 Offset: 0x1AE311 VA: 0x1AE210
	// RVA: 0x2037E30 Offset: 0x2037F31 VA: 0x2037E30
	public float get_PlayerScore() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE220 Offset: 0x1AE321 VA: 0x1AE220
	// RVA: 0x2037E40 Offset: 0x2037F41 VA: 0x2037E40
	private void set_PlayerScore(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE230 Offset: 0x1AE331 VA: 0x1AE230
	// RVA: 0x2037E50 Offset: 0x2037F51 VA: 0x2037E50
	public List<ActorID> get_GluttonActorList() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE240 Offset: 0x1AE341 VA: 0x1AE240
	// RVA: 0x2037E60 Offset: 0x2037F61 VA: 0x2037E60
	private void set_GluttonActorList(List<ActorID> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE250 Offset: 0x1AE351 VA: 0x1AE250
	// RVA: 0x2037E70 Offset: 0x2037F71 VA: 0x2037E70
	public List<ActorID> get_PetActorList() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE260 Offset: 0x1AE361 VA: 0x1AE260
	// RVA: 0x2037E80 Offset: 0x2037F81 VA: 0x2037E80
	private void set_PetActorList(List<ActorID> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE270 Offset: 0x1AE371 VA: 0x1AE270
	// RVA: 0x2037E90 Offset: 0x2037F91 VA: 0x2037E90
	public List<ActorID> get_PartnerNPCList() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE280 Offset: 0x1AE381 VA: 0x1AE280
	// RVA: 0x2037EA0 Offset: 0x2037FA1 VA: 0x2037EA0
	private void set_PartnerNPCList(List<ActorID> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE290 Offset: 0x1AE391 VA: 0x1AE290
	// RVA: 0x2037EB0 Offset: 0x2037FB1 VA: 0x2037EB0
	public bool get_IsLoading() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE2A0 Offset: 0x1AE3A1 VA: 0x1AE2A0
	// RVA: 0x2037EC0 Offset: 0x2037FC1 VA: 0x2037EC0
	private void set_IsLoading(bool value) { }

	// RVA: 0x2037ED0 Offset: 0x2037FD1 VA: 0x2037ED0
	public bool get_NextRound() { }

	// RVA: 0x2037EE0 Offset: 0x2037FE1 VA: 0x2037EE0
	public void set_NextRound(bool value) { }

	// RVA: 0x2037F70 Offset: 0x2038071 VA: 0x2037F70
	public bool get_IsBattleEnd() { }

	// RVA: 0x2037F80 Offset: 0x2038081 VA: 0x2037F80
	public void set_IsBattleEnd(bool value) { }

	// RVA: 0x2038010 Offset: 0x2038111 VA: 0x2038010
	public bool get_IsPlaying() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE2B0 Offset: 0x1AE3B1 VA: 0x1AE2B0
	// RVA: 0x2038040 Offset: 0x2038141 VA: 0x2038040
	public FestivalUI get_FestivalUI() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE2C0 Offset: 0x1AE3C1 VA: 0x1AE2C0
	// RVA: 0x2038050 Offset: 0x2038151 VA: 0x2038050
	private void set_FestivalUI(FestivalUI value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE2D0 Offset: 0x1AE3D1 VA: 0x1AE2D0
	// RVA: 0x2038060 Offset: 0x2038161 VA: 0x2038060
	public FestivalState get_State() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE2E0 Offset: 0x1AE3E1 VA: 0x1AE2E0
	// RVA: 0x2038070 Offset: 0x2038171 VA: 0x2038070
	private void set_State(FestivalState value) { }

	// RVA: 0x2038080 Offset: 0x2038181 VA: 0x2038080 Slot: 4
	protected override void Awake() { }

	// RVA: 0x20382B0 Offset: 0x20383B1 VA: 0x20382B0
	private void Start() { }

	// RVA: 0x2038B60 Offset: 0x2038C61 VA: 0x2038B60
	private void Update() { }

	// RVA: 0x20393F0 Offset: 0x20394F1 VA: 0x20393F0
	private void OnDestroy() { }

	// RVA: 0x2038A20 Offset: 0x2038B21 VA: 0x2038A20
	private void UILoading() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AE2F0 Offset: 0x1AE3F1 VA: 0x1AE2F0
	// RVA: 0x2039460 Offset: 0x2039561 VA: 0x2039460
	public IEnumerator CountDown() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AE360 Offset: 0x1AE461 VA: 0x1AE360
	// RVA: 0x2039510 Offset: 0x2039611 VA: 0x2039510
	public IEnumerator OnFinishCoroutine() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AE3D0 Offset: 0x1AE4D1 VA: 0x1AE3D0
	// RVA: 0x2039590 Offset: 0x2039691 VA: 0x2039590
	public IEnumerator OnNextRoundCoroutine() { }

	// RVA: 0x2039610 Offset: 0x2039711 VA: 0x2039610
	public void AddScore(float _score) { }

	// RVA: 0x2039650 Offset: 0x2039751 VA: 0x2039650
	public void SetScore(float _score) { }

	// RVA: 0x2039750 Offset: 0x2039851 VA: 0x2039750
	public ActorID FestivalActorLottery() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AE440 Offset: 0x1AE541 VA: 0x1AE440
	// RVA: 0x20397E0 Offset: 0x20398E1 VA: 0x20397E0
	public IEnumerator PlayCheerVoice() { }

	// RVA: 0x2039860 Offset: 0x2039961 VA: 0x2039860
	public void RemoveCheerActor(List<ActorID> _ignore_list) { }

	// RVA: 0x2039980 Offset: 0x2039A81 VA: 0x2039980
	public void RemoveCheerActor(ActorID _actor_id) { }

	// RVA: 0x20399A0 Offset: 0x2039AA1 VA: 0x20399A0
	public void SetPetRankingList(List<ActorID> _ranking_list) { }

	[IteratorStateMachineAttribute] // RVA: 0x1AE4B0 Offset: 0x1AE5B1 VA: 0x1AE4B0
	// RVA: 0x2039A50 Offset: 0x2039B51 VA: 0x2039A50
	private IEnumerator OnTalkingADV(string _script_name) { }

	// RVA: 0x2039AD0 Offset: 0x2039BD1 VA: 0x2039AD0
	private void CallBackAfterTeleporting() { }

	// RVA: 0x2039C70 Offset: 0x2039D71 VA: 0x2039C70
	public void .ctor() { }

	// RVA: 0x2039E50 Offset: 0x2039F51 VA: 0x2039E50
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE520 Offset: 0x1AE621 VA: 0x1AE520
	// RVA: 0x2039E60 Offset: 0x2039F61 VA: 0x2039E60
	private void <Update>b__64_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE530 Offset: 0x1AE631 VA: 0x1AE530
	// RVA: 0x203A0F0 Offset: 0x203A1F1 VA: 0x203A0F0
	private void <Update>b__64_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE540 Offset: 0x1AE641 VA: 0x1AE540
	// RVA: 0x203A210 Offset: 0x203A311 VA: 0x203A210
	private void <Update>b__64_2() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE550 Offset: 0x1AE651 VA: 0x1AE550
	// RVA: 0x203A220 Offset: 0x203A321 VA: 0x203A220
	private void <UILoading>b__66_0(AssetHandle<GameObject> _handle) { }
}

public class FestivalManager : SingletonMonoBehaviour<FestivalManager> // TypeDefIndex: 10314
{
	// Fields
	public static bool IsMemories; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x181280 Offset: 0x181381 VA: 0x181280
	private static bool <IsMiniGame>k__BackingField; // 0x1
	[CompilerGeneratedAttribute] // RVA: 0x181290 Offset: 0x181391 VA: 0x181290
	private FestivalParamter <FestivalParamter>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x1812A0 Offset: 0x1813A1 VA: 0x1812A0
	private float <TimeCount>k__BackingField; // 0x20
	public const float FIELD_HEIGHT = 13.31;
	[CompilerGeneratedAttribute] // RVA: 0x1812B0 Offset: 0x1813B1 VA: 0x1812B0
	private float <PlayerScore>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x1812C0 Offset: 0x1813C1 VA: 0x1812C0
	private List<ActorID> <GluttonActorList>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x1812D0 Offset: 0x1813D1 VA: 0x1812D0
	private List<ActorID> <PetActorList>k__BackingField; // 0x30
	private List<ActorID> petRankingList; // 0x38
	private List<ActorID> festivalVistorActorList; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x1812E0 Offset: 0x1813E1 VA: 0x1812E0
	private List<ActorID> <PartnerNPCList>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x1812F0 Offset: 0x1813F1 VA: 0x1812F0
	private bool <IsLoading>k__BackingField; // 0x50
	private bool nextRound; // 0x51
	private bool isBattleEnd; // 0x52
	private CheerVoiceDataTable cheerVoiceDataTable; // 0x58
	[SerializeField] // RVA: 0x181300 Offset: 0x181401 VA: 0x181300
	private FestivalPlayerInput festivalInput; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x181310 Offset: 0x181411 VA: 0x181310
	private FestivalUI <FestivalUI>k__BackingField; // 0x68
	private int festivalUIID; // 0x70
	private readonly Dictionary<FestivalType, Event> FESTIVAL_TYPE_TO_EVENT; // 0x78
	private bool isTimeLimit; // 0x80
	public static FestivalType Type; // 0x4
	[CompilerGeneratedAttribute] // RVA: 0x181320 Offset: 0x181421 VA: 0x181320
	private FestivalState <State>k__BackingField; // 0x84

	// Properties
	public static FestivalCharacterController FestivalPlayer { get; }
	public static bool IsMiniGame { get; set; }
	public FestivalParamter FestivalParamter { get; set; }
	public float TimeCount { get; set; }
	public float PlayerScore { get; set; }
	public List<ActorID> GluttonActorList { get; set; }
	public List<ActorID> PetActorList { get; set; }
	public List<ActorID> PartnerNPCList { get; set; }
	public bool IsLoading { get; set; }
	public bool NextRound { get; set; }
	public bool IsBattleEnd { get; set; }
	public bool IsPlaying { get; }
	public FestivalUI FestivalUI { get; set; }
	public FestivalState State { get; set; }

	// Methods

	// RVA: 0x2037050 Offset: 0x2037151 VA: 0x2037050
	public static FestivalCharacterController get_FestivalPlayer() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE1B0 Offset: 0x1AE2B1 VA: 0x1AE1B0
	// RVA: 0x2037D10 Offset: 0x2037E11 VA: 0x2037D10
	public static bool get_IsMiniGame() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE1C0 Offset: 0x1AE2C1 VA: 0x1AE1C0
	// RVA: 0x2037D80 Offset: 0x2037E81 VA: 0x2037D80
	private static void set_IsMiniGame(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE1D0 Offset: 0x1AE2D1 VA: 0x1AE1D0
	// RVA: 0x2037DF0 Offset: 0x2037EF1 VA: 0x2037DF0
	public FestivalParamter get_FestivalParamter() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE1E0 Offset: 0x1AE2E1 VA: 0x1AE1E0
	// RVA: 0x2037E00 Offset: 0x2037F01 VA: 0x2037E00
	private void set_FestivalParamter(FestivalParamter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE1F0 Offset: 0x1AE2F1 VA: 0x1AE1F0
	// RVA: 0x2037E10 Offset: 0x2037F11 VA: 0x2037E10
	public float get_TimeCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE200 Offset: 0x1AE301 VA: 0x1AE200
	// RVA: 0x2037E20 Offset: 0x2037F21 VA: 0x2037E20
	private void set_TimeCount(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE210 Offset: 0x1AE311 VA: 0x1AE210
	// RVA: 0x2037E30 Offset: 0x2037F31 VA: 0x2037E30
	public float get_PlayerScore() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE220 Offset: 0x1AE321 VA: 0x1AE220
	// RVA: 0x2037E40 Offset: 0x2037F41 VA: 0x2037E40
	private void set_PlayerScore(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE230 Offset: 0x1AE331 VA: 0x1AE230
	// RVA: 0x2037E50 Offset: 0x2037F51 VA: 0x2037E50
	public List<ActorID> get_GluttonActorList() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE240 Offset: 0x1AE341 VA: 0x1AE240
	// RVA: 0x2037E60 Offset: 0x2037F61 VA: 0x2037E60
	private void set_GluttonActorList(List<ActorID> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE250 Offset: 0x1AE351 VA: 0x1AE250
	// RVA: 0x2037E70 Offset: 0x2037F71 VA: 0x2037E70
	public List<ActorID> get_PetActorList() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE260 Offset: 0x1AE361 VA: 0x1AE260
	// RVA: 0x2037E80 Offset: 0x2037F81 VA: 0x2037E80
	private void set_PetActorList(List<ActorID> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE270 Offset: 0x1AE371 VA: 0x1AE270
	// RVA: 0x2037E90 Offset: 0x2037F91 VA: 0x2037E90
	public List<ActorID> get_PartnerNPCList() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE280 Offset: 0x1AE381 VA: 0x1AE280
	// RVA: 0x2037EA0 Offset: 0x2037FA1 VA: 0x2037EA0
	private void set_PartnerNPCList(List<ActorID> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE290 Offset: 0x1AE391 VA: 0x1AE290
	// RVA: 0x2037EB0 Offset: 0x2037FB1 VA: 0x2037EB0
	public bool get_IsLoading() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE2A0 Offset: 0x1AE3A1 VA: 0x1AE2A0
	// RVA: 0x2037EC0 Offset: 0x2037FC1 VA: 0x2037EC0
	private void set_IsLoading(bool value) { }

	// RVA: 0x2037ED0 Offset: 0x2037FD1 VA: 0x2037ED0
	public bool get_NextRound() { }

	// RVA: 0x2037EE0 Offset: 0x2037FE1 VA: 0x2037EE0
	public void set_NextRound(bool value) { }

	// RVA: 0x2037F70 Offset: 0x2038071 VA: 0x2037F70
	public bool get_IsBattleEnd() { }

	// RVA: 0x2037F80 Offset: 0x2038081 VA: 0x2037F80
	public void set_IsBattleEnd(bool value) { }

	// RVA: 0x2038010 Offset: 0x2038111 VA: 0x2038010
	public bool get_IsPlaying() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE2B0 Offset: 0x1AE3B1 VA: 0x1AE2B0
	// RVA: 0x2038040 Offset: 0x2038141 VA: 0x2038040
	public FestivalUI get_FestivalUI() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE2C0 Offset: 0x1AE3C1 VA: 0x1AE2C0
	// RVA: 0x2038050 Offset: 0x2038151 VA: 0x2038050
	private void set_FestivalUI(FestivalUI value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE2D0 Offset: 0x1AE3D1 VA: 0x1AE2D0
	// RVA: 0x2038060 Offset: 0x2038161 VA: 0x2038060
	public FestivalState get_State() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE2E0 Offset: 0x1AE3E1 VA: 0x1AE2E0
	// RVA: 0x2038070 Offset: 0x2038171 VA: 0x2038070
	private void set_State(FestivalState value) { }

	// RVA: 0x2038080 Offset: 0x2038181 VA: 0x2038080 Slot: 4
	protected override void Awake() { }

	// RVA: 0x20382B0 Offset: 0x20383B1 VA: 0x20382B0
	private void Start() { }

	// RVA: 0x2038B60 Offset: 0x2038C61 VA: 0x2038B60
	private void Update() { }

	// RVA: 0x20393F0 Offset: 0x20394F1 VA: 0x20393F0
	private void OnDestroy() { }

	// RVA: 0x2038A20 Offset: 0x2038B21 VA: 0x2038A20
	private void UILoading() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AE2F0 Offset: 0x1AE3F1 VA: 0x1AE2F0
	// RVA: 0x2039460 Offset: 0x2039561 VA: 0x2039460
	public IEnumerator CountDown() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AE360 Offset: 0x1AE461 VA: 0x1AE360
	// RVA: 0x2039510 Offset: 0x2039611 VA: 0x2039510
	public IEnumerator OnFinishCoroutine() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AE3D0 Offset: 0x1AE4D1 VA: 0x1AE3D0
	// RVA: 0x2039590 Offset: 0x2039691 VA: 0x2039590
	public IEnumerator OnNextRoundCoroutine() { }

	// RVA: 0x2039610 Offset: 0x2039711 VA: 0x2039610
	public void AddScore(float _score) { }

	// RVA: 0x2039650 Offset: 0x2039751 VA: 0x2039650
	public void SetScore(float _score) { }

	// RVA: 0x2039750 Offset: 0x2039851 VA: 0x2039750
	public ActorID FestivalActorLottery() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AE440 Offset: 0x1AE541 VA: 0x1AE440
	// RVA: 0x20397E0 Offset: 0x20398E1 VA: 0x20397E0
	public IEnumerator PlayCheerVoice() { }

	// RVA: 0x2039860 Offset: 0x2039961 VA: 0x2039860
	public void RemoveCheerActor(List<ActorID> _ignore_list) { }

	// RVA: 0x2039980 Offset: 0x2039A81 VA: 0x2039980
	public void RemoveCheerActor(ActorID _actor_id) { }

	// RVA: 0x20399A0 Offset: 0x2039AA1 VA: 0x20399A0
	public void SetPetRankingList(List<ActorID> _ranking_list) { }

	[IteratorStateMachineAttribute] // RVA: 0x1AE4B0 Offset: 0x1AE5B1 VA: 0x1AE4B0
	// RVA: 0x2039A50 Offset: 0x2039B51 VA: 0x2039A50
	private IEnumerator OnTalkingADV(string _script_name) { }

	// RVA: 0x2039AD0 Offset: 0x2039BD1 VA: 0x2039AD0
	private void CallBackAfterTeleporting() { }

	// RVA: 0x2039C70 Offset: 0x2039D71 VA: 0x2039C70
	public void .ctor() { }

	// RVA: 0x2039E50 Offset: 0x2039F51 VA: 0x2039E50
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE520 Offset: 0x1AE621 VA: 0x1AE520
	// RVA: 0x2039E60 Offset: 0x2039F61 VA: 0x2039E60
	private void <Update>b__64_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE530 Offset: 0x1AE631 VA: 0x1AE530
	// RVA: 0x203A0F0 Offset: 0x203A1F1 VA: 0x203A0F0
	private void <Update>b__64_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE540 Offset: 0x1AE641 VA: 0x1AE540
	// RVA: 0x203A210 Offset: 0x203A311 VA: 0x203A210
	private void <Update>b__64_2() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE550 Offset: 0x1AE651 VA: 0x1AE550
	// RVA: 0x203A220 Offset: 0x203A321 VA: 0x203A220
	private void <UILoading>b__66_0(AssetHandle<GameObject> _handle) { }
}

