public class ShortplayAdvController // TypeDefIndex: 7230
{
	// Fields
	public bool IsLoadingWait; // 0x10
	public bool IsLoadingActor000; // 0x11
	public int IsLoadingNpcId; // 0x14
	public List<int> doPartnerId; // 0x18
	public List<int> doDatePartnerId; // 0x20
	private string SummonMonsterName; // 0x28
	public bool IsPreLoad; // 0x30
	private GameObject ShortplayOnGroundItem; // 0x38
	private string CreateObject_itemId; // 0x40
	private string CreateObject_itemName; // 0x48
	private float CreateObject_scale; // 0x50
	private int CreateObject_positionType; // 0x54
	private float CreateObject_posX; // 0x58
	private float CreateObject_posY; // 0x5C
	private float CreateObject_posZ; // 0x60
	private float CreateObject_rotX; // 0x64
	private float CreateObject_rotY; // 0x68
	private float CreateObject_rotZ; // 0x6C
	private NpcController ShortplayAdvTargetNpc; // 0x70
	private bool IsOnGroundItem; // 0x78
	public Color[] ColorList; // 0x80
	public GameObject shakeCameraObj; // 0x88
	private bool timelineShake; // 0x90
	private float magnitude; // 0x94
	private Vector3 cameraPos; // 0x98
	public ShortplayAdvController.StateShortPlayExitPlayer StateExitPlayer; // 0xA4
	public bool IsShortPlayExitNpc; // 0xA8
	public bool IsCheckShortPlayExitNpc; // 0xA9
	private bool IsChangePlayableCamera; // 0xAA

	// Properties
	public bool IsPreLoading { get; }
	private SpcController PlayerSpc { get; }
	private Character ActiveCharacter { get; }
	private Transform GetPlayerTransform { get; }

	// Methods

	// RVA: 0x1C91360 Offset: 0x1C91461 VA: 0x1C91360
	public bool get_IsPreLoading() { }

	// RVA: 0x1C91390 Offset: 0x1C91491 VA: 0x1C91390
	private SpcController get_PlayerSpc() { }

	// RVA: 0x1C91460 Offset: 0x1C91561 VA: 0x1C91460
	private Character get_ActiveCharacter() { }

	// RVA: 0x1C914C0 Offset: 0x1C915C1 VA: 0x1C914C0
	public bool Update() { }

	// RVA: 0x1C917F0 Offset: 0x1C918F1 VA: 0x1C917F0
	private bool LoadingPlayerActor() { }

	// RVA: 0x1C91C50 Offset: 0x1C91D51 VA: 0x1C91C50
	public void LoadingNpcActor() { }

	// RVA: 0x1C92DC0 Offset: 0x1C92EC1 VA: 0x1C92DC0
	private Actor CreateActor(int NpcId) { }

	// RVA: 0x1C93760 Offset: 0x1C93861 VA: 0x1C93760
	public void SetPlayerSpcBaseActorLoading() { }

	// RVA: 0x1C93770 Offset: 0x1C93871 VA: 0x1C93770
	public bool ShortPlayPreLoadNpc(int npcId) { }

	[IteratorStateMachineAttribute] // RVA: 0x19E330 Offset: 0x19E431 VA: 0x19E330
	// RVA: 0x1C93840 Offset: 0x1C93941 VA: 0x1C93840
	public IEnumerator ShortPlayStartId(int npcId, float wait, FieldPlaceId FieldPlaceId) { }

	// RVA: 0x1C93080 Offset: 0x1C93181 VA: 0x1C93080
	public void ShortPlayNpcLoaded(SpcController spc) { }

	[IteratorStateMachineAttribute] // RVA: 0x19E3A0 Offset: 0x19E4A1 VA: 0x19E3A0
	// RVA: 0x1C938D0 Offset: 0x1C939D1 VA: 0x1C938D0
	public IEnumerator ShortPlayStartName(string name, float wait, string sceneName) { }

	// RVA: 0x1C916C0 Offset: 0x1C917C1 VA: 0x1C916C0
	public void ShortPlayStartNameCheckEnabled() { }

	// RVA: 0x1C920A0 Offset: 0x1C921A1 VA: 0x1C920A0
	public void SpcToPlayerReset() { }

	// RVA: 0x1C922D0 Offset: 0x1C923D1 VA: 0x1C922D0
	private void UpdateCheckChangePlayerCamera() { }

	// RVA: 0x1C93970 Offset: 0x1C93A71 VA: 0x1C93970
	public void CheckSpcToNpc() { }

	// RVA: 0x1C92380 Offset: 0x1C92481 VA: 0x1C92380
	public void SpcToNpcReset() { }

	[IteratorStateMachineAttribute] // RVA: 0x19E410 Offset: 0x19E511 VA: 0x19E410
	// RVA: 0x1C93F20 Offset: 0x1C94021 VA: 0x1C93F20
	public IEnumerator ShortPlayEndId(int npcId, float wait) { }

	[IteratorStateMachineAttribute] // RVA: 0x19E480 Offset: 0x19E581 VA: 0x19E480
	// RVA: 0x1C93FC0 Offset: 0x1C940C1 VA: 0x1C93FC0
	public IEnumerator ShortPlayEndName(string name, float wait) { }

	// RVA: 0x1C94070 Offset: 0x1C94171 VA: 0x1C94070
	public void DoPartner(int NpcId, bool isDate) { }

	// RVA: 0x1C93EB0 Offset: 0x1C93FB1 VA: 0x1C93EB0
	public void ClearPartner() { }

	// RVA: 0x1C94150 Offset: 0x1C94251 VA: 0x1C94150
	public void ClearPartner(int NpcId) { }

	// RVA: 0x1C941D0 Offset: 0x1C942D1 VA: 0x1C941D0
	public void AppearOnGroundReward(int orderId, int rewardId, int rewardNum, float posx, float posy, float posz) { }

	// RVA: 0x1C944A0 Offset: 0x1C945A1 VA: 0x1C944A0
	public void AppearOnGroundReward(int orderId, int rewardId, int rewardNum, bool attachHand) { }

	// RVA: 0x1C94DE0 Offset: 0x1C94EE1 VA: 0x1C94DE0
	public void AppearOnGroundRewardForwardPlayer(int orderId, int rewardId, int rewardNum, bool attachHand) { }

	// RVA: 0x1C94540 Offset: 0x1C94641 VA: 0x1C94540
	public void AppearOnGroundReward(int orderId, int rewardId, int rewardNum, int rewardLevel, int npcId, bool attachHand) { }

	// RVA: 0x1C94DF0 Offset: 0x1C94EF1 VA: 0x1C94DF0
	private Transform get_GetPlayerTransform() { }

	// RVA: 0x1C94EC0 Offset: 0x1C94FC1 VA: 0x1C94EC0
	public void CreateNpcPresent(int npcid, NpcPresentType type) { }

	// RVA: 0x1C95370 Offset: 0x1C95471 VA: 0x1C95370
	private ItemID GetItemIDAtEveryDayPresentAfterMarrage(NpcData data, int idx = -1) { }

	// RVA: 0x1C95400 Offset: 0x1C95501 VA: 0x1C95400
	public bool CanHaveItemNpc(NpcController npc, int positionType) { }

	[IteratorStateMachineAttribute] // RVA: 0x19E4F0 Offset: 0x19E5F1 VA: 0x19E4F0
	// RVA: 0x1C955A0 Offset: 0x1C956A1 VA: 0x1C955A0
	public IEnumerator CreateObject(string itemId, string itemName, float scale, int positionType, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, NpcController npc) { }

	[IteratorStateMachineAttribute] // RVA: 0x19E560 Offset: 0x19E661 VA: 0x19E560
	// RVA: 0x1C956D0 Offset: 0x1C957D1 VA: 0x1C956D0
	public IEnumerator CreateShortplayObject(string itemId, string itemName, float scale, int positionType, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, NpcController npc) { }

	[IteratorStateMachineAttribute] // RVA: 0x19E5D0 Offset: 0x19E6D1 VA: 0x19E5D0
	// RVA: 0x1C95800 Offset: 0x1C95901 VA: 0x1C95800
	public IEnumerator CreateShortplayOnlyItem(string itemId, string itemName, float scale, int positionType, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, NpcController npc) { }

	// RVA: 0x1C95930 Offset: 0x1C95A31 VA: 0x1C95930
	public void CallbackCreateShortplayObject(OnGroundItem onGroundItem) { }

	// RVA: 0x1C95980 Offset: 0x1C95A81 VA: 0x1C95980
	public void CallbackCreateShortplayObject(GameObject onGroundItemObj) { }

	// RVA: 0x1C959A0 Offset: 0x1C95AA1 VA: 0x1C959A0
	public void AfterCreateShortplayObject(GameObject itemObj, string itemId, string itemName, float scale, int positionType, float posX, float posY, float posZ, float rotX, float rotY, float rotZ) { }

	[IteratorStateMachineAttribute] // RVA: 0x19E640 Offset: 0x19E741 VA: 0x19E640
	// RVA: 0x1C97380 Offset: 0x1C97481 VA: 0x1C97380
	public IEnumerator MoveObject(string itemName, float wait, int positionType, float posX, float posY, float posZ, float rotX, float rotY, float rotZ) { }

	// RVA: 0x1C973E0 Offset: 0x1C974E1 VA: 0x1C973E0
	public void DeleteObject(string itemName, float wait) { }

	[IteratorStateMachineAttribute] // RVA: 0x19E6B0 Offset: 0x19E7B1 VA: 0x19E6B0
	// RVA: 0x1C97CC0 Offset: 0x1C97DC1 VA: 0x1C97CC0
	public IEnumerator PlayEffect(string effectFileName, string effectName, float wait, int positionType, float posX, float posY, float posZ, float rotX, float rotY, float rotZ) { }

	[IteratorStateMachineAttribute] // RVA: 0x19E720 Offset: 0x19E821 VA: 0x19E720
	// RVA: 0x1C97D20 Offset: 0x1C97E21 VA: 0x1C97D20
	public IEnumerator MoveEffect(string effectName, float wait, int positionType, float posX, float posY, float posZ, float rotX, float rotY, float rotZ) { }

	[IteratorStateMachineAttribute] // RVA: 0x19E790 Offset: 0x19E891 VA: 0x19E790
	// RVA: 0x1C97D80 Offset: 0x1C97E81 VA: 0x1C97D80
	public IEnumerator StopEffect(string effectName, float wait) { }

	// RVA: 0x1C97DE0 Offset: 0x1C97EE1 VA: 0x1C97DE0
	public void ChangeScene(string sceneName) { }

	[IteratorStateMachineAttribute] // RVA: 0x19E800 Offset: 0x19E901 VA: 0x19E800
	// RVA: 0x1C97E60 Offset: 0x1C97F61 VA: 0x1C97E60
	public IEnumerator ChangeSceneCoroutine(string sceneName) { }

	// RVA: 0x1C97EE0 Offset: 0x1C97FE1 VA: 0x1C97EE0
	public void SetBehavierTree(string name) { }

	// RVA: 0x1C98020 Offset: 0x1C98121 VA: 0x1C98020
	public void SetNavMeshAgentDestination(string toName, float PatrolSpeed) { }

	// RVA: 0x1C98030 Offset: 0x1C98131 VA: 0x1C98030
	public void SetNavMeshAgentDestinationOther(string fromName, string toName, float moveSpeed) { }

	[IteratorStateMachineAttribute] // RVA: 0x19E870 Offset: 0x19E971 VA: 0x19E870
	// RVA: 0x1C98040 Offset: 0x1C98141 VA: 0x1C98040
	public IEnumerator SetCameraMotion(string motionId, float wait, float posX, float posY, float posZ, float rotX, float rotY, float rotZ) { }

	[IteratorStateMachineAttribute] // RVA: 0x19E8E0 Offset: 0x19E9E1 VA: 0x19E8E0
	// RVA: 0x1C98120 Offset: 0x1C98221 VA: 0x1C98120
	public IEnumerator CameraShake(float wait, float amplitudeGain = 1, float frequencyGain = 1, float attackTime = 1, float sutainTime = 0.2, float decayTime = 0.7) { }

	// RVA: 0x1C981D0 Offset: 0x1C982D1 VA: 0x1C981D0
	public void UsePlayerCamera(int resetType) { }

	[IteratorStateMachineAttribute] // RVA: 0x19E950 Offset: 0x19EA51 VA: 0x19E950
	// RVA: 0x1C98290 Offset: 0x1C98391 VA: 0x1C98290
	public IEnumerator UseShortPlayCamera(float wait) { }

	// RVA: 0x1C98310 Offset: 0x1C98411 VA: 0x1C98310
	public void ShortPlayCameraSetPosition(float wait, float posX, float posY, float posZ, float rotX, float rotY, float rotZ) { }

	// RVA: 0x1C98420 Offset: 0x1C98521 VA: 0x1C98420
	public void ShortPlayCameraSetTargetPosition(float wait, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float moveSpeed) { }

	// RVA: 0x1C98530 Offset: 0x1C98631 VA: 0x1C98530
	public void SetPoseId(int npcId, int poseId) { }

	// RVA: 0x1C98730 Offset: 0x1C98831 VA: 0x1C98730
	public void SetPoseName(string name, int poseId) { }

	// RVA: 0x1C98910 Offset: 0x1C98A11 VA: 0x1C98910
	public void NpcMotionId(int npcId, int motionId, float wait, bool IsShortPlayCalled = True) { }

	[IteratorStateMachineAttribute] // RVA: 0x19E9C0 Offset: 0x19EAC1 VA: 0x19E9C0
	// RVA: 0x1C98BB0 Offset: 0x1C98CB1 VA: 0x1C98BB0
	public IEnumerator NpcMotionName(string name, int motionId, float wait) { }

	[IteratorStateMachineAttribute] // RVA: 0x19EA30 Offset: 0x19EB31 VA: 0x19EA30
	// RVA: 0x1C94400 Offset: 0x1C94501 VA: 0x1C94400
	public IEnumerator AppearEmotionId(int npcId, int _emotionId, float wait, float dispTime, bool IsShortPlay) { }

	[IteratorStateMachineAttribute] // RVA: 0x19EAA0 Offset: 0x19EBA1 VA: 0x19EAA0
	// RVA: 0x1C98C50 Offset: 0x1C98D51 VA: 0x1C98C50
	public IEnumerator AppearEmotionName(string name, int emotionId, float wait, float loop, bool IsShortPlay) { }

	// RVA: 0x1C98D20 Offset: 0x1C98E21 VA: 0x1C98D20
	public void AppearEmotion(CharacterBase target, int emotionId, float dispTime, bool IsShortPlay) { }

	[IteratorStateMachineAttribute] // RVA: 0x19EB10 Offset: 0x19EC11 VA: 0x19EB10
	// RVA: 0x1C98D30 Offset: 0x1C98E31 VA: 0x1C98D30
	public IEnumerator SetEnabledObjectId(int npcId, bool enabled, float wait) { }

	[IteratorStateMachineAttribute] // RVA: 0x19EB80 Offset: 0x19EC81 VA: 0x19EB80
	// RVA: 0x1C98DE0 Offset: 0x1C98EE1 VA: 0x1C98DE0
	public IEnumerator SetEnabledObjectName(string name, bool enabled, float wait) { }

	[IteratorStateMachineAttribute] // RVA: 0x19EBF0 Offset: 0x19ECF1 VA: 0x19EBF0
	// RVA: 0x1C98E80 Offset: 0x1C98F81 VA: 0x1C98E80
	public IEnumerator ScreenFade(int fadeType, float wait, float fadetime, int colorType) { }

	[IteratorStateMachineAttribute] // RVA: 0x19EC60 Offset: 0x19ED61 VA: 0x19EC60
	// RVA: 0x1C98F30 Offset: 0x1C99031 VA: 0x1C98F30
	public IEnumerator UIAllShow(float wait) { }

	[IteratorStateMachineAttribute] // RVA: 0x19ECD0 Offset: 0x19EDD1 VA: 0x19ECD0
	// RVA: 0x1C98FB0 Offset: 0x1C990B1 VA: 0x1C98FB0
	public IEnumerator UIAllHide(float wait) { }

	[IteratorStateMachineAttribute] // RVA: 0x19ED40 Offset: 0x19EE41 VA: 0x19ED40
	// RVA: 0x1C99030 Offset: 0x1C99131 VA: 0x1C99030
	public IEnumerator SetPositionId(int npcId, float wait, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, bool relative = False) { }

	[IteratorStateMachineAttribute] // RVA: 0x19EDB0 Offset: 0x19EEB1 VA: 0x19EDB0
	// RVA: 0x1C99120 Offset: 0x1C99221 VA: 0x1C99120
	public IEnumerator SetPositionName(string name, float wait, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, bool relative = False) { }

	[IteratorStateMachineAttribute] // RVA: 0x19EE20 Offset: 0x19EF21 VA: 0x19EE20
	// RVA: 0x1C99210 Offset: 0x1C99311 VA: 0x1C99210
	public IEnumerator MovePositionId(int npcId, float wait, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float moveSpeed, float locomotion, bool relative = False) { }

	[IteratorStateMachineAttribute] // RVA: 0x19EE90 Offset: 0x19EF91 VA: 0x19EE90
	// RVA: 0x1C992F0 Offset: 0x1C993F1 VA: 0x1C992F0
	public IEnumerator MovePositionName(string name, float wait, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float moveSpeed, float locomotion, bool relative = False) { }

	[IteratorStateMachineAttribute] // RVA: 0x19EF00 Offset: 0x19F001 VA: 0x19EF00
	// RVA: 0x1C993D0 Offset: 0x1C994D1 VA: 0x1C993D0
	public IEnumerator StartBgm(string name, bool restart, float wait) { }

	[IteratorStateMachineAttribute] // RVA: 0x19EF70 Offset: 0x19F071 VA: 0x19EF70
	// RVA: 0x1C99460 Offset: 0x1C99561 VA: 0x1C99460
	public IEnumerator StopBgm(float wait) { }

	[IteratorStateMachineAttribute] // RVA: 0x19EFE0 Offset: 0x19F0E1 VA: 0x19EFE0
	// RVA: 0x1C994E0 Offset: 0x1C995E1 VA: 0x1C994E0
	public IEnumerator StartSe(string name, bool loop, float wait) { }

	[IteratorStateMachineAttribute] // RVA: 0x19F050 Offset: 0x19F151 VA: 0x19F050
	// RVA: 0x1C99570 Offset: 0x1C99671 VA: 0x1C99570
	public IEnumerator StopSe(string name, float wait) { }

	[IteratorStateMachineAttribute] // RVA: 0x19F0C0 Offset: 0x19F1C1 VA: 0x19F0C0
	// RVA: 0x1C99600 Offset: 0x1C99701 VA: 0x1C99600
	public IEnumerator StartVoice(string name, bool loop, float wait) { }

	[IteratorStateMachineAttribute] // RVA: 0x19F130 Offset: 0x19F231 VA: 0x19F130
	// RVA: 0x1C99690 Offset: 0x1C99791 VA: 0x1C99690
	public IEnumerator StopVoice(string name, float wait) { }

	// RVA: 0x1C99720 Offset: 0x1C99821 VA: 0x1C99720
	public void TimeLineEnd() { }

	// RVA: 0x1C998C0 Offset: 0x1C999C1 VA: 0x1C998C0
	public void StartTimelineMsg(TimelineMsgID msgId) { }

	// RVA: 0x1C99980 Offset: 0x1C99A81 VA: 0x1C99980
	public void EndTimelineMsg() { }

	// RVA: 0x1C99A60 Offset: 0x1C99B61 VA: 0x1C99A60
	public void ShakeStart(string cameraName) { }

	// RVA: 0x1C99B80 Offset: 0x1C99C81 VA: 0x1C99B80
	public void ShakeStop(string cameraName) { }

	// RVA: 0x1C99BB0 Offset: 0x1C99CB1 VA: 0x1C99BB0
	public void FadeInBlack(float fadeTime) { }

	// RVA: 0x1C99C50 Offset: 0x1C99D51 VA: 0x1C99C50
	public void FadeOutBlack(float fadeTime) { }

	// RVA: 0x1C99CF0 Offset: 0x1C99DF1 VA: 0x1C99CF0
	public void FadeInWhite(float fadeTime) { }

	// RVA: 0x1C99D90 Offset: 0x1C99E91 VA: 0x1C99D90
	public void FadeOutWhite(float fadeTime) { }

	// RVA: 0x1C99E30 Offset: 0x1C99F31 VA: 0x1C99E30
	public void ChageFaceIdle(int npcId) { }

	// RVA: 0x1C99F10 Offset: 0x1C9A011 VA: 0x1C99F10
	public void ChageFaceSmile(int npcId) { }

	// RVA: 0x1C99FF0 Offset: 0x1C9A0F1 VA: 0x1C99FF0
	public void ChageFaceDamage(int npcId) { }

	// RVA: 0x1C9A0D0 Offset: 0x1C9A1D1 VA: 0x1C9A0D0
	public void ChageFaceDie(int npcId) { }

	// RVA: 0x1C9A1B0 Offset: 0x1C9A2B1 VA: 0x1C9A1B0
	public void ChageFaceSurprise(int npcId) { }

	// RVA: 0x1C9A290 Offset: 0x1C9A391 VA: 0x1C9A290
	public void ChageFaceSerious(int npcId) { }

	// RVA: 0x1C9A370 Offset: 0x1C9A471 VA: 0x1C9A370
	public void ChageFaceShy(int npcId) { }

	[IteratorStateMachineAttribute] // RVA: 0x19F1A0 Offset: 0x19F2A1 VA: 0x19F1A0
	// RVA: 0x1C9A450 Offset: 0x1C9A551 VA: 0x1C9A450
	public IEnumerator FaceParttern(int npcId, int faceId, float wait) { }

	[IteratorStateMachineAttribute] // RVA: 0x19F210 Offset: 0x19F311 VA: 0x19F210
	// RVA: 0x1C9A500 Offset: 0x1C9A601 VA: 0x1C9A500
	public IEnumerator LookAtTarget(int npcId, int targetNpcId, float wait, float posX, float posY, float posZ, float speed) { }

	// RVA: 0x1C9A5D0 Offset: 0x1C9A6D1 VA: 0x1C9A5D0
	public void StartMovie(string movieName) { }

	[IteratorStateMachineAttribute] // RVA: 0x19F280 Offset: 0x19F381 VA: 0x19F280
	// RVA: 0x1C9A7C0 Offset: 0x1C9A8C1 VA: 0x1C9A7C0
	public IEnumerator AllNpcDisable(bool forceDisabled, float wait) { }

	[IteratorStateMachineAttribute] // RVA: 0x19F2F0 Offset: 0x19F3F1 VA: 0x19F2F0
	// RVA: 0x1C9A850 Offset: 0x1C9A951 VA: 0x1C9A850
	public IEnumerator SummonMonster(MonsterDataID id, string name, float wait, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, int IsShortPlayMonster) { }

	// RVA: 0x1C9A940 Offset: 0x1C9AA41 VA: 0x1C9A940
	public void SpringboneStop() { }

	// RVA: 0x1C9ABF0 Offset: 0x1C9ACF1 VA: 0x1C9ABF0
	public void SpringboneStart() { }

	// RVA: 0x1C97250 Offset: 0x1C97351 VA: 0x1C97250
	private Character GetCharacter(int npcId) { }

	// RVA: 0x1C9AEA0 Offset: 0x1C9AFA1 VA: 0x1C9AEA0
	private NpcData GetNpcData(int npcId) { }

	// RVA: 0x1C9AF30 Offset: 0x1C9B031 VA: 0x1C9AF30
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x19F360 Offset: 0x19F461 VA: 0x19F360
	// RVA: 0x1C9B0A0 Offset: 0x1C9B1A1 VA: 0x1C9B0A0
	private void <ShortPlayStartId>b__42_0(HumanController human) { }
}

